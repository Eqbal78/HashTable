using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table Program");

           // MyMapNode<int, string> hash = new MyMapNode<int, string>(5);
          /*  hash.Add(0, "to");
            hash.Add(1, "be");
            hash.Add(2, "or");
            hash.Add(3, "not");
            hash.Add(4, "to");
            hash.Add(5, "be");

            Console.WriteLine("Frequency of to  : " + hash.GetFrequencyOfWords("to"));
            Console.WriteLine("Frequency of be  : " + hash.GetFrequencyOfWords("be"));
            Console.WriteLine("Frequency of or  : " + hash.GetFrequencyOfWords("or"));
            Console.WriteLine("Frequency of not : " + hash.GetFrequencyOfWords("not"));*/

            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] para = paragraph.Split(" ");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(para.Length);
            MyMapNode<string, string> hashs = new MyMapNode<string, string>(para.Length);
            int keys = 0;
            foreach (string word in para)
            {
                int k = keys++;
                string key = k.ToString();
                hash.Add(word, key);
                
                
            }
           // string value = hash.Get("Paranoids");
           // hash.GetArrayPosition(value);
            //hash.Frequency(hash);
            hash.Remove("avoidable");
           // hashs.Frequency(hash);

        }
    }
}
