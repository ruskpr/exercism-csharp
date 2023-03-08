using System;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string ret = string.Empty;
        phrase.Replace('-', ' ').Replace('_', ' ');
        string[] words = phrase.Split(" ");



        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < words[i].Length; j++)
            {

            }
            ret += words[i].ToCharArray()[0];
        }

        return ret.ToUpper();
    }
}