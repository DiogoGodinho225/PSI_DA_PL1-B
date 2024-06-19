using System;
using System.Collections.Generic;
using System.Linq;
using Projeto_DA.controladores;
using System.Text;
using System.Threading.Tasks;
using Projeto_DA.modelos;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Projeto_DA.controladores
{
    public class PratosController
    {
        public List<Prato> pratos;
        ProjetoContext context;

        public PratosController(ProjetoContext context)
        {
            this.context = context;
        }

        public List<Prato> ListarPratos()
        {
            pratos = new List<Prato>();
            var prato = context.Prato.ToList();
            pratos.AddRange(prato);
            return pratos;
        }

        public void InserirPrato(string descricaoPrato, string tipo)
        {
            var prato = new Prato { descricao = descricaoPrato, tipo = tipo,  ativoPrato = false };
            context.Prato.Add(prato);
            context.SaveChanges();
            MessageBox.Show("Prato Inserido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void RemoverPrato(int id)
        {

            var prato = context.Prato.Find(id);

            if (prato != null)
            {
                context.Prato.Remove(prato);
                context.SaveChanges();
                MessageBox.Show("Prato apagado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Prato não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AlterarPrato(int id, string descricao, string tipo)
        {
            var prato = context.Prato.Find(id);
            if (prato != null)
            {
                prato.descricao = descricao;
                prato.tipo = tipo;
                context.SaveChanges();
                MessageBox.Show("Prato Atualizado", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Prato não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int ProcurarPrato(string desc)
        {
            Prato prato = context.Prato.FirstOrDefault(p => p.descricao == desc);
            if (prato != null)
            {
                int id = prato.id;
                return id;
            }
            else
            {
                MessageBox.Show("Prato não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public List<Prato> MoverPratos(int id)
        {
            pratos = new List<Prato>();
            Prato prato = context.Prato.FirstOrDefault(p => p.id == id);
            pratos.Add(prato);
            return pratos;
        }

        public List<Prato> ProcurarPratoTipo(string tipo)
        {
            var prato = context.Prato.Where(p => p.tipo == tipo).ToList();
            if (prato != null)
            { 
                return prato;
            }
            else
            {
                MessageBox.Show("Prato não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void AlterarEstado(int id)
        {
            var estadoprato = context.Prato.FirstOrDefault(q => q.id == id);

            if (estadoprato != null)
            {
                estadoprato.ativoPrato = true;
                context.SaveChanges();
            }
        }

        public bool verificarEstado(int id)
        {
            var estadoprato = context.Prato.FirstOrDefault(q => q.id == id);

            if(estadoprato != null)
            {
                if(estadoprato.ativoPrato != true)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
