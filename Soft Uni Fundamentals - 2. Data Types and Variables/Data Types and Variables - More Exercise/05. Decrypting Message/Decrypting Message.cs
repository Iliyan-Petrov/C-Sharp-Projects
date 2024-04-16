class Decrypting_Message
{
    static void Main(string[] args)
    {
        int key = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        string message = "";
        
        for (int i = 0; i < n; i++)
        {
            char encryptedChar = Console.ReadLine()[0];
            char decryptedChar = (char)(encryptedChar + key);
            message += decryptedChar;
        }
        
        Console.WriteLine(message);
    }
}
