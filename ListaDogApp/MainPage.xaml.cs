using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ListaDogApp.Model;

namespace ListaDogApp
{
    public partial class MainPage : ContentPage
    {
        List<Dog> listaDog = new List<Dog>();


        public MainPage()
        {
            InitializeComponent();
        }

        void Adicionar(object sender, System.EventArgs e)
        {
            Dog dog = new Dog();
            dog.nome = nome.Text;
            dog.idade = idade.Text;
            dog.raca = raca.Text;
            listaDog.Add(dog);
        }

        void Listar(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new DogPage(listaDog));
        }
    }

}