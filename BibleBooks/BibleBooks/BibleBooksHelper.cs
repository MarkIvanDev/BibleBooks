using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BibleBooks
{
    public static class BibleBooksHelper
    {
        private static readonly Dictionary<string, BibleBook> keys;

        static BibleBooksHelper()
        {
            keys = ((BibleBook[])Enum.GetValues(typeof(BibleBook))).ToDictionary(k => k.ToString(), k => k);
        }

        public static string GetNumber(Number number, CultureInfo culture = null)
        {
            return Names.Numbers.ResourceManager.GetString(number.ToString(), culture ?? Names.Numbers.Culture);
        }

        public static string GetName(BibleBook key, CultureInfo culture = null)
        {
            return Names.Books.ResourceManager.GetString(key.ToString(), culture ?? Names.Books.Culture);
        }

        public static BibleBook? GetKeyForName(string name, CultureInfo culture = null)
        {
            foreach (var item in GetNames(culture))
            {
                if (item.Value.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                {
                    return item.Key;
                }
            }
            return null;
        }

        public static IEnumerable<KeyValuePair<BibleBook, string>> GetNames(CultureInfo culture = null)
        {
            foreach (var key in keys)
            {
                yield return new KeyValuePair<BibleBook, string>(key.Value, GetName(key.Value, culture));
            }
        }

        public static string GetAlternativeName(BibleBook key, CultureInfo culture = null)
        {
            return Names.Alternative.ResourceManager.GetString(key.ToString(), culture ?? Names.Alternative.Culture);
        }

        public static BibleBook? GetKeyForAlternativeName(string alternativeName, CultureInfo culture = null)
        {
            foreach (var item in GetAlternativeNames(culture))
            {
                if (item.Value.Equals(alternativeName, StringComparison.CurrentCultureIgnoreCase))
                {
                    return item.Key;
                }
            }
            return null;
        }

        public static IEnumerable<KeyValuePair<BibleBook, string>> GetAlternativeNames(CultureInfo culture = null)
        {
            foreach (var key in keys)
            {
                yield return new KeyValuePair<BibleBook, string>(key.Value, GetAlternativeName(key.Value, culture));
            }
        }

        public static string GetOsisCode(BibleBook key)
        {
            return Codes.OSIS.ResourceManager.GetString(key.ToString());
        }

        public static BibleBook? GetKeyForOsisCode(string code)
        {
            foreach (var item in GetOsisCodes())
            {
                if (item.Value.Equals(code, StringComparison.CurrentCultureIgnoreCase))
                {
                    return item.Key;
                }
            }
            return null;
        }

        public static IEnumerable<KeyValuePair<BibleBook, string>> GetOsisCodes()
        {
            foreach (var key in keys)
            {
                yield return new KeyValuePair<BibleBook, string>(key.Value, GetOsisCode(key.Value));
            }
        }

        public static string GetParatextCode(BibleBook key)
        {
            return Codes.Paratext.ResourceManager.GetString(key.ToString());
        }

        public static BibleBook? GetKeyForParatextCode(string code)
        {
            foreach (var item in GetParatextCodes())
            {
                if (item.Value.Equals(code, StringComparison.CurrentCultureIgnoreCase))
                {
                    return item.Key;
                }
            }
            return null;
        }

        public static IEnumerable<KeyValuePair<BibleBook, string>> GetParatextCodes()
        {
            foreach (var key in keys)
            {
                yield return new KeyValuePair<BibleBook, string>(key.Value, GetParatextCode(key.Value));
            }
        }

        public static string GetStandardAbbreviation(BibleBook key, CultureInfo culture = null)
        {
            return Abbreviations.Standard.ResourceManager.GetString(key.ToString(), culture ?? Abbreviations.Standard.Culture);
        }

        public static BibleBook? GetKeyForStandardAbbreviation(string abbreviation, CultureInfo culture = null)
        {
            foreach (var item in GetStandardAbbreviations(culture))
            {
                if (item.Value.Equals(abbreviation, StringComparison.CurrentCultureIgnoreCase) ||
                    $"{item.Value}.".Equals(abbreviation, StringComparison.CurrentCultureIgnoreCase))
                {
                    return item.Key;
                }
            }
            return null;
        }

        public static IEnumerable<KeyValuePair<BibleBook, string>> GetStandardAbbreviations(CultureInfo culture = null)
        {
            foreach (var key in keys)
            {
                yield return new KeyValuePair<BibleBook, string>(key.Value, GetStandardAbbreviation(key.Value, culture));
            }
        }

        public static string GetThompsonAbbreviation(BibleBook key, CultureInfo culture = null)
        {
            return Abbreviations.Thompson.ResourceManager.GetString(key.ToString(), culture ?? Abbreviations.Thompson.Culture);
        }

        public static BibleBook? GetKeyForThompsonAbbreviation(string abbreviation, CultureInfo culture = null)
        {
            foreach (var item in GetThompsonAbbreviations(culture))
            {
                if(item.Value.Equals(abbreviation, StringComparison.CurrentCultureIgnoreCase) ||
                   $"{item.Value}.".Equals(abbreviation, StringComparison.CurrentCultureIgnoreCase))
                {
                    return item.Key;
                }
            }
            return null;
        }

        public static IEnumerable<KeyValuePair<BibleBook, string>> GetThompsonAbbreviations(CultureInfo culture = null)
        {
            foreach (var key in keys)
            {
                yield return new KeyValuePair<BibleBook, string>(key.Value, GetThompsonAbbreviation(key.Value, culture));
            }
        }

        public static int GetMaxChapter(BibleBook key)
        {
            if (int.TryParse(Metadata.Chapters.ResourceManager.GetString(key.ToString()), out var maxChapter))
            {
                return maxChapter;
            }
            return int.MaxValue;
        }
    }
}
