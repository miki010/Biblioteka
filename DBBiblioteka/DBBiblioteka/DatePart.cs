using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBiblioteka
{
    public sealed class DatePart
    {
        static DatePart()
        {

        }

        private DatePart()
        {

        }

        public static DatePart GetInstance { get; } = new DatePart();

        public static string TimeSpanToDateParts(DateTime d1, DateTime d2)
        {
            if (d1.Date > d2.Date)
            {
                return "Nevalidan raspon datuma";
            }
            int years = 0, months = 0, days = 0;

            if ((d2.Year - d1.Year) > 1) //(minimalno 3 razlicite godine u rasponu)
            {
                years += d2.Year - d1.Year - 1; //razlika godina bez prve i posljednje godine u rasponu
                months += 12 - d1.Month; //puni mjeseci od d1 do nove godine
                days += DateTime.DaysInMonth(d1.Year, d1.Month) - d1.Day;

                //sad od nove godine d2 do d2 
                months += d2.Month - 1; //puni mjeseci od nove godine do d2
                if (months >= 12)
                {
                    years++;
                    months -= 12;
                }
                days += d2.Day;
                if (days >= DateTime.DaysInMonth(years + 1, months + 1))
                {
                    days -= DateTime.DaysInMonth(years + 1, months + 1);
                    months++;
                    if (months == 12)
                    {
                        years++;
                        months = 0;
                    }
                }
            }
            else if ((d2.Year - d1.Year) == 0) //ista godina
            {
                if (d1.Month == d2.Month)
                {
                    days += d2.Day - d1.Day;
                }
                else
                {
                    months = d2.Month - d1.Month - 1;
                    days = DateTime.DaysInMonth(d1.Year, d1.Month) - d1.Day + d2.Day;
                    if (days >= DateTime.DaysInMonth(years + 1, months + 1))
                    {
                        days -= DateTime.DaysInMonth(years + 1, months + 1);
                        months++;
                    }
                }

            }
            else //uzastopne godine 
            {
                months = 12 - d1.Month;
                days = DateTime.DaysInMonth(d1.Year, d1.Month) - d1.Day;

                months += d2.Month - 1;
                if (months >= 12)
                {
                    years++;
                    months -= 12;
                }
                days += d2.Day;

                if (days >= DateTime.DaysInMonth(years + 1, months + 1))
                {
                    days -= DateTime.DaysInMonth(years + 1, months + 1);
                    months++;
                    if (months == 12)
                    {
                        years++;
                        months = 0;
                    }
                }
            }

            string y = "", m = "", d = "";
            if (years == 1) y = "Godinu"; else if (years == 0) y = "Godina"; else y = "Godine";
            if (months == 1) m = "Mjesec"; else m = "Mjeseci";
            if (days == 1) d = "Dan"; else d = "Dana";


            return "Korisnik kasni sa vraćanjem knjige " + years + " " + y + " " + months + " " + m + " i " + days + " " + d;

        }
    }
}
