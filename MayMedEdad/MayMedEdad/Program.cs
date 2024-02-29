/*
 * Created by SharpDevelop.
 * User: Macbeth Adolfo Carrillo Ibarra
 * Date: 03/04/2017
 * Time: 04:48 p. m.
 * Objetivo: identificar si el hombre o la mujer es mayor o menor de edad
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace MayMedEdad
{
	class Program
	{
		public static void Main(string[] args)
		{
			int ed;
			string nom,sex;
			Console.Write("Nombre: ");
			nom=(Console.ReadLine());
			
			Console.WriteLine("Sexo:");
			sex=(Console.ReadLine());
			Console.WriteLine("Edad:");
			ed=int.Parse(Console.ReadLine());
			
			//VALIDA EL SEXO
			
			if(sex=="F")
			{
				Console.WriteLine("Alumna");
			}
			else
			{
				Console.WriteLine("Alumno");
			}
			
			//VALIDA LA EDAD
			if(ed>=18)
			{
				Console.WriteLine("Es mayor de edad");
			}
			else
			{
				Console.WriteLine("Es menor de edad");
			}
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}