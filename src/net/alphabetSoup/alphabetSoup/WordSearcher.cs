// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

void Main(string[] args)
{

}
public class WordSearcher
{
    private char[,] soup;

    public WordSearcher(char[,] soup)
    {
        this.soup = soup;
    }

    public bool IsPresent(string word)
    {
        int wordLength = word.Length;
        int wordIndexFound = 0;
        bool[,] whereFounded = new bool[soup.GetLength(0), soup.GetLength(1)];
        bool founded = false;
        for (int i = 0; i < soup.GetLength(0); i++)
        {
            for(int j = 0; j < soup.GetLength(1); j++)
            {
                 founded = Search(whereFounded, wordIndexFound, i, j, wordLength, word);
                if (founded) return founded;
            }
        }
        return founded;
    }

    public bool Search(bool[,] whereFounded, int wordIndexFound, int i, int j, int wordLength, string word) 
    {
        if (wordLength == wordIndexFound)
        {
            return true;
        }
        if (word[wordIndexFound] == soup[i, j])
        {
            whereFounded[i, j] = true;
            wordIndexFound++;
            if (wordLength == wordIndexFound)
            {
                return true;
            }
            else
            {
                if(i - 1 >= 0)
                {
                    if(Search(whereFounded, wordIndexFound, i - 1, j, wordLength, word)) return true;
                }
                if(i + 1 < whereFounded.GetLength(0))
                {
                    if (Search(whereFounded, wordIndexFound, i + 1, j, wordLength, word)) return true;
                }
                if (j - 1 >= 0)
                {
                    if (Search(whereFounded, wordIndexFound, i, j - 1, wordLength, word)) return true;
                }
                if (j + 1 < whereFounded.GetLength(1))
                {
                    if (Search(whereFounded, wordIndexFound, i, j + 1, wordLength, word)) return true;
                }
            }
            return false;
        }
        return false;
    }
}