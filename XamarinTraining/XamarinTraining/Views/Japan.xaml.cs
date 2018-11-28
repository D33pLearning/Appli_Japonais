using Xamarin.Forms;

namespace XamarinTraining.Views
{
    public partial class Japan : ContentPage
    {
        public Japan()
        {
            InitializeComponent();
        }

    private void ButtonHiragana_Clicked(object sender, System.EventArgs e)
    {
      LabelResult.Text = "WRONG!";
    }

    private void ButtonKatakana_Clicked(object sender, System.EventArgs e)
    {
      LabelResult.Text = "GOOD JOB";
    }
  }
}
