
public class Button
{
    public event EventHandler Clicked;

    public void OnClick()
    {
        Clicked?.Invoke(this, EventArgs.Empty);
        //Clicked(this, EventArgs.Empty);
    }
}

public class Program
{
    public static void Main()
    {

        Button button = new Button();
        button.Clicked += Button_clicked;

        //(sender, e) => Console.WriteLine("Button was clicked!");
        button.OnClick();
    }

    public static void Button_clicked(object sender, EventArgs e)
    {
        Console.WriteLine(sender.GetType()+" was clicked!");
        
    }
}