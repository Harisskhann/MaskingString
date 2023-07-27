using System;

public class Program
{
    public static string Maskify(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length <= 4)
            return input;

        char[] maskedChars = input.ToCharArray();
        for (int i = 0; i < input.Length - 4; i++)
        {
            maskedChars[i] = '#';
        }

        return new string(maskedChars);

    }
    public static void Main(string[] args)
    {
        String Text;
        Console.WriteLine("Enter a string");
        Text = Convert.ToString(Console.ReadLine());
        string value = Maskify(Text);
        Console.WriteLine(value);
        Console.ReadLine();

    }
}