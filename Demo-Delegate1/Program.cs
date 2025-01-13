using Demo_Delegate1.Models;

NotificationService notificationService = new NotificationService();

// Enregistrer les méthodes de notification
notificationService.RegisterNotification(SendEmail);
notificationService.RegisterNotification(SendPigeon);
notificationService.RegisterNotification(SendSMS);
notificationService.RegisterNotification(SendEmail);


notificationService.UnRegisterNotification(SendEmail);
notificationService.UnRegisterNotification(SendEmail);
notificationService.UnRegisterNotification(SendEmail);

// Envoyer la notification
notificationService.Notify("Hello World");


static void SendEmail(string message)
{
    Console.WriteLine($"Envoi d'email: {message}");
}

static void SendSMS(string message)
{
    Console.WriteLine($"Envoi SMS: {message}");
}

static void SendPigeon(string message)
{
    Console.WriteLine($"Envoi Pigeon: {message}");
}