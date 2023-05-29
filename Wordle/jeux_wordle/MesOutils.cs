using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeux_wordle
{
    class MesOutils
    {
        public static string ChoisirMotCache()
        {
            string[] mots = {"pomme", "drone", "ecran", "bonjour", "soleil", "vendre", "plaque","cadeau", "souris", "fleur", "avoir", "dormir","argent", "patate", "boiter", "avion", "chante", "chance","danse", "esprit", "forêt", "gouter", "joindre","maison", "nouvel", "parler", "quitter", "savoir"};
            Random random = new Random();
            int indexMot = random.Next(0, mots.Length);
            return mots[indexMot];
        }

        public static bool motCorrect(string tentative, string motCache)
        {
            int lettresCorrectesBienPlacees = 0;
            int lettresCorrectesMalPlacees = 0;

            for (int i = 0; i < motCache.Length; i++)
            {
                if (tentative[i] == motCache[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(tentative[i]);
                    lettresCorrectesBienPlacees++;
                }
                else if (motCache.Contains(tentative[i]))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(tentative[i]);
                    lettresCorrectesMalPlacees++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(tentative[i]);
                }
            }

            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Lettres bien placées : {0}", lettresCorrectesBienPlacees);
            Console.WriteLine("Lettres mal placées : {0}", lettresCorrectesMalPlacees);
            Console.WriteLine("Lettres incorrectes : {0}", motCache.Length - lettresCorrectesBienPlacees - lettresCorrectesMalPlacees);

            return lettresCorrectesBienPlacees == motCache.Length;
        }
    }
}
