using CollectionViewMemoryLeaks.ViewModels;

namespace CollectionViewMemoryLeaks.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
