﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double preco { get; set; }
        public int Estoque { get; set; }

        //metodos
        public void QuantidadeEstoque()
        {
            Console.WriteLine("A Quantidade em estoque é: " + this.Estoque);
        }
    }
}
