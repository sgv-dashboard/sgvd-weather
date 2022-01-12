using System.Runtime.Serialization;

namespace Models {
    [DataContract]
    public class Weather {
        [DataMember]
        public float lon {get; set;}
        [DataMember]
        public float lat {get; set;}

        public Weather(float lon, float lat){
            this.lon = lon;
            this.lat = lat;
        }

        public float getLon(){
            return lon;
        }

        public float getLat(){
            return lat;
        }
    }
}