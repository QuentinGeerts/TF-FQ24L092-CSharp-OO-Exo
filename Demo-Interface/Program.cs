using Demo_Interface.Models;

namespace Demo_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture v = new Voiture("Jaune", "1-TFT-123") { NomConducteur = "Tom" };
            IVoiture i_v = v;
            IVehicule i_ve = i_v;

            i_v.Avancer(50);
            i_v.Tourner("Droite");

            Console.WriteLine($"La voiture est immatriculé : {i_ve.Matricule}");
        }
    }
}
