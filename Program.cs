using bank_project_new;

ClientsBaseAdd();
Bank.DisplayStartScreen();

void ClientsBaseAdd()
{
    Clients.GetData(Clients.clients, out Clients _, 1, "Jan", "Nowak", "001", 1457.23m);
    Clients.GetData(Clients.clients, out Clients _, 2, "Agnieszka", "Kowalska", "002", 3600.18m);
    Clients.GetData(Clients.clients, out Clients _, 3, "Robert", "Lewandowski", "003", 2745.03m);
    Clients.GetData(Clients.clients, out Clients _, 4, "Zofia", "Plucińska", "004", 7344.00m);
    Clients.GetData(Clients.clients, out Clients _, 5, "Grzegorz", "Braun", "005", 455.38m);
}