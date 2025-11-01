using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_medicamentos
{
    internal class Medicamentos
    {
        private List<Medicamento> listaMedicamentos;

        public List<Medicamento> ListaMedicamentos { get => listaMedicamentos; set => listaMedicamentos = value; }

        public Medicamentos()
        {
            ListaMedicamentos = new List<Medicamento>();
        }

        public void Adicionar(Medicamento medicamento)
        {

        }

        public bool Deletar(Medicamento medicamento)
        {
            return false;
        }

        public Medicamento Pesquisar(Medicamento medicamento)
        {
            return medicamento;
        }
    }
}
