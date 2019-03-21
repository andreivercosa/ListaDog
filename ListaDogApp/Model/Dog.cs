using System;
namespace ListaDogApp.Model
{
    public class Dog
    {
        public string nome { get; set; }
        public string idade { get; set; }
        public string raca { get; set; }
        public string nomeIdade
        {
            get { return "NOME: " + nome + ", IDADE: " + idade; }
        }
        public Dog()
        {
        }
    }
}
