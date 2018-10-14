using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.ControlesBasicos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConfigPage : ContentPage
	{
		public ConfigPage ()
		{
            BindingContext = App.ConfigModel;
            InitializeComponent ();
		}

        private void OnReceberEmail_Changed(object sender, EventArgs e)
        {
            var selecioneAtivo = ((SwitchCell)sender).BindingContext as Configuracao;


            if (selecioneAtivo.ReceberEmail)
                txtEnderecoEmail.IsVisible = true;
            else
                txtEnderecoEmail.IsVisible = false;
        }
    }
}