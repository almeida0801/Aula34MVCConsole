using System;
using System.Collections.Generic;
using Aula34MVCconsole.Models;

namespace Aula34MVCconsole.Views
{
    public class ProdutoView
    {
        public void MostrarNoConsole(List<Produto> lista){
            foreach(Produto item in lista)
            {
                Console.WriteLine($" {item.Codigo} R$ {item.Preco} -- {item.Nome} ");
            }
        }


    }
}