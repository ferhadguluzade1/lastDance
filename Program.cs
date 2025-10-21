using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UserManagement
{
    public class Program : User
    {
        public static void Main(string[] args)
        {
            User[] lenArray = [3];
            lenArray = Console.ReadLine(fullname);
            lenArray = Console.ReadLine(email);
            lenArray = Console.ReadLine(password);
            string password1 = Console.ReadLine();

            if (password1 != password)
            {
                Console.WriteLine("Wrong password! ");
                goto password;
            }

            else
            {
                Console.WriteLine
                    (
                    "1. Show all users" +
                    "2. Get info by id" +
                    "0. Quit"
                    );

                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    Console.WriteLine("all users: " + lenArray);
                }

                else if ( secim == 2)
                {
                    id = Console.ReadLine();
                 
                }

                else if ( secim == 0)
                {
                    Console.WriteLine("Program ends!");
                    break;
                }

            }
        }

    }
}
