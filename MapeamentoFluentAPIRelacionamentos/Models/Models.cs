using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapeamentoFluentAPIRelacionamentos.Models
{
    public class CidadeEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public int EstadoId { get; set; }

        public virtual EstadoEntity Estado { get; set; }
    }

    public class EstadoEntity
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public virtual IList<CidadeEntity> CidadeLista { get; set; }

        public int PaisId { get; set; }

        public virtual PaisEntity Pais { get; set; }
    }
    public class PaisEntity
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public virtual IList<EstadoEntity> EstadoLista { get; set; }
    }
}
