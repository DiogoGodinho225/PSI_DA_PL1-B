using Projeto_DA.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_DA.controladores;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace Projeto_DA.controladores
{
    public class MenusController
    {
        ProjetoContext context;
        float precoEstudante = (float)2.80;
        float precoProfessor = (float)2.50;
        

        public MenusController(ProjetoContext context)
        {
            this.context = context;
        }

        public void inserirMenus(DateTime menuDataHora, List<Extra> extra, List<Prato>prato)
        {
         
                var menu = new Projeto_DA.modelos.Menu { menuDataHora = menuDataHora, precoEstudante = precoEstudante, precoProfessor = precoProfessor, extras = extra, pratos = prato  };
                context.Menu.Add(menu);
                context.SaveChanges();
                MessageBox.Show("Menu inserido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }

    
}
