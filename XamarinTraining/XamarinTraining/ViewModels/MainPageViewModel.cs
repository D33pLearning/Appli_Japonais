using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace XamarinTraining.ViewModels
{
  public class MainPageViewModel : ViewModelBase
  {
    private INavigationService _navigationService;

    public DelegateCommand NavigateToSpeakPageCommand { get; private set; }
    public DelegateCommand NavigateToSpeakPageCommand2 { get; private set; }

    public DelegateCommand NavigateToSpeakPageCommand3 { get; private set; }


    public MainPageViewModel(INavigationService navigationService)
        : base(navigationService)
    {
      Title = "Main Page";
      _navigationService = navigationService;
      NavigateToSpeakPageCommand = new DelegateCommand(NavigateToSpeakPage);
      NavigateToSpeakPageCommand2 = new DelegateCommand(NavigateToSpeakPage2);
      NavigateToSpeakPageCommand3 = new DelegateCommand(NavigateToSpeakPage3);
    }


    private void NavigateToSpeakPage()
    {
      _navigationService.NavigateAsync("Japan");
    }

    private void NavigateToSpeakPage2()
    {
      _navigationService.NavigateAsync("CoursesContentPage");
    }

    private void NavigateToSpeakPage3()
    {
      _navigationService.NavigateAsync("HiraganaContentPage");
    }

    public void Button_Clicked(object sender, EventArgs e)
    {
      (sender as Button).Text = "Nice job";
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
      (sender as Button).Text = "You pressed me!";
    }

    private void Button_Pressed(object sender, EventArgs e)
    {
      (sender as Button).Text = "I was just clicked!";
    }

  }
}
