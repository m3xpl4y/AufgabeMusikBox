using System.Collections.Generic;

namespace Aufgabe_Musikbox
{
    public class Record
    {
        public int ID { get; set; }
        public string Title { get; set; }
        List<Track> tracksList;
        public void AddTrackToRecord(Track track)
        {
            tracksList.Add(track);
        }

        public Record(int iD, string title, List<Track> tracksList)
        {
            ID = iD;
            Title = title;
            this.tracksList = tracksList;
        }
    }
}