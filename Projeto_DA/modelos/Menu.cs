using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.modelos
{
    public class Menu
    {
        public int id{  get; set; }

        public DateTime menuDataHora {  get; set; }

        public int qntDisponivel { get; set; }

        public float precoEstudante {  get; set; }
        
        public float precoProfessor { get; set; }

        public List<Prato> pratos { get; set; }

        public List<Extra> extras { get; set; }
    }
}
