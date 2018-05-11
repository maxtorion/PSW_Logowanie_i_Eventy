using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Klasa reprezentująca użytkownika programu, służy głównie jako wygodny pośrednik pomiędzy danymi z bazy a programem
/// </summary>
namespace Lab3PSW
{
    public class User
    {
        //---------------------------------------POLA--------------------------------------
       
        private int id;
        private String name;
        private String surname;
        private String login;
        private String password;
        private String email;
        private String access;




        //------------------------------------WŁAŚCIWOŚCI----------------------------------
        public int Id { get => id; set => id = value; }
        public string Name {
            get => name;
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value) || !value.All((letter) => Char.IsLetter(letter))
                    || Char.IsLower(value.First()))
                    throw new MyException("Given name is incorrect","Incorrect name");
                else
                name = value;
            }
        }
        public string Surname {
            get => surname;
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value) || !value.All((letter) => Char.IsLetter(letter))
                     || Char.IsLower(value.First()))
                    throw new MyException("Given surname is incorrect", "Incorrect surname");
                else
                    surname = value;
            }
        }
        public string Login {
            get => login;
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                    throw new MyException("No login was given", "Empty login");
                else
                login = value;
            }
        }
        public string Password {
            get => password;
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                    throw new MyException("No password was given", "Empty password");
                else
                    password = value;
            }
        }
        public string Email {
            get => email;
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value) || !value.Any((letter) => letter == '@'))
                    throw new MyException("No email was given or incorrect (@?)", "Empty email");
                else
                    email = value;
            }
        }
        public string Access { get => access; set => access = value; }

        //------------------------------------KONSTRUKTOR----------------------------------
        public User(string name, string surname, string login, string password, string email, string access="user", int id=0)
        {
            this.Id = id;
            this.Name = name;
            Surname = surname;
            this.Login = login;
            this.Email = email;
            this.Password = password;
            Access = access;
        }
        //-------------------------------------POZOSTAŁE-----------------------------------
    }
}
