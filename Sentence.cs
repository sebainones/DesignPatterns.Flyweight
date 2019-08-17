using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyWeight
{
    public class Sentence
    {
        private string[] words;

        private List<WordToken> WordTokens = new List<WordToken>();
        public Sentence(string plainText)
        {
            words = plainText.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                WordTokens.Add(new WordToken(words[i]));
            }
        }

        public WordToken this[int index]
        {
            get
            {
                return WordTokens[index];
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var currentWordToken in WordTokens)
            {
                if (currentWordToken.Capitalize)
                    sb.Append(currentWordToken.word.ToUpper());
                else
                    sb.Append(currentWordToken.word);

                if (WordTokens.LastOrDefault() != currentWordToken)
                    sb.Append(" ");
            }
            return sb.ToString();
        }        
    }
}