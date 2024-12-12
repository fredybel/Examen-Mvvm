
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Examen_Mvvm.ViewModels
{
    public partial class ProductoAppMvvmViewModel : ObservableObject
    {
        [ObservableProperty]
        private double _p1;

        [ObservableProperty]
        private double _p2;

        [ObservableProperty]
        private double _p3;

        [ObservableProperty]
        private double subtotal;

        [ObservableProperty]
        private double descuento;

        [ObservableProperty]
        private double total;

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]
        private void Calcular()
        {

            try
            {
                Subtotal = P1 + P2 + P3;
                
                

                if (Subtotal < 999)
                {
                    Descuento = 0;
                    Total = Subtotal + Descuento;
                } 
                if  (Subtotal > 1000 & Subtotal < 4999)
                {
                    Descuento =  (Subtotal * 10) / 100;
                    Total = Subtotal + Descuento;
                }
               else  if (Subtotal > 5000 & Subtotal < 9999)
                {
                    Descuento = (Subtotal * 20) / 100;
                    Total = Subtotal + Descuento;
                }
                else if(Subtotal > 10000)
                {
                    Descuento = (Subtotal * 30) / 100;
                    Total = Subtotal + Descuento;
                }
            }


            catch (Exception ex)
            {
                Alerta("ERROR", ex.Message);
            }
        }
        [RelayCommand]
        private void Limpiar()
        {
            P1 = 0;
            P2 = 0;
            P3 = 0;
            Subtotal = 0;
            Descuento = 0;
            Total = 0;
        }
    }
}
