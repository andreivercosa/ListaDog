using System;
using System.Collections.Generic;
using ListaDogApp.Model;

using Xamarin.Forms;

namespace ListaDogApp
{
    public partial class DogPage : ContentPage
    {
        public DogPage(List<Dog> DogList)
        {
            InitializeComponent();
            listView_lista.ItemsSource = DogList;

        }
    }
}
