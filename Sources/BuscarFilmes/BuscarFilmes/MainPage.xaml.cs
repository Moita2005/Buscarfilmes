using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BuscarFilmes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnEnviarClicked(object sender, EventArgs e)
        {
            string textoDoEntry = MeuEntry.Text; // Obtenha o texto do Entry
            // Faça algo com o texto, por exemplo, envie-o para algum lugar ou realize alguma ação

            //Console.WriteLine(textoDoEntry);
        }
    }
}
