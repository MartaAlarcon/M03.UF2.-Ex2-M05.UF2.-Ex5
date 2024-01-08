namespace ValidarSenarLibreria
{
    public class Validar
    {
        static void Main()
        {
            int number;
            Console.WriteLine("Introdueix un nombre per comprobar si és senar: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ValidarSenar(number));
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
