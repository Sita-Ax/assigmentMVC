﻿using Microsoft.AspNetCore.Components.Forms;

namespace assigmentMVC.Models
{
    public class Guess
    {
        static int guesses = 0;
        public static string RandomNumbers(int guess, int rand)
        {
            while(guesses != 10 || rand == guess) { 
                if (guess < rand)
                {
                    guesses++;
                    return "The guessing number: " + guess + " was to small. You have guessed: " + guesses + "times.";
                
                }
                else if (guess > rand)
                {
                    guesses++;
                    return "The guessing number: " + guess + " was to big. You have guessed " + guesses + "times.";
                }
                else
                {
                    return guess + " was your guess and it was equals to the random number: " + rand + " and you have guesses " + guesses + " times";
                }
            }
            return "No input.";
           
        }
        public static int GetRandom()
        {
            Random random = new Random();
            return random.Next(1, 100);
        }
    }
}
