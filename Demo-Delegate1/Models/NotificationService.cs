namespace Demo_Delegate1.Models;

// Définir le délégué pour les méthodes de notification
delegate void NotifyDelegate (string message);

internal class NotificationService
{
    // Déclaration de la variable de type du délégué
    private NotifyDelegate _notifyDelegate;

    // Méthode pour enregistrer la / les méthode(s) de notification
    public void RegisterNotification(NotifyDelegate notifyDelegate)
    {
        _notifyDelegate += notifyDelegate;
    }

    // Méthode pour désenregistrer la / les méthode(s) de notification
    public void UnRegisterNotification(NotifyDelegate notifyDelegate)
    {
        if (_notifyDelegate != null)
            _notifyDelegate -= notifyDelegate;
    }

    // Méthode pour envoyer la notification
    public void Notify(string message)
    {
        _notifyDelegate?.Invoke(message);

        // Autre façon 

        // if (_notifyDelegate != null) _notifyDelegate(message);
    }
}