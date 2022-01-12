using System.ServiceModel;

namespace Models {
    [ServiceContract]
    interface IWeather {
        [OperationContract]
        public int getGetal();
    }
}