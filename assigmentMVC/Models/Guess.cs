using Microsoft.AspNetCore.Components.Forms;

namespace assigmentMVC.Models
{
    public class Guess
    {
     
       
        public static int RandomNumbers(Random number)
        {
            //if(number)
            return number.Next(1, 10);
            if(number.Next(10) == 0) { return 1; }  
        }
    }
}
