using System;
using System.Collections.Generic;

namespace ListaFeira
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> listaDeFeira = new List<string>();

            Console.WriteLine("Bem-vindo à sua lista de feira!");
            Console.WriteLine("Digite as frutas e legumes que deseja comprar (digite 'fim' para encerrar):");

            string item;
            int contador = 1; 
            do
            {
                
                Console.Write($"| {contador,-2} | Adicionar item: ");
                item = Console.ReadLine();

                
                if (item.ToLower() != "fim" && !string.IsNullOrWhiteSpace(item))
                {
                    listaDeFeira.Add(item);
                    contador++;
                }

            } while (item.ToLower() != "fim");

           
            Console.Clear();

            
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;

            
            string bordaSuperior = "╔════╦═════════════════════════════════╗";
            string bordaInferior = "╚════╩═════════════════════════════════╝";
            string separador = "╠════╬═════════════════════════════════╣";

            
            Console.WriteLine(bordaSuperior);
            Console.WriteLine("║ Nº ║ Item                            ║");
            Console.WriteLine(separador);

            
            for (int i = 0; i < listaDeFeira.Count; i++)
            {
             
                string itemFormatado = listaDeFeira[i].Length > 30 ? listaDeFeira[i].Substring(0, 30) : listaDeFeira[i].PadRight(31);
                Console.WriteLine($"║ {i + 1,-2} ║ {itemFormatado,-30} ║");
            }

            Console.WriteLine(bordaInferior); 

            
            Console.WriteLine("\nObrigado por usar a lista de feira!");
            Console.ResetColor(); 
        }
    }
}