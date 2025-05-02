using System.Globalization;
using BibleBooks.Tests.Generators;

namespace BibleBooks.Tests;

public class KeyTests
{
    [Theory]
    [ClassData(typeof(BibleBookGenerator))]
    public void KeyForName(BibleBook book)
    {
        var name = BibleBooksHelper.GetName(book);
        Assert.Equal(BibleBooksHelper.GetKeyForName(name), book);
    }

    [Theory]
    [ClassData(typeof(CultureInfoGenerator))]
    public void KeyForNameWithCulture(CultureInfo culture)
    {
        foreach (var book in Enum.GetValues<BibleBook>())
        {
            var name = BibleBooksHelper.GetName(book, culture);
            Assert.Equal(BibleBooksHelper.GetKeyForName(name, culture), book);
        }
    }

    [Theory]
    [ClassData(typeof(BibleBookGenerator))]
    public void KeyForOsisCode(BibleBook book)
    {
        var osis = BibleBooksHelper.GetOsisCode(book);
        Assert.Equal(BibleBooksHelper.GetKeyForOsisCode(osis), book);
    }

    [Theory]
    [ClassData(typeof(BibleBookGenerator))]
    public void KeyForParatextCode(BibleBook book)
    {
        var paratext = BibleBooksHelper.GetParatextCode(book);
        Assert.Equal(BibleBooksHelper.GetKeyForParatextCode(paratext), book);
    }

    [Theory]
    [ClassData(typeof(BibleBookGenerator))]
    public void KeyForStandardAbbreviation(BibleBook book)
    {
        var standard = BibleBooksHelper.GetStandardAbbreviation(book);
        Assert.Equal(BibleBooksHelper.GetKeyForStandardAbbreviation(standard), book);
    }

    [Theory]
    [ClassData(typeof(BibleBookGenerator))]
    public void KeyForThompsonAbbreviation(BibleBook book)
    {
        var thompson = BibleBooksHelper.GetThompsonAbbreviation(book);
        Assert.Equal(BibleBooksHelper.GetKeyForThompsonAbbreviation(thompson), book);
    }
}
