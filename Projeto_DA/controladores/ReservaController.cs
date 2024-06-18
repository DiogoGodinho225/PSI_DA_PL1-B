using Projeto_DA.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.controladores
{
    public class ReservaController
    {
        ProjetoContext context;
       
        public ReservaController(ProjetoContext context) 
        {
            this.context = context;
        }

    }
}
