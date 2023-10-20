using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Models
{
    //Classe abstrata: n�o pode ser instanciada e pode conter m�todos
    //sem implementa��o (m�todos abstratos)
    internal abstract class Pessoa
    {
        public string Nome { get; set; }
        public char Genero { get; set; }

        //Construtor com Nome
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        //M�todos
        //virtual -> permite a sobrescrita do m�todo
        public virtual void Falar(string fala)
        {
            Console.WriteLine($"Pessoa falando: {fala}");
        }

        public abstract void Sonhar();

    }
}