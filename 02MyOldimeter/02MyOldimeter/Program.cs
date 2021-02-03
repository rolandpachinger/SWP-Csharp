using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oldimeter
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			Das soll euer Programm anzeigen:

				*** Altersrechner (Stand 2020) ***
	
				Du heißt Vorname Nachname.
				Du bist schon ... Jahre alt.
				Nächstes Jahr bist du ... Jahre alt.
	
				Dein Opa ist ... Jahre alt.
				Nächstes Jahr ist er ... Jahre alt.
	
				In fünf Jahren (2025) ist Opa ... Jahre und du ... Jahre alt!
				Gemeinsam seid ihr dann ... Jahre alt (falls Opa das erlebt).
	
	
			Zahlen sollen mit Variablen dargestellt werden.
			Eine Altersänderung soll nur an einer Stelle gemacht werden müssen
			Das Jahr soll auch als Variable angegeben werden.
			für Spezialisten: Auch die Namen sollen mit Variablen dargestellt werden
			*/
			Console.WriteLine("*** Altersrechner (Stand 2020) ***\n\n");

			Console.Write("Gib deinen Vornamen ein: ");
			string firstName = Console.ReadLine();

			Console.Write("Gib deinen Nachnamen ein: ");
			string lastName = Console.ReadLine();

			Console.Write("Wie alt bist du? ");
			// Alter wird als Text (string) zurück geliefert
			string myAgeAsString = Console.ReadLine();
			// String in Integer umwandeln
			int myAge = Convert.ToInt32(myAgeAsString);

			Console.Write("Wie alt ist Opa? ");
			int opaAge;
			// opaAge = Convert.ToInt32(Console.ReadLine());
			// mit Int.Parse() oder Int.TryParse() testen

			if(int.TryParse(Console.ReadLine(), out opaAge))
			{
				int year = 2020;

				Console.WriteLine("Du heißt " + firstName + " " + lastName);
				Console.WriteLine("Du bin schon " + myAge + " Jahre alt.");
				Console.WriteLine("Nächstes Jahr bist du " + (myAge + 1) + " Jahre alt.\n\n");

				Console.WriteLine("Dein Opa ist " + opaAge + " Jahre alt.");
				Console.WriteLine("Nächstes Jahr ist er " + (opaAge + 1) + " Jahre alt.");

				Console.WriteLine("In fünf Jahren (" + (year + 5) + ") ist Opa " + (opaAge + 5) + " Jahre und du " + (myAge + 5) + " Jahre alt!");
				Console.WriteLine("Gemeinsam seid ihr dann " + (opaAge + 5 + myAge + 5) + " Jahre alt (falls Opa das erlebt).");
			}
			else
			{
				{Console.WriteLine("Parse Error");}
			}
			Console.ReadLine();
		}

	}
}
