using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BibleBooks
{
    public static class BibleBooksHelper
    {
        private static readonly BibleBook[] books;

        static BibleBooksHelper()
        {
            books = (BibleBook[])Enum.GetValues(typeof(BibleBook));
        }

        public static IEnumerable<KeyValuePair<BibleBook, string>> GetAllNames(CultureInfo? culture = null)
        {
            foreach (var book in books)
            {
                yield return new KeyValuePair<BibleBook, string>(book, GetName(book, culture) ?? "");
            }
        }

        public static string? GetName(BibleBook book, CultureInfo? culture = null)
        {
            return ResourceManagers.Books.GetString(book.ToString(), culture);
        }

        public static BibleBook? GetKeyForName(string? name, CultureInfo? culture = null)
        {
            foreach (var item in GetAllNames(culture))
            {
                if (IsEqual(item.Value, name?.Trim(), culture))
                {
                    return item.Key;
                }
            }
            return null;
        }

        public static IEnumerable<KeyValuePair<BibleBook, IList<string>>> GetAllAlternativeNames(CultureInfo? culture = null)
        {
            foreach (var book in books)
            {
                yield return new KeyValuePair<BibleBook, IList<string>>(book, GetAlternativeNames(book, culture));
            }
        }

        public static IList<string> GetAlternativeNames(BibleBook book, CultureInfo? culture = null)
        {
            var names = ResourceManagers.Alternative.GetString(book.ToString(), culture);
            return string.IsNullOrEmpty(names) ? Array.Empty<string>() : names.Split('|');
        }

        public static BibleBook? GetKeyForAlternativeName(string? alternativeName, CultureInfo? culture = null)
        {
            foreach (var item in GetAllAlternativeNames(culture))
            {
                if (item.Value.Any(i => IsEqual(i, alternativeName?.Trim(), culture)))
                {
                    return item.Key;
                }
            }
            return null;
        }

        public static IEnumerable<KeyValuePair<BibleBook, string>> GetAllOsisCodes()
        {
            foreach (var book in books)
            {
                yield return new KeyValuePair<BibleBook, string>(book, GetOsisCode(book) ?? "");
            }
        }

        public static string? GetOsisCode(BibleBook book)
        {
            return ResourceManagers.OSIS.GetString(book.ToString());
        }

        public static BibleBook? GetKeyForOsisCode(string? code)
        {
            foreach (var item in GetAllOsisCodes())
            {
                if (item.Value.Equals(code?.Trim(), StringComparison.CurrentCultureIgnoreCase))
                {
                    return item.Key;
                }
            }
            return null;
        }

        public static IEnumerable<KeyValuePair<BibleBook, string>> GetAllParatextCodes()
        {
            foreach (var book in books)
            {
                yield return new KeyValuePair<BibleBook, string>(book, GetParatextCode(book) ?? "");
            }
        }

        public static string? GetParatextCode(BibleBook book)
        {
            return ResourceManagers.Paratext.GetString(book.ToString());
        }

        public static BibleBook? GetKeyForParatextCode(string? code)
        {
            foreach (var item in GetAllParatextCodes())
            {
                if (item.Value.Equals(code?.Trim(), StringComparison.CurrentCultureIgnoreCase))
                {
                    return item.Key;
                }
            }
            return null;
        }

        public static IEnumerable<KeyValuePair<BibleBook, string>> GetAllStandardAbbreviations(CultureInfo? culture = null)
        {
            foreach (var book in books)
            {
                yield return new KeyValuePair<BibleBook, string>(book, GetStandardAbbreviation(book, culture) ?? "");
            }
        }

        public static string? GetStandardAbbreviation(BibleBook book, CultureInfo? culture = null)
        {
            return ResourceManagers.Standard.GetString(book.ToString(), culture);
        }

        public static BibleBook? GetKeyForStandardAbbreviation(string? abbreviation, CultureInfo? culture = null)
        {
            var abbr = abbreviation?.Trim();
            foreach (var item in GetAllStandardAbbreviations(culture))
            {
                if (IsEqual(item.Value, abbr, culture) ||
                    IsEqual($"{item.Value}.", abbr, culture))
                {
                    return item.Key;
                }
            }
            return null;
        }

        public static IEnumerable<KeyValuePair<BibleBook, string>> GetAllThompsonAbbreviations(CultureInfo? culture = null)
        {
            foreach (var book in books)
            {
                yield return new KeyValuePair<BibleBook, string>(book, GetThompsonAbbreviation(book, culture) ?? "");
            }
        }

        public static string? GetThompsonAbbreviation(BibleBook book, CultureInfo? culture = null)
        {
            return ResourceManagers.Thompson.GetString(book.ToString(), culture);
        }

        public static BibleBook? GetKeyForThompsonAbbreviation(string? abbreviation, CultureInfo? culture = null)
        {
            var abbr = abbreviation?.Trim();
            foreach (var item in GetAllThompsonAbbreviations(culture))
            {
                if (IsEqual(item.Value, abbr, culture) ||
                    IsEqual($"{item.Value}.", abbr, culture))
                {
                    return item.Key;
                }
            }
            return null;
        }

        public static IEnumerable<KeyValuePair<BibleBook, int>> GetAllMaxChapters()
        {
            foreach (var book in books)
            {
                yield return new KeyValuePair<BibleBook, int>(book, GetMaxChapter(book) ?? 0);
            }
        }

        public static int? GetMaxChapter(BibleBook book)
        {
            if (int.TryParse(ResourceManagers.Chapters.GetString(book.ToString()), out var maxChapter))
            {
                return maxChapter;
            }
            return null;
        }

        public static string? GetNumber(Number number, CultureInfo? culture = null)
        {
            return ResourceManagers.Numbers.GetString(number.ToString(), culture);
        }

        private static bool IsEqual(string? a, string? b, CultureInfo? culture = null)
        {
            var comparer = culture?.CompareInfo?.GetStringComparer(CompareOptions.IgnoreCase) ?? StringComparer.OrdinalIgnoreCase;
            return comparer.Equals(a, b);
        }

    }
}
