using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_project_new
{
    public class Bank
    {
        public static void DisplayStartScreen()
        {
            
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Wybierz Opcję: ");
                Console.WriteLine("");
                Console.WriteLine("1 => Lista wszystkich klientów banku ");
                Console.WriteLine("");
                Console.WriteLine("2 => Logowanie ");
                Console.WriteLine("");
                Console.WriteLine("3 => Zakończ program ");
                Console.WriteLine("");
                Console.WriteLine("4 => Logowanie randomne");
                var userText = Console.ReadLine();
                int userChoice = 0;
                bool success = int.TryParse(userText, out userChoice);

                switch success:
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Lista wszystkich klientów banku");
                        ShowClientsList();
                        break;
                    case 2:
                        Login(false);
                        Console.Clear();
                        ShowClientsList();
                        flag = false;
                        break;
                    case 3:
                        Console.WriteLine("Zakoncz program");
                        flag = false;
                        break;
                    case 4:
                        Login(true);
                        Console.Clear();
                        ShowClientsList();
                        flag = false;
                        break;
                    default:
                        Console.Clear();
                        break;
            }
        }


        public static void Login(bool isRandom)
        {
            Console.Write("Zalaguj się wybierając ID klienta: ");
            var userText = Console.ReadLine();
            int logInd = 0;
            if (!isRandom)
            {
                bool done = int.TryParse(userText, out logInd);
            } else
            {
                bool done = true;
                logInd = random.Next(1, Clients.clients.Length);
            }
            if (done)
            {
                Console.Clear();
                Console.WriteLine("Zalogowany klient");
                Console.WriteLine($"ID: {Clients.clients[logInd-1].id}");
                Console.WriteLine($"Inię i nazwisko: {Clients.clients[logInd-1].fullName}");
                Console.WriteLine($"NR konta: {Clients.clients[logInd - 1].nrKonta}");
                Console.WriteLine($"Saldo: {Clients.clients[logInd - 1].Saldo}");
            }
            else
            {
                Console.WriteLine("Logowanie nieudane");

            }
            Console.Write("Wpisz numer konta na który chcesz wykonać przelew: ");
            
            userText = Console.ReadLine();
            int accNumb = 0;
            done = int.TryParse(userText, out accNumb);
            int cAccNumb = int.Parse(Clients.clients[logInd - 1].nrKonta);
            if (cAccNumb == accNumb)
            {
                Console.WriteLine("Nieprawidlowy numer konta");
            }
            else
            {
                if (done)
                {
                    Console.Clear();
                    Console.Write("Podaj kwotę przelew: ");

                    userText = Console.ReadLine();
                    int transAmount = 0;
                    done = int.TryParse(userText, out transAmount);
                    decimal cBalance = Clients.clients[logInd - 1].Saldo;
                    if (cBalance >= transAmount)
                    {
                        if (done)
                        {
                            Clients.clients[logInd - 1].Saldo -= transAmount;
                            Clients.clients[accNumb - 1].Saldo += transAmount;
                        }
                        else
                        {
                            Console.WriteLine("Nieprawidlowa kwota");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidlowa kwota");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Nieprawidlowy numer konta");
                    Console.ReadLine();
                }
            }

            
        }


        void ClientsBaseAdd()
        {
            Clients.GetData(Clients.clients, out Clients _, 1, "Jan", "Nowak", "001", 1457.23m);
            Clients.GetData(Clients.clients, out Clients _, 2, "Agnieszka", "Kowalska", "002", 3600.18m);
            Clients.GetData(Clients.clients, out Clients _, 3, "Robert", "Lewandowski", "003", 2745.03m);
            Clients.GetData(Clients.clients, out Clients _, 4, "Zofia", "Plucińska", "004", 7344.00m);
            Clients.GetData(Clients.clients, out Clients _, 5, "Grzegorz", "Braun", "005", 455.38m);
        }



        static void ShowClientsList()
        {
            foreach (var client in Clients.clients)
            {
                Console.WriteLine($" {client.id} | {client.firstName} | {client.lastName} | {client.nrKonta} | {client.Saldo}");
            }
        }
    }
}
