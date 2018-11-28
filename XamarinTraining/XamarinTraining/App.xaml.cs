using Prism;
using Prism.Ioc;
using XamarinTraining.ViewModels;
using XamarinTraining.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinTraining
{
  public partial class App
  {
    /* 
     * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
     * This imposes a limitation in which the App class must have a default constructor. 
     * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
     */
    public App() : this(null) { }

    public App(IPlatformInitializer initializer) : base(initializer) { }

    protected override async void OnInitialized()
    {
      InitializeComponent();

      await NavigationService.NavigateAsync("NavigationPage/MainPage");
    }


    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
      containerRegistry.RegisterForNavigation<NavigationPage>();
      containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
      containerRegistry.RegisterForNavigation<Japan, JapanViewModel>();
      containerRegistry.RegisterForNavigation<CoursesContentPage, CoursesContentPageViewModel>();
      containerRegistry.RegisterForNavigation<HiraganaContentPage, HiraganaContentPageViewModel>();
      containerRegistry.RegisterForNavigation<Hiragana_AContentPage, Hiragana_AContentPageViewModel>();
    }
  }
}
