
using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Master",
                DiariaAdulto = 150,
                DiariaCriana = 75.5
            },
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                DiariaAdulto = 100,
                DiariaCriana = 50.5
            },
            new Quarto()
            {
                Descricao = "Suíte Express",
                DiariaAdulto = 50,
                DiariaCriana = 25.5
            },
            new Quarto()
            {
                Descricao = "Suíte Simples",
                DiariaAdulto = 25,
                DiariaCriana = 13
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 700;

            return window;
        }
    }
}
