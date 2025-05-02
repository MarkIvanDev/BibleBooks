using System.Collections;
using System.Globalization;

namespace BibleBooks.Tests.Generators;

internal class CultureInfoGenerator : IEnumerable<TheoryDataRow<CultureInfo>>
{
    private readonly List<TheoryDataRow<CultureInfo>> _data =
    [
        CultureInfos.En,
        CultureInfos.FilPH,
    ];

    public IEnumerator<TheoryDataRow<CultureInfo>> GetEnumerator() => _data.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
