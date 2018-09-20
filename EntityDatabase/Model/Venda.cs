using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDatabase.Model
{
    class Venda
    {
        public int ID { get; set; }
        public int Valor { get; set; }
        public DateTime DataVenda { get; set; }
        public virtual Produto IDProduto { get; set; }
    }
}
