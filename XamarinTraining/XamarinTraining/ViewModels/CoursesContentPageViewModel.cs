using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XamarinTraining.ViewModels
{
	public class CoursesContentPageViewModel : BindableBase
	{
        private string hiragana;
        public CoursesContentPageViewModel()
        {
          Hiragana = "おはよ!";
        }

    public string Hiragana { get => hiragana; set => hiragana = value; }
  }
}
