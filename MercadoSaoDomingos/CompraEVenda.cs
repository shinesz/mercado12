using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoSaoDomingos
{
    class CompraEVenda
    {
       
            // declarar variaveis 
            private int codigoCompra;
            private int quantidade;
            private  string cpf;
            private double valor;

            public CompraEVenda()
            {
                AcessarCodigoCompra = 0;
                AcessarQuantidade = 0;
                AcessarValor = 0;
                 AcessarCpf = "";

            }// fim construtor


        //desenvolver os metodos gets e sets

        public string AcessarCpf
        {
            get
            {

                return cpf;
            }
            set
            {
                this.cpf = value;
            }
        }//fim do acessar cpf
        public int AcessarCodigoCompra
            {
                get
                {

                    return codigoCompra;
                }
                set
                {
                    this.codigoCompra = value;
                }
            }//fim do acessar codigo


            public int AcessarQuantidade
            {
                get
                {

                    return quantidade;
                }
                set
                {
                    this.quantidade = value;
                }
            }//fim do acessar quantidade de compras

            public double AcessarValor
            {
                get
                {

                    return valor;
                }
                set
                {
                    this.valor = value;
                }
            }//fim do acessar valor total gasto

            public void Cadastrar(int codigoCompra, int quantidade, double valor)
            {
                AcessarCodigoCompra = codigoCompra;
                AcessarQuantidade = quantidade;
                AcessarValor = valor;
                AcessarCpf = cpf;
            }

        public string Consultar(int codigoCompra)
            {
                if (AcessarCodigoCompra == codigoCompra)
                {
                    return "Código: " + AcessarCodigoCompra +
                           "\nQuantidade de compras: " + AcessarQuantidade +
                           "\nValor total gasto:" + AcessarValor;
                }
                else
                {
                    return "Código Informado Não é Valido!";
                }
            }//fim do método consultar



            public string AtualizarQuantidade(int codigoCompra, int quantidade)
            {
                if (AcessarCodigoCompra == codigoCompra)
                {
                    AcessarQuantidade = quantidade;
                    return "Quantidade de compras atualizado com sucesso!";
                }
                else
                {
                    return "Código informado não é válido!";
                }
            }//fim atualizar quantidade 



            public string AtualizarValorTotalGasto(int codigoCompra, double valor)
            {
                if (AcessarCodigoCompra == codigoCompra)
                {
                    AcessarValor = valor;
                    return "Valor  de compra atualizado com sucesso!";
                }
                else
                {
                    return "Código informado não é válido!";
                }
            }//fim atualizar valor 


            public string Excluir(int codigoCompra)
            {
                if (AcessarCodigoCompra == codigoCompra)
                {
                    AcessarCodigoCompra = 0;
                    AcessarQuantidade = 0;
                    AcessarValor = 0;

                    return "Dados excluídos com sucesso!";
                }
                else
                {
                    return "Código informado não é válido!";
                }
            }//fim do excluir


       

    }// fim compra e venda 
}// fim projeto




