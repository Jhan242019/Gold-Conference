using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoldConf.Models
{
    public class Conferencia
    {
        public int Id { get; set; }
        [Required]
        public string ImagePath { get; set; }
        [Required]
        public string NameConf { get; set; }
        [Required]
        public DateTime FechaConf { get; set; }
        [Required]
        public string TituloConf { get; set; }
        [Required]
        public decimal PrecioConf { get; set; }
        [Required]
        public string DetalleConf { get; set; }
        public int UserId { get; set; }
    }
}
