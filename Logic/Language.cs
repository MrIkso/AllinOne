
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace AllInOne.Logic
{
    public static class Language
    {
        public static string current;

        public static string plugin_name = "";
        public static string plugin_delete = "";
        public static string plugin_delete_antianalytics = "";
        public static string plugin_delete_googlebanner = "";
        public static string plugin_delete_internet = "";
        public static string plugin_delete_emulator = "";
        public static string plugin_delete_location = "";
        public static string plugin_delete_gms = "";
        public static string plugin_delete_receiver = "";
        public static string plugin_delete_toast = "";
        public static string plugin_signcheck = "";
        public static string plugin_signcheck_ref = "";
        public static string plugin_signcheck_binsign = "";
        public static string plugin_signcheck_binsignInst = "";
        public static string plugin_license = "";
        public static string plugin_inst = "";
        public static string plugin_splash = "";
        public static string plugin_splash_inst = "";
        public static string plugin_splash_rem = "";
        public static string plugin_other = "";
        public static string plugin_other_addsave = "";
        public static string plugin_other_dex = "";
        public static string plugin_other_fullscreen = "";
        public static string plugin_other_hideicon = "";
        public static string plugin_other_root = "";
        public static string plugin_other_toastfr = "";
        public static string plugin_other_toastfr_text = "";
        public static string plugin_other_minsdk = "";
        public static string plugin_other_instlocation = "";
        public static string plugin_other_collectstrings = "";
        public static string plugin_other_mockloc = "";
        public static string plugin_other_screenshot_secure = "";
        public static string plugin_other_back_kill = "";
        public static string plugin_other_back_kill_one_click = "";
        public static string plugin_other_back_kill_double_tap = "";
        public static string plugin_other_back_kill_long_tap = "";
        public static string plugin_themes = "";
        public static string plugin_themes_d = "";
        public static string plugin_themes_l = "";
        public static string plugin_replace = "";
        public static string plugin_replace_all_auto = "";
        public static string plugin_replace_all_man = "";
        public static string plugin_replace_time = "";
        public static string plugin_order_patches = "";
        public static string instloc_extern = "";
        public static string instloc_intern = "";
        public static string tab_main = "";
        public static string tab_help = "";
        public static string disMenuMessage = "";
        public static string disMenuButtonText = "";
        public static string disMenuButtonTextDone = "";
        public static string clearButtonText = "";
        public static string errorMsg = "";
        public static string errorMsgRsa = "";
        public static string errorMsgNoLaunchActivity = "";
        public static string errorMsgNoSplash = "";
        public static string errorMsgTime = "";
        public static string errorMsgCollect = "";
        public static string errorMsgNotExist = "";
        public static string orderDone = "";
        public static string notFound = "";
        public static string showAllItems = "";
        public static string startQueue = "";
        public static string helpSmaliButtonText = "";
        public static string googleMapsRepair = "";
        public static string DebugCheckboxText = "";
        public static string addDebugInfo = "";
        public static string remDebugInfo = "";
        public static string noUpdate = "";
        public static string deleteAutoStart = "";
        public static string writeDebug = "";
        public static string saveCheckboxes = "";
        public static string refLog = "";
        public static string analLayout = "";
        public static string analActivity = "";
        public static string analReceiver = "";
        public static string analService = "";
        public static string analLinks = "";
        public static string analMethod = "";
        public static string analFirebase = "";
        public static string emptyInputApk = "";
        public static string openFolder = "";
        public static string author = "";
        public static string version = "";
        public static string donate = "";
        public static string yandexMoney = "";
        public static string Link = "";
        public static string openFolderError = "";
        public static string inProcess = "";
        public static string tools = "";
        //public static string layoutIds = "";
        public static string uncheckAllCheckboxes = "";
        public static string hideSelected = "";
        public static string InterestingPlaces = "";
        public static string filterLabel = "";
        public static string caseSens = "";
        public static string listOfAllIds = "";
        public static string deleteRes = "";
        public static string mergeStrings = "";
        public static string mergeWithReplace = "";
        public static string mergeFrom, mergeTo = "";
        public static string replaced, added = "";
        public static string cloneApk, cloneError, delResError = "";
        public static string corruptedFileError = "";
        public static string blockSensors = "";
        public static string newAutchor = "";
        public static string settings = "";
        public static string mapskey = "";
        public static string adslink = "";
        public static string texteditorpatch = "";
        public static string tskcount = "";
        public static string texteditoroptions = "";
        public static string search_asset = "";
        public static string search_lib = "";
        public static string language = "";
        public static string closeSettings_button = "";
        public static string deleteDebug = "";
        public static string authorLabel2 = "";
        public static string authorLabel3 = "";
        public static string buildDate = "";
        public static string mainTabPage = "";
        public static string replaceTabPage = "";
        public static string helpbutton = "";
        public static string error = "";
        public static string log_interesing_placed = "";
        public static string log_interesing_done = "";
        public static string tooltip_double_click = "";
        public static string plugin_restart = "";
        public static string plugin_restart_message = "";
        public static string debug_message = "";
        public static string debug_message_height = "";
        public static string debug_message_width = "";
        public static string log_patched = "";
        public static string log_remove_dbg_info = "";
        public static string log_remove_dbg_info_done = "";
        public static string log_add_dbg_info = "";
        public static string log_add_dbg_info_done = "";
        public static string log_add_smali_secondary_info = "";
        public static string log_add_smali_secondary_info_done = "";
        public static string log_collecting_string = "";
        public static string log_collecting_string_done = "";
        public static string log_hide_id = "";
        public static string log_hide_id_done = "";
        public static string log_delete_resource = "";
        public static string log_delete_resource_lib = "";
        public static string log_delete_resource_done = "";
        public static string log_from = "";
        public static string log_to = "";
        public static string log_clone = "";
        public static string log_clone_done = "";
        public static string log_auto_replace = "";
        public static string log_auto_replace_done = "";
        public static string log_manual_replace = "";
        public static string log_manual_replace_done = "";
        public static string log_merge_string = "";
        public static string log_merge_string_done = "";


        public static void Load(string lng)
        {
            List<LangItem> langFile = new List<LangItem>();//new LanguageFile();
            current = lng;
            if (File.Exists(Program.pathToMyPluginDir + "\\language\\" + lng + ".xml"))
            {
                XmlSerializer xmlS = new XmlSerializer(typeof(List<LangItem>), new Type[] { typeof(LangItem)});
                FileStream fs = new FileStream(Program.pathToMyPluginDir + "\\language\\" + lng + ".xml", FileMode.Open);
                langFile = (List<LangItem>)xmlS.Deserialize(fs);
                fs.Close();
            }
            else//английский по умолчанию
            {
                current = "english";
                XmlSerializer xmlS = new XmlSerializer(typeof(List<LangItem>), new Type[] { typeof(LangItem) });
                FileStream fs = new FileStream(Program.pathToMyPluginDir + "\\language\\english.xml", FileMode.Open);
                langFile = (List<LangItem>)xmlS.Deserialize(fs);
                fs.Close();
            }

            Type langType = typeof(Language);
            foreach (FieldInfo field in langType.GetFields())
            {
                if (field.Name.Equals("current")) { continue; }

                foreach (LangItem item in langFile)
                {
                    if (field.Name.Equals(item.name))
                    {
                        field.SetValue(null, item.value);
                    }
                }
            }
        }
    }

   
}
