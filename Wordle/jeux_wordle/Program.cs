using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeux_wordle
{
    class Program
    {
        static void Main()
        {
            string motCache = MesOutils.ChoisirMotCache();
            int essaisRestants = 6;

            Console.WriteLine("Bienvenue dans Wordle !");
            Console.WriteLine("Le mot à deviner contient {0} lettres.", motCache.Length);
            Console.WriteLine("Vous disposez de {0} essais.", essaisRestants);

            while (essaisRestants > 0)
            {
                Console.Write("Entrez un mot : ");
                string tentative = Console.ReadLine();

                if (tentative.Length != motCache.Length)
                {
                    Console.WriteLine("Le mot doit contenir {0} lettres.", motCache.Length);
                    continue;
                }

                bool MotCorrect = MesOutils.motCorrect(tentative, motCache);
                if (MotCorrect)
                {
                    Console.WriteLine("Félicitations, vous avez trouvé le mot !");
                    break;
                }

                essaisRestants--;
                Console.WriteLine("Mauvaise réponse. Il vous reste {0} essais.", essaisRestants);

                if (essaisRestants == 0)
                {
                    Console.WriteLine("Vous avez épuisé tous vos essais. Le mot était : {0}", motCache);
                }
            }

            Console.WriteLine("Merci d'avoir joué à Wordle !");
            Console.ReadLine(); //  ajout d'une pause pour empêcher la fermeture automatique du programme
        }
    }
}
