﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paocombife.Model
{
    class Venda
    {
        [Key]
        public int ID { get; set; }
        public int Valor { get; set; }
        public DateTime DataVenda { get; set; }
        public virtual Produto IDProduto { get; set; }
    }
}
