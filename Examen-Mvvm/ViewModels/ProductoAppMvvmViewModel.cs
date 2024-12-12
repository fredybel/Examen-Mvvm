
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

                Total = Subtotal + Descuento;


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
