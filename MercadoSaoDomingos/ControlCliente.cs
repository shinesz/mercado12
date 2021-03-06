using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoSaoDomingos
{
    class ControlCliente
    {
        DAO conexao;//Criando a variável conexao
       public int opcao;
    
        public ControlCliente()
        {
            conexao = new DAO();//Instanciando a variável conexao
           
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
          
            Console.WriteLine("\n\nEscolha uma das opções abaixo:\n\n" +
                              "1. Cadastrar\n" +
                              "2. Consultar Tudo\n" +
                              "3. Consultar por Código\n" +
                              "4. Atualizar\n" +
                              "5. Excluir\n" +
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
                       
                        Console.WriteLine("Informe um nome: ");
                        string nomeCompleto = Console.ReadLine();
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
                        conexao.Inserir(nomeCompleto,telefone,endereco,cpf,sexo,email, quantidadeDeCompras , valorTotalGasto );
                        //Mostro o dado em tela
                        
                        break;
                    case 2:
                        Console.WriteLine(conexao.ConsultarTudo());
                        break;
                    case 3:
                        Console.WriteLine("Informe o código do cliente que deseja consultar: ");
                        int codigoCliente = Convert.ToInt32(Console.ReadLine());
                        //Mostrando o resultado em tela
                        Console.WriteLine(conexao.ConsultarTudo(codigoCliente));
                        break;
                    case 4:
                        Console.WriteLine("Informe o campo que deseja atualizar: ");
                        string campo = Console.ReadLine();
                        Console.WriteLine("Informe o novo dado para esse campo: ");
                        string novoDado = Console.ReadLine();
                        Console.WriteLine("Informe o código do usuário que deseja atualizar: ");
                        codigoCliente = Convert.ToInt32(Console.ReadLine());
                        //utilizar os dados acima no método atualizar
                        Console.WriteLine(conexao.Atualizar(codigoCliente, campo, novoDado));
                        break;
                  
                    case 5:
                        Console.WriteLine("Informe o código que deseja apagar");
                        codigoCliente = Convert.ToInt32(Console.ReadLine());
                        //Mostrar o resultado em tela
                        Console.WriteLine(conexao.Deletar(codigoCliente));
                        break;

                    default:
                        Console.WriteLine("Opção escolhida não é válida! Tente novamente!");
                        break;
                }//fim do switch
            } while (AcessarOpcao != 0);
        }//fim do executar
    }//fim da control
}//fim do projeto

    

