using System;


using ValidarSenarLibreria;

namespace Programa
{
    public class ejPrograma
    {
        public static void Main()
        {
            const string MsgWelcome = "Escull una opció:\r\n a. Validar si un nombre és senar\r\nb. Calcular la potència d'un nombre\r\nc. Retornar un valor aleatori\r\nd. Comptar el nombre de vocals o consonants en un text\r\ne. Sortir";
            char menu;

            int number, exponent;
            Random rand = new Random();

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
                    Console.WriteLine("Introdueix un nombre per la base i després un per l'exponent: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    exponent = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(CalcularPotencia(number, exponent));
                    break;
                case 'c':
                    Console.WriteLine(RetornarAleatori(rand));
                    break;
                case 'd':
                    break;
                case 'e':
                    Console.WriteLine("GRACIAS");
                    break;

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
            static int CalcularPotencia(int number, int exponent)
            {
                int result = 1;
                for (int i = 0; i < exponent; i++)
                {
                    result *= number;
                }
                return result;
            }
            static int RetornarAleatori(Random rand)
            {
                int numberOne, numberTwo;
                Console.WriteLine("Escriu el primer nombre: ");
                numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escriu el segon nombre: ");
                numberTwo = Convert.ToInt32(Console.ReadLine());
                return rand.Next(numberOne, numberTwo);

            }

        }
       

        }
    }
    
