using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_02._21._2022
{
    internal class User
    {
        private string Username;
        private string Password;

        public User(string username,string password)
        {
            Username = username;
            Password = password;
        }

        public void setUsername(string username)
        {
            if (username.Length>6)
            {
                Username = username;
            }
            else
            {
                Console.WriteLine("Zehmet olmasa username-ni duzgun daxil edin");
                Username = Console.ReadLine();
            }
        }
        //public void setPassword(string password)
        //{
        //    foreach (char symbol in password)
        //    {
        //        if (symbol ==(1-9) )
        //        {
        //            Password = password;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Zehmet olmasa paswword-u duzgun daxil edin");
        //            Password = Console.ReadLine();
        //        }
        //    }

        //}

        public string getinfo()
        {
            return $"UserName:{Username}\nPasword:{Password}";
        }
    }
}
