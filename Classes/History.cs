using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime;

namespace DietCalc.Classes
{
    public class History
    {
        public decimal weight { get; set; }
        public string date { get; set; }
        public decimal activity { get; set; }
        public decimal BMR { get; set; }
        public decimal CPM { get; set; }
        public int age { get; set; }

        /// <summary>
        /// do daty wpisanej recznie
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="date"></param>
        /// <param name="activity"></param>
        /// <param name="user"></param>
        public History(int age, decimal weight, string date, decimal activity, int height)
        {
            this.age = age;

            this.weight = weight;

            this.date = date;

            this.activity = activity;

            this.BMR = CalcBMR(weight, height, activity);

            this.CPM = CalcCPM(weight, height, activity);
        }

        /// <summary>
        /// do daty dnia dzisiejszego
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="date"></param>
        /// <param name="activity"></param>
        /// <param name="user"></param>
        public History(int age, decimal weight, decimal activity, int height) //konstruktor
        {
            this.age = age;

            this.weight = weight;

            this.date = DateTime.Now.ToString("dd.MM.yyyy");

            this.activity = activity;

            this.BMR = CalcBMR(weight, height, activity);

            this.CPM = CalcCPM(weight, height, activity);
        }

        public decimal CalcBMR (decimal weight, int height, decimal activity)
        {
            return weight * height * activity;
        }

        public decimal CalcCPM(decimal weight, int height, decimal activity)
        {
            return weight * height * activity;
        }

        /// dodanie wratosci do tabeli
        public void DodajNowyRekord(string dataManual, Account user)
        {
            string data;


            //odwolanie insterta do tabeli historiauzytkownika
            //string query......
        }
    }
}