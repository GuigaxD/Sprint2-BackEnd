using Microsoft.AspNetCore.Mvc;
using Senai.Optus.WebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Optus.WebApi.Controller
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class EstiloController : ControllerBase
    {
        EstiloRepository EstiloRepository = new EstiloRepository();

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(EstiloRepository.Listar());
        }

        [HttpPost]
        public IActionResult Cadastrar(Estilos estilo)
        {
            try
            {
                EstiloRepository.Cadastrar(estilo);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "Eita, erro:" + ex.Message });
            }
    }
}
