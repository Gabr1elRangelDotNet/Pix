using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesafioNet.Business.Models.Enumerado;

namespace DesafioNet.Business.Models
{
    public class Chave
    {
        public Guid Id { get; set; }

        public ETipoChave TipoChave { get; set; }
        public string Descricao { get; set; }
    }
}
