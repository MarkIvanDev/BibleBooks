using BibleBooks.Tests.Generators;

namespace BibleBooks.Tests;

public class MetadataTests
{
    [Theory]
    [ClassData(typeof(BibleBookGenerator))]
    public void MaxChapters(BibleBook book)
    {
        Assert.NotNull(BibleBooksHelper.GetMaxChapter(book));
    }
}
