using BLL.IRepo;
using BLL.ModelsView;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using System.Threading.Tasks;
using BLL.Response_VM;
using Invoice_Api.StatusCodes;

namespace Invoice_Api.Controllers.BasicDataController
{
    [ApiController]
    [Route("BasicData")]
    public class BasicDataController : Controller
    {
        private readonly IRepoWrapper repo;


        public BasicDataController(IRepoWrapper _repo)
        {
            repo = _repo;

        }
        [HttpGet]
        [Route("RegisterData")]
        public JsonResult RegisterData()
        {
            RegisteredDate_VM registeredDate_VM = new RegisteredDate_VM();
            Response_VM response_VM = new Response_VM();
            var ActivityType = repo._ActivityType.GetAll().Result.Select(s=>new ActivityTypes_VM{Id= s.Id, Adescription=s.Adescription,Code=s.Code}).ToList();
            var countries = repo._Country.GetAll().Result.Select(s => new Countries_VM { Id = s.Id, Code = s.Code, Adescription = s.Adescription }).ToList();


            string GroupItemsUnitsQuery = @"SELECT AD.Id AS AddressPropId,
                                            AD.name AS AddressPropName,
                                            AD.caption AS caption,
                                            AD.hasValidation AS hasValidation,
                                            IC.name AS controleName,
                                            ISNULL(ADV.id,' ') AS addressValidationId,
                                            ISNULL(ADV.value,' ') AS value,
                                            ISNULL(VA.id,' ')AS validationId,
                                            ISNULL(VA.name,' ') AS validitionName,
                                            ISNULL(VA.hasValue,' ') AS hasValue
                                       FROM Address_Property AD
                                            LEFT JOIN InputControllers IC
                                               ON AD.controller_id = IC.id
                                            LEFT JOIN AddressProperty_Validations ADV
                                               ON AD.id = ADV.addressProperty_id
                                            LEFT JOIN Validations VA
                                               ON VA.id = ADV.validation_id";

            var GroupItemsUnits_VM = repo.CallQuery<AddressValidations_VM>(GroupItemsUnitsQuery).ToList();

           

            registeredDate_VM.activityTypes_VM = ActivityType;
            registeredDate_VM.countries_VM = countries;
            registeredDate_VM.addressValidation = GroupItemsUnits_VM;

            response_VM = new Response_VM() { Data = registeredDate_VM, StatusCode = 200, Message = CustomeStatusCodes.ErrorCodes[200] };
            return Json(response_VM);
        }

        [HttpGet]
        [Route("ControllersWithValidation")]
        public JsonResult ControllerValidations(string controllerName)
        {
            //InputControl_VM InputControl_VM = new InputControl_VM();
            List<Validations_VM> validations_VM = new List<Validations_VM>();
            List<ControlValidation_VM> controlValidation_VMs = new List<ControlValidation_VM>();
           var x= repo._InputController.GetAll().Result.Select(s => new InputControl_VM {controllerId=s.Id,controllerName=s.Name});
            foreach (var item in x)
            {
              controlValidation_VMs.AddRange( repo._Validation.GetByCondition(s => s.ControllerNames.Contains(item.controllerName)||s.ControllerNames.Contains("all")).Result.Select(s=>new ControlValidation_VM{validationId= s.Id, validationName=s.Name , ControlId = item.controllerId, ControlName = item.controllerName }).ToList());
            }

            return Json(controlValidation_VMs);
        }
    }
}

