using LearnMaui.ViewModels;

namespace LearnMaui.Views;

public partial class ProductPage : ContentPage
{
	public ProductPage()
	{
		InitializeComponent();
        BindingContext = new ProductViewModel();
	}
}