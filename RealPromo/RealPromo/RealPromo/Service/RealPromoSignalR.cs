using Microsoft.AspNetCore.SignalR.Client;
using RealPromo.Models;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace RealPromo.Service
{
    public class RealPromoSignalR
    {
        public RealPromoSignalR(ObservableCollection<Promocao> lista)
        {
            Task.Run(async () => { await ConfigurarSignalR(lista); });
        }


        private async Task ConfigurarSignalR(ObservableCollection<Promocao> lista)
        {
            try
            {

                var connection = new HubConnectionBuilder().WithUrl("https://localhost:44390/PromoHub").Build();



                connection.On<Promocao>("ReceberPromocao", (promocao) =>
                {
                    Xamarin.Forms.Device.InvokeOnMainThreadAsync(() =>
                    {
                        lista.Add(promocao);
                    });

                });

                connection.Closed += async (error) => {
                    await Task.Delay(5000);
                    await connection.StartAsync();
                };

                await connection.StartAsync();

            }

            catch (Exception ex)
            {
               
            }
        }
    }
}
