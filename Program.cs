using System;

namespace Pedidos
{
    class Produtos
    {
        static void Main(string[] args)
        {

            string traco = new string('-', 50);

            Itens op = new Itens(); 


            Console.WriteLine("Sistema de Pedidos");
            Console.WriteLine(traco);

            Console.WriteLine("Escolha o Produto que deseja comprar ");


            Console.WriteLine("\nTabela de produtos: ");
            Console.WriteLine(traco);

            Console.WriteLine("1.Camisetas Personalizadas - R$ 25,00 por unidade");
            Console.WriteLine("2.Canecas de Porcelana - R$ 15,00 por unidade");
            Console.WriteLine("3.Kits de Maquiagem - R$ 50,00 por kit");
            Console.WriteLine("4.Fones de Ouvido Bluetooth - R$ 80,00 por unidade");
            Console.WriteLine("5.Livros Best-sellers - R$ 30,00 por unidade");
            Console.WriteLine(traco);

            op.MenuOpcoes();

        }
    }
}