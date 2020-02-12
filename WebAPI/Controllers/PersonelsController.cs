using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CvMaker.Business.Abstract;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonelsController : ControllerBase
    {
        private IPersonelService _personelService;
        public PersonelsController(IPersonelService personelService)
        {
            _personelService = personelService;
        }
        [HttpGet (template:"getall")]
        public ActionResult GetList()
        {
            var result = _personelService.GetList();

        }
    }
}
