using System;

class Program
{
    static void Main(string[] args)
    {
        // This represents a word in the scripture set.
        public class word 
        {
            public string _text;
            public bool IsHidden;

            public word(string text) 
            {
                _text = text;
                IsHidden = false;
            }
            // returns the display text for the word
            public string GetDisplayText()
            {
                return IsHidden ? new string ('_', _text.Length) : Text;
            }
            // hides the word 
            public void Hide()
            {
                IsHidden = true;
            }
        }
        // Represents a scripture reference
        public class Reference
        {
            public string _book;
            public int _chapter;
            public int _verse ;
            public int _endVerse;
        }
        //constructor for one verse
        public Reference(string book, int startChapter, int startVerse)
        {
            _book = book;
            _startChapter = startChapter;
            _startVerse = startVerse;
        }
        // constructor for a range of verses.
        public Reference(string book, int startChapter, int startVerse, int endChapter, int endVerse)
        {
            _book = book;
            _startChapter = stratChapter;
            _startVerse = startVerse;
            _endChapter = endChapter;
            _endVerse = endVerse;
        }
        // returns the display text for the reference.
        public string GetDisplayText()
        {
            if (_endChapter.HasValue)
            {
                return $ "{Book} {StartChapter}:{StartVerse}-{EndChapter.Value}:{EndVerse.Value}";
            }
            else
            {
                return $ "{Book} {StartChapter}:{StartVerse}"
            }
        }
        // Represents the scripture
        public class Scripture
        {
            private Reference _reference;
            private List<word> _words;

            public Scripture(Reference reference, string text)
            {
                _reference = Reference;
            }
            public void HiddenRandomWords(int count)
            {
                var _random = new Random();
                var _hiddenWords = words.Where(w => w.IsHidden).ToList();
                var visiblewords = words.where(w => ! w.IsHidden).ToList();
                for (int i = 0; i < count; i++)
                {
                    if(visiblewords.Count == 0)
                    {
                        break;
                    }
                }
            }
            public string GetDisplayText()
            {

            }


        }

    }
}
