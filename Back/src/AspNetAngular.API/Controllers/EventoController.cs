using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetAngular.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetAngular.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {
        }

// teste de commit

        [HttpGet]
        public Evento Get(){
            var evento = new Evento(){
                Id = 1,
                Tema = "AspNet com Angular",
                Local = "São Pa8lo",
                Lote = "1® Lote",
                QtdPerson = 250,
                DataEvento =  DateTime.Now.AddDays(2).ToString(),
                ImagemUrl = "imagem 1"
            };
            return evento;
 
        }

                [HttpPost]
        public string Post(){
            return "Exemplo de post";
        }
    }
}