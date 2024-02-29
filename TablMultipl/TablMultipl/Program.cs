/*
 * Created by SharpDevelop.
 * User: Macbeth Adolfo Carrillo Ibarra
 * Date: 27/04/2017
 * Time: 06:36 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NumPrimo
{
    class Program
    {
        public static void Main(string[] args)
        {int num, res;
            Console.WriteLine("Numero:");
            num=int.Parse(Console.ReadLine());
            res = num % 2;
            
            if(res> 0)
                Console.WriteLine("El numero proporcionado es primo");
            else
                Console.WriteLine("El numero proporcionado no es primo");
            
            
            Console.Write("Presiona Cualquier Tecla Para Continuar");
            Console.ReadKey(true);
        }
    }
}
