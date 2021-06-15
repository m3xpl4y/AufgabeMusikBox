using System.Net.Http.Headers;
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
            if(recordsList.Count < 0)
                System.Console.WriteLine("Keine Platte eingelegt");
            if(recordsList.Count > 0 && recordsList.Count <= 50)
                System.Console.WriteLine("Die Platte " + "\"" + recordsList[num].Title + "\"" + " wird abgespielt ");
            if(recordsList.Count >= 50)
                System.Console.WriteLine("Musikbox ist voll, bitte zuerst eine Platte entfernen");
        }
        public double GetSumOfTitleLenght()
        {
            double playTime = 0;
            foreach (var item in recordsList)
            {
                playTime = playTime + item.Lenght;
            }
            return playTime;
        }
        public void SearchRecord(string title)
        {
            foreach (var item in recordsList)
            {
                if(item.Title.Contains(title))
                {
                    System.Console.WriteLine("Titel wurde gefunden!");
                }
            }
        }
    }
}