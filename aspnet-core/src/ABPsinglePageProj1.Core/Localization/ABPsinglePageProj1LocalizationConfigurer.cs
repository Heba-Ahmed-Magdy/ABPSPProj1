using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ABPsinglePageProj1.Localization
{
    public static class ABPsinglePageProj1LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ABPsinglePageProj1Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ABPsinglePageProj1LocalizationConfigurer).GetAssembly(),
                        "ABPsinglePageProj1.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
