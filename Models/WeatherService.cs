namespace Models {
    public class WeatherService : IWeather {

        public string getInfo(float temperature, int rainChance){
            string response = "";

            //Response based on the temperature
            if(temperature < 0.0){
                response = "Vergeet je muts en handschoenen niet mee te nemen.";
            }
            else if(temperature >= 0.0 && temperature < 10.0){
                response = "Vergeet geen dikke jas mee te nemen.";
            }
            else if(temperature >= 10.0 && temperature < 20.0){
                response = "Vergeet je jas niet.";
            }
            else if(temperature >= 20.0 && temperature < 30.0){
                response = "Vergeet geen flesje water mee te nemen.";
            }
            else if(temperature >= 30.0){
                response = "Vergeet geen zonnecrème en zonnebril mee te nemen.";
            }
            
            //Response based on the rain chance
            if(rainChance > 80){
                response = response + " Het gaat regenen vandaag, neem een goede regenjas mee.";
            }
            else if(rainChance <= 80 && rainChance > 50){
                response = response + " Het gaat misschien regenen vandaag, neem een waterdichte jas mee.";
            }
            else if(rainChance < 50){
                response = response + " Het gaat waarschijnlijk droog blijven vandaag, een gewone jas is voldoende.";
            }   
            
            return response;
        }
    }
}