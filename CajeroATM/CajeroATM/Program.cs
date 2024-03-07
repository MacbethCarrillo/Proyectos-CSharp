/*
 * Created by SharpDevelop.
 * User: Macbeth Adolfo Carrillo Ibarra
 * Date: 27/05/2018
 * Time: 05:15 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace omar
{
	class Program
	{
		public static void Main(string[] args)
		{ int deposito,retiro,saldo;
 		 string depositar, retirar, verSal;

 		 Console.WriteLine("Introdusca su saldo:");
 		 	saldo=int.Parse(Console.ReadLine());
 		 
 		 Console.WriteLine("¿Desea depositar?");
 	  depositar=(Console.ReadLine());
 	  
 	  if (depositar=="si")
 	  {
 	  	 Console.WriteLine("¿Cuanto Quiere Depocitar?");
 	  	deposito=int.Parse(Console.ReadLine());
 	  	
 	  	saldo=saldo+deposito;
 	  }
 	  else {
 	  	Console.WriteLine("-Vamos a la siguiente-");
 	  }
 	  Console.WriteLine("¿Desea Retirar?");
 	  retirar=(Console.ReadLine());
 	  
 	  if (retirar=="si")
 	  {
 	  	Console.WriteLine("Cuanto desea retirar:");
 	  	retiro=int.Parse(Console.ReadLine());
 	  	saldo= saldo-retiro;
 	  }
 	  else {
 	  	Console.WriteLine("-Ok Vamos a la siguiente-");
 	  }
 	  Console.WriteLine("Quiere ver su saldo?");
 	  verSal=(Console.ReadLine());
 	  
 	  if(verSal=="si")
 	  {
 	  	Console.WriteLine("Tu saldo es: "+saldo);
 	  }
 	  else {
 	  	Console.WriteLine("-Que tenga un buen dia-");
 	  }

 	     Console.WriteLine("Gracias por usar nuestro servicio");
 	    Console.ReadKey(true);
 	
 		}
 	}
 }