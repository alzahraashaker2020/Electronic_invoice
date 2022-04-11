using BLL.IRepo;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

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



        //HelpMethod To Fill Data In DatBasebY Consuming API



        [HttpGet]
        [Route("FillDataBaseFromJsonFileByConsumeAPI")]
        public async Task FillDataByJsonFile()
        {
           
            //******Change this Url For Each JsonFIle*******
            string URL = "https://sdk.preprod.invoicing.eta.gov.eg/files/UnitTypes.json";

            using (var client = new System.Net.Http.HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));      
                HttpResponseMessage Res = await client.GetAsync(URL);
                if (Res.IsSuccessStatusCode)
                {  
                    var response = Res.Content.ReadAsStringAsync().Result;

                    //******Change Deserialized Object Type for your ObjectType*******
                    var ListOFObjs = JsonConvert.DeserializeObject<List<UniteType>>(response);

                    foreach (var objs in ListOFObjs)
                    {
                        try
                        {
                            _warpper._UniteType.Create(objs);
                            _warpper.Save();
                        }


                        catch (Exception ex) {
                        
                        }
                    }
                }
            }
        }
    }
}
