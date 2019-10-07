using System;
using System.Collections.Generic;
using System.Text;

namespace CourtTask.Models
{
    public static class Question
    {
        public static List<string> Questions { get; set; } = new List<string> {
            "If You Had A Theme Song, What Would It Be?" ,
            "If You Could Write One New Law That Everyone Had To Obey, What Law Would You Create?",
            "What Do You Miss Most About Being A Kid?",
             "What’s The Most Interesting Thing You’ve Read Or Seen This Week?",
             "What Cartoon Do You Still Like To Watch?",
            "What Skill Or Craft Would You Like To Master?",            
            "How Did You Find Out That Santa Isn’t Real?",
        };

        public static string GetRandomQuestion()
        {
            Random random = new Random();

            return Questions[random.Next(0, Questions.Count)];
        }
    }
}
