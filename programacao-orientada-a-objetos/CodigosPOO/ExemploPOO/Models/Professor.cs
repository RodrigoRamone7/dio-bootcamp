﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    internal class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {

        }
        public decimal Salario { get; set; }

        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {Nome}");
            Console.WriteLine($"E meu salário é R${Salario}");
        }
    }
}
