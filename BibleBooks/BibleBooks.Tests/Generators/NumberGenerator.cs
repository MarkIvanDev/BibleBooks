using System.Collections;

namespace BibleBooks.Tests.Generators;
internal class NumberGenerator : IEnumerable<TheoryDataRow<Number>>
{
    private readonly List<TheoryDataRow<Number>> _data =
    [
        .. Enum.GetValues<Number>()
    ];

    public IEnumerator<TheoryDataRow<Number>> GetEnumerator() => _data.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
