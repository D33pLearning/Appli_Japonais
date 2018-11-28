using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XamarinTraining.ViewModels
{
	public class HiraganaContentPageViewModel : BindableBase
	{
    private INavigationService _navigationService;
    public DelegateCommand NavigateToSpeakPageCommand { get; private set; }
    public HiraganaContentPageViewModel(INavigationService navigationService)
    {
      _navigationService = navigationService;
      NavigateToSpeakPageCommand = new DelegateCommand(NavigateToSpeakPage);
    }
    private void NavigateToSpeakPage()
    {
      _navigationService.NavigateAsync("Hiragana_AContentPage");
    }

  }
}
