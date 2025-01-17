using Demo_Event02.Enums;

namespace Demo_Event02.Handlers;

public class ButtonEventArgs : EventArgs
{
    public ButtonTypes ButtonType { get; init; }
    public string Message { get; set; }

    public ButtonEventArgs(string message)
    {
        Message = message;
    }
}
