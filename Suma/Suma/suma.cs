/*
 * Created by SharpDevelop.
 * User: Computo01
 * Date: 14/03/2017
 * Time: 03:22 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Suma
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num1,num2,suma,prome;
			Console.WriteLine("Cetis No. 108");
			
			// TODO: Implement Functionality Here
			
			Console.WriteLine("Alumna: Carolina Escarrega");
			Console.WriteLine("Grupo: 2AV-Programación");
			Console.WriteLine("Proporcione los siguientes datos:");
   			Console.WriteLine("1er. Número:  ");
   			num1=int.Parse(Console.ReadLine());
   			Console.WriteLine("2do. Número:  ");
   			num2=int.Parse(Console.ReadLine());
   			suma=num1+num2;
   			
   			Console.WriteLine("La suma total es: "+suma);
   			prome=suma/2;
   			Console.WriteLine("El promedio de los dos números es:  "+prome);
   			
   			
   			Console.Write("Presione una tecla para continuar . . .");
   			Console.ReadKey(true);
   			
   			
			
		}
	}
}