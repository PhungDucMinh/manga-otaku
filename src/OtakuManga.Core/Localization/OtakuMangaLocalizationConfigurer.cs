using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace OtakuManga.Localization
{
    public static class OtakuMangaLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(OtakuMangaConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(OtakuMangaLocalizationConfigurer).GetAssembly(),
                        "OtakuManga.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
