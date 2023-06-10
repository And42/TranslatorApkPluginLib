using System;

namespace TranslatorApkPluginLib
{
    /// <summary>
    /// Интерфейс нового сервися перевода
    /// </summary>
    public interface ITranslateService
    {
        /// <summary>
        /// Возвращает название сервиса
        /// </summary>
        string GetServiceName();

        /// <summary>
        /// Возвращает guid сервиса перевода
        /// </summary>
        Guid Guid { get; }

        /// <summary>
        /// Переводит текст на требуемый язык
        /// </summary>
        /// <param name="text">Текст</param>
        /// <param name="targetLanguage">Язык в двубуквенном формате</param>
        /// <param name="apiKey">Ключ api</param>
        string Translate(string text, string targetLanguage, string apiKey);
    }
}
