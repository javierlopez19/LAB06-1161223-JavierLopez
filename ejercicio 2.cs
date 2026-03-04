using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("El Banco Industrial ha decidido aumentar el límite de crédito en sus tarjetas");
        Console.WriteLine("Ingrese su límite actual");
        double limite = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese que tipo de cliente es, 1, 2, 3 u otro 4: ");
        int cliente = int.Parse(Console.ReadLine());
        double porcentaje = 0; 

        switch (cliente)
        {
            case 1:
                porcentaje = 0.25; break;
            case 2:
                porcentaje = 0.35; break;
            case 3:
                porcentaje = 0.40; break;
            default:
                porcentaje = 0.50; break;
        }


      



    }
}