using System;

namespace SistemaCadastroProdutos
{
    class Program
    {
        //Função principal
        // Objetivo é fazer a recepção do usuario
        static void Main(string[] args)
        {
            //Criei uma nova instância de program para chamar metodos externos ao Main
            Program Myclass = new Program();
            
            //Metodo write|ine escreve na tela
            Console.WriteLine("Inicio do sistema");
            Myclass.VerificaOpcao();
        }

        //Metodo que verifica opção
        public void VerificaOpcao()
        {
            Program Myclass = new Program();
            Console.WriteLine("O que você quer fazer?");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("Opção 1 - Cadastrar produto");
            Console.WriteLine("Opção 2 - Editar produto");
            Console.WriteLine("Opção 3 - Excluir produto");
            Console.WriteLine("Opção 4 - Pesquisar produto");

            //declaração de uma variavel inteira que recebe o
            //numero de opção escolhida pelo usuario.
            //O método precisou ser convertido em inteiro
            int opcaoEscolhida = int.Parse(Console.ReadLine());

            Console.WriteLine("Opção escolhida: " + opcaoEscolhida);

            //valida a opção escolhida e chama o metodo
            if (opcaoEscolhida == 1)
            {
                Myclass.CadastrarProduto();
            }
            else if (opcaoEscolhida == 2)
            {
                Myclass.EditarProduto();
            }
            else if (opcaoEscolhida == 3)
            {
                Myclass.ExcluirProduto();
            }
            else if (opcaoEscolhida == 4)
            {
                Myclass.PesquisarProduto();
            }

        }

        //como eu vou saber se o produto camiseta  existe no cadastro?

        //Metodo para cadastrar produto
        public void CadastrarProduto()
        {

        }      
        
        //Metodo para editar produto
        public void EditarProduto()
        {

        }
        //Metodo para excluir produto
        public void ExcluirProduto()
        {

        } 
        
        //Metodo para pesquisar produto
        public void PesquisarProduto()
        {
            Console.WriteLine("teste");
        }
    }
}
