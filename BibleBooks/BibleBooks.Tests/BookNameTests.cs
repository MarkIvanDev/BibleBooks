using System.Globalization;

namespace BibleBooks.Tests
{
    public class BookNameTests
    {
        [Fact]
        public void Names()
        {
            foreach (var book in Enum.GetValues<BibleBook>())
            {
                Assert.NotNull(BibleBooksHelper.GetName(book));
            }
        }

        [Theory]
        [ClassData(typeof(CultureInfoGenerator))]
        public void NamesWithCulture(CultureInfo culture)
        {
            foreach (var book in Enum.GetValues<BibleBook>())
            {
                Assert.NotNull(BibleBooksHelper.GetName(book, culture));
            }
        }

        [Fact]
        public void AlternativeNames()
        {
            foreach (var book in Enum.GetValues<BibleBook>())
            {
                Assert.NotNull(BibleBooksHelper.GetAlternativeNames(book));
            }
        }

        [Theory]
        [ClassData(typeof(CultureInfoGenerator))]
        public void AlternativeNamesWithCulture(CultureInfo culture)
        {
            foreach (var book in Enum.GetValues<BibleBook>())
            {
                Assert.NotNull(BibleBooksHelper.GetAlternativeNames(book, culture));
            }
        }

        [Fact]
        public void Numbers()
        {
            foreach (var number in Enum.GetValues<Number>())
            {
                Assert.NotNull(BibleBooksHelper.GetNumber(number));
            }
        }

        [Theory]
        [ClassData(typeof(CultureInfoGenerator))]
        public void NumbersWithCulture(CultureInfo culture)
        {
            foreach (var number in Enum.GetValues<Number>())
            {
                Assert.NotNull(BibleBooksHelper.GetNumber(number, culture));
            }
        }
    }
}
