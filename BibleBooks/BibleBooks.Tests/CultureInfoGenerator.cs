using System.Collections;

namespace BibleBooks.Tests
{
    public class CultureInfoGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>()
        {
            new object[] { CultureInfos.En },
            new object[] { CultureInfos.FilPH },
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
