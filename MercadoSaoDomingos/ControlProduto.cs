using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoSaoDomingos
{
    class ControlProduto
    {
        Produto conexao;//Criando a variável conexao
        public int opcao;

        public ControlProduto()
        {
            conexao = new Produto();//Instanciando a variável conexao

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
                            "2. Consultar Tudo\n" +
                            "3. Consultar por Código\n" +
                            "4. Atualizar\n" +
                            "5. Excluir\n" +
                            "6. consultar estoque\n" +

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

                        Console.ReadLine();
                        Console.WriteLine("Informe a descrição: ");
                        string descrição = Console.ReadLine();
                        Console.WriteLine("Informe a quantidade: ");
                        int quantidade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe a unidade de medida: ");
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
                        conexao.Inserir(descrição, quantidade, unidadeDeMedida, valorUnitario, dataDeFabricacao, dataDeValidade, tipoDeProduto);
                        //Mostro o dado em tela
                        Console.WriteLine("Cadastrado com Sucesso!");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine(conexao.ConsultarTudo());
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Informe o código do Produto que deseja consultar: ");
                        int codigoProduto = Convert.ToInt32(Console.ReadLine());
                        //Mostrando o resultado em tela
                        Console.WriteLine(conexao.ConsultarTudo(codigoProduto));
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Informe o campo que deseja atualizar: ");
                        string campo = Console.ReadLine();
                        Console.WriteLine("Informe o novo dado para esse campo: ");
                        string novoDado = Console.ReadLine();
                        Console.WriteLine("Informe o código do produto que deseja atualizar: ");
                        codigoProduto = Convert.ToInt32(Console.ReadLine());
                        //utilizar os dados acima no método atualizar
                        Console.WriteLine(conexao.Atualizar(codigoProduto, campo, novoDado));
                        Console.ReadLine();

                        break;
                    case 5:
                        Console.WriteLine("Informe o código que deseja apagar");
                        codigoProduto = Convert.ToInt32(Console.ReadLine());
                        //Mostrar o resultado em tela
                        Console.WriteLine(conexao.Deletar(codigoProduto));
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
    


