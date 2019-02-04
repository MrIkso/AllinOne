using System;
using System.Diagnostics;
using System.IO;
using System.Xml;

namespace AllInOne.Logic
{
    public static class Settings
    {
        public static bool writeDebug;
        public static bool deleteDebug;
        public static string GoogleMapsApiKey;
        public static string ReplaceLinksTo;
        public static string language;
        public static string textEditorPath;
        public static string textEditorArgs;
        public static bool searchAssetsFiles;
        public static bool searchLibFiles;
        public static int TaskCount;

        //чтение настроек
        public static void Load()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(new FileInfo(Process.GetCurrentProcess().MainModule.FileName).DirectoryName + "\\settings.xml");
            XmlNode root = doc.SelectSingleNode("root");
            XmlNode settings = root.SelectSingleNode("settings");

            foreach (XmlNode settingsItem in settings)
            {
                if (settingsItem.NodeType == XmlNodeType.Comment) { continue; }
                switch (settingsItem.Attributes[0].Value)
                {
                    case "GoogleMapsApiKey":
                        GoogleMapsApiKey = settingsItem.InnerText;
                        break;
                    case "ReplaceLinksTo":
                        ReplaceLinksTo = settingsItem.InnerText;
                        break;
                    case "language":
                        language = settingsItem.InnerText;
                        break;
                    case "taskCount":
                        TaskCount = int.Parse(settingsItem.InnerText);
                        break;
                    case "textEditorPath":
                        textEditorPath = settingsItem.InnerText;
                        break;
                    case "textEditorArgs":
                        textEditorArgs = settingsItem.InnerText;
                        break;
                    case "searchAssetsFiles":
                        searchAssetsFiles = Boolean.Parse(settingsItem.InnerText);
                        break;
                    case "searchLibFiles":
                        searchLibFiles = Boolean.Parse(settingsItem.InnerText);
                        break;
                    case "debug":
                        writeDebug = Boolean.Parse(settingsItem.InnerText);
                        break;
                    case "delDebugLog":
                        deleteDebug = Boolean.Parse(settingsItem.InnerText);
                        break;
                }
            }
        }
        //сохранение настроек
        public static void Save()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Program.pathToMyPluginDir + "\\settings.xml");
            XmlNode root = doc.SelectSingleNode("root");
            XmlNode settings = root.SelectSingleNode("settings");

            foreach (XmlNode settingsItem in settings)
            {
                if (settingsItem.NodeType == XmlNodeType.Comment) { continue; }
                switch (settingsItem.Attributes[0].Value)
                {
                    case "debug":
                        settingsItem.InnerText = writeDebug.ToString();
                        //debugEnabled = Boolean.Parse(settingsItem.InnerText);
                        //debugCb.Checked = Program.debugEnabled;
                        break;
                    case "delDebugLog":
                        settingsItem.InnerText = deleteDebug.ToString();
                        break;

                }
            }

            doc.Save(Program.pathToMyPluginDir + "\\settings.xml");
        }
    }
}
