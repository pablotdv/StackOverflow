using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RelatoriosTags.Models
{
    public class RelatorioTagModels
    {
        [Key]
        public int TagID { get; set; }


        [Required]
        public string Tag { get; set; }
        [Required]
        public string Vedacao { get; set; }
        [Required]
        public string Fluido { get; set; }
        [Required]
        public string Criticidade { get; set; }
        [Required]
        public decimal Mtbf { get; set; }
    }
}