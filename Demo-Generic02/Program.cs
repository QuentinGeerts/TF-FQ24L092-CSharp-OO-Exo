

using Demo_Generic02.Models;

Repository<User> userRepository = new Repository<User>();
Repository<Product> productRepository = new Repository<Product>();

User user1 = new User { Id = Guid.NewGuid(), Name = "Quentin", Email = "quentin.geerts@bstorm.be" };
User user2 = new User { Id = Guid.NewGuid(), Name = "Michael", Email = "michael.person@cognitic.be" };
User user3 = new User { Id = Guid.NewGuid(), Name = "Thierry", Email = "thierry.morre@cognitic.be" };

userRepository.Add(user1);
userRepository.Add(user2);
userRepository.Add(user3);

// User? foundUser = userRepository.FindById("123"); // Ne fonctionne pas car la méthode n'accepte que les paramètres de type "struct"
User? foundUser = userRepository.FindById(123);

Console.WriteLine(foundUser != null ? $"Utilisateur trouvé: {foundUser.Name}" : "Aucun utilisateur trouvé");