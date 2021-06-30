using System;
using System.Collections.Generic;

namespace iLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words =
            { "the", "fox", "jumps", "over", "the", "dog" };

            LinkedList<string> sentence = new LinkedList<string>(words);

            LinkedListNode<string> mark1 = sentence.Find("over");

            sentence.AddBefore(mark1, "Yasser");

            foreach (string word in sentence)
            {
                Console.Write(word + " ");
            }
        }
    }
}
