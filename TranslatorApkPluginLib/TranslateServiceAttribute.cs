using System;

namespace TranslatorApkPluginLib
{
    /// <summary>
    /// Атрибут сервиса перевода
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class TranslateServiceAttribute : Attribute
    {
    }
}
