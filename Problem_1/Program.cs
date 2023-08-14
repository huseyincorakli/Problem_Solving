// Verilen bir metindeki her kelimenin kaç kez tekrarlandığını bul

using System;

namespace ConsoleUygulamasi
{
    class Program
    {
        public static int Count(string text, string[] textArray)
        {
            int count = 0;
            foreach (var item in textArray)
            {
                if (item == text)
                {
                    count++;
                }

            }
            return count;
        }

        static void Main(string[] args)
        {
            string text = "Bugün Ali, Osman, Mahmut ve Cabbar buluştuk. Özellikle bugün buluşmamızın bir amacı yoktu, ama Ali bir süre sonra bugün özel bir gün dedi.";
            text=text.Replace(",", "");
            text=text.Replace(".", "");
            text=text.Replace("'", "");
            text = text.ToLower();
            var textArray = text.Split(new char[] { ' ', });
            Dictionary<string, int> CountText = new Dictionary<string, int>();

            foreach (var item in textArray)
            {
                int count = Count(item, textArray);
                CountText[item] = count;

            }

            foreach(KeyValuePair<string,int> kvp in CountText)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            
            
        }

       

        
    }
}

