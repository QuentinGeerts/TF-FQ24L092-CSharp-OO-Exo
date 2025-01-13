using Demo_Heritage01.Models;

namespace Demo_Heritage01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bateau bateau = new Bateau();
            bateau.Matricule = "MonPetitBateau";
            bateau.NombrePlaces = 12;
            bateau.EstMotorise = false;
            bateau.Avancer(12);
            Console.WriteLine(bateau.ToString());
            Console.WriteLine(((object)bateau).ToString());

            Voiture voiture = new Voiture();
            voiture.Matricule = "1-TFT-123";
            voiture.NombrePlaces = 6;
            voiture.NombreRoues = 5;
            voiture.Avancer(50);
            Console.WriteLine(voiture.ToString());
            Console.WriteLine(((Vehicule)voiture).ToString());


            Vehicule test = new TestVehicule();
            ((TestVehicule)test).Avancer(50);
        }
    }
}
