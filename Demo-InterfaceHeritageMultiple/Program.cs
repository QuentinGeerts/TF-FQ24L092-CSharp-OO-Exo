using Demo_InterfaceHeritageMultiple.Models;

namespace Demo_InterfaceHeritageMultiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IVehicule> garage = new List<IVehicule>() {
                new Voiture(),
                new Bateau(),
                new VehiculeAmphibie()
            };

            Random RNG = new Random();

            IVehicule v = garage[RNG.Next(garage.Count)];

            switch (v)
            {
                case VehiculeAmphibie va:
                    Console.WriteLine("Avec mon véhicule amphibie, je peux :");
                    va.Rouler();
                    va.Naviguer();
                    va.Tourner();
                    break;
                case Voiture car:
                    Console.WriteLine("Avec ma voiture, je peux :");
                    car.Rouler();
                    car.Tourner();
                    break;
                case Bateau b:
                    Console.WriteLine("Avec mon bateau, je peux :");
                    b.Naviguer();
                    b.Tourner();
                    break;
            }
        }
    }
}
