using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paocombife.Model
{
    class Pedido
    {
        public int ID { get; set; }
        public virtual Produto IDProduto { get; set; }
    }
}
