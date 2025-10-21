using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace UserManagement
{
    using System;
    public class User
    {
        public static void Main(string[] args)
        {
            private string id = Console.ReadLine();
        private string fullname = Console.ReadLine();
        private string email = Console.ReadLine();
        private int age;

        public string GetInfo()
        {
            return id;
            return fullname;
            return email;
        }

        public void PasswordChecker(bool isCorrect)
        {
            string password;
        password:
        main:
            password = Console.ReadLine();

            if (password.Length >= 8)
            {
                bool stringBigger = false;
                foreach (char big in password)
                {
                    if (char.IsUpper(big))
                    {
                        stringBigger = true;
                        break;
                    }
                }

                if (stringBigger)
                {
                    Console.WriteLine("stringBigger uppercase letters");
                    goto secondStatement;
                }

            secondStatement:

                bool stringSmaller = false;
                foreach (char small in password)
                {
                    if (char.IsLower(small))
                    {
                        stringSmaller = true;
                        break;
                    }
                }
                if (stringSmaller)
                {
                    Console.WriteLine("stringSmaller lowercase letters");
                    goto thirdStatement;
                }

            thirdStatement:

                bool number = false;
                foreach (char numb in password)
                {
                    if (char.IsNumber(numb))
                    {
                        number = true;
                        break;
                    }
                }
                if (number)
                {
                    Console.WriteLine("number letters");
                }
            }
            else
            {
                Console.WriteLine("incorrect password entered! ");
                goto main;
            }
        }
    }
}
}
