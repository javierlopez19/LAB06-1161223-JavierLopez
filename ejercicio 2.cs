using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("El Banco Industrial ha decidido aumentar el límite de crédito en sus tarjetas, indique que tipo de cliente es (1,2,3 u otro 4): ");
        int cliente = int.Parse(Console.ReadLine());

        switch (cliente)
        {
            case 1:
                Console.WriteLine("Cliente Tipo 1 aumentará un 25%"); break;
            case 2:
                Console.WriteLine("Cliente Tipo 2 aumentará un 35%"); break;
            case 3:
                Console.WriteLine("Cliente Tipo 3 aumentará un 40%"); break;
            default:
                Console.WriteLine("Ustes es otro tipo de cliente entonces, aumentará un 50%"); break;
        }


      



    }
}