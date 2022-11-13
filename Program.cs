using AppPunto2.controllers;
using AppPunto2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPunto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListdataController obj = new ListdataController();
            int opcion = 0;

            do {

                Console.WriteLine("** Menu de Opciones **" +
                "\n 1. Agregar Elemento" +
                "\n 2. Mostrar lista de Elementos" +
                "\n 3. Mostrar lista de Elementos Repetidos" +
                "\n 4. Mostrar lista de Elementos ordenados de menor a mayor" +
                "\n 5. Mostrar lista de Elementos ordenados de mayor a menor" +
                "\n 6. Salir" +
                "\n elige tu opcion :)");

                var data = Console.ReadLine();
                if (data != null)
                {
                    opcion = int.Parse(data);
                }

                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("Escriba el id: ");
                        var inputId = Console.ReadLine();
                        Console.WriteLine("Escriba el nombre: ");
                        var inputName = Console.ReadLine();

                        if (inputId != null && inputName != null)
                        {
                            obj.addListdata(new Listdata(int.Parse(inputId),inputName.ToString()));
                        }
                        break;
                    case 2:
                        // Se coloca este componente para diferenciar la salidar de texto
                        Console.BackgroundColor = ConsoleColor.DarkCyan;  
                        Console.WriteLine(obj.showList());
                        Console.ResetColor();
                        break;
                    case 3:
                        Console.WriteLine(obj.showRepeatedList());
                        break;
                    case 4:
                        obj.showListlowesttohighest();
                        break;
                    case 5:
                        obj.showListhighesttolowest();
                        break;
                    case 6:
                        opcion = 6;
                        break;
                    default:
                        Console.WriteLine("elige una opcion del menu");
                        break;
                }
            } 
            while (opcion != 6);
        }
    }
}
