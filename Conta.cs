using System;
using System.Collections.Generic;
using System.Text;

namespace BancoJequiti
{
    class Conta
    {
        private int Agencia;
        private int Numero;
        private double Saldo;

        public void SetAgencia(int Valor)
        { 
        Agencia = Valor;
        }
        public int GetAgencia()
        {
        return Agencia;
        }

        public void SetNumero(int Valor)
        {
        Numero = Valor;
        }
        public int GetNumero()
        {
        return Numero;
        }

        public void SetSaldo(int Valor)
        {
            Saldo = Valor;
        }
        public double GetSaldo()
        {
            return this.Saldo;
        }
    }
}
