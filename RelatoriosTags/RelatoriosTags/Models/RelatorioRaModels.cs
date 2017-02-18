using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RelatoriosTags.Models
{
    public class RelatorioRaModels
    {
        [Key]
        public int RaID { get; set; }


        [Required]
        public string Data { get; set; }
        [Required]
        public string Nivel { get; set; }
        [Required]
        public string Nº { get; set; }

        // Não será mais necessário
        //[Required]
        //public string Tag { get; set; }

        public int TagID { get; set; }

        //Cria a FK com o Model de Tag
        [ForeignKey("TagID")]
        public virtual RelatorioTagModels RelatorioTag { get; set; }
    }
}