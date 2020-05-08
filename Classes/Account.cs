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
            dateBirth = connection.GetField("dateBirth", "Users", "REF = " + ID);
            gender = Convert.ToInt32(connection.GetField("gender", "Users", "REF = " + ID));
            height = Convert.ToInt32(connection.GetField("height", "Users", "REF = " + ID));
        }
        
        public bool CreateAccount() //tworzenie nowego uzytkownika
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
       

        public bool VerifyLoginandPassword()
        {
            SQLConnection connection = new SQLConnection();

            string getPassword = connection.GetField("userPassword", "Users", "userLogin = '" + accountID + "'");

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