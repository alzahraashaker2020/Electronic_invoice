using BLL.IRepo;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Invoice_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitTypeController : ControllerBase
    {

        private readonly IRepoWrapper _warpper;

        public UnitTypeController(IRepoWrapper Warpper)
        {
            _warpper = Warpper;
        }




        [HttpGet]
        [Route("GetAllUniteTypes")]
        public IActionResult Get()
        {

            try
            {
                var List_of_AllunitTypes = _warpper._UniteType.GetAll().Result;
                if (List_of_AllunitTypes.Count != 0)
                    return StatusCode(1, List_of_AllunitTypes);

                else
                    return StatusCode(0, "No Data Found");
            }
            catch (System.Exception ex)
            {

                return StatusCode(-1, ex.Message);
            }


        }


        [HttpGet]
        [Route("GetUniteTypeCodeByDescription/{DESC}")]
        public IActionResult GetCodeByDesc(string DESC)
        {

            try
            {
                var List_of_UniteType = _warpper._UniteType.GetByCondition(t => t.Desc_ar.Contains(DESC) || t.Desc_en.Contains(DESC)).Result;
                if (List_of_UniteType.Count != 0)
                    return StatusCode(1, List_of_UniteType);

                else
                    return StatusCode(0, "No Data Found");
            }
            catch (System.Exception ex)
            {

                return StatusCode(-1, ex.Message);
            }
        }

       
        [HttpPost]
        [Route("CreateNewUniteType")]
        public IActionResult Post([FromBody] UniteType Entity)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    _warpper._UniteType.Create(Entity);
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
        [Route("EditUniteType")]
        public IActionResult Put([FromBody] UniteType Entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _warpper._UniteType.Update(Entity);
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
        [Route("DeleteUniteType/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {

                var TargetEntity = _warpper._UniteType.GetByCondition(t => t.Id == id).Result;
                if (TargetEntity.Count > 0)
                {
                    _warpper._UniteType.Delete(TargetEntity[0]);
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
