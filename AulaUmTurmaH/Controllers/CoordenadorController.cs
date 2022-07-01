using AulaUmTurmaH.Application.DTOs;
using AulaUmTurmaH.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AulaUmTurmaH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoordenadorController : ControllerBase
    {
        private readonly ICoordenadorApplication _coordenadorApplication;
        public CoordenadorController(ICoordenadorApplication coordenadorApplication)
        {
            _coordenadorApplication = coordenadorApplication;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            return Ok(_coordenadorApplication.GetAll());
        }

        [HttpPost]
        public IActionResult Insert(CoordenadorDTO coordenadorDTO)
        {
            _coordenadorApplication.Insert(coordenadorDTO);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(CoordenadorDTO coordenadorDTO)
        {
            _coordenadorApplication.Update(coordenadorDTO);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _coordenadorApplication.Delete(id);
            return Ok();
        }


    }
}