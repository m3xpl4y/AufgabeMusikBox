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
        public void SearchRecord()
        {
            
        }
    }
}