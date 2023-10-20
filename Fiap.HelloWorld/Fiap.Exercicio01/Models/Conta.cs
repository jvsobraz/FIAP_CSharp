using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Models
{
    //Classe abstrata: n�o pode ser instanciada e pode conter m�todos abstratos
    internal abstract class Conta
    {
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public DateTime DataAbertura { get; set; }
        public decimal Saldo { get; protected set; }

        //virtual: permite a sobrescrita do m�todo
        public virtual void Depositar(decimal valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor n�o pode ser negativo");
            }
            Saldo += valor;
        }

        public virtual void Retirar(decimal valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor n�o pode ser negativo");
            }
            Saldo -= valor;
        }
    }
}