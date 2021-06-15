using System.Collections.Generic;

namespace Aufgabe_Musikbox
{
    public class Musicbox
    {
        List<Record> recordsList;

        public void LoadRecord(Record record)
        {
            recordsList.Add(record);
        }

        public void RemoveRecord(Record record)
        {
            recordsList.Remove(record);
        }
        public void SearchRecord(Record record)
        {
            if(recordsList.Contains(record))
            {
                System.Console.WriteLine();
            }
        }

        public Musicbox(List<Record> recordsList)
        {
            this.recordsList = recordsList;
        }

        public void Play(int num)
        {
            ;
            System.Console.WriteLine("Die Platte " + "\"" + recordsList[num].Title + "\"" + " wird abgespielt ");
        }

    }
}