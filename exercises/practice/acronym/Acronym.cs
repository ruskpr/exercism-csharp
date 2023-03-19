using System;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string ret = "";
        //phrase.Replace("-", " - ");
        string[] words = phrase.Split(' ');

        for (int i = 0; i < words.Length; i++) // loop through each word
        {
            // hyphenated word check
            if (words[i].Contains("-") && words[i].Length > 1)
            {
                string[] hyphenatedWord = words[i].Split('-');
                for (int j = 0; j < hyphenatedWord.Length; j++)
                {
                    ret += hyphenatedWord[j].ToCharArray()[0];
                }

                continue;
            }

            if (words[i] == "-")
                continue;

            // underscore check
            words[i] = words[i].Trim('_');

            ret += words[i].ToCharArray()[0];
        }

        return ret.ToUpper();
    }
}