using Okna.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Windows.Forms;

namespace Okna.Classes

{
    public class Account
    {
        public string accountID { get; set; }
        public string password { get; set; }
        public string dateBirth { get; set; }
        public int gender { get; set; }
        public int height { get; set; }
        public int ID { get; set; }

        /// <summary>
        /// uzupelnienie danych obiektu klasu Account
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="dateBirth"></param>
        /// <param name="gender"></param>
        public Account(string login, string password, string dateBirth, int gender, int height)
        {
            this.accountID = login;
            this.password = password;
            this.dateBirth = dateBirth;
            this.gender = gender;
            this.height = height;
        }

        public Account(string login, string password)
        {
            this.accountID = login;
            this.password = password;
        }
        
        public void SetOtherData()
        {
            SQLConnection connection = new SQLConnection();
            dateBirth = connection.GetField("dateBirth", "Users", "userLogin = '" + accountID + "'");
            gender = Convert.ToInt32(connection.GetField("gender", "Users", "userLogin = '" + accountID + "'"));
            height = Convert.ToInt32(connection.GetField("height", "Users", "userLogin = '" + accountID + "'"));
        }
        /// <summary>
        /// dodanie nowego uztkownika
        /// </summary>
        public bool CreateAccount()
        {
            if (VerifyLogin() == true)
            {
                return AddNewUser();
            }
            else
            {
                MessageBox.Show("Taki login juz istnieje", "Informacja");
                return false;
            }
        }


        /// <summary>
        /// porownuje loginy podczas zakladania konta
        /// </summary>
        /// <returns></returns>
        public bool VerifyLogin()
        {
            SQLConnection connection = new SQLConnection();

            string userREF = connection.GetField ("REF","Users", "userLogin = '" + accountID + "'");

            if(string.IsNullOrEmpty(userREF))
            {
                return true; // nie ma takiego loginu w tabeli
            }
            else
            {
                return false; //istnieje taki login w bazie
            }
        }

        ///metoda odpalajaca zapytanie, dodawanie uzytk. do tabeli
        ///<param name="=query"></param>
        ///

       

        /// <summary>
        /// sprawdza czy login istnieje w bazie i czy do danego loginu wpisane jest dobre haslo
        /// </summary>
        /// <returns> true - login i haslo prawidlowe, false lub haslo bledne</returns>
        public bool VerifyLoginandPassword()
        {
            SQLConnection connection = new SQLConnection();

            string getPassword = connection.GetField("userPassword", "Users", "userLogin = '" + accountID + "'"); // wyciagniecie hasla przypisane do danego loginu

            if (string.IsNullOrEmpty(getPassword))
            {
                return false; //brak loginu w tabeli Users
            }
            else
            {
                if (getPassword == password)
                {
                    SetUserID();
                    return true; // dane logowania prawidłowe
                }
                else
                {
                    return false; //haslo nieprawidlowe
                }
            }
        }

        public bool AddNewUser()
        {
            SQLConnection connection = new SQLConnection();

            string query = string.Format("insert into Users (userLogin, userPassword, dateBirth, height, gender) values ('{0}', '{1}', '{2}', {3}, {4})", accountID, password, dateBirth, height, gender);

            int result = connection.RunSQL(query);

            if (result > 0)
            {
                SetUserID();
                return true;
            }
            else
            {
                return false;
            }
        }
       
        public void SetUserID()
        {
            SQLConnection connection = new SQLConnection();

            this.ID = Convert.ToInt32(connection.GetField("REF", "Users", "userLogin ='" + accountID + "'"));
        }
    }
}