using System.Globalization;

namespace BibleBooks.Tests.Generators;

internal class NumberCultureInfoMatrix : MatrixTheoryData<Number, CultureInfo>
{
    public NumberCultureInfoMatrix() : base(Enum.GetValues<Number>(), [CultureInfos.En, CultureInfos.FilPH])
    {
    }
}
