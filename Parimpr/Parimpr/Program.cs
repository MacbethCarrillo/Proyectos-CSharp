/*
 * Created by SharpDevelop.
 * Alumno: Macbeth Adolfo Carrillo Ibarra
 * Fecha: 03/04/2017
 * Programa: ParImpar
 * Objetivo: Identificar si el numero es par o impar.
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Parimpr
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num;
			
				Console.Write("Número:");
			num=int.Parse(Console.ReadLine());
				
			if(num>0)
			{
				if (num % 2 ==0) 
				{
					Console.WriteLine("El número proporcionado es par");
				}
				else
				{
					Console.WriteLine("El número proporcionado es impar");
				}
			}
			
			else
			{
				Console.WriteLine("Dato erroneeo");
			}
				
				
					
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}