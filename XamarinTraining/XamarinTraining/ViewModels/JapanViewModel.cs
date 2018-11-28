using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace XamarinTraining.ViewModels
{

	public class JapanViewModel : BindableBase
	{
    private String hiragana;
    private String katakana;
    private String exercice;
    private String message;
    private INavigationService _navigationService;
 
    public JapanViewModel(INavigationService navigationService)
    {
      Hiragana = "こんばんわ";
      Katakana = "ビル";
      Exercice = "The following word is write in katakana or in hiragana? ";

    }

   
    public string Hiragana { get => hiragana; set => hiragana = value; }
    public INavigationService NavigationService { get => _navigationService; set => _navigationService = value; }
    public string Katakana { get => katakana; set => katakana = value; }
    public string Exercice { get => exercice; set => exercice = value; }
    public string Message { get => message; set => message = value; }
  }
}
