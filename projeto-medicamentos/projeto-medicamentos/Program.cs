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
                        //cadastrarMedicamento();
                        break;
                    case 2:
                        //consultorMedicamentoSintetico();
                        break;
                    case 3:
                        //consultorMedicamentoAnalitico();
                        break;
                    case 4:
                        //comprarMedicamento();
                        break;
                    case 5:
                        //venderMedicamento();
                        break;
                    case 6:
                        //listarMedicamento();
                        break;
                    default:
                        Utils.MensagemErro("Digite um número de 0-6!");
                        break;
                }
            }
        }
    }
}
