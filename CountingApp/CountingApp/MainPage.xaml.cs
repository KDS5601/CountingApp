using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CountingApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();

            int countNum = 0;

            CountUp.Clicked += (sender, e) => { ++countNum; CountingLabel.Text = countNum.ToString(); };
            CountDown.Clicked += (sender, e) => { --countNum; CountingLabel.Text = countNum.ToString(); };
            Reset.Clicked += (sender, e) => { countNum = 0; CountingLabel.Text = countNum.ToString(); };
        }
    }
}