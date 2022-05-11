using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoSaoDomingos
{
    class ControlProduto
    {
        Produto produto;//Conectando a model e a control
        private int opcao;
        public ControlProduto()
        {
           produto = new Produto();
        }//fim do construtor

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
                               "1. Cadastrar\n" +
                               "2. Consultar\n" +
                               "3. Atualizar Descrição\n" +
                               "4. Atualizar Quantidade\n" +
                               "5. Atualizar Unidade de Medida\n" +
                               "6. Atualizar Valor Unitário\n" +
                               "7. Atualizar Data de Fabricação\n" +
                               "8. Atualizar Data de Validade\n" +
                               "9. Atualizar Tipo de Produto\n" +
                               "10. Excluir\n" +
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
                        //Coletando o dado
                        Console.WriteLine("Informe um código: ");
                        int codigoProduto = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe a descrição: ");
                        string descrição = Console.ReadLine();
                        Console.WriteLine("Informe a quantidade: ");
                        int quantidade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe a uniade de medida: ");
                        string unidadeDeMedida = Console.ReadLine();
                        Console.WriteLine("Informe o valor unitário: ");
                        int  valorUnitario = Convert.ToInt32 (Console.ReadLine());
                        Console.WriteLine("Informe a data de fabricação: ");
                        DateTime dataDeFabricacao = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Informe a data de validade: ");
                        DateTime dataDeValidade = Convert.ToDateTime (Console.ReadLine());
                        Console.WriteLine("Informe o tipo de produto: ");
                        string tipoDeProduto = Console.ReadLine();
                        //Passei o dado por parâmetro para o método
                        produto.Cadastrar(codigoProduto, descrição, quantidade, unidadeDeMedida, valorUnitario, dataDeFabricacao, dataDeValidade, tipoDeProduto);
                        //Mostro o dado em tela
                        Console.WriteLine("Cadastrado com Sucesso!");
                        break;
                    case 2:
                        //Pedir para o usuário digitar um código
                        Console.WriteLine("Informe um código: ");
                        codigoProduto = Convert.ToInt32(Console.ReadLine());
                        //Mostrar o resultado da operação
                        Console.WriteLine(produto.Consultar(codigoProduto));
                        Console.ReadLine();//Manter o prompt aberto
                        break;
                    case 3:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigoProduto = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe a descrição: ");
                        descrição = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(produto.AtualizarDescricao(codigoProduto, descrição));
                        break;
                    case 4:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigoProduto = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe a quantidade: ");
                        quantidade = Convert.ToInt32(Console.ReadLine());
                        //Utilizar o método da classe model
                        Console.WriteLine(produto.AtualizarQuantidade(codigoProduto, quantidade));
                        break;
                    case 5:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigoProduto = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe a unidade de medida: ");
                        unidadeDeMedida = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(produto.AtualizarUnidadeDeMedida(codigoProduto, unidadeDeMedida));
                        break;

                    case 6:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigoProduto = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o valor unitário: ");
                        valorUnitario = Convert.ToInt32 (Console.ReadLine());
                        //Utilizar o método da classe model
                        Console.WriteLine(produto.AtualizarValorUnitario(codigoProduto, valorUnitario));
                        break;

                    case 7:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigoProduto = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe uma data de fabricação : ");
                        dataDeFabricacao = Convert.ToDateTime(Console.ReadLine());
                        //Utilizar o método da classe model
                        Console.WriteLine(produto.AtualizarDataDeFabricacao(codigoProduto, dataDeFabricacao));
                        break;

                    case 8:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigoProduto = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe data de validade: ");
                        dataDeValidade = Convert.ToDateTime(Console.ReadLine());
                        //Utilizar o método da classe model
                        Console.WriteLine(produto.AtualizarDataDeValidade(codigoProduto, dataDeValidade));
                        break;

                    case 9:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigoProduto = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe uma Quantidade de compras: ");
                        tipoDeProduto = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(produto.AtualizarTipoDeProduto(codigoProduto, tipoDeProduto));
                        break;

                    case 10:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigoProduto = Convert.ToInt32(Console.ReadLine());
                        //Utiliza o método
                        Console.WriteLine(produto.Excluir(codigoProduto));
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida! Tente novamente!");
                        break;
                }//fim do switch
            } while (AcessarOpcao != 0);
        }//fim do executar
    }//fim da control
}//fim do projeto
    


