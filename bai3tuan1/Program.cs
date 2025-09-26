using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TextProcessing
{
    class TextProcessor
    {
        private string text;
        public void Input()
        {
            Console.WriteLine("Nhap van ban:");
            text = Console.ReadLine();
        }
        public void Normalize()
        {
            if (string.IsNullOrWhiteSpace(text)) return;
            text = Regex.Replace(text, @"\s+", " ").Trim();
            char[] delimiters = { '.', '!', '?' };
            string[] sentences = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < sentences.Length; i++)
            {
                string s = sentences[i].Trim();
                if (s.Length > 0)
                {
                    sentences[i] = char.ToUpper(s[0]) + s.Substring(1);
                }
            }
            text = "";
            int idx = 0;
            foreach (char c in text = Regex.Replace(text, @"\s+", " ").Trim())
            {
                idx++;
            }
            text = string.Join(". ", sentences).Trim();
            if (!Regex.IsMatch(text, @"[.!?]$"))
            {
                text += ".";
            }
        }
        public int CountWords()
        {
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' },
                                        StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        public int CountDistinctWords()
        {
            string[] words = text.ToLower().Split(new char[] { ' ', '.', ',', '!', '?' },
                                                  StringSplitOptions.RemoveEmptyEntries);
            return words.Distinct().Count();
        }
        public Dictionary<string, int> WordFrequency()
        {
            string[] words = text.ToLower().Split(new char[] { ' ', '.', ',', '!', '?' },
                                                  StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> freq = new Dictionary<string, int>();

            foreach (string w in words)
            {
                if (freq.ContainsKey(w))
                    freq[w]++;
                else
                    freq[w] = 1;
            }

            return freq;
        }

        public void DisplayResults()
        {
            Console.WriteLine("Ket qua");
            Console.WriteLine("Van ban:");
            Console.WriteLine(text);

            Console.WriteLine($"Tong so tu: {CountWords()}");
            Console.WriteLine($"So tu khac nha: {CountDistinctWords()}");

            Console.WriteLine("");
            var freq = WordFrequency();
            foreach (var kvp in freq)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TextProcessor tp = new TextProcessor();
            tp.Input();
            tp.Normalize();
            tp.DisplayResults();

            Console.WriteLine("Ket thuc");
        }
    }
}
