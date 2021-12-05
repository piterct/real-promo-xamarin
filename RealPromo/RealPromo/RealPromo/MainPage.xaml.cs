using RealPromo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RealPromo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ListViewPromocao.ItemsSource = GetPromocoes();
        }

        private List<Promocao> GetPromocoes()
        {
            List<Promocao> lista = new List<Promocao>();

            lista.Add(new Promocao { Empresa = "Carrefour", Chamada = "Tvs em promoções", Regras = "10 unidades", EnderecoURL = "https://www.carrefour.com.br" }); 
            lista.Add(new Promocao { Empresa = "Carrefour", Chamada = "Notebooks em promoções", Regras = "20 unidades", EnderecoURL = "https://www.carrefour.com.br" });

            return lista;
        }
    }
}
