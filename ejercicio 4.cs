using System;
using System.ComponentModel.Design;
class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a la pizzería Bella Napoli, seleccione tipo de pizza va a desear:");
        Console.WriteLine("1. Vegetariana o 2. NO Vegetariana");
        int tipo = int.Parse(Console.ReadLine());

        switch (tipo)
        {
            case 1:
                Console.WriteLine("Escogiste la pizza Vegetariana y para esta tenemos estos ingredientes:");
                Console.WriteLine("1. Pimiento y 2. TOFU, escoge el que tu desees");
                int ingredienteveg = int.Parse(Console.ReadLine());
                switch (ingredienteveg)
                {
                    case 1:
                        Console.WriteLine("Escogiste Pimiento para tu pizza");
                        break;
                    case 2:
                        Console.WriteLine("Escogiste TOFU para tu pizza");
                        break;
                    default:
                        Console.WriteLine("Ese ingrediente no está disponible para las Pizzas");
                        break;
                }
                break;
                


                      case 2:
                        Console.WriteLine("Escogiste la pizza NO Vegetariana y para esta tenemos estos ingredientes: ");
                        Console.WriteLine("1. Pepperoni , 2. Jamón y 3. Salmón, escoge el que tu desees");
                        int ingredientenoveg = int.Parse(Console.ReadLine());

                        switch (ingredientenoveg)
                        {
                            case 1:
                                Console.WriteLine("Escogiste Pepperoni para tu pizza");
                                break;
                            case 2:
                                Console.WriteLine("Escogiste Jamón para tu pizza");
                                break;
                            case 3:
                                Console.WriteLine("Escogiste Salmón para tu pizza");
                                break;
                            default:
                                Console.WriteLine("Ese ingrediente no está disponible para las Pizzas");
                                break;
                        }
                        break;


                

        }
    }
}

        


    

