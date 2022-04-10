﻿using BLL.IRepo;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Invoice_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityTypeController : ControllerBase
    {
        private readonly IRepoWrapper _warpper;

        public ActivityTypeController(IRepoWrapper Warpper )
        {
            _warpper = Warpper;
        }
       
        [HttpGet]
        [Route("GetAllActivitiesTypes")]
        public IActionResult  Get()
        {

            try
            {
                var List_of_AllAvtivityType = _warpper._ActivityType.GetAll().Result;
                if (List_of_AllAvtivityType.Count != 0)
                    return StatusCode(1, List_of_AllAvtivityType);

                else
                    return StatusCode(0, "No Data Found");
            }
            catch (System.Exception ex)
            {

                return StatusCode(-1, ex.Message);
            }

            
        }

       
        [HttpGet]
        [Route("GetActivityTypeCodeByDescription/{DESC}")]
        public IActionResult GetCodeByDesc(string DESC)
        {

         try
         {
          var List_of_AvtivityType= _warpper._ActivityType.GetByCondition(t => t.Desc_ar.Contains(DESC) || t.Desc_en.Contains(DESC)).Result;
                if (List_of_AvtivityType.Count != 0)
                    return StatusCode(1, List_of_AvtivityType);

                else
                    return StatusCode(0, "No Data Found");
         }
            catch (System.Exception ex)
            {

                return StatusCode(-1, ex.Message);
            }
        }

        // POST api/<ActivityTypeController>
        [HttpPost]
        [Route("CreateNewActivityType")]
        public IActionResult Post([FromBody] ActivityType Entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   
                    _warpper._ActivityType.Create(Entity);
                    _warpper.Save();
                    return StatusCode(1, "Added Successfully");
                }

                return StatusCode(0, "Invalid Entity");

            }
            catch (System.Exception ex)
            {

                return StatusCode(-1,ex.Message );
            }




        }

       
        [HttpPut]
        [Route("EditActivityType")]
        public IActionResult Put( [FromBody] ActivityType Entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                        _warpper._ActivityType.Update(Entity);
                        _warpper.Save();
                        return StatusCode(1, "Updated Successfully");
                }
                

                return StatusCode(0, "Invalid Entity");



            }
            catch (System.Exception ex)
            {

                return StatusCode(-1, ex.Message);
            }


        }

        [HttpDelete]
        [Route("DeleteActivityType/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
               
                    var TargetEntity = _warpper._ActivityType.GetByCondition(t => t.Id == id).Result;
                    if (TargetEntity.Count > 0)
                    {
                        _warpper._ActivityType.Delete(TargetEntity[0]);
                        _warpper.Save();
                        return StatusCode(1, "Deleted Successfully");
                    }
                    return StatusCode(404, "Entity Not Exist");
            }
            catch (System.Exception ex)
            {

                return StatusCode(-1, ex.Message);
            }

        }
    }
}
