namespace BibleBooks.Tests
{
    public class MetadataTests
    {
        [Fact]
        public void MaxChapters()
        {
            foreach (var book in Enum.GetValues<BibleBook>())
            {
                Assert.NotNull(BibleBooksHelper.GetMaxChapter(book));
            }
        }
    }
}
