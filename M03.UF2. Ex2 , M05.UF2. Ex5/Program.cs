using System;
using ValidarSenarLibreria;
namespace Programa
{
    public class ejPrograma
    {
        public static void Main()
        {
            const string MsgWelcome = "Escull una opció: a. Validar si un nombre és senar\r\nb. Calcular la potència d'un nombre\r\nc. Retornar un valor aleatori\r\nd. Comptar el nombre de vocals o consonants en un text\r\ne. Sortir";
            char menu;
            int number;
            Console.WriteLine(MsgWelcome);
            menu = Convert.ToChar(Console.ReadLine());
            menu = char.ToLower(menu);
            switch (menu)
            {
                case 'a':
                    Console.WriteLine("Introdueix un nombre per comprobar si és senar: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(ValidarSenar(number));
                        break;
                case 'b':
                    break;
                case 'c':
                    break;
                case 'd':
                    break;
                case 'e':
                    break;

            }


        }
        static bool ValidarSenar(int number)
        {
            if (number / 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
    
}