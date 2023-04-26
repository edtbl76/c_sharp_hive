namespace SavingInterface;

public class PasswordManager : IDisplayable, IResetable
{
    private string Password { get; set;  }
    private bool Hidden { get; set;  }

    public PasswordManager(string password, bool hidden)
    {
        Password = password;
        Hidden = hidden;
    }

    public void Display()
    {
        /*
         *  The false condition of the ternary operator is a call to string() where the params are
         *  the character I want to repeat, and the number of times I want to repeat it. 
         */
        Console.WriteLine(!Hidden ? Password : new string('*', Password.Length));
    }

    public void Reset()
    {
        Password = "";
        Hidden = false;
    }
}