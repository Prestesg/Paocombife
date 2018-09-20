using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDatabase.Model
{
    class Venda
    {
        public int id { get; set; }
        public int IDProduto { get; set; }
        public int Valor { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
