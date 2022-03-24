using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorDeDias.ConsoleApp
{
    public class TempoExtenso
    {
        public string[] numerosPorExtenso = { "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez" };

        public string ExibirTimeSpanPorExtenso(TimeSpan tempoDecorrido)
        {
            if (tempoDecorrido.Days <= 10)
                return numerosPorExtenso[tempoDecorrido.Days - 1];
            else
                return tempoDecorrido.Days.ToString();
        }

        public string ExibirIntPorExtenso(int tempo)
        {
            if (tempo <= 10)
                return numerosPorExtenso[tempo - 1];
            else
                return tempo.ToString();
        }

    }
}
