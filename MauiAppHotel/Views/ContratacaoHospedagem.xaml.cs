using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	App PropriedadesApp;
	public ContratacaoHospedagem()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		pck_suite.ItemsSource = PropriedadesApp.lista_quartos;

		dtpck_checkin.MinimumDate = DateTime.Now;
		dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

		dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
		dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddMonths(3);
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{

			hospedagem h = new hospedagem
			{
				QuartoSelecionado = (Quarto)pck_suite.SelectedItem,
				QntAdultos = Convert.ToInt32(stp_adultos.Value),
				QntCriancas = Convert.ToInt32(stp_criancas.Value),
				DataCheckin = dtpck_checkin.Date,
				DataCheckout = dtpck_checkout.Date,

			};

			await Navigation.PushAsync(new HospedagemContratada()
			{
				BindingContext = h
			});

		}catch (Exception ex) 
		{
			await DisplayAlert("Ops", ex.Message, "Ok");
		}
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;

		DateTime data_selecionada_checkin = elemento.Date;

		dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
		dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
    }
}