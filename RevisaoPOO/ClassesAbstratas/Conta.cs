﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratas
{
    public abstract class Conta
    {
        private double saldo;
        private double rendimentoAtual;
        private string correntista;
        private int numeroConta = 1000;

        public abstract void CalcularRendimento();

        public virtual int NumeroConta()
        {
            return this.numeroConta;
        }

        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                this.saldo = value;
            }
        }

        public double RendimentoAtual
        {
            get
            {
                return this.rendimentoAtual;
            }
            set
            {
                this.rendimentoAtual = value;
            }
        }

        public string Correntista
        {
            get
            {
                return this.correntista;
            }
            set
            {
                this.correntista = value;
            }
        }
    }
}
