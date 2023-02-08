namespace BibleBooks.Tests
{
    public class AbbreviationTests
    {
        [Fact]
        public void Standard()
        {
            foreach (var book in Enum.GetValues<BibleBook>())
            {
                Assert.NotNull(BibleBooksHelper.GetStandardAbbreviation(book));
            }
        }

        [Fact]
        public void Thompson()
        {
            foreach (var book in Enum.GetValues<BibleBook>())
            {
                Assert.NotNull(BibleBooksHelper.GetThompsonAbbreviation(book));
            }
        }
    }
}