using System.Collections.Generic;

namespace Aufgabe_Musikbox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Record> mblist = new List<Record>();

            List<Track> trackList1 = new List<Track>();
            Track track1 = new Track(1, "Hallo Welt", 2.35);
            Track track2 = new Track(2, "We are Coding", 3.24);

            Record platte1 = new Record(1, "The World", trackList1);
            platte1.AddTrackToRecord(track1);
            platte1.AddTrackToRecord(track2);


            Musicbox mb = new Musicbox(mblist);
            mb.LoadRecord(platte1);
            mb.Play(0);


            
        
        }
    }
}
