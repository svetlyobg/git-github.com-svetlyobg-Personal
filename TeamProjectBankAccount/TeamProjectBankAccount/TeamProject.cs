using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjectBankAccount
{
    class TeamProject
    {
        static void Main(string[] args)
        {
            string inputUsername, inputPassword;
            bool match = false;
            Person krasen = new Person("krasen", "0000", "Krasen Kunev", "1000");
            Person svetlyo = new Person("svet", "5555", "Svetlozar Kosev", "200");
            Person[] masivPotrebiteli = { svetlyo, krasen };

            while (match == false)
            {
                Console.WriteLine("Enter username");
                inputUsername = Console.ReadLine();

                int isUser = -1;

                foreach (Person person in masivPotrebiteli)
                {
                    if (inputUsername == person.username)
                    {
                        isUser = Array.IndexOf(masivPotrebiteli, person);
                    }
                }

                if (isUser > -1)
                {
                    Console.WriteLine("\nEnter password");

                    inputPassword = Console.ReadLine();

                    if (inputPassword == masivPotrebiteli[isUser].password)
                    {
                        Console.WriteLine("\nLog in successfully");

                        Console.WriteLine(masivPotrebiteli[isUser].GetPersonInfo());
                        match = true;
                    }
                    else
                    {
                        Console.WriteLine("wait 5 sec");
                        //System.Media.SystemSounds.Beep.Play();
                        System.Threading.Thread.Sleep(5000);
                    }
                }
                else
                {
                    Console.WriteLine("User name is not corect!");
                }
            }
            Console.WriteLine("Program finished ... ");
        }
    }
}