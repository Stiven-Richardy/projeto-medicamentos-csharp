using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_medicamentos
{
    internal class Medicamento
    {
        private int id;
        private string nome;
        private string laboratorio;
        private Queue<Lote> lotes;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Laboratorio { get => laboratorio; set => laboratorio = value; }
        public Queue<Lote> Lotes { get => lotes; set => lotes = value; }

        public Medicamento() { }

        public Medicamento(int id, string nome, string laboratorio)
        {
            Id = id;
            Nome = nome;
            Laboratorio = laboratorio;
            Lotes = new Queue<Lote>();
        }

        public int QtdeDisponivel()
        {
            return 0;
        }

        public void Comprar(Lote lote)
        {
            
        }

        public bool Vender(int qtde)
        {
            return false;
        }

        public override string ToString()
        {
            return "";
        }

        public override bool Equals(object obj)
        {
            return false;
        }
    }
}
