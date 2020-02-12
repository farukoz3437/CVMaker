using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CvMaker.Business.Abstract;
using CvMaker.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CvMakerWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonelController : ControllerBase
    {

        private IPersonelService _personelService;

        public PersonelController(IPersonelService personelService)
        {
            _personelService = personelService;
        }
        [HttpGet(template: "getdeneme")]
        public string GetDeneme()
        {
            return "deneme";
        }

        [HttpGet(template: "getall")]
        public IActionResult GetList()
        {
            var result = _personelService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet(template: "getlistbycategory")]
        public IActionResult GetByCategory(string personelName)
        {
            var result = _personelService.GetListByPersonelName(personelName);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet(template: "getbyid")]
        public IActionResult GetById(int productId)
        {
            var result = _personelService.GetById(productId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpPost(template: "add")]
        public IActionResult Add(Personel personel)
        {
            var result = _personelService.Add(personel);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost(template: "delete")]
        public IActionResult Delete(Personel personel)
        {
            var result = _personelService.Delete(personel);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost(template: "update")]
        public IActionResult Update(Personel personel)
        {
            var result = _personelService.Update(personel);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }



    }
}