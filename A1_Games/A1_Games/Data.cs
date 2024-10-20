using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_Games
{
    public static class Data
    {
        public static List<Words> GetWord()
        {
            List<Words> words = new List<Words>();

            Words word = new Words
            {
                id=1,
                word= "leader",
                clue= "a person in control of a group, country, or situation"
            };
            words.Add(word);

            word = new Words
            {
                id=2,
                word = "design",
                clue = "to make or draw plans for something, for example clothes or buildings"
            };
            words.Add(word);

            word = new Words
            {
                id = 3,
                word = "create",
                clue = "to make something new, or invent something"
            };
            words.Add(word);

            return words;
        }
    }
}
