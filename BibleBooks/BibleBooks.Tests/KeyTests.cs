using System.Globalization;

namespace BibleBooks.Tests
{
    public class KeyTests
    {
        [Fact]
        public void KeyForName()
        {
            foreach (var book in Enum.GetValues<BibleBook>())
            {
                var name = BibleBooksHelper.GetName(book);
                Assert.Equal(BibleBooksHelper.GetKeyForName(name), book);
            }
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

        [Fact]
        public void KeyForOsisCode()
        {
            foreach (var book in Enum.GetValues<BibleBook>())
            {
                var osis = BibleBooksHelper.GetOsisCode(book);
                Assert.Equal(BibleBooksHelper.GetKeyForOsisCode(osis), book);
            }
        }

        [Fact]
        public void KeyForParatextCode()
        {
            foreach (var book in Enum.GetValues<BibleBook>())
            {
                var paratext = BibleBooksHelper.GetParatextCode(book);
                Assert.Equal(BibleBooksHelper.GetKeyForParatextCode(paratext), book);
            }
        }

        [Fact]
        public void KeyForStandardAbbreviation()
        {
            foreach (var book in Enum.GetValues<BibleBook>())
            {
                var standard = BibleBooksHelper.GetStandardAbbreviation(book);
                Assert.Equal(BibleBooksHelper.GetKeyForStandardAbbreviation(standard), book);
            }
        }

        [Fact]
        public void KeyForThompsonAbbreviation()
        {
            foreach (var book in Enum.GetValues<BibleBook>())
            {
                var thompson = BibleBooksHelper.GetThompsonAbbreviation(book);
                Assert.Equal(BibleBooksHelper.GetKeyForThompsonAbbreviation(thompson), book);
            }
        }
    }
}
