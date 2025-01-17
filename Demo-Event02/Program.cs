using Demo_Event02.Models;

// Création d'un bouton
Button button = new Button();

// Création de l'écouteur d'événements
EventListener listener = new EventListener();

// Abonnement de l'écouteur d'événements au bouton
listener.Subscribe(button);

// Simulation d'un clic gauche
button.LeftClick();

// Simulation d'un clic droit
button.RightClick();
