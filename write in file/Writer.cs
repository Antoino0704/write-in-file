using System;
using System.IO;

namespace file_Writer
{
    public class Write
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("inserisci testo");
            string text = Console.ReadLine();
            Console.WriteLine("inserisci numero di volte in cui devo ripetre il testo");
            int num = Convert.ToInt32(Console.ReadLine());
            StreamWriter fp = new StreamWriter("file.txt");
            for(int i=0; i<num; i++)
            {
                fp.Write(text + "\n");
            }
            fp.Close();
            Console.WriteLine("puoi chiudere il programma");
            Console.Read();

        }
    }
}