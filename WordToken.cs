namespace FlyWeight
{
    public class WordToken
        {
            public readonly string word;
            public bool Capitalize;
            public WordToken(string word)
            {
                this.word = word;
            }
        }
}