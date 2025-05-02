using BibleBooks.Tests.Generators;

namespace BibleBooks.Tests;

public class AbbreviationTests
{
    [Theory]
    [ClassData(typeof(BibleBookGenerator))]
    public void Standard(BibleBook book)
    {
        Assert.NotNull(BibleBooksHelper.GetStandardAbbreviation(book));
    }

    [Theory]
    [ClassData(typeof(BibleBookGenerator))]
    public void Thompson(BibleBook book)
    {
        Assert.NotNull(BibleBooksHelper.GetThompsonAbbreviation(book));
    }
}