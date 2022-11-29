using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTabuada
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Executar(object sender, EventArgs e)
        {

            int n = Convert.ToInt32(eNumero.Text);
            List<String> itens = new List<String>();
            string texto = "";
            for (int i = 0; i < 11; i++)
            {

                texto = n + " X " + i + " = " + (n * i);
                itens.Add(texto);

            }

            Dados.ItemsSource= itens;

        }
    }
}
