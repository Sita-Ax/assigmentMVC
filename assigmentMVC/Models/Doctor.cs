namespace assigmentMVC.Models
{
    public class Doctor
    {
        public static string Diagnose(double temp)
        {
            bool temperature = false;
            while (!temperature)
            {
               if(temp == 37)
                {
                    return "You have the perfect temperature. Go home again!";
                    temperature = true;
                } 
               else if (temp > 36 && temp < 38)
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
               else if(temp > 40)
                {
                    return "Call ambulanse ";
                }
               
            }
            return "Temp outside";
            //return (temp > 37) ? "Almost healty...have a cookie" : "No fever..Do not take a cookie!";

        }
    }
}
