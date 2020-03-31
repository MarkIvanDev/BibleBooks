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

        public static string GetName(Key key, CultureInfo culture = null)
        {
            return Names.Books.ResourceManager.GetString(key.ToString(), culture ?? Names.Books.Culture);
        }

        public static Key? GetKeyForName(string name, CultureInfo culture = null)
        {
            foreach (var item in GetNames(culture))
            {
                if (item.Value.Equals(name))
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
                yield return new KeyValuePair<Key, string>(key.Value, Names.Books.ResourceManager.GetString(key.Key, culture ?? Names.Books.Culture));
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
                if (item.Value.Equals(code))
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
                yield return new KeyValuePair<Key, string>(key.Value, Codes.OSIS.ResourceManager.GetString(key.Key));
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
                if (item.Value.Equals(code))
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
                yield return new KeyValuePair<Key, string>(key.Value, Codes.Paratext.ResourceManager.GetString(key.Key));
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
                if (item.Value.Equals(abbreviation))
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
                yield return new KeyValuePair<Key, string>(key.Value, Abbreviations.Standard.ResourceManager.GetString(key.Key, culture ?? Abbreviations.Standard.Culture));
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
                if(item.Value.Equals(abbreviation))
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
                yield return new KeyValuePair<Key, string>(key.Value, Abbreviations.Thompson.ResourceManager.GetString(key.Key, culture ?? Abbreviations.Thompson.Culture));
            }
        }
    }
}
