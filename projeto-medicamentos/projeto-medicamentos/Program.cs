/*
| Instituto Federal de São Paulo - Campus Cubatão
| Nome: Guilherme Mendes de Sousa - CB3030857
| Nome: Stiven Richardy Silva Rodrigues - CB3030202
| Turma: ADS 471
| 
| Opções no seletor:
| 0. Finalizar processo
| 1. Cadastrar medicamento
| 2. Consultar medicamento (sintético: informar dados1)
| 3. Consultar medicamento (analítico: informar dados1 + lotes2)
| 4. Comprar medicamento (cadastrar lote)
| 5. Vender medicamento (abater do lote mais antigo)
| 6. Listar medicamentos (informando dados sintéticos)
| Legenda:
| 1) Dados do medicamento: ID + NOME + LABORATÓRIO + QTDE DISPONÍVEL
| 2) Dados do lote: ID + QTDE + DATA DE VENCIMENTO 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_medicamentos
{
    internal class Program
    {
        public static Medicamentos medicamentos = new Medicamentos();
        public static int idMedicamento = 0;

        static void Main(string[] args)
        {
            int seletor = -1;
            while (seletor != 0)
            {
                Console.Clear();
                Utils.Titulo("PAINEL PRINCIPAL");
                Console.WriteLine(" 0 - Sair\n" +
                    " 1 - Cadastrar Medicamento\n" +
                    " 2 - Consultar Medicamento (Sintético)\n" +
                    " 3 - Consultar Medicamento (Analítico)\n" +
                    " 4 - Comprar Medicamento\n" +
                    " 5 - Vender Medicamento\n" +
                    " 6 - Listar Medicamento");
                Console.WriteLine(new string('-', 70));
                Console.Write(" Escolha uma opção: ");
                seletor = Utils.lerInt(Console.ReadLine(), 0, " Entrada inválida!\n  Digite outro número: ");

                switch (seletor)
                {
                    case 0:
                        Console.WriteLine(" Programa finalizado!");
                        break;
                    case 1:
                        cadastrarMedicamento();
                        break;
                    case 2:
                        consultarMedicamentoSintetico();
                        break;
                    case 3:
                        consultarMedicamentoAnalitico();
                        break;
                    case 4:
                        comprarMedicamento();
                        break;
                    case 5:
                        //venderMedicamento();
                        break;
                    case 6:
                        //listarMedicamentos();
                        break;
                    default:
                        Utils.MensagemErro("Digite um número de 0-6!");
                        break;
                }
            }
        }

        static void cadastrarMedicamento()
        {
            Utils.Titulo("CADASTRAR MEDICAMENTO - MEDICAMENTO 1/3");
            Console.Write(" Digite o Nome do Medicamento: ");
            string nome = Console.ReadLine();
            Console.Write(" Digite o Nome do Laboratório: ");
            string lab = Console.ReadLine();
            Medicamento novoMedicamento = new Medicamento(idMedicamento, nome, lab);

            Utils.Titulo("CADASTRAR MEDICAMENTO - LOTE 2/3");
            Console.Write(" Digite a quantidade de medicamentos: ");
            int qtdeLote = Utils.lerInt(Console.ReadLine(), 1, " Entrada inválida!\n Tente novamente: ");
            Console.WriteLine("\n DATA DE VENCIMENTO");
            Console.Write(" Informe o ano: ");
            int ano = Utils.lerMinMax(Console.ReadLine(), DateTime.Now.Year + 1, 2100, " Ano inválido!\n Tente novamente: ");
            Console.Write(" Informe o mês: ");
            int mes = Utils.lerMinMax(Console.ReadLine(), 1, 12, " Mês inválido!\n Tente novamente: ");
            int diasNoMes = DateTime.DaysInMonth(ano, mes);
            Console.Write(" Informe o dia: ");
            int dia = Utils.lerMinMax(Console.ReadLine(), 1, diasNoMes, " Dia inválido!\n Tente novamente: ");
            DateTime venc = new DateTime(ano, mes, dia);
            Lote novoLote = new Lote(novoMedicamento.Lotes.Count, qtdeLote, venc);

            Utils.Titulo("CADASTRAR MEDICAMENTO 3/3");
            if (medicamentos.Pesquisar(novoMedicamento) == null) {
                medicamentos.Adicionar(novoMedicamento);
                novoMedicamento.Lotes.Enqueue(novoLote);
                Console.WriteLine($" Id: {novoMedicamento.Id}\n" +
                    $" Nome: {novoMedicamento.Nome}");
                Utils.MensagemSucesso("Medicamento cadastrado!");
                idMedicamento++;
            }
            else
            {
                Utils.MensagemErro("O medicamento já existe.");
            }
        }

        static void consultarMedicamentoSintetico()
        {
            Utils.Titulo("CONSULTAR MEDICAMENTO (SINTÉTICO)");
            Console.Write(" Digite o Nome do Medicamento: ");
            string nome = Console.ReadLine();
            Medicamento medicamentoPesquisado = new Medicamento(nome);
            medicamentoPesquisado = medicamentos.Pesquisar(medicamentoPesquisado);
            if (medicamentoPesquisado != null)
            {
                Console.WriteLine(medicamentoPesquisado.ToString());
                Utils.MensagemSucesso("Medicamento encontrado!");
            }
            else
            {
                Utils.MensagemErro("O medicamento não existe.");
            }
        }

        static void consultarMedicamentoAnalitico()
        {
            Utils.Titulo("CONSULTAR MEDICAMENTO (ANALÍTICO)");
            Console.Write(" Digite o Nome do Medicamento: ");
            string nome = Console.ReadLine();
            Medicamento medicamentoPesquisado = new Medicamento(nome);
            medicamentoPesquisado = medicamentos.Pesquisar(medicamentoPesquisado);
            if (medicamentoPesquisado != null)
            {
                Console.WriteLine(medicamentoPesquisado.ToString());
                Console.WriteLine("\n Lotes disponíveis:");
                foreach (Lote l in medicamentoPesquisado.Lotes)
                {
                    Console.WriteLine(l.ToString());
                }
                Utils.MensagemSucesso("Medicamento encontrado!");
            }
            else
            {
                Utils.MensagemErro("O medicamento não existe.");
            }
        }
        static void comprarMedicamento()
        {
            Utils.Titulo("COMPRAR MEDICAMENTO");
            Console.Write(" Digite o Nome do Medicamento: ");
            string nome = Console.ReadLine();
            Medicamento medicamentoPesquisado = medicamentos.Pesquisar(new Medicamento(nome));
            if (medicamentoPesquisado != null)
            {
                int id = medicamentoPesquisado.Lotes.Count;
                Console.Write(" Digite a quantidade de medicamentos: ");
                int qtde = Utils.lerInt(Console.ReadLine(), 1, "Quantidade inválida!");
                Console.WriteLine("\n DATA DE VENCIMENTO");
                Console.Write(" Informe o ano: ");
                int ano = Utils.lerMinMax(Console.ReadLine(), DateTime.Now.Year + 1, 2100, " Ano inválido!\n Tente novamente: ");
                Console.Write(" Informe o mês: ");
                int mes = Utils.lerMinMax(Console.ReadLine(), 1, 12, " Mês inválido!\n Tente novamente: ");
                int diasNoMes = DateTime.DaysInMonth(ano, mes);
                Console.Write(" Informe o dia: ");
                int dia = Utils.lerMinMax(Console.ReadLine(), 1, diasNoMes, " Dia inválido!\n Tente novamente: ");
                DateTime venc = new DateTime(ano, mes, dia);
                Lote lote = new Lote(id, qtde, venc);
                medicamentoPesquisado.Comprar(lote);
                Utils.MensagemSucesso($"Compra de lote de {medicamentoPesquisado.Nome} efetuada!");
            }
            else
                Utils.MensagemErro("O medicamento não existe");
        }
    }
}
