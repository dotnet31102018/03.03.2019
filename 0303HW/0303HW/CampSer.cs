using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0303HW
{
    public class CampSer
    {
        #region Data

        public int id;
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public int NumberOfPeoples { get; set; }
        public int NumberOfTents { get; set; }
        public int NumberOfFlashLights { get; set; }

        private static int lastCampId = 0;

        #endregion

        #region Ctor

        public CampSer(int latitude, int longitude, int numberOfPeople, int numberOfTents, int numberOfFlashLights)
        {
            this.id = ++lastCampId;
            Latitude = latitude;
            Longitude = longitude;
            NumberOfPeoples = numberOfPeople;
            NumberOfTents = numberOfTents;
            NumberOfFlashLights = numberOfFlashLights;
        }

        public CampSer()
        {

        }

        #endregion

        public static bool operator ==(CampSer camp1, CampSer camp2)
        {
            if (ReferenceEquals(camp1, null) && ReferenceEquals(camp2, null))
                return true;
            if (ReferenceEquals(camp1, null) || ReferenceEquals(camp2, null))
                return false;

            return camp1.id == camp2.id;
        }

        public static bool operator !=(CampSer camp1, CampSer camp2)
        {
            return !(camp1 == camp2);
        }

        public static CampSer operator +(CampSer camp1, CampSer camp2)
        {
            return new CampSer((camp1.Latitude + camp2.Latitude) / 2, (camp1.Longitude + camp2.Longitude) / 2,
                camp1.NumberOfPeoples + camp2.NumberOfPeoples, camp1.NumberOfTents + camp2.NumberOfTents,
                camp1.NumberOfFlashLights + camp2.NumberOfFlashLights);
        }

        public static bool operator >(CampSer camp1, CampSer camp2)
        {
            return camp1.NumberOfPeoples > camp2.NumberOfPeoples;
        }

        public static bool operator <(CampSer camp1, CampSer camp2)
        {
            return camp1.NumberOfPeoples < camp2.NumberOfPeoples;
        }

        public override int GetHashCode()
        {
            return this.id;
        }

        public override string ToString()
        {
            return $"Camp {id} {Latitude} {Longitude} people: {NumberOfPeoples} flashlights : {NumberOfFlashLights} tents : {NumberOfTents}";
        }

        public override bool Equals(object obj)
        {
            //if (ReferenceEquals(obj, null))
            //    return false;

            CampSer other = obj as CampSer;
            return this == other;
        }
    }

}
