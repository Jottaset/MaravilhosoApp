using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Maravilhoso
{
    public partial class MainPage : ContentPage
    {
        int i = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        void AcaoDeClicar(Object sender, EventArgs e)
        {
            string c = i + " Clicadas";

            if (i % 2 != 0)
            {
                label_1.Text = "Foi";
                Button_1.Text = "Clicou";
                label_2.Text = c;
            }
            if (i % 2 == 0)
            {
                label_1.Text = "Voltou";
                Button_1.Text = "Clicastes";
                label_2.Text = c;
            }
            i++;
        }
    }
}
