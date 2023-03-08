using System;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string ret = "";

        string[] words = phrase.Split(' ');

        for (int i = 0; i < words.Length; i++)// loop through each word
        {
            for (int j = 0; j < words[i].Length; j++) // loop through each word's letter
            {

            }
        }

        return ret.ToUpper();
    }
}