/*
 * Alumna: Carolina Escarrega Sánchez
 * Programa: FeliMBien
 * Fecha: 04/04/2017
 * Objetivo: Que lea una calificación y en base a ello imprimir en pantalla el mensaje de felicidades si es 10, muy bien si es 9, bien si es 8.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace FeliMBien
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nom;
			double numcon;
			string sex;
			int prom;
			
			
			
			Console.Write("Nombre: ");
			nom=Console.ReadLine();
			Console.Write("Sexo: ");
			sex=Console.ReadLine();
			Console.WriteLine("Número de Control:");
			numcon=double.Parse(Console.ReadLine());
			Console.Write("Promedio: ");
			prom=int.Parse(Console.ReadLine());
		
			
			switch(prom)
			{
				case 10:
					Console.WriteLine(" ");
					Console.WriteLine(nom+ " Te la rifaste vato :v!!!");
					break;
					
				case 9:
					Console.WriteLine(" ");
					Console.WriteLine(nom+ " Muy Bien !!");
					break;
					
				case 8:
					Console.WriteLine(" ");
					Console.WriteLine(nom+ " Bien !");
					break;
					
				default:
					Console.WriteLine(nom+ " Hechale ganas!");
					break;
			}
					
			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}