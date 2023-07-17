using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class CalendarService
    {
        //Quest09
        public int GetHoursInMinutes(int hours)
        {
            int minutes = hours * 60;
            return minutes;
        }
        //Quest15
        public string GetSeason(int numOfMonth)
        {
            string nameOfSeason = "мяв";
            if ((numOfMonth >= 1) && (numOfMonth <= 2) || (numOfMonth == 12))
            {
                nameOfSeason = "Зима";
            }
            if ((numOfMonth >= 3) && (numOfMonth <= 5))
            {
                nameOfSeason = "Весна";
            }
            if ((numOfMonth >= 6) && (numOfMonth <= 8))
            {
                nameOfSeason = "Лето";
            }
            if ((numOfMonth >= 9) && (numOfMonth <= 11))
            {
                nameOfSeason = "Осень";
            }
            return nameOfSeason;
        }
    }
}
