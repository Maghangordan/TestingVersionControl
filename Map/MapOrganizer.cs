using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tsport.Map
{
    public class MapOrganizer
    {
        List<Location> myMap = new List<Location>();
        public MapOrganizer()
        {
            //M2
            myMap.Add(new Location() { Name = "Onkmot", Elevator="M2", Floor=0 });
            myMap.Add(new Location() { Name = "Provtagning", Elevator = "M2", Floor = 0 });

            myMap.Add(new Location() { Name = "Kemlab", Elevator = "M2", Floor = 1 });
            myMap.Add(new Location() { Name = "Blodcentralen", Elevator = "M2", Floor = 1 });

            myMap.Add(new Location() { Name = "Avd. 82", Elevator = "M2", Floor = 2 });
            myMap.Add(new Location() { Name = "Avd. 92", Elevator = "M2", Floor = 2 });

            myMap.Add(new Location() { Name = "Avd. 83", Elevator = "M2", Floor = 3 });
            myMap.Add(new Location() { Name = "Avd. 93", Elevator = "M2", Floor = 3 });
            //M3
            myMap.Add(new Location() { Name = "Gerimot", Elevator = "M3", Floor = 0 });
            myMap.Add(new Location() { Name = "Fysioterapi", Elevator = "M3", Floor = 0 });

            myMap.Add(new Location() { Name = "Medmot 1", Elevator = "M3", Floor = 1 });

            //A-huset
            myMap.Add(new Location() { Name = "40A", Elevator = "A0", Floor = 0 });
            myMap.Add(new Location() { Name = "40B", Elevator = "A0", Floor = 0 });

            myMap.Add(new Location() { Name = "Logopeden", Elevator = "A1", Floor = 7 });
            //B-huset

            //O-huset

            //G-huset


        }
    }
}
