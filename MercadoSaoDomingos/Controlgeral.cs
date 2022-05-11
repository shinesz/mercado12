using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoSaoDomingos
{

    class Controlgeral
    {

        private int opcao;
        public Controlgeral()
        {
           

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
                               "1. Cadastrar cliente\n" +
                               "2. Cadastrar funcionario\n" +
                               "3. Cadastrar produto \n" +
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

                        ControlCliente  cliente = new ControlCliente();
                       cliente.Executar();
                        Console.ReadLine();
                        break;

                    case 2:

                        ControlFuncionario funcionario = new ControlFuncionario();
                        funcionario.Executar();
                        Console.ReadLine();
                        break;

                    case 3:

                        ControlProduto produto = new ControlProduto();
                        produto.Executar();
                        Console.ReadLine();
                        break;

                }//fim do switch
            } while (AcessarOpcao != 0);
        }//fim do executar
    }//fim da control
}//fim do projeto




