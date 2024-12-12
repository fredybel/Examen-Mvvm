
using Examen_Mvvm.ViewModels;

namespace Examen_Mvvm.Views;

public partial class ProductoAppMvvmView : ContentPage
{
	ProductoAppMvvmViewModel ViewModel;
	public ProductoAppMvvmView()
	{
		InitializeComponent();
		ViewModel = new ProductoAppMvvmViewModel();
		BindingContext = ViewModel;
	}
}