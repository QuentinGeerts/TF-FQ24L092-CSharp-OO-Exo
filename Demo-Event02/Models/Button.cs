using Demo_Event02.Enums;
using Demo_Event02.Handlers;

namespace Demo_Event02.Models;

public class Button
{
    // Déclaration de l'événement base sur EventHandler
    public event EventHandler ClickEvent;

    public void LeftClick()
    {
        Console.WriteLine("Button Clicked");

        OnButtonClicked("Clic Gauche", ButtonTypes.Left);
    }
    
    public void RightClick()
    {
        Console.WriteLine("Button Clicked");

        OnButtonClicked("Clic droit", ButtonTypes.Right);
    }

    // Méthode protégée pour déclencher l'événement
    protected virtual void OnButtonClicked(string message, ButtonTypes type)
    {
        ButtonEventArgs args = new ButtonEventArgs(message)
        {
            ButtonType = type
        };
        ClickEvent?.Invoke(this, args);
    }
}
