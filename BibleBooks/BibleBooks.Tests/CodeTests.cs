using BibleBooks.Tests.Generators;

namespace BibleBooks.Tests;

public class CodeTests
{
    [Theory]
    [ClassData(typeof(BibleBookGenerator))]
    public void OSIS(BibleBook book)
    {
        Assert.NotNull(BibleBooksHelper.GetOsisCode(book));
    }

    [Theory]
    [ClassData(typeof(BibleBookGenerator))]
    public void Paratext(BibleBook book)
    {
        Assert.NotNull(BibleBooksHelper.GetParatextCode(book));
    }
}
