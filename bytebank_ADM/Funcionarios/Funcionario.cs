﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario 
    {
        public static int TotalFuncionarios { get; set; }
        public string Nome    { get; set; }

        public string Cpf     { get; private set; }

        public double Salario { get;  set; }

        public string Senha   { get; set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Salario = salario;

            TotalFuncionarios++;
        }

        public Funcionario(string cpf) 
        { 
            this.Cpf += cpf;
        }

        public Funcionario(string cpf , double salario)
        {
            this.Cpf += cpf;
            this.Salario = salario;
        }

        /// <summary>
        /// Este método retorna 10% do salario do Funcionario

        /// </summary>
        /// <returns>this.salario.</returns>
        public abstract double GetBonificacao();

        public abstract void AumentarSalario();        

        public virtual void MostrarInformacao()
        {
            Console.WriteLine("Nome...:" + this.Nome + '\n' +
                              "CPF....:" + this.Cpf  + '\n' +
                              "Salario:" + this.Salario);
        }
    }
}
