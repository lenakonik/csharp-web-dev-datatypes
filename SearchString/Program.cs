using System;

namespace SearchString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            txt = txt.ToLower();
            Console.WriteLine("Which term you want to find in the text?");
            string term = (Console.ReadLine()).ToLower();

            //find index of the 1 occurrence of a character or substring. Returns -1 if the character or substring is not found in this string.
            int i = txt.IndexOf(term);
            if (i != -1)
            {
                Console.WriteLine("found at index " + i + ". Length is " + term.Length);
                //Remove substring from string - first works too, but we need to confirm that we remove from same index, same length
                //string stripped_txt = txt.Replace(term, "");
                string stripped_txt = txt.Remove(txt.IndexOf(term), term.Length);
                Console.WriteLine(stripped_txt);
            }
            else
            {
                Console.WriteLine("not found");
            }
        }
    }
}
