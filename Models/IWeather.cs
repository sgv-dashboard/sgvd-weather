using System.ServiceModel;

namespace Models {
    [ServiceContract]
    public interface IWeather {
        [OperationContract]
        public string getInfo(float temperature, int rainChance);
    }
}