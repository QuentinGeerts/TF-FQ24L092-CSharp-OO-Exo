

using DemoGeneric01.Models;

ArrayListInt arrayListInt = new ArrayListInt();
arrayListInt.Add(1); // Indice 0
arrayListInt.Add(2); // Indice 1
arrayListInt.Add(3); // Indice 2

//arrayListInt.Add("Hello"); // Ne fonctionne pas car ArrayListInt n'accepte que les entiers.

Console.WriteLine($"Le nombre entier en indice 2 est {arrayListInt[2]}"); // 3

ArrayListString arrayListString = new ArrayListString();
arrayListString.Add("Hello"); // Indice 0
arrayListString.Add("World"); // Indice 1

//arrayListString.Add(2); // Ne fonctionne pas car ArrayListString n'accepte que les chaines de caractères.

Console.WriteLine($"Le nombre entier en indice 2 est {arrayListString[1]}"); // World


ArrayListGeneric<int> arrayListGenericInt = new ArrayListGeneric<int>();
ArrayListGeneric<string> arrayListGenericString = new ArrayListGeneric<string>();
ArrayListGeneric<object> arrayListGenericObject = new ArrayListGeneric<object>();
ArrayListGeneric<Chien> arrayListGenericChien = new ArrayListGeneric<Chien>();
