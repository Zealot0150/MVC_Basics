namespace MVC_Basics.Models
{
    public class Patient
    {
        private static string scale = "Celcius";
        public static string Scale { get => scale; set =>scale = value;}


        public string CheckPerson(int temp,string scale)
        {
            double calcTemp;
            Scale = scale;
            if (scale =="Farenheit")
                calcTemp = (temp - 32) / 1.8;
            else
                calcTemp = temp;
            if (calcTemp > 37.5)
                return "Du har feber!";
            else if (calcTemp < 36.0)
                return " Du har hypotermi!";
            else
                return "Normal temp.";
        }
    }
}
