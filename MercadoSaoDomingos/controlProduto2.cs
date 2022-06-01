using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoSaoDomingos
{
    class controlProduto2
    {
        class ControlProduto
        {
          
            public int opcao;

            public int AcessarOpcao
            {
                get
                {
                    return opcao;
                }
                set
                {
                    this.opcao = value;
                }
            }//fim do acessarOpcao
            public void Menu()
            {
                Console.Clear();//Limpar a tela do console
                Console.WriteLine("\n\nEscolha uma das opções abaixo:\n\n" +
                                "1. Consultar produto por código\n" +
                                "2. Estoque\n" +
                                "3. Consultar por Código\n" +
                                "4. Atualizar\n" +
                                "5. Excluir\n" +
                                "6. Consultar estoque\n" +

                                "0. Sair");
                AcessarOpcao = Convert.ToInt32(Console.ReadLine());
            }//fim do método menu

            public void Executar()
            {
                do
                {
                    Menu();
                    //Executar a ação
                    switch (AcessarOpcao)
                    {
                        case 0:
                            Console.WriteLine("Obrigado!");
                            break;
                        case 1:
                            Console.WriteLine("Informe o código do Produto que deseja consultar: ");
                            int codigoProduto = Convert.ToInt32(Console.ReadLine());
                            //Mostrando o resultado em tela
                            Console.WriteLine(conexao.ConsultarTudo(codigoProduto));
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine(conexao.ConsultarEstoque());
                            Console.ReadLine();
                            break;

                        default:
                            Console.WriteLine("Opção escolhida não é válida! Tente novamente!");
                            break;
                    }//fim do switch
                } while (AcessarOpcao != 0);
           
            }//fim do executar
        }//fim da control
    }//fim do projeto


}

