namespace Aufgabe_Musikbox
{
    public class Track
    {
        public Track()
        {
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public double Lenght { get; set; }

        public Track(int iD, string title, double lenght)
        {
            ID = iD;
            Title = title;
            Lenght = lenght;
        }
    }
}