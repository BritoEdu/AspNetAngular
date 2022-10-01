using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetAngular.API.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdPerson { get; set; }
        public string Lote { get; set; }
        public string ImagemUrl { get; set; }
        
    }
}