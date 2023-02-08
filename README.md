# BibleBooks
A library to get info about bible books.

It supports Standard & Thompson abbreviations, OSIS & Paratext codes, max chapters, alternative names, and localized names.

## Features

### Supported bible book info:
- Book name
- Alternative book name
- OSIS code
- Paratext code
- Standard abbreviation
- Thompson abbreviation
- Max chapter

### Supported Locales
- English
- Filipino

## Usage

You can use the `BibleBooksHelper` static class to retrieve the book's info.

```csharp
using BibleBooks;

var books = (BibleBook[])Enum.GetValues(typeof(BibleBook));
foreach (var book in books) {
  // Standard abbreviation
  Console.WriteLine(BibleBooksHelper.GetStandardAbbreviation(book));
  
  // Thompson abbreviation
  Console.WriteLine(BibleBooksHelper.GetThompsonAbbreviation(book));
  
  // OSIS code
  Console.WriteLine(BibleBooksHelper.GetOsisCode(book));
  
  // Paratext code
  Console.WriteLine(BibleBooksHelper.GetParatextCode(book));
  
  // Max chapter
  Console.WriteLine(BibleBooksHelper.GetMaxChapter(book));
  
  // Alternative book names
  Console.WriteLine(string.Join(",", BibleBooksHelper.GetAlternativeNames(book)));
  
  // Book name - default locale
  Console.WriteLine(BibleBooksHelper.GetName(book));
  
  // Book name - English (en) locale
  Console.WriteLine(BibleBooksHelper.GetName(book, CultureInfos.En));
  
  // Book name - Filipino (fil) locale
  Console.WriteLine(BibleBooksHelper.GetName(book, CultureInfos.Fil));
}
```

## Support
If you like my work and want to support me, buying me a coffee would be awesome! Thanks for your support!

<a href="https://www.buymeacoffee.com/markivandev" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/v2/default-blue.png" alt="Buy Me A Coffee" style="height: 60px !important;width: 217px !important;" ></a>

---------
**Mark Ivan Basto** &bullet; **GitHub**
**[@MarkIvanDev](https://github.com/MarkIvanDev)** &bullet; **Twitter**
**[@Rivolvan_Speaks](https://twitter.com/Rivolvan_Speaks)**