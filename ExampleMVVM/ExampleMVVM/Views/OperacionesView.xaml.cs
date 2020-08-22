using ExampleMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExampleMVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OperacionesView : ContentPage
    {
        public OperacionesView()
        {
            InitializeComponent();
            BindingContext = new OperacionesViewModel();
        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    lblResultado.Text = txtValor1.Text + txtValor2.Text;
        //}
    }
}