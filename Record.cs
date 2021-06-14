using System.Collections.Generic;
namespace Aufgabe_Musikbox
{
    public class Record
    {
        public int ID { get; set; }
        public string Title { get; set; }

        List<Track> tracksList;

        public void AddTrackToRecord()
        {
            foreach(var track in tracksList)
            {
                tracksList.Add(track);
            }
        }

    }
}