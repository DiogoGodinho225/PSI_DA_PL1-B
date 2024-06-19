using Projeto_DA.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_DA.controladores;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Data.Entity;

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

        public void inserirMenus(DateTime menuDataHora, List<Prato>prato)
        {
             var menu = new Projeto_DA.modelos.Menu { menuDataHora = menuDataHora, precoEstudante = precoEstudante, precoProfessor = precoProfessor, pratos = prato  };
             context.Menu.Add(menu);
             context.SaveChanges();
             MessageBox.Show("Menu inserido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<Projeto_DA.modelos.Menu> procurarMenus(DateTime data)
        {
            var menus = context.Menu.Include(m => m.pratos).Where(m => DbFunctions.TruncateTime(m.menuDataHora) == DbFunctions.TruncateTime(data)).ToList();

            if (menus.Any())
            {
                return menus;
            }
            return null;
            
        }

        public Projeto_DA.modelos.Menu procurarMenuDataReservas(DateTime data)
        {
            Projeto_DA.modelos.Menu menus = context.Menu.Include(m => m.pratos).Where(m => DbFunctions.TruncateTime(m.menuDataHora) == DbFunctions.TruncateTime(data)).FirstOrDefault();

            if (menus != null)
            { 
                return menus;  
            }
            return null;
        }

        public bool procurarMenuData(DateTime data)
        {
            Projeto_DA.modelos.Menu menus = context.Menu.Include(m => m.pratos).Where(m => DbFunctions.TruncateTime(m.menuDataHora) == DbFunctions.TruncateTime(data)).FirstOrDefault();

            if (menus != null)
            {
                return true;
            }
            return false;
        }

        public int ProcurarMenuData(DateTime data)
        {
            var menu = context.Menu.FirstOrDefault(m => DbFunctions.TruncateTime(m.menuDataHora) == DbFunctions.TruncateTime(data));

            if (menu != null)
            {
                return menu.id;
            }

            return 0;
        }

        public Projeto_DA.modelos.Menu ObterMenuPorId(int menuId)
        {
            var menu = context.Menu.Include(m => m.pratos).FirstOrDefault(m => m.id == menuId);

            return menu;
        }

    } 
}
