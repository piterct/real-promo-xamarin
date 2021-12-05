using RealPromo.Models;
using RealPromo.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RealPromo
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Promocao> lista = new ObservableCollection<Promocao>();
        public MainPage()
        {
            InitializeComponent();

            new RealPromoSignalR(lista);

            ListViewPromocao.ItemsSource = lista;


        }


    }
}
