using Demo_Event02.Enums;
using Demo_Event02.Handlers;

namespace Demo_Event02.Models;

public class EventListener
{

    public void Subscribe(Button button)
    {
        button.ClickEvent += OnButtonClicked;
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        Console.WriteLine($"Événement intercepté pour la classe {sender.GetType().Name}!");

        if (e != null && e is ButtonEventArgs btn)
        {
            if (btn.ButtonType == ButtonTypes.Left)
            {
                Console.WriteLine($"Clic Gauche intercepté, message transmis: {btn.Message}");
            }
            else
            {
                Console.WriteLine($"Clic Droit intercepté, message transmis: {btn.Message}");
            }
        }
    }
}
