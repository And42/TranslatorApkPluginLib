using System;
using System.Collections.Generic;

namespace TranslatorApkPluginLib
{
    /// <summary>
    /// Интерфейс нового плагина
    /// </summary>
    public interface IAdditionalAction
    {
        ///// <summary>
        ///// Действия, относящиеся к этой кнопке
        ///// </summary>
        //IEnumerable<IAdditionalAction> Actions { get; }

        /// <summary>
        /// Возвращает название плагина
        /// </summary>
        string GetActionTitle();

        /// <summary>
        /// Возвращает guid плагина
        /// </summary>
        Guid Guid { get; }

        /// <summary>
        /// Выполняется при нажатии на кнопку плагина в окне программы
        /// </summary>
        /// <param name="pathToApk">Путь к текущему apk</param>
        /// <param name="pathToProjectFolder">Путь к папке текущего проекта</param>
        /// <param name="pathToCompiledApk">Путь к скомпилированному файлу</param>
        /// <param name="pathToSignedApk">Путь к подписанному файлу</param>
        /// <param name="pathToResourcesFolder">Путь к папке с ресурсами основной программы (StartFolder\Files\Resources)</param>
        /// <param name="pathToFilesFolder">Путь к папке с файлами основной программы (StartFolder\Files)</param>
        /// <param name="pathToPortableJava">Путь к портативной java</param>
        /// <param name="pathToApktool"></param>
        /// <param name="pathToPluginFolder">Путь к папке плагина</param>
        void Process(string pathToApk, string pathToProjectFolder, string pathToCompiledApk, string pathToSignedApk, string pathToResourcesFolder, string pathToFilesFolder, string pathToPortableJava, string pathToApktool, /*Action<string> loggingFuction, Action clearLog,*/ string pathToPluginFolder);
    }
}
