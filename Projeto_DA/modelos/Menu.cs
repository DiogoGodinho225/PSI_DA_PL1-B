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

        public float precoEstudante {  get; set; }
        
        public float precoProfessor { get; set; }

        public List<Prato> pratos { get; set; } = new List<Prato>();

        public List<Extra> extras { get; set; }

        public override string ToString()
        {
            StringBuilder descricoes = new StringBuilder();
            if (pratos != null)
            {
                Console.WriteLine(pratos.Count);
                if (pratos.Count > 0)
                {
                    for (int i = 0; i < pratos.Count; i++)
                    {
                        if (pratos[i].descricao != null)
                        {
                            descricoes.Append(pratos[i].descricao + " | ");
                        }
                    }

                    if(descricoes.Length > 0)
                    {
                        descricoes.Length -= 3;
                        return descricoes.ToString();
                    }
                }
            }

            return "ERRO";
        }
    }
}
