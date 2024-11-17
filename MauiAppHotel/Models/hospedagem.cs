using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppHotel.Models
{
    public class hospedagem
    {
        public Quarto QuartoSelecionado { get; set; }
        public int QntAdultos { get; set; }
        public int QntCriancas { get; set; }
        public DateTime DataCheckin {  get; set; }
        public DateTime DataCheckout { get; set; }

        public int Estadia
        {
            get => DataCheckout.Subtract(DataCheckin).Days;
        }

        public double ValorTotal
        {
            get
            {
                double Valor_adultos = QntAdultos * QuartoSelecionado.DiariaAdulto;
                double Valor_crianca = QntCriancas * QuartoSelecionado.DiariaCriana;
                double Total = (Valor_adultos + Valor_crianca) + Estadia;

                return Total;
            }
        }
    }
}
