public class InputException:Exception
{
    private string message;

    public InputException(string msg)
    {
        message=msg;
    }
   
}