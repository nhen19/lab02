

namespace lab02
{
    public class CompareTitle : System.Collections.Generic.Comparer<Book>
    {

        public override int Compare(Book x, Book y)
        {
            return x.Title.CompareTo(y.Title);
        }

    }
    public class ComparePublisher : System.Collections.Generic.Comparer<Book>
    {

        public override int Compare(Book x, Book y)
        {
            return x.Publisher.CompareTo(y.Publisher);
        }

    }
    public class CompareAuthor : System.Collections.Generic.Comparer<Book>
    {

        public override int Compare(Book x, Book y)
        {
            return x.Author.CompareTo(y.Author);
        }

    }
    public class CompareYear : System.Collections.Generic.Comparer<Book>
    {

        public override int Compare(Book x, Book y)
        {
            return x.Year.CompareTo(y.Year);
        }

    }
}