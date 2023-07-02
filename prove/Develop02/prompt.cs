using System.Collections.Generic;
using System;

namespace Develop02
{
    public class Prompt{
        Random rnd = new Random();
        public List<string> prompt;
        
        public Prompt(){
            prompt.Add("What was a highlight of our day?");
            prompt.Add("Have you met anyone you would want to strangle today?");
            prompt.Add("Did you touch grass today?");
            prompt.Add("What was the hardest task you have accomplished today?");

        }
        public string GetRandomPrompt()
        {
            int index = rnd.Next(prompt.Count);
            return prompt[index];
        }
    }
}