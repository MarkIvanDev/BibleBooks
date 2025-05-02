using System.Resources;

namespace BibleBooks;

internal static class ResourceManagers
{
    // Abbreviations
    public static ResourceManager Standard { get; } = new ResourceManager("BibleBooks.Abbreviations.Standard.Standard", typeof(ResourceManagers).Assembly);
    public static ResourceManager Thompson { get; } = new ResourceManager("BibleBooks.Abbreviations.Thompson.Thompson", typeof(ResourceManagers).Assembly);

    // Codes
    public static ResourceManager OSIS { get; } = new ResourceManager("BibleBooks.Codes.OSIS.OSIS", typeof(ResourceManagers).Assembly);
    public static ResourceManager Paratext { get; } = new ResourceManager("BibleBooks.Codes.Paratext.Paratext", typeof(ResourceManagers).Assembly);

    // Metadata
    public static ResourceManager Chapters { get; } = new ResourceManager("BibleBooks.Metadata.Chapters.Chapters", typeof(ResourceManagers).Assembly);

    // Names
    public static ResourceManager Alternative { get; } = new ResourceManager("BibleBooks.Names.Alternative.Alternative", typeof(ResourceManagers).Assembly);
    public static ResourceManager Books { get; } = new ResourceManager("BibleBooks.Names.Books.Books", typeof(ResourceManagers).Assembly);
    public static ResourceManager Numbers { get; } = new ResourceManager("BibleBooks.Names.Numbers.Numbers", typeof(ResourceManagers).Assembly);
}
