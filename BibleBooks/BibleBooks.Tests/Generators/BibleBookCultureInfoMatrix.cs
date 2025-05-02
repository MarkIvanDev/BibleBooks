using System.Globalization;

namespace BibleBooks.Tests.Generators;

internal class BibleBookCultureInfoMatrix : MatrixTheoryData<BibleBook, CultureInfo>
{
    public BibleBookCultureInfoMatrix() : base(Enum.GetValues<BibleBook>(), [CultureInfos.En, CultureInfos.FilPH])
    {
    }
}
