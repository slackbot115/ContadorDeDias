using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorDeDias.ConsoleApp
{
    public class Data
    {
        DateTime data;
        TempoExtenso tempoExtenso = new TempoExtenso();

        public void VerificarTempoDecorrido()
        {
            Console.Write("Digite o dia e as horas da data desejada (dd/mm/yyyy hh:mm:ss): ");
            data = DateTime.Parse(Console.ReadLine());

            if(data.CompareTo(DateTime.Now) < 0)
            {
                // antes que hoje
                TimeSpan tempoDecorrido;

                tempoDecorrido = DateTime.Now.Subtract(data);

                if(tempoDecorrido.Days != 0)
                    Console.WriteLine($"Se passaram {tempoExtenso.ExibirTimeSpanPorExtenso(tempoDecorrido)} dia(s)");
                if (ContarSemanas(tempoDecorrido) != 0)
                    Console.WriteLine($"{tempoExtenso.ExibirIntPorExtenso(ContarSemanas(tempoDecorrido))} semana(s)");
                if (tempoDecorrido.Days > 31)
                    Console.WriteLine($"{tempoExtenso.ExibirIntPorExtenso(ContarMeses())} mes(es)");
                if(tempoDecorrido.Days > 365)
                    Console.WriteLine($"{tempoExtenso.ExibirIntPorExtenso(ContarAnos())} ano(s)");
                if(tempoDecorrido.Days == 0)
                {
                    if(tempoDecorrido.Hours >= 1 && tempoDecorrido.Hours != 0)
                        Console.WriteLine($"Se passaram {tempoExtenso.ExibirIntPorExtenso(tempoDecorrido.Hours)} hora(s)");
                    if(tempoDecorrido.Minutes > 1 && tempoDecorrido.Minutes != 0)
                        Console.WriteLine($"Se passaram {tempoExtenso.ExibirIntPorExtenso(tempoDecorrido.Minutes)} minuto(s)");
                    if(tempoDecorrido.Seconds > 0 && tempoDecorrido.Seconds != 0)
                        Console.WriteLine($"Se passaram {tempoExtenso.ExibirIntPorExtenso(tempoDecorrido.Seconds)} segundo(s)");
                }
            }
            else if(data.CompareTo(DateTime.Now) > 0)
            {
                // depois de hoje
            }
            else if(data.CompareTo(DateTime.Now) == 0)
            {
                // hoje
            }

        }

        public int ContarHoras()
        {
            int horas = DateTime.Now.Hour - data.Hour;
            return horas;
        }

        public int ContarSemanas(TimeSpan tempoDecorrido)
        {
            int semanas = tempoDecorrido.Days / 7;
            return semanas;
        }

        public int ContarMeses()
        {
            int meses = ((DateTime.Now.Year - data.Year) * 12) + DateTime.Now.Month - data.Month;
            return meses;
        }

        public int ContarAnos()
        {
            int anos = DateTime.Now.Year - data.Year;
            return anos;
        }

    }
}
