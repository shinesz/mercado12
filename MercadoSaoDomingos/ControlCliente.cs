using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoSaoDomingos
{
    class ControlCliente
    {
        Cliente cliente;//Conectando a model e a control
        private int opcao;
        public ControlCliente()
        {
            cliente = new Cliente();
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
                               "3. Atualizar Nome\n" +
                               "4. Atualizar Telefone\n" +
                               "5. Atualizar Endereço\n" +
                               "6. Atualizar Sexo\n" +
                               "7. Atualizar Email \n" +
                               "8. Atualizar Quantidade de compras\n" +
                               "9. Atualizar Valor Total Gasto\n" +
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
                        int codigoCliente = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe um nome: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Informe um telefone: ");
                        string telefone = Console.ReadLine();
                        Console.WriteLine("Informe um endereço: ");
                        string endereco = Console.ReadLine();
                        Console.WriteLine("Informe um CPF: ");
                        string cpf = Console.ReadLine();
                        Console.WriteLine("Informe um sexo: ");
                        string sexo = Console.ReadLine();
                        Console.WriteLine("Informe um email: ");
                        string email = Console.ReadLine();
                        Console.WriteLine("Informe a quantidade de compras: ");
                        int quantidadeDeCompras = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe a valor total gasto: ");
                        double valorTotalGasto = Convert.ToDouble(Console.ReadLine());
                        //Passei o dado por parâmetro para o método
                        cliente.Cadastrar(codigoCliente,nome,telefone,endereco,cpf,sexo,email, quantidadeDeCompras , valorTotalGasto );
                        //Mostro o dado em tela
                        Console.WriteLine("Cadastrado com Sucesso!");
                        break;
                    case 2:
                        //Pedir para o usuário digitar um código
                        Console.WriteLine("Informe um código: ");
                        codigoCliente = Convert.ToInt32(Console.ReadLine());
                        //Mostrar o resultado da operação
                        Console.WriteLine(cliente.Consultar(codigoCliente));
                        Console.ReadLine();//Manter o prompt aberto
                        break;
                    case 3:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigoCliente = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe um nome: ");
                        nome = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(cliente.AtualizarNome(codigoCliente, nome));
                        break;
                    case 4:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigoCliente = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe um telefone: ");
                        telefone = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(cliente.AtualizarTelefone(codigoCliente, telefone));
                        break;
                    case 5:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigoCliente = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe um Endereço: ");
                        endereco = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(cliente.AtualizarEndereco(codigoCliente, endereco));
                        break;

                    case 6:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigoCliente = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe um Sexo: ");
                        sexo = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(cliente.AtualizarSexo(codigoCliente, sexo));
                        break;

                    case 7:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigoCliente = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe um Email: ");
                        email = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(cliente.AtualizarEmail(codigoCliente, email));
                        break;

                    case 8:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigoCliente = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe uma Quantidade de compras: ");
                        quantidadeDeCompras = Convert.ToInt32(Console.ReadLine());
                        //Utilizar o método da classe model
                        Console.WriteLine(cliente.AtualizarQuantidadeDeCompras(codigoCliente, quantidadeDeCompras));
                        break;

                    case 9:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigoCliente = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe uma Quantidade de compras: ");
                        valorTotalGasto = Convert.ToDouble(Console.ReadLine());
                        //Utilizar o método da classe model
                        Console.WriteLine(cliente.AtualizarValorTotalGasto(codigoCliente, valorTotalGasto));
                        break;

                    case 10:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigoCliente = Convert.ToInt32(Console.ReadLine());
                        //Utiliza o método
                        Console.WriteLine(cliente.Excluir(codigoCliente));
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida! Tente novamente!");
                        break;
                }//fim do switch
            } while (AcessarOpcao != 0);
        }//fim do executar
    }//fim da control
}//fim do projeto

    

