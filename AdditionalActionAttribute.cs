using System;

namespace TranslatorApkPluginLib
{
    /// <summary>
    /// Атрибут плагина
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class AdditionalActionAttribute : Attribute
    {
    }
}
