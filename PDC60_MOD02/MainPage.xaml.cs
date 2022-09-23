using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC60_MOD02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void Button_Clicked(Object sender, EventArgs e)
        {
            txtLabel.Text = txtEntry.Text;


        }
    }
}
