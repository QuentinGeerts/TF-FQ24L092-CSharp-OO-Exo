using Demo_IDisposable.Models;

namespace Demo_IDisposable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (TalkieWalkie t1 = new TalkieWalkie() { NomUtilisateur = "Joachim" })
            {
                using (TalkieWalkie t2 = new TalkieWalkie() { NomUtilisateur = "Linda" })
                {
                    t1.Parler("Bonjour, suis-je seul?");
                    t2.Parler("Non, je t'écoute!");
                    t1.Parler("Malheureusement je dois partir! Au revoir.");
                    t2.Parler("Dommage! Au revoir.");
                }
            }

            /* using sans accolades
            using TalkieWalkie t1 = new TalkieWalkie() { NomUtilisateur = "Joachim" };
            using TalkieWalkie t2 = new TalkieWalkie() { NomUtilisateur = "Linda" };
            t1.Parler("Bonjour, suis-je seul?");
            t2.Parler("Non, je t'écoute!");
            t1.Parler("Malheureusement je dois partir! Au revoir.");
            t2.Parler("Dommage! Au revoir.");
             */
        }
    }
}
