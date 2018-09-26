using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paocombife.Model
{
    class Produto
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Preço { get; set; }
        public string Imagem { get; set; }
    }
}
