using Paocombife.Model;
using PaocomBife.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaocomBife.Controller
{
    class FechamentoController
    {
        private readonly ContextoBase contexto;

        public FechamentoController()
        {
            contexto = new ContextoBase();
        }
        /*
        public Fechamento AddNewFechamento(int valor, Produto produto)
        {
         /*  var fechamento = new Fechamento { Valor = valor, DataFechamento = DateTime.Now };
            contexto.Vendas.Add(fechamento);
            contexto.SaveChanges();

            return fechamento; 
        }*/
    }
}
