using AulaUmTumaH.Domain.Entities;
using AulaUmTurmaH.Application.DTOs;
using AulaUmTurmaH.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AulaUmTurmaH.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PeriodoController : ControllerBase
    {
        private readonly IPeriodoApplication _periodoApplication;
        public PeriodoController(IPeriodoApplication periodoApplication)
        {
            _periodoApplication = periodoApplication;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            return Ok(_periodoApplication.GetAll());
        }

        [HttpPost]
        public IActionResult Insert(PeriodoDTO periodoDTO)
        {
            _periodoApplication.Insert(periodoDTO);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(PeriodoDTO periodoDTO)
        {
            _periodoApplication.Update(periodoDTO);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _periodoApplication.Delete(id);
            return Ok();
        }


    }
}