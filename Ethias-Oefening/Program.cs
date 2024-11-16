using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ethias_Oefening
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
             * ETHIAS - GROET
             *
             * Voorzie een programma dat door de verzekeringsmaatschappij
             * Ethias gebruikt kan worden om klanten te registreren.
             *
             * Maak één variabele aan, genaamd groet
             *  - Zorg er voor dat je groet meerdere regels lang is
             *  - Druk de groet af, zodra het programma start
             *
             */
            string groet = "-------------------------------\r\nWelkom bij Ethias Administratie\r\n-------------------------------\r\n";
            Console.WriteLine(groet);

            /*
             * ETHIAS - REGISTRATIE FORMULIER
             * Nadat de welkomsgroet getoond is, vraagt het programma om gegevens van de klant in te geven voor registratie
             *
             * Maak een variabele voor elk van de volgende klantengegevens:
             *  - Voornaam
             *  - Achternaam
             *  - Leeftijd
             *  - IsMan (waar of niet waar)
             *  - Telefoonnummer
             */
            Console.WriteLine("Voornaam:");
            string firstName = Console.ReadLine();

            Console.WriteLine("\r\nNaam:");
            string lastName = Console.ReadLine();

            Console.WriteLine("\r\nLeeftijd:");
            int.TryParse(Console.ReadLine(), out int age);

            Console.WriteLine("\r\nMan (true/false):");
            bool.TryParse(Console.ReadLine(), out bool isMale);

            Console.WriteLine("\r\nTelefoonnummer:");
            string phoneNumber = Console.ReadLine();

            /*
             * ETHIAS - VERSLAG PRINTEN
             * Nadat het programma alle gegevens heeft ontvangen van de klant
             * wordt er een samenvatting afgedrukt in de console.
             *
             * Gebruik string interpolatie om de variabelen te injecteren in een
             * samenvatting. Zorg er voor dat je samenvatting uitlijning bevat.
             */
            Console.WriteLine("\r\n------------------------\r\nSamenvatting registratie\r\n------------------------\r\n");
            Console.WriteLine($"Voornaam:\t{firstName}\r\nNaam:\t\t{lastName}\r\nLeeftijd:\t{age}\r\nMan:\t\t{isMale}\r\nTelefoonnummer:\t{phoneNumber}\r\n");

            /*
             * ETHIAS - TryParse
             * Pas je Ethias registratie programma aan, zodat het niet meer kan
             * crashen wanneer er ongeldige input wordt ingegeven.
             *
             * Gebruik TryParse om je waardes te converteren.
             */
        }
    }
}