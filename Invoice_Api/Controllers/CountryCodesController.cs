using BLL.IRepo;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Invoice_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryCodesController : ControllerBase
    {
        private readonly IRepoWrapper _warpper;

        public CountryCodesController(IRepoWrapper Warpper)
        {
            _warpper = Warpper;
        }



        [HttpGet]
        [Route("GetAllCountryCodes")]
        public IActionResult Get()
        {

            try
            {
                var List_of_AllCountryCodes = _warpper._Country.GetAll().Result;
                if (List_of_AllCountryCodes.Count != 0)
                    return StatusCode(1, List_of_AllCountryCodes);

                else
                    return StatusCode(0, "No Data Found");
            }
            catch (System.Exception ex)
            {

                return StatusCode(-1, ex.Message);
            }


        }


        [HttpGet]
        [Route("GetCountryCodeByDescription/{DESC}")]
        public IActionResult GetCodeByDesc(string DESC)
        {

            try
            {
                var List_of_CountryCode = _warpper._Country.GetByCondition(t => t.Desc_ar.Contains(DESC) || t.Desc_en.Contains(DESC)).Result;
                if (List_of_CountryCode.Count != 0)
                    return StatusCode(1, List_of_CountryCode);

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
        [Route("CreateNewCountryCode")]
        public IActionResult Post([FromBody] Country Entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   
                    _warpper._Country.Create(Entity);
                    _warpper.Save();
                    return StatusCode(1, "Added Successfully");
                }

                return StatusCode(0, "Invalid Entity");

            }
            catch (System.Exception ex)
            {

                return StatusCode(-1, ex.Message);
            }




        }


        [HttpPut]
        [Route("EditCountryCode")]
        public IActionResult Put([FromBody] Country Entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                        _warpper._Country.Update(Entity);
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
        [Route("DeleteCountryCode/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {

                var TargetEntity = _warpper._Country.GetByCondition(t => t.Id == id).Result;
                if (TargetEntity.Count > 0)
                {
                    _warpper._Country.Delete(TargetEntity[0]);
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
