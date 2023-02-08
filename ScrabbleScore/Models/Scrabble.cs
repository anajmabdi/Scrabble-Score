namespace ScrabbleScore.Models
{
    public class Word
    {
        public char[] UserWord { get; set; }
        public Word(string userWord)
        {
            UserWord = userWord.ToCharArray();
        }

    }
}

