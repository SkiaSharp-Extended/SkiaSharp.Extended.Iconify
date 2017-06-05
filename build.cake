#addin "Cake.FileHelpers"

var target = Argument("target", "Default");

var FontAwesomeVersion = "4.7.0";
var FontAwesomeStyleUrl = string.Format("https://raw.githubusercontent.com/FortAwesome/Font-Awesome/v{0}/css/font-awesome.min.css", FontAwesomeVersion);
var FontAwesomeFontUrl = string.Format("https://raw.githubusercontent.com/FortAwesome/Font-Awesome/v{0}/fonts/fontawesome-webfont.ttf", FontAwesomeVersion);

// var EntypoUrl = "https://dl.dropboxusercontent.com/u/4339492/entypo.zip";

var IonIconsVersion = "2.0.1";
var IonIconsStyleUrl = string.Format("https://raw.githubusercontent.com/ionic-team/ionicons/v{0}/css/ionicons.min.css", IonIconsVersion);
var IonIconsFontUrl = string.Format("https://raw.githubusercontent.com/ionic-team/ionicons/v{0}/fonts/ionicons.ttf", IonIconsVersion);

var MaterialDesignIconsVersion = "1.9.32";
var MaterialDesignIconsStyleUrl = string.Format("http://cdn.materialdesignicons.com/{0}/css/materialdesignicons.min.css", MaterialDesignIconsVersion);
var MaterialDesignIconsFontUrl = string.Format("http://cdn.materialdesignicons.com/{0}/fonts/materialdesignicons-webfont.ttf", MaterialDesignIconsVersion);

var MaterialIconsVersion = "3.0.1";
var MaterialIconsStyleUrl = string.Format("https://raw.githubusercontent.com/google/material-design-icons/{0}/iconfont/codepoints", MaterialIconsVersion);
var MaterialIconsFontUrl = string.Format("https://github.com/google/material-design-icons/raw/{0}/iconfont/MaterialIcons-Regular.ttf", MaterialIconsVersion);

var MeteoconsUrl = "http://www.alessioatzeni.com/meteocons/res/download/meteocons-font.zip";

var SimpleLineIconsVersion = "2.4.1";
var SimpleLineIconsStyleUrl = string.Format("https://raw.githubusercontent.com/thesabbir/simple-line-icons/{0}/css/simple-line-icons.css", SimpleLineIconsVersion);
var SimpleLineIconsFontUrl = string.Format("https://raw.githubusercontent.com/thesabbir/simple-line-icons/{0}/fonts/Simple-Line-Icons.ttf", SimpleLineIconsVersion);

var TypiconsVersion = "2.0.9";
var TypiconsStyleUrl = string.Format("https://raw.githubusercontent.com/stephenhutchings/typicons.font/v{0}/src/font/typicons.min.css", TypiconsVersion);
var TypiconsFontUrl = string.Format("https://raw.githubusercontent.com/stephenhutchings/typicons.font/v{0}/src/font/typicons.ttf", TypiconsVersion);

var WeatherIconsVersion = "2.0.10";
var WeatherIconsStyleUrl = string.Format("https://raw.githubusercontent.com/erikflowers/weather-icons/{0}/css/weather-icons.min.css", WeatherIconsVersion);
var WeatherIconsStyleWindUrl = string.Format("https://raw.githubusercontent.com/erikflowers/weather-icons/{0}/css/weather-icons-wind.min.css", WeatherIconsVersion);
var WeatherIconsFontUrl = string.Format("https://raw.githubusercontent.com/erikflowers/weather-icons/{0}/font/weathericons-regular-webfont.ttf", WeatherIconsVersion);

