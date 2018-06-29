using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sorteio
{
	public partial class MainPage : ContentPage
	{
        static int numeroSorteado;
        static int score;

		public MainPage()
		{
			InitializeComponent();
            numeroSorteado = sortear();
            score = 0;
            DisplayAlert("Sorteio", "Sorteado: " + (numeroSorteado + 1), "Ok");
        }

        private int sortear() {
            Random rand = new Random();
            int sorteado = rand.Next(3);//sorteia de 0 a 2
            return sorteado;
        }

        private void BtnCarta1_Clicked(object sender, EventArgs e) {
            if (numeroSorteado == 0) {
                DisplayAlert("Carta 1", "GANHOU", "Ok");
                score += 7;
                LbScore.Text = "ACERTOU";
            } else {
                DisplayAlert("Carta 1", "PERDEU", "Ok");
                score -= 5;
            }
            LbScore.Text = "Pontos: " + score;
        }

        private void BtnCarta2_Clicked(object sender, EventArgs e) {
            if (numeroSorteado == 1) {
                DisplayAlert("Carta 2", "GANHOU", "Ok");
                score += 7;
            } else {
                DisplayAlert("Carta 2", "PERDEU", "Ok");
                score -= 5;
            }
            LbScore.Text = "Pontos: " + score;
        }

        private void BtnCarta3_Clicked(object sender, EventArgs e) {
            if (numeroSorteado == 2) {
                DisplayAlert("Carta 3", "GANHOU", "Ok");
                score += 7;
            } else {
                DisplayAlert("Carta 3", "PERDEU", "Ok");
                score -= 5;
            }
            LbScore.Text = "Pontos: " + score;
        }

        private void BtnRestart_Clicked(object sender, EventArgs e) {
            numeroSorteado = sortear();
            score = 0;
            LbScore.Text = "Pontos: " + score;
            DisplayAlert("Sorteio", "Sorteado: " + (numeroSorteado + 1), "Ok");
        }

        
    }
}
