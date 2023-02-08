namespace BibleBooks.Tests
{
    public class CodeTests
    {
        [Fact]
        public void OSIS()
        {
            foreach (var book in Enum.GetValues<BibleBook>())
            {
                Assert.NotNull(BibleBooksHelper.GetOsisCode(book));
            }
        }

        [Fact]
        public void Paratext()
        {
            foreach (var book in Enum.GetValues<BibleBook>())
            {
                Assert.NotNull(BibleBooksHelper.GetParatextCode(book));
            }
        }
    }
}
