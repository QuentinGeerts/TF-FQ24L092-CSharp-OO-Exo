using Carwash02.Models;

Carwash carwash = new Carwash();

Voiture voiture1 = new Voiture("AB123CD");
Voiture voiture2 = new Voiture("EF456GH");


carwash.Traiter(voiture1);
carwash.Traiter(voiture2);