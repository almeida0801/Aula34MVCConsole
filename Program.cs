using System;
using Aula34MVCconsole.Controllers;

namespace Aula34MVCconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produto = new ProdutoController();
            produto.Filtrar("4500");

        }
    }
}
