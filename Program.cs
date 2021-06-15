using System.Collections.Generic;

namespace Aufgabe_Musikbox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Record> mblist = new List<Record>();
            Record rec1 = new Record(1, "Happy Coding", 2.38);
            Record rec2 = new Record(2, "We are Coding", 3.10);
            Record rec3 = new Record(3, "The Code we are", 2.59);
            Musicbox mb = new Musicbox(mblist);
            mb.LoadRecord(rec1);
            mb.LoadRecord(rec2);
            mb.LoadRecord(rec3);
            mb.Play(0);
            System.Console.WriteLine(mb.GetSumOfTitleLenght());
        
        }
    }
}
