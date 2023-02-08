dotnet clean .\BibleBooks\BibleBooks\BibleBooks.csproj --configuration Release
dotnet build .\BibleBooks\BibleBooks\BibleBooks.csproj --configuration Release

$nuspecs = gci .\nuspecs\*.nuspec
foreach ($nuspec in $nuspecs)
{
	dotnet pack .\BibleBooks\BibleBooks\BibleBooks.csproj -p:NuspecFile=$($nuspec.FullName) --configuration Release --no-build
}