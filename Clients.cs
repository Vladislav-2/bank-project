using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_project_new
{
    public class Clients
    {
        public int id { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? nrKonta { get; set; }
        public decimal Saldo { get; set; }
        public string? fullName
        {
            get { return firstName + " " + lastName; }
        }
        public static Dictionary<int, Clients> clientDictionary = new Dictionary<int, Clients>();
        public 
        public static List<Clients> clients = new List<Clients>();

        public setClientDictionary(int id, Clients client)
        {
            clientDictionary.add(id, client);
        }

        public static void GetData(List<Clients> clients, out Clients client, int id, string firstName, string lastName, string nrKonta, decimal Saldo)
        {
            client = new Clients()
            {
                id = id,
                firstName = firstName,
                lastName = lastName,
                nrKonta = nrKonta,
                Saldo = random.Next(0, 1001);
        };

            clients.Add(client);
        }
        
    }
}
