using Demo_Polymorphisme01.Models;

namespace Demo_Polymorphisme01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Joueur joueur = new Joueur();

            Equipement e = new Equipement() { 
                Nom = "Epée de vérité",
                Bonus = 10
            };


            Equipement e1 = new Equipement()
            {
                Nom = "Casque du savoir",
                Bonus = 5
            };

            ObjetSoin potion = new ObjetSoin()
            {
                Nom = "Potion de santé",
                Bonus = 20
            };

            ObjetSoin potion1 = new ObjetSoin()
            {
                Nom = "Potion de magie",
                Bonus = 20
            };

            ObjetQuete cle = new ObjetQuete() { Nom = "Clé du donjon" };

            ObjetInventaire oi = new ObjetSoin();

            joueur.Ramasser(e);
            joueur.Ramasser(e1);
            joueur.Ramasser(potion);
            joueur.Ramasser(potion1);
            joueur.Ramasser(cle);

            foreach (ObjetInventaire obj in joueur.Inventaire )
            {
                /*
                if (obj is ObjetQuete)
                {
                    Console.WriteLine($"🗝️ : {obj.Nom}");
                }
                else if (obj is ObjetSoin soin)
                {
                    //ObjetSoin soin = (ObjetSoin)obj;
                    Console.WriteLine($"🍶 : {soin.Nom} - {soin.Bonus}");
                }
                else if (obj is Equipement equipement) { 
                    //Equipement equipement = (Equipement)obj;
                    Console.WriteLine($"⚔️ : {equipement.Nom} - {equipement.Bonus} - {(equipement.EstEquipe?"✔️":"⏹️")}");
                }*/

                switch (obj)
                {
                    case ObjetQuete:
                        Console.WriteLine($"🗝️ : {obj.Nom}");
                        break;
                    case ObjetSoin soin:
                        Console.WriteLine($"🍶 : {soin.Nom} - {soin.Bonus}");
                        break;
                    case Equipement equipement:
                        Console.WriteLine($"⚔️ : {equipement.Nom} - {equipement.Bonus} - {(equipement.EstEquipe ? "✔️" : "⏹️")}");
                        break;
                }
            }

            joueur.Utiliser(cle);
            joueur.Utiliser(e);
            joueur.Utiliser(e1);
            joueur.Utiliser(e);
            joueur.Utiliser(potion);
            joueur.Utiliser(potion1);
        }
    }
}
