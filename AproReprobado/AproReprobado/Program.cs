/*
 * Programa:AproRebrobado
 * Alumna: carolina
 * Fecha: 03/04/2017
 * Objetivo:Saber si el alumno aprobo o reprobo.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace AproReprobado
{
	class Programación
	{
		public static void Main(string[] args)
		{
			string nom;
			string espe;
			string sex;
			float prom;
			
			
			Console.Write("Nombre:");
			nom=Console.ReadLine();
			Console.Write("Especialidad:");
			espe=Console.ReadLine();
			Console.Write("Sexo:");
			sex=Console.ReadLine();
			Console.Write("Promedio:");
			prom=float.Parse(Console.ReadLine());
			
			
			if (sex=="F")
			{
				Console.Write("La alumna  ");
				Console.WriteLine(nom);
			}
			else
			{
				Console.WriteLine("El alumno  ");
				Console.WriteLine(nom);
			}
			if (prom>6)
			{
				Console.WriteLine("Aprobado");
			}
			else
			{
				Console.WriteLine("Reprobado");
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}