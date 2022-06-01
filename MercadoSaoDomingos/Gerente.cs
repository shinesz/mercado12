using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MercadoSaoDomingos
{
    class Gerente
    {
        controlProduto2 conexao;//Criando a variável conexao
        private int opcao;
        public Gerente()
        {
            conexao = new controlProduto2();//Instanciando a variável conexao


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
        public int senhage = 09876;
        public void Menu()

        {

            Console.WriteLine("\n\nEscolha uma das opções abaixo:\n\n" +
                              "1. Cadastrar\n" +
                              "2. Consultar Tudo\n" +
                              "3. Consultar por Código\n" +
                              "4. Atualizar\n" +
                              "5. Consultar cpf\n" +
                              "6. Excluir\n" +

                              "0. Sair");
            AcessarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do método menu

        public void Executar()
        {
            do
            {
                Console.ReadLine();
                Console.WriteLine("Digite a senha de gerente: ");
                int senha = Convert.ToInt32(Console.ReadLine());

                if (senha == 09876)
                {
                    Menu();
                    //Executar a ação
                    switch (AcessarOpcao)
                    {
                        case 0:
                            Console.WriteLine("Obrigado!");
                            break;

                        case 1:
                            ControlFuncionario funcionario = new ControlFuncionario();
                            funcionario.Executar();
                            break;

                        case 3:

                            controlProduto2 produto = new controlProduto2();
                            produto.Executar();
                            break;


                        default:
                            Console.WriteLine("Opção escolhida não é válida! Tente novamente!");
                            break;
                    }//fim do switch

                }
                else
                {
                    Console.WriteLine("senha incorreta !!!!");
                }
            } while (senhage == senhage);

        }
        }  

    }



  
