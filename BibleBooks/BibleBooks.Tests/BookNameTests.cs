using System.Globalization;
using BibleBooks.Tests.Generators;

namespace BibleBooks.Tests;

public class BookNameTests
{
    [Theory]
    [ClassData(typeof(BibleBookGenerator))]
    public void Names(BibleBook book)
    {
        Assert.NotNull(BibleBooksHelper.GetName(book));
    }

    [Theory]
    [ClassData(typeof(BibleBookCultureInfoMatrix))]
    public void NamesWithCulture(BibleBook book, CultureInfo culture)
    {
        Assert.NotNull(BibleBooksHelper.GetName(book, culture));
    }

    [Theory]
    [ClassData(typeof(BibleBookGenerator))]
    public void AlternativeNames(BibleBook book)
    {
        Assert.NotNull(BibleBooksHelper.GetAlternativeNames(book));
    }

    [Theory]
    [ClassData(typeof(BibleBookCultureInfoMatrix))]
    public void AlternativeNamesWithCulture(BibleBook book, CultureInfo culture)
    {
        Assert.NotNull(BibleBooksHelper.GetAlternativeNames(book, culture));
    }

    [Theory]
    [ClassData(typeof(NumberGenerator))]
    public void Numbers(Number number)
    {
        Assert.NotNull(BibleBooksHelper.GetNumber(number));
    }

    [Theory]
    [ClassData(typeof(NumberCultureInfoMatrix))]
    public void NumbersWithCulture(Number number, CultureInfo culture)
    {
        Assert.NotNull(BibleBooksHelper.GetNumber(number, culture));
    }
}