Task("Externals")
    .Does(() =>
{
    // download all the styles

    // FontAwesome
    EnsureDirectoryExists("./externals/FontAwesome/");
    if (!FileExists("./externals/FontAwesome/font-awesome.min.css"))
        DownloadFile(FontAwesomeStyleUrl, "./externals/FontAwesome/font-awesome.min.css");
    if (!FileExists("./externals/FontAwesome/fontawesome-webfont.ttf"))
        DownloadFile(FontAwesomeFontUrl, "./externals/FontAwesome/fontawesome-webfont.ttf");

    // // Entypo
    // EnsureDirectoryExists("./externals/Entypo/");
    // if (!FileExists("./externals/Entypo/Entypo.zip")) DownloadFile(EntypoUrl, "./externals/Entypo/Entypo.zip");
    // Unzip("./externals/Entypo/Entypo.zip", "./externals/Entypo/Entypo/");

    // IonIcons
    EnsureDirectoryExists("./externals/IonIcons/");
    if (!FileExists("./externals/IonIcons/ionicons.min.css"))
        DownloadFile(IonIconsStyleUrl, "./externals/IonIcons/ionicons.min.css");
    if (!FileExists("./externals/IonIcons/ionicons.ttf"))
        DownloadFile(IonIconsFontUrl, "./externals/IonIcons/ionicons.ttf");

    // MaterialDesignIcons
    EnsureDirectoryExists("./externals/MaterialDesignIcons/");
    if (!FileExists("./externals/MaterialDesignIcons/materialdesignicons.min.css"))
        DownloadFile(MaterialDesignIconsStyleUrl, "./externals/MaterialDesignIcons/materialdesignicons.min.css");
    if (!FileExists("./externals/MaterialDesignIcons/materialdesignicons-webfont.ttf"))
        DownloadFile(MaterialDesignIconsFontUrl, "./externals/MaterialDesignIcons/materialdesignicons-webfont.ttf");

    // MaterialIcons
    EnsureDirectoryExists("./externals/MaterialIcons/");
    if (!FileExists("./externals/MaterialIcons/codepoints"))
        DownloadFile(MaterialIconsStyleUrl, "./externals/MaterialIcons/codepoints");
    if (!FileExists("./externals/MaterialIcons/MaterialIcons-Regular.ttf"))
        DownloadFile(MaterialIconsFontUrl, "./externals/MaterialIcons/MaterialIcons-Regular.ttf");

    // Meteocons
    EnsureDirectoryExists("./externals/Meteocons/");
    if (!FileExists("./externals/Meteocons/meteocons-font.zip"))
        DownloadFile(MeteoconsUrl, "./externals/Meteocons/meteocons-font.zip");
    if (!FileExists("./externals/Meteocons/meteocons-font/FONT/Font-face/meteocons-webfont.ttf"))
        Unzip("./externals/Meteocons/meteocons-font.zip", "./externals/Meteocons/");

    // SimpleLineIcons
    EnsureDirectoryExists("./externals/SimpleLineIcons/");
    if (!FileExists("./externals/SimpleLineIcons/simple-line-icons.css"))
        DownloadFile(SimpleLineIconsStyleUrl, "./externals/SimpleLineIcons/simple-line-icons.css");
    if (!FileExists("./externals/SimpleLineIcons/Simple-Line-Icons.ttf"))
        DownloadFile(SimpleLineIconsFontUrl, "./externals/SimpleLineIcons/Simple-Line-Icons.ttf");

    // Typicons
    EnsureDirectoryExists("./externals/Typicons/");
    if (!FileExists("./externals/Typicons/typicons.min.css"))
        DownloadFile(TypiconsStyleUrl, "./externals/Typicons/typicons.min.css");
    if (!FileExists("./externals/Typicons/typicons.ttf"))
        DownloadFile(TypiconsFontUrl, "./externals/Typicons/typicons.ttf");

    // WeatherIcons
    EnsureDirectoryExists("./externals/WeatherIcons/");
    if (!FileExists("./externals/WeatherIcons/weather-icons.min.css"))
        DownloadFile(WeatherIconsStyleUrl, "./externals/WeatherIcons/weather-icons.min.css");
    if (!FileExists("./externals/WeatherIcons/weather-icons-wind.min.css"))
        DownloadFile(WeatherIconsStyleWindUrl, "./externals/WeatherIcons/weather-icons-wind.min.css");
    if (!FileExists("./externals/WeatherIcons/weathericons-regular-webfont.ttf"))
        DownloadFile(WeatherIconsFontUrl, "./externals/WeatherIcons/weathericons-regular-webfont.ttf");
    if (!FileExists("./externals/WeatherIcons/weather-icons.css")) {
        CopyFile("./externals/WeatherIcons/weather-icons.min.css", "./externals/WeatherIcons/weather-icons.css");
        FileAppendText("./externals/WeatherIcons/weather-icons.css", FileReadText("./externals/WeatherIcons/weather-icons-wind.min.css"));
    }
});

