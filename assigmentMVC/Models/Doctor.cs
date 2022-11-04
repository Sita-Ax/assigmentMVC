namespace assigmentMVC.Models
{
    public class Doctor
    {

        public string? Celisius { get; set; }
        public string? Fahrenhigt { get; set; }
        public static string Diagnose(double temp)
        {
               if(temp == 37)
                {
                    return "You have the perfect temperature. Go home again!";
                } 
               else if (temp >= 36 && temp <= 38)
                {
                    return "Your temperature is not that wrong so go home and rest.";
                }
               else if(temp < 36)
                {
                    return "To low so watch out for hypothermia";
                }
               else if(temp > 38 && temp < 40)
                {
                    return "You have high fever, you are sick.";
                }
               else if(temp >= 40)
                {
                    return "Call ambulanse ";
                }
            return "Go to doctor or play a game.";
        }

    }
}
