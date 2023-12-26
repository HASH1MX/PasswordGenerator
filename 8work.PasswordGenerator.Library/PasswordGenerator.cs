namespace _8work.PasswordGenerator.Library;

public class PasswordGenerator
{
    private string characters = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
    private string charactersWithNumerics = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm0123456789";
    private string charactersWithNumericAndSpecial = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm0123456789¬!£$%^&*()_+}{~@:?><}";
    public string Generate(int length = 8)
    {

        Random random = new Random();
        string password = string.Empty;

        for (int i = 0; i < length; i++)
        {

            int x = random.Next(characters.Length);
            password = password + characters[x];

        }
        return password;
    }
    public string Generate(bool isNumeric, int length = 8)
    {
        string password = String.Empty;
        if (isNumeric == true)
        {
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {

                int x = random.Next(charactersWithNumerics.Length);
                password = password + charactersWithNumerics[x];

            }
        }
        else if (isNumeric == false)
        {
            password = this.Generate(length);
        }
        return password;
    }
    public string Generate(bool isNumeric, bool isSpecial, int length = 8)
    {
        string password = String.Empty;
        if (isSpecial == true)
        {
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {

                int x = random.Next(charactersWithNumericAndSpecial.Length);
                password = password + charactersWithNumericAndSpecial[x];

            }
        }
        else if (isNumeric == true)
        {
            password = this.Generate(true, length);
        }
        else if (isNumeric == false && isSpecial == false)
        {
            password = this.Generate(length);
        }
        return password;

    }
}