Task("Build")
    .IsDependentOn("Externals")
    .Does(() =>
{
    var GenerateIconifySource = new Action<FilePath, string, string>((stylesheet, type, codepointType) => {
        var iconify = MakeAbsolute((FilePath)"./output/IconifyGenerator/iconify.exe");
        var iconifyResult = StartProcess(iconify, new ProcessSettings {
            Arguments = new ProcessArgumentBuilder()
                .AppendSwitchQuoted("-o", "=", stylesheet.GetDirectory().CombineWithFilePath(type + ".generated.cs").FullPath)
                .AppendSwitchQuoted("-n", "SkiaSharp.Extended.Iconify")
                .AppendSwitchQuoted("-t", type)
                .AppendSwitchQuoted("-c", "=", codepointType)
                .AppendQuoted(stylesheet.FullPath)
        });
        if (iconifyResult != 0) {
            throw new Exception("iconify.exe failed.");
        }
    });

    // first build the generator
    NuGetRestore("./source/IconifyGenerator.sln");
    DotNetBuild("./source/IconifyGenerator.sln", settings => settings.SetConfiguration("Release"));

    // copy generator to output
    EnsureDirectoryExists("./output/");
    CopyDirectory("./source/IconifyGenerator/bin/Release", "./output/IconifyGenerator/");

    // then, run the generator on the styles
    GenerateIconifySource("externals/FontAwesome/font-awesome.min.css", "FontAwesome", "css");
    GenerateIconifySource("externals/IonIcons/ionicons.min.css", "IonIcons", "css");
    GenerateIconifySource("externals/MaterialDesignIcons/materialdesignicons.min.css", "MaterialDesignIcons", "css");
    GenerateIconifySource("externals/MaterialIcons/codepoints", "MaterialIcons", "codepoints");
    GenerateIconifySource("externals/SimpleLineIcons/simple-line-icons.css", "SimpleLineIcons", "css");
    GenerateIconifySource("externals/Typicons/typicons.min.css", "Typicons", "css");
    GenerateIconifySource("externals/WeatherIcons/weather-icons.css", "WeatherIcons", "css");

    // now build the libraries
    NuGetRestore("./source/SkiaSharp.Extended.Iconify.sln");
    DotNetBuild("./source/SkiaSharp.Extended.Iconify.sln", settings => settings.SetConfiguration("Release"));

    // copy to output
    EnsureDirectoryExists("./output/");
    CopyFileToDirectory("./source/SkiaSharp.Extended.Iconify/bin/Release/SkiaSharp.Extended.Iconify.dll", "./output/");
    CopyFileToDirectory("./source/SkiaSharp.Extended.Iconify.FontAwesome/bin/Release/SkiaSharp.Extended.Iconify.FontAwesome.dll", "./output/");
    CopyFileToDirectory("./source/SkiaSharp.Extended.Iconify.IonIcons/bin/Release/SkiaSharp.Extended.Iconify.IonIcons.dll", "./output/");
    CopyFileToDirectory("./source/SkiaSharp.Extended.Iconify.MaterialDesignIcons/bin/Release/SkiaSharp.Extended.Iconify.MaterialDesignIcons.dll", "./output/");
    CopyFileToDirectory("./source/SkiaSharp.Extended.Iconify.MaterialIcons/bin/Release/SkiaSharp.Extended.Iconify.MaterialIcons.dll", "./output/");
    CopyFileToDirectory("./source/SkiaSharp.Extended.Iconify.Meteocons/bin/Release/SkiaSharp.Extended.Iconify.Meteocons.dll", "./output/");
    CopyFileToDirectory("./source/SkiaSharp.Extended.Iconify.SimpleLineIcons/bin/Release/SkiaSharp.Extended.Iconify.SimpleLineIcons.dll", "./output/");
    CopyFileToDirectory("./source/SkiaSharp.Extended.Iconify.Typicons/bin/Release/SkiaSharp.Extended.Iconify.Typicons.dll", "./output/");
    CopyFileToDirectory("./source/SkiaSharp.Extended.Iconify.WeatherIcons/bin/Release/SkiaSharp.Extended.Iconify.WeatherIcons.dll", "./output/");
});

Task("Clean")
    .Does(() =>
{
    CleanDirectories ("./source/*/bin");
    CleanDirectories ("./source/*/obj");
    CleanDirectories ("./source/packages");

    CleanDirectories ("./samples/*/bin");
    CleanDirectories ("./samples/*/obj");
    CleanDirectories ("./samples/packages");
    CleanDirectories ("./samples/*/AppPackages");
    DeleteFiles ("./samples/*/project.lock.json");
    CleanDirectories ("./samples/*/*/bin");
    CleanDirectories ("./samples/*/*/obj");
    CleanDirectories ("./samples/*/packages");
    CleanDirectories ("./samples/*/*/AppPackages");
    DeleteFiles ("./samples/*/*/project.lock.json");

    if (DirectoryExists ("./externals"))
        DeleteDirectory ("./externals", true);

    if (DirectoryExists ("./output"))
        DeleteDirectory ("./output", true);
});

Task("Default")
    .IsDependentOn("Build");

RunTarget(target);
