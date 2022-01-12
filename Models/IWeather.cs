using System.ServiceModel;

namespace Models {
    [ServiceContract]
    interface IWeather {
        [OperationContract]
        public string getInfo(float temperature, int rainChance);
    }
}