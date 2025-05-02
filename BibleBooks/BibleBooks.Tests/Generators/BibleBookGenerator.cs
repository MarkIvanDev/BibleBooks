using System.Collections;

namespace BibleBooks.Tests.Generators;

internal class BibleBookGenerator : IEnumerable<TheoryDataRow<BibleBook>>
{
    private readonly List<TheoryDataRow<BibleBook>> _data =
    [
        .. Enum.GetValues<BibleBook>()
    ];

    public IEnumerator<TheoryDataRow<BibleBook>> GetEnumerator() => _data.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
