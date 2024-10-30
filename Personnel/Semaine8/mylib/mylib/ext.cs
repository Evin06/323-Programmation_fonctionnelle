using System;

public static class Ext
{
    public static int ReadInt(this string prompt)
    {
        int result;
        do
        {
            Console.Write(prompt);
        } while (!int.TryParse(Console.ReadLine(), out result));
        return result;
    }

    public static double ReadDouble(this string prompt)
    {
        double result;
        do
        {
            Console.Write(prompt);
        } while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }

    public static DateTime ReadDate(this string prompt)
    {
        DateTime result;
        do
        {
            Console.Write(prompt);
        } while (!DateTime.TryParse(Console.ReadLine(), out result));
        return result;
    }

    public static int ToIntSafe(this string input, int defaultValue = 0)
    {
        return int.TryParse(input, out int result) ? result : defaultValue;
    }

    public static string RandomString(this Random random, int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        char[] stringChars = new char[length];
        for (int i = 0; i < length; i++)
        {
            stringChars[i] = chars[random.Next(chars.Length)];
        }
        return new string(stringChars);
    }

    public static bool RandomBool(this Random random)
    {
        return random.Next(2) == 1;
    }
}
