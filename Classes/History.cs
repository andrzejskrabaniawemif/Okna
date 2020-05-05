using Okna.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime;
using System.Windows.Forms;

namespace Okna.Classes
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

            this.BMR = CalcBMR(weight, height, activity, age);

            this.CPM = CalcCPM(weight, height, activity, age);
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

            this.BMR = CalcBMR(weight, height, activity, age);

            this.CPM = CalcCPM(weight, height, activity, age);
        }

        public decimal CalcBMR (decimal weight, int height, decimal activity, int age)
        {
            return (14M * weight) + (5M * height) + (7 * age);
        }

        public decimal CalcCPM(decimal weight, int height, decimal activity, int age)
        {
            return ((14M * weight) + (5M * height) + (7 * age)) * activity;
        }

        /// dodanie wratosci do tabeli
        public void AddNewRecord(int ID)
        {
            SQLConnection connection = new SQLConnection();

            string query = string.Format("insert into History (userREF, userWeight, measureDate) values ({0}, {1}, '{2}')", ID, weight, date);

            int result = connection.RunSQL(query);
            if (result < 0)
            {
                MessageBox.Show("Nie udalo sie dodac rekordu do tabeli", "Błąd");
            }

        }
    }
}