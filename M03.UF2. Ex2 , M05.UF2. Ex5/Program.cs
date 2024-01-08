using System;
namespace Programa
{
    public class ejPrograma
    {
        public static void Main()
        {
            const string MsgWelcome = "Escull una opció: a. Validar si un nombre és senar\r\nb. Calcular la potència d'un nombre\r\nc. Retornar un valor aleatori\r\nd. Comptar el nombre de vocals o consonants en un text\r\ne. Sortir";
            char menu;
            Console.WriteLine(MsgWelcome);
            menu = Convert.ToChar(Console.ReadLine());
            menu = char.ToLower(menu);
            switch (menu)
            {
                case 'a':
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
    }
}