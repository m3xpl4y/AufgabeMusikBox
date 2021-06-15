using System.Collections.Generic;

namespace Aufgabe_Musikbox
{
    public class Record
    {


        public int ID { get; set; }
        public string Title { get; set; }
        public double Lenght { get; set; }

        public Record(int id, string title, double lenght)
        {
            ID = id;
            Title = title;
            Lenght = lenght;
        }

        public void AddTrackToRecord()
        {
            
        }
    }
}