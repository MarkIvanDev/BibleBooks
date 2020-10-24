using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BibleBooks
{
    public static class BibleBooksHelper
    {
        private static readonly Dictionary<string, Key> keys;

        static BibleBooksHelper()
        {
            keys = ((Key[])Enum.GetValues(typeof(Key))).ToDictionary(k => k.ToString(), k => k);
        }

        public static string GetNumber(Number number, CultureInfo culture = null)
        {
            return Names.Numbers.ResourceManager.GetString(number.ToString(), culture ?? Names.Numbers.Culture);
        }

        public static string GetName(Key key, CultureInfo culture = null)
        {
            return Names.Books.ResourceManager.GetString(key.ToString(), culture ?? Names.Books.Culture);
        }

        public static Key? GetKeyForName(string name, CultureInfo culture = null)
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

        public static IEnumerable<KeyValuePair<Key, string>> GetNames(CultureInfo culture = null)
        {
            foreach (var key in keys)
            {
                yield return new KeyValuePair<Key, string>(key.Value, GetName(key.Value, culture));
            }
        }

        public static string GetAlternativeName(Key key, CultureInfo culture = null)
        {
            return Names.Alternative.ResourceManager.GetString(key.ToString(), culture ?? Names.Alternative.Culture);
        }

        public static Key? GetKeyForAlternativeName(string alternativeName, CultureInfo culture = null)
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

        public static IEnumerable<KeyValuePair<Key, string>> GetAlternativeNames(CultureInfo culture = null)
        {
            foreach (var key in keys)
            {
                yield return new KeyValuePair<Key, string>(key.Value, GetAlternativeName(key.Value, culture));
            }
        }

        public static string GetOsisCode(Key key)
        {
            return Codes.OSIS.ResourceManager.GetString(key.ToString());
        }

        public static Key? GetKeyForOsisCode(string code)
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

        public static IEnumerable<KeyValuePair<Key, string>> GetOsisCodes()
        {
            foreach (var key in keys)
            {
                yield return new KeyValuePair<Key, string>(key.Value, GetOsisCode(key.Value));
            }
        }

        public static string GetParatextCode(Key key)
        {
            return Codes.Paratext.ResourceManager.GetString(key.ToString());
        }

        public static Key? GetKeyForParatextCode(string code)
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

        public static IEnumerable<KeyValuePair<Key, string>> GetParatextCodes()
        {
            foreach (var key in keys)
            {
                yield return new KeyValuePair<Key, string>(key.Value, GetParatextCode(key.Value));
            }
        }

        public static string GetStandardAbbreviation(Key key, CultureInfo culture = null)
        {
            return Abbreviations.Standard.ResourceManager.GetString(key.ToString(), culture ?? Abbreviations.Standard.Culture);
        }

        public static Key? GetKeyForStandardAbbreviation(string abbreviation, CultureInfo culture = null)
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

        public static IEnumerable<KeyValuePair<Key, string>> GetStandardAbbreviations(CultureInfo culture = null)
        {
            foreach (var key in keys)
            {
                yield return new KeyValuePair<Key, string>(key.Value, GetStandardAbbreviation(key.Value, culture));
            }
        }

        public static string GetThompsonAbbreviation(Key key, CultureInfo culture = null)
        {
            return Abbreviations.Thompson.ResourceManager.GetString(key.ToString(), culture ?? Abbreviations.Thompson.Culture);
        }

        public static Key? GetKeyForThompsonAbbreviation(string abbreviation, CultureInfo culture = null)
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

        public static IEnumerable<KeyValuePair<Key, string>> GetThompsonAbbreviations(CultureInfo culture = null)
        {
            foreach (var key in keys)
            {
                yield return new KeyValuePair<Key, string>(key.Value, GetThompsonAbbreviation(key.Value, culture));
            }
        }

        public static int GetMaxChapter(Key key)
        {
            if (int.TryParse(Metadata.Chapters.ResourceManager.GetString(key.ToString()), out var maxChapter))
            {
                return maxChapter;
            }
            return int.MaxValue;
        }
    }
}
