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
    public class EscolaController : ControllerBase
    {
        private readonly IEscolaApplication _escolaApplication;
        public EscolaController(IEscolaApplication escolaApplication)
        {
            _escolaApplication = escolaApplication;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            return Ok(_escolaApplication.GetAll());
        }

        [HttpPost]
        public IActionResult Insert(EscolaDTO escolaDTO)
        {
            _escolaApplication.Insert(escolaDTO);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(EscolaDTO escolaDTO)
        {
            _escolaApplication.Update(escolaDTO);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _escolaApplication.Delete(id);
            return Ok();
        }


    }
}