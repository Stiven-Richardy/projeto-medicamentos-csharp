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

        public Medicamento(string nome) 
        { 
            Nome = nome;
        }

        public Medicamento(int id, string nome, string laboratorio)
        {
            Id = id;
            Nome = nome;
            Laboratorio = laboratorio;
            Lotes = new Queue<Lote>();
        }

        public int QtdeDisponivel()
        {
            int total = 0;
            foreach(Lote l in Lotes)
            {
                total += l.Qtde;
            }
            return total;
        }

        public void Comprar(Lote lote)
        {
            Lotes.Enqueue(lote);
        }

        public bool Vender(int qtde)
        {
            return false;
        }

        public override string ToString()
        {
            return $" Id: {Id}\n Nome: {Nome}\n Laboratório: {Laboratorio}\n Quantidade: {QtdeDisponivel()}";
        }

        public override bool Equals(object obj)
        {
            return false;
        }
    }
}
