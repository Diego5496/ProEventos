using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{

            new Evento()
            {
                EventoId = 1,
                Tema = " Angular 11 e .net 5",
                Local = "Atibaia - SP",
                Qtdèssoas = 25,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                Lote = "1 Lote",
                ImagemURL = "teste.png"
            },
             new Evento()
            {
                EventoId = 2,
                Tema = " Angular 11 suas novidas",
                Local = "São Paulo",
                Qtdèssoas = 250,
                DataEvento = DateTime.Now.AddDays(4).ToString("dd/MM/yyyy"),
                Lote = "2º Lote",
                ImagemURL = "foto.png"
            }
        };

        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }
        
          [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId ==id );
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de put com id = {id}";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de delete com id = {id}";
        }
    }
}
