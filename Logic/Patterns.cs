using System;
using System.Collections.Generic;
using System.IO;

namespace AllInOne.Logic
{
    public static class Patterns
    {
        public static string[] AdvModules;
        private static string AdvModulesSmali, AdvModulesXml, smaliUrls, smaliExactMatchUrls, activityNames, recservNames, methodNames, idNames;
        public static Dictionary<string, string> linksPattern, linksExactMatchPattern, methodsPatterns, activityPatterns, servicePatterns, receiverPatterns, LayoutPatterns;

        public static void LoadPatterns()
        {
            AdvModules = File.ReadAllLines(Program.pathToMyPluginDir + "\\antiADS\\AdvModules.txt");
            AdvModulesSmali = String.Join("|", AdvModules);
            AdvModulesXml = AdvModulesSmali.Replace("/", "\\.");
            methodNames = String.Join("|", File.ReadAllLines(Program.pathToMyPluginDir + "\\antiADS\\methodNames.txt"));
            smaliUrls = String.Join("|", File.ReadAllLines(Program.pathToMyPluginDir + "\\antiADS\\urls.txt"));
            smaliExactMatchUrls = String.Join("|", File.ReadAllLines(Program.pathToMyPluginDir + "\\antiADS\\urls_exact_match.txt"));
            activityNames = String.Join("|", File.ReadAllLines(Program.pathToMyPluginDir + "\\antiADS\\activityNames.txt"));
            recservNames = String.Join("|", File.ReadAllLines(Program.pathToMyPluginDir + "\\antiADS\\receiverServiceNames.txt"));
            idNames = String.Join("|", File.ReadAllLines(Program.pathToMyPluginDir + "\\antiADS\\idNames.txt"));
            

            linksPattern = new Dictionary<string, string>
            {
                {@"const-string(.+)([pv]\d+), \""(https*:|//).+("+smaliUrls+@").*\""",
                "const-string$1$2, \""+Settings.ReplaceLinksTo+"\""},
                {@"\.field(.+):Ljava/lang/String; = \""(https*:|//).+("+smaliUrls+@").*\""",
                ".field$1:Ljava/lang/String; = \""+Settings.ReplaceLinksTo+"\""}
            };

            linksExactMatchPattern = new Dictionary<string, string>
            {
                {@"const-string(.+)([pv]\d+), \"".+("+smaliExactMatchUrls+@").*\""",
                "const-string$1$2, \""+Settings.ReplaceLinksTo+"\""},
                {@"\.field(.+):Ljava/lang/String; = \"".+("+smaliExactMatchUrls+@").*\""",
                ".field$1:Ljava/lang/String; = \""+Settings.ReplaceLinksTo+"\""}
            };


            methodsPatterns = new Dictionary<string, string>
            {
                { @"const-string(.+)([pv]\d+), \""ca-app-pub.+?\""",
                "const-string$1$2, \"ca-app-pub-0000000000000000~0000000000\""},
                {@"([ais]*get-object.*Lcom/google/android/gms/(?:internal|ads).*)[\r\n]+\s+invoke-.+Landroid/.*;->addView\([^\)]*\)V",
                "$1"},
                {@"const/(\d+) ([pv]\d+), 0x(4|0)[\r\n]+\s+invoke-virtual \{([pv]\d+), ([pv]\d+)\}, Lcom/google/android/gms/ads/AdView;->setVisibility\(I\)V",
                "const $2, 0x8\n\n    invoke-virtual {$4, $2}, Lcom/google/android/gms/ads/AdView;->setVisibility(I)V"},
                {@"const/*\d* ([pv]\d+), 0x(?:4|0)[\r\n]+\s+(invoke-.+(?:/ads/|/adview|/ad/|Interstitial|banner|" + AdvModulesSmali + @").*;->setVisibility\([^\)]*\))",
                "const $1, 0x8\n\n    $2"},
                {@"invoke-.*(" + AdvModulesSmali + @").*;->(" + methodNames + @")\(.*\)V",
                "invoke-static {}, Lcom/PinkiePie;->DianePie()V"},
                {@"invoke-.*(" + AdvModulesSmali + @").*;->(" + methodNames + @")\(.*\)Z",
                "invoke-static {}, Lcom/PinkiePie;->DianePieNull()Z"},
                {@"invoke-.*Lcom/google/android/gms/ads.*;->a\(Lcom/google/android/gms/ads/AdRequest;.*\)V",
                "invoke-static {}, Lcom/PinkiePie;->DianePie()V"},
                {@"invoke-.+;->(addHtmlAdView|animateAdView|bannerAdmobMainActivity|expandAd|internalLoadAd|loadAd|loadAds|loadBannerAd|loadChildAds|loadInterstitial|loadInterstitialAd|loadNativeAd|loadNativeAds|loadNextAd|loadVideoAds|mraidVideoAddendumInterstitialShow|nativeAdLoaded|preloadAd|preloadNativeAdImage|refreshAds|requestAd|requestBannerAd|requestInterstitial|requestInterstitialAd|showAd|showAdInActivity|showAdinternal|showAsInterstitial|showBanner|showInterstitial|showAds)\(.*\)V",        "invoke-static {}, Lcom/PinkiePie;->DianePie()V"},
                {@"invoke-.+Lcom/flurry/.+;->(onStartSession|onEndSession|onEvent|logEvent)\(.+",
                "invoke-static {}, Lcom/PinkiePie;->DianePie()V"},
                {@"invoke-.+Lcom/google/android/gms/(internal|ads).*;->addView\([^\)]*\)V",
                "invoke-static {}, Lcom/PinkiePie;->DianePie()V"},
                {@"invoke-super(.+);->getAdSize\(\)(.+)AdSize;[\r\n]+\s+move-result-object ([pv]\d+)",
                "invoke-super$1;->getAdSize()$2AdSize;\n\n    const $3, 0x0"}
            };

            activityPatterns = new Dictionary<string, string>
            {
                {@"[\r\n]+\s+<activity.*android:name=\"".*(" + activityNames + "|" + AdvModulesXml + @").*>(?<!/>)(\r|\n|.)+?</activity>",
                ""},
                {@"[\r\n]+\s+<activity.*android:name=\"".*(" + activityNames + "|" + AdvModulesXml + @").*/>",
                ""}
            };
            servicePatterns = new Dictionary<string, string>
            {
                {@"[\r\n]+\s+<service.*android:name=\"".*(" + recservNames + "|" + activityNames + "|" + AdvModulesXml + @").*>(?<!/>)(\r|\n|.)+?</service>",
                ""},
                {@"[\r\n]+\s+<service.*android:name=\"".*(" + recservNames + "|" + activityNames + "|" + AdvModulesXml + @").*/>",
                ""},
                {@"[\r\n\s]+<service[^>]+>(?<!/>)([\r\n\s]+<meta-data[^>]*>)*?[\r\n\s]+<intent-filter>[\r\n\s]+(<(category|data)[^>]*>[\r\n\s]+)*?<action.+android:name=\""[^\""]*(analytics|AppMeasurement|campaign|measurement|metrica|tracking)[^\""]*\""[^>]*>[\r\n\s]+(<(category|data)[^>]*>[\r\n\s]+)*?</intent-filter>[\r\n\s]+(<meta-data[^>]*>[\r\n\s]+)*?</service>", ""}
            };
            receiverPatterns = new Dictionary<string, string>
            {
                {@"[\r\n]+\s+<receiver.*android:name=\"".*(" + recservNames + "|" + activityNames + "|" + AdvModulesXml + @").*>(?<!/>)(\r|\n|.)+?</receiver>",
                ""},
                {@"[\r\n]+\s+<receiver.*android:name=\"".*(" + recservNames + "|" + activityNames + "|" + AdvModulesXml + @").*/>",
                ""},
                {@"[\r\n\s]+<receiver[^>]+>(?<!/>)([\r\n\s]+<meta-data[^>]*>)*?[\r\n\s]+<intent-filter>[\r\n\s]+(<(category|data)[^>]*>[\r\n\s]+)*?<action.+android:name=\""[^\""]*(analytics|AppMeasurement|campaign|measurement|metrica|tracking)[^\""]*\""[^>]*>[\r\n\s]+(<(category|data)[^>]*>[\r\n\s]+)*?</intent-filter>[\r\n\s]+(<meta-data[^>]*>[\r\n\s]+)*?</receiver>", ""}
            };

            LayoutPatterns = new Dictionary<string, string>
            {
                {@"(android|n\d+):visibility=\""(?:visible|invisible)\""(.*)((?:android|n\d+):id=\""@id/(?:" + idNames + @")\"")",       "$1:visibility=\"gone\"$2$3"},
                {@"((android|n\d+):id=\""@id/(?:" + idNames + @")\"")(.*)(android|n\d+):visibility=\""(?:visible|invisible)\""",       "$1$3$4:visibility=\"gone\""},
                {@"(?<!visibility.*)((android|n\d+):id=\""@id/(?:" + idNames + @")\"")(?!.*visibility)",                               "$1 $2:visibility=\"gone\""},
                {@"(android|n\d+):layout_(height)=\""[^\""]+\""(.*)((?:android|n\d+):id=\""@id/(?:" + idNames + @")\"")",                "$1:layout_$2=\"0.0dip\"$3$4"},
                {@"(android|n\d+):layout_(width)=\""[^\""]+\""(.*)((?:android|n\d+):id=\""@id/(?:" + idNames + @")\"")",                 "$1:layout_$2=\"0.0dip\"$3$4"},
                {@"((?:android|n\d+):id=\""@id/(?:" + idNames + @")\"")(.*)(android|n\d+):layout_(height)=\""[^\""]+\""",                "$1$2$3:layout_$4=\"0.0dip\""},
                {@"((?:android|n\d+):id=\""@id/(?:" + idNames + @")\"")(.*)(android|n\d+):layout_(width)=\""[^\""]+\""",                 "$1$2$3:layout_$4=\"0.0dip\""},
                {@"(<[^\s]*(?:" + AdvModulesXml + @").+)(android|n\d+):layout_(height)=\""[^\""]+\""",                                      "$1$2:layout_$3=\"0.0dip\""},
                {@"(<[^\s]*(?:" + AdvModulesXml + @").+)(android|n\d+):layout_(width)=\""[^\""]+\""",                                       "$1$2:layout_$3=\"0.0dip\""},
                {@"(<[^\s]*(?:" + AdvModulesXml + @")[^\s]*)(?!.*?:visibility)(.*?\s(android|n\d+):\w+=\""[^\""]+\"")",                     "$1$2 $3:visibility=\"gone\""},
                {@"(<[^\s]*(?:" + AdvModulesXml + @")[^\s]*)(.*)(android|n\d+):visibility=\""(?:visible|invisible)\""",                     "$1$2$3:visibility=\"gone\""}
            };
    }

        public static Dictionary<string, string> adviewPatterns = new Dictionary<string, string>
        {
            {@"\.method.+synthetic (.+)\(Lcom/google/android/gms/ads/AdRequest;\)V[\r\n]+\s+\.locals.+(\r|\n|.)+?end method.*",
                ".method public final bridge synthetic $1(Lcom/google/android/gms/ads/AdRequest;)V\n    .locals 2\n    return-void\n.end method"},
            {@"\.method.+synthetic (.+)\(\)Lcom/google/android/gms/ads/AdSize;(\r|\n|.)+?end method",
                ".method public final bridge synthetic $1()Lcom/google/android/gms/ads/AdSize;\n    .locals 2\n    const v0, 0x0\n    return-object v0\n.end method"}
        };

        public static Dictionary<string, string> NativeExpressAdViewPatterns = new Dictionary<string, string>
        {
            {@"\.method.+synthetic (.+)\(Lcom/google/android/gms/ads/AdRequest;\)V[\r\n]+\s+\.locals.+(\r|\n|.)+?end method.*",
                ".method public final bridge synthetic $1(Lcom/google/android/gms/ads/AdRequest;)V\n    .locals 2\n    return-void\n.end method"}
        };

        public static Dictionary<string, string> firebasePatterns = new Dictionary<string, string>
        {
            {@"[\r\n]+\s+<activity.*android:name=\"".*firebase.*>(?<!/>)(\r|\n|.)+?</activity>",
                ""},
            {@"[\r\n]+\s+<activity.*android:name=\"".*firebase.*/>",
                ""},
            {@"[\r\n]+\s+<service.*android:name=\"".*firebase.*>(?<!/>)(\r|\n|.)+?</service>",
                ""},
            {@"[\r\n]+\s+<service.*android:name=\"".*firebase.*/>",
                ""},
            {@"[\r\n\s]+<service[^>]+>(?<!/>)([\r\n\s]+<meta-data[^>]*>)*?[\r\n\s]+<intent-filter>[\r\n\s]+(<(category|data)[^>]*>[\r\n\s]+)*?<action.+android:name=\""[^\""]*(firebase)[^\""]*\""[^>]*>[\r\n\s]+(<(category|data)[^>]*>[\r\n\s]+)*?</intent-filter>[\r\n\s]+(<meta-data[^>]*>[\r\n\s]+)*?</service>", ""},
            {@"[\r\n]+\s+<receiver.*android:name=\"".*firebase.*>(?<!/>)(\r|\n|.)+?</receiver>",
                ""},
            {@"[\r\n]+\s+<receiver.*android:name=\"".*firebase.*/>",
                ""},
            {@"[\r\n\s]+<receiver[^>]+>(?<!/>)([\r\n\s]+<meta-data[^>]*>)*?[\r\n\s]+<intent-filter>[\r\n\s]+(<(category|data)[^>]*>[\r\n\s]+)*?<action.+android:name=\""[^\""]*(firebase)[^\""]*\""[^>]*>[\r\n\s]+(<(category|data)[^>]*>[\r\n\s]+)*?</intent-filter>[\r\n\s]+(<meta-data[^>]*>[\r\n\s]+)*?</receiver>", ""}
        };

        public static Dictionary<string, string> ManifestPatterns = new Dictionary<string, string>
        {
            {@"\""ca-app-pub[^\""]*\""",
                "\"ca-app-pub-0000000000000000~0000000000\""},
            {@"<meta-data(.+)android:name=\""com\.crashlytics\.ApiKey\""(.+)android:value=\"".+\""(.*)/>",
            "<meta-data$1android:name=\"com.crashlytics.ApiKey\"$2android:value=\"Deleted By AllInOne\"$3/>"},
            {@"<meta-data(.+)android:name=\""io\.fabric\.ApiKey\""(.+)android:value=\"".+\""(.*)/>",
            "<meta-data$1android:name=\"io.fabric.ApiKey\"$2android:value=\"Deleted By AllInOne\"$3/>"},
            {@"<meta-data(.+)android:name=\""com\.montexi\.sdk\.FLURRY_KEY\""(.+)android:value=\"".+\""(.*)/>",
            "<meta-data$1android:name=\"com.montexi.sdk.FLURRY_KEY\"$2android:value=\"Deleted By AllInOne\"$3/>"}
        };

        public static Dictionary<string, string> XmlPatterns = new Dictionary<string, string>
        {
            {@"\""ca-app-pub[^\""]*\""",    "\"ca-app-pub-0000000000000000~0000000000\""},
            {@">ca-app-pub[^<]*</",        ">ca-app-pub-0000000000000000~0000000000</"}
        };

        public static Dictionary<string, string> adsModulesOnly = new Dictionary<string, string>
        {
            {@"invoke-.+Landroid/widget/Toast;->show\(\)V",                                               ""},
            {@"invoke-.*Landroid/net/NetworkInfo;->isConnected\(\)Z[\r\n]+\s+move-result ([pv]\d+)",      "const $1, 0x0"},
            {@"invoke-.+Landroid/app/AlertDialog;->show\(\)V", ""},
            {@"invoke.+Landroid/net/NetworkInfo;->isConnectedOrConnecting\(\)Z[\r\n\s]+move-result ([pv]\d+)","const $1, 0x0"}
        };

        public static Dictionary<string, string> InstallerGoogle = new Dictionary<string, string>
        {
            {@"invoke-virtual \{([pv]\d+), ([pv]\d+)\}, Landroid/content/pm/PackageManager;->getInstallerPackageName\(Ljava/lang/String;\)Ljava/lang/String;[\r\n]+\s+:try_end_(\d+)[\r\n]+\s+\.catch Ljava/io/IOException; \{:try_start_(\d+) \.\. :try_end_(\d+)\} :catch_(\d+)[\r\n]+\s+move-result-object ([pv]\d+)",
                "invoke-virtual {$1, $2}, Landroid/content/pm/PackageManager;->getInstallerPackageName(Ljava/lang/String;)Ljava/lang/String;\n\n    :try_end_$3\n    .catch Ljava/io/IOException; {:try_start_$4 .. :try_end_$5} :catch_$6\n    const-string $7, \"com.android.vending\""},
            {@"invoke-virtual \{([pv]\d+), ([pv]\d+)\}, Landroid/content/pm/PackageManager;->getInstallerPackageName\(Ljava/lang/String;\)Ljava/lang/String;[\r\n]+\s+move-result-object ([pv]\d+)", 
                "invoke-virtual {$1, $2}, Landroid/content/pm/PackageManager;->getInstallerPackageName(Ljava/lang/String;)Ljava/lang/String;\n\n    const-string $3, \"com.android.vending\""}
        };

        public static Dictionary<string, string> InstallerAmazon = new Dictionary<string, string>
        {
            {@"invoke-virtual \{([pv]\d+), ([pv]\d+)\}, Landroid/content/pm/PackageManager;->getInstallerPackageName\(Ljava/lang/String;\)Ljava/lang/String;[\r\n]+\s+:try_end_(\d+)[\r\n]+\s+\.catch Ljava/io/IOException; \{:try_start_(\d+) \.\. :try_end_(\d+)\} :catch_(\d+)[\r\n]+\s+move-result-object ([pv]\d+)",
                "invoke-virtual {$1, $2}, Landroid/content/pm/PackageManager;->getInstallerPackageName(Ljava/lang/String;)Ljava/lang/String;\n\n    :try_end_$3\n    .catch Ljava/io/IOException; {:try_start_$4 .. :try_end_$5} :catch_$6\n    const-string $7, \"com.amazon\""},
            {@"invoke-virtual \{([pv]\d+), ([pv]\d+)\}, Landroid/content/pm/PackageManager;->getInstallerPackageName\(Ljava/lang/String;\)Ljava/lang/String;[\r\n]+\s+move-result-object ([pv]\d+)",
                "invoke-virtual {$1, $2}, Landroid/content/pm/PackageManager;->getInstallerPackageName(Ljava/lang/String;)Ljava/lang/String;\n\n    const-string $3, \"com.amazon\""}
        };

        public static Dictionary<string, string> LicensePatchGoogle = new Dictionary<string, string>
        {
            {@"invoke-virtual \{([pv]\d+), ([pv]\d+)\}, Ljava/security/Signature;->verify\(\[B\)Z[\r\n]+\s+move-result ([pv]\d+)",
                "invoke-virtual {$1, $2}, Ljava/security/Signature;->verify([B)Z\n\n    const/4 $3, 0x1"},
            {@"invoke-virtual \{([pv]\d+), ([pv]\d+)\}, Landroid/content/pm/PackageManager;->(getInstallerPackageName|InstallerPackageName)\(Ljava/lang/String;\)Ljava/lang/String;[\r\n]+\s+:try_end_(.+)[\r\n]+\s+\.catch (.+); \{:try_start_(.+) \.\. \:try_end_(.+)\} :catch_(.+)[\r\n]+\s+move-result-object ([pv]\d+)",
                "invoke-virtual {$1, $2}, Landroid/content/pm/PackageManager;->$3(Ljava/lang/String;)Ljava/lang/String;\n\n    :try_end_$4\n\n    .catch $5; {:try_start_$6 .. :try_end_$7} :catch_$8\n\n    const-string $9, \"com.android.vending\""},
            {@"invoke-virtual \{([pv]\d+), ([pv]\d+)\}, Landroid/content/pm/PackageManager;->(getInstallerPackageName|InstallerPackageName)\(Ljava/lang/String;\)Ljava/lang/String;[\r\n]+\s+move-result-object ([pv]\d+)",
                "invoke-virtual {$1, $2}, Landroid/content/pm/PackageManager;->$3(Ljava/lang/String;)Ljava/lang/String;\n\n    const-string $4, \"com.android.vending\""},
            {@"const-string ([pv]\d+), \""com\.android\.vending\.licensing\.ILicenseResultListener\""[\r\n]+\s+invoke-virtual \{([pv]\d+), ([pv]\d+)\}, Landroid/os/Parcel;->enforceInterface\(Ljava/lang/String;\)V[\r\n]+\s+invoke-virtual \{([pv]\d+)\}, Landroid/os/Parcel;->readInt\(\)I[\r\n]+\s+move-result ([pv]\d+)[\r\n]+\s+invoke-virtual \{([pv]\d+)\}, Landroid/os/Parcel;->readString\(\)Ljava/lang/String;[\r\n]+\s+move-result-object ([pv]\d+)[\r\n]+\s+invoke-virtual \{([pv]\d+)\}, Landroid/os/Parcel;->readString\(\)Ljava/lang/String;[\r\n]+\s+move-result-object ([pv]\d+)[\r\n]+\s+invoke-virtual \{([pv]\d+), ([pv]\d+), ([pv]\d+), ([pv]\d+)\}, (.+);->a\(ILjava/lang/String;Ljava/lang/String;\)V",
                "const-string $1, \"com.android.vending.licensing.ILicenseResultListener\"\n\n    invoke-virtual {$2, $1}, Landroid/os/Parcel;->enforceInterface(Ljava/lang/String;)V\n\n    const/4 $11, 0x0\n\n    invoke-virtual {$6}, Landroid/os/Parcel;->readString()Ljava/lang/String;\n\n    move-result-object $12\n\n    invoke-static {$12}, LfixLicense;->reworkRequestCode(Ljava/lang/String;)Ljava/lang/String;\n\n    move-result-object $12\n\n    const-string $13, \"hL9GqWwZL35OoLxZQN1EYmyylu3zmf8umnXW4P0EPqGjV0QcRYjD+NtiqoDEmxnnocvrqA7Z/0v+i0O4cwgOsD7/Tg3B1QI/ukA7ZUcibvFQUNoq7KjUWSg1Qn5MauaFFhAhZbuP840wnCuntxVDUkVJ6GDymDXLqhFG1LbZmNoPl6QjkschEBLVth1YtBxE4GnbVVI8Cq5LY7/F0N8d6EGLIISD6ekoD4lkhxq3nORsibX7kjmotyhLpO7THNMXvOeXeKhVp6dNSblOHp9tcL6l/NJY7sHPw/DBSxteW2hZ9y7yyaMxMAz+nTIN/V8gJXzeaRlmIXntJpQDEMz5pQ==\"\n\n    invoke-virtual {$10, $11, $12, $13}, $14;->a(ILjava/lang/String;Ljava/lang/String;)V"},
            {@"const-string ([pv]\d+), \""com\.android\.vending\.licensing\.ILicenseResultListener\""[\r\n]+\s+invoke-virtual \{([pv]\d+), ([pv]\d+)\}, Landroid/os/Parcel;->enforceInterface\(Ljava/lang/String;\)V[\r\n]+\s+invoke-virtual \{([pv]\d+)\}, Landroid/os/Parcel;->readInt\(\)I[\r\n]+\s+move-result ([pv]\d+)[\r\n]+\s+invoke-virtual \{([pv]\d+)\}, Landroid/os/Parcel;->readString\(\)Ljava/lang/String;[\r\n]+\s+move-result-object ([pv]\d+)[\r\n]+\s+invoke-virtual \{([pv]\d+)\}, Landroid/os/Parcel;->readString\(\)Ljava/lang/String;[\r\n]+\s+move-result-object ([pv]\d+)[\r\n]+\s+invoke-virtual \{([pv]\d+), ([pv]\d+), ([pv]\d+), ([pv]\d+)\}, (.+);->(.)\(ILjava/lang/String;Ljava/lang/String;\)V",
                "const-string $1, \"com.android.vending.licensing.ILicenseResultListener\"\n\n    invoke-virtual {$2, $3}, Landroid/os/Parcel;->enforceInterface(Ljava/lang/String;)V\n\n    const/4 $11, 0x0\n\n    invoke-virtual {$6}, Landroid/os/Parcel;->readString()Ljava/lang/String;\n\n    move-result-object $7\n\n    invoke-static {$7}, LfixLicense;->reworkRequestCode(Ljava/lang/String;)Ljava/lang/String;\n\n    move-result-object $12\n\n    const-string $13, \"hL9GqWwZL35OoLxZQN1EYmyylu3zmf8umnXW4P0EPqGjV0QcRYjD+NtiqoDEmxnnocvrqA7Z/0v+i0O4cwgOsD7/Tg3B1QI/ukA7ZUcibvFQUNoq7KjUWSg1Qn5MauaFFhAhZbuP840wnCuntxVDUkVJ6GDymDXLqhFG1LbZmNoPl6QjkschEBLVth1YtBxE4GnbVVI8Cq5LY7/F0N8d6EGLIISD6ekoD4lkhxq3nORsibX7kjmotyhLpO7THNMXvOeXeKhVp6dNSblOHp9tcL6l/NJY7sHPw/DBSxteW2hZ9y7yyaMxMAz+nTIN/V8gJXzeaRlmIXntJpQDEMz5pQ==\"\n\n    invoke-virtual {$10, $11, $12, $13}, $14;->$15(ILjava/lang/String;Ljava/lang/String;)V"},
            {@"const-string ([pv]\d+), \""com\.android\.vending\.licensing\.ILicenseResultListener\""[\r\n]+\s+invoke-virtual \{([pv]\d+), ([pv]\d+)\}, Landroid/os/Parcel;->enforceInterface\(Ljava/lang/String;\)V[\r\n]+\s+invoke-virtual \{([pv]\d+)\}, Landroid/os/Parcel;->readInt\(\)I[\r\n]+\s+move-result ([pv]\d+)[\r\n]+\s+invoke-virtual \{([pv]\d+)\}, Landroid/os/Parcel;->readString\(\)Ljava/lang/String;[\r\n]+\s+move-result-object ([pv]\d+)[\r\n]+\s+invoke-virtual \{([pv]\d+)\}, Landroid/os/Parcel;->readString\(\)Ljava/lang/String;[\r\n]+\s+move-result-object ([pv]\d+)[\r\n]+\s+invoke-virtual \{([pv]\d+), ([pv]\d+), ([pv]\d+), ([pv]\d+)\}, (.+);->(.+)\(ILjava/lang/String;Ljava/lang/String;\)V",
                "const-string $1, \"com.android.vending.licensing.ILicenseResultListener\"\n\n    invoke-virtual {$2, $3}, Landroid/os/Parcel;->enforceInterface(Ljava/lang/String;)V\n\n    const/4 $11, 0x0\n\n    invoke-virtual {$6}, Landroid/os/Parcel;->readString()Ljava/lang/String;\n\n    move-result-object $7\n\n    invoke-static {$7}, LfixLicense;->reworkRequestCode(Ljava/lang/String;)Ljava/lang/String;\n\n    move-result-object $12\n\n    const-string $13, \"hL9GqWwZL35OoLxZQN1EYmyylu3zmf8umnXW4P0EPqGjV0QcRYjD+NtiqoDEmxnnocvrqA7Z/0v+i0O4cwgOsD7/Tg3B1QI/ukA7ZUcibvFQUNoq7KjUWSg1Qn5MauaFFhAhZbuP840wnCuntxVDUkVJ6GDymDXLqhFG1LbZmNoPl6QjkschEBLVth1YtBxE4GnbVVI8Cq5LY7/F0N8d6EGLIISD6ekoD4lkhxq3nORsibX7kjmotyhLpO7THNMXvOeXeKhVp6dNSblOHp9tcL6l/NJY7sHPw/DBSxteW2hZ9y7yyaMxMAz+nTIN/V8gJXzeaRlmIXntJpQDEMz5pQ==\"\n\n    invoke-virtual {$10, $11, $12, $13}, $14;->$15(ILjava/lang/String;Ljava/lang/String;)V"},
            {@"if-eq ([pv]\d+), ([pv]\d+), :cond_(.+)[\r\n]+\s+const-string ([pv]\d+), \""LicenseValidator\""[\r\n]+\s+const-string ([pv]\d+), \""AajRXYtBCdn42cl9GZgU2Yu9mT\""",
                "goto :cond_$3\n\n    const-string $4, \"LicenseValidator\"\n\n    const-string $5, \"AajRXYtBCdn42cl9GZgU2Yu9mT\""},
            {@"if-eq ([pv]\d+), ([pv]\d+), :cond_(.+)[\r\n]+\s+const-string ([pv]\d+), \""LicenseValidator\""[\r\n]+\s+const-string ([pv]\d+), \""Nonce doesn(.+)\.\""",
                "goto :cond_$3\n\n    const-string $4, \"LicenseValidator\"\n\n    const-string $5, \"Nonce doesn$6.\""},
            {@"if-eq ([pv]\d+), ([pv]\d+), :cond_(.+)[\r\n]+\s+const-string ([pv]\d+), \""LicenseValidator\""[\r\n]+\s+const-string ([pv]\d+), \""(.+)\""[\r\n]+\s+const-string ([pv]\d+), \""(.+)\""[\r\n]+\s+const-string ([pv]\d+), \""Nonce doesn(.+)\.\""",
                "goto :cond_$3\n\n    const-string $4, \"LicenseValidator\"\n\n    const-string $5, \"$6\"\n\n    const-string $7, \"$8\"\n\n    const-string $9, \"Nonce doesn$10.\""},
            {@"if-eq ([pv]\d+), ([pv]\d+), :cond_(.+)[\r\n]+\s+const-string ([pv]\d+), \""(.+)\""[\r\n]+\s+const-string ([pv]\d+), \""Nonce doesn(.+)\.\""",
                "goto :cond_$3\n\n    const-string $4, \"$5\"\n\n    const-string $6, \"Nonce doesn$7.\""},
            {@"if-eq ([pv]\d+), ([pv]\d+), :cond_(.+)[\r\n]+\s+const-string ([pv]\d+), \""Nonce doesn(.+)\.\""",
                "goto :cond_$3\n\n    const-string $4, \"Nonce doesn$5.\""}
        };

        public static Dictionary<string, string> LicensePatchAmazon = new Dictionary<string, string>
        {
            {@"invoke-virtual \{([pv]\d+), ([pv]\d+)\}, Ljava/security/Signature;->verify\(\[B\)Z[\r\n]+\s+move-result ([pv]\d+)",
                "invoke-virtual {$1, $2}, Ljava/security/Signature;->verify([B)Z\n\n    const/4 $3, 0x1"},
            {@"const-string ([pv]\d+), \""APPLICATION_LICENSE\""[\r\n]+\s+invoke-virtual \{([pv]\d+), ([pv]\d+)\}, (.+)[\r\n]+\s+move-result ([pv]\d+)[\r\n]+\s+if-eqz ([pv]\d+), :cond_(\d+)",
                "const-string $1, \"APPLICATION_LICENSE\"\n\n    invoke-virtual {$2, $3}, $4\n\n    const/4 $5, 0x1\n\n    if-eqz $6, :cond_$7"}
        };

        public static Dictionary<string, string> EmulatorPatch = new Dictionary<string, string>
        {
            {@"const-string ([pv]\d+), \""(wlan0|tunl0|eth0|10\.0\.2\.15|000000000000000|15555215554|15555215556|15555215558|15555215560|15555215562|15555215564|15555215566|15555215568|15555215570|15555215572|15555215574|15555215576|15555215578|15555215580|15555215582|15555215584|012345678912345|310260000000000|/dev/qemu_pipe|/dev/socket/baseband_genyd|/dev/socket/genyd|/dev/socket/qemud|/system/etc/init.nox.sh|Android SDK built for x86|Andy|com\.bignox\.app|com\.bluestacks|com\.google\.android\.launcher\.layouts\.genymotion|com\.vphone\.launcher|droid4x|e21833235b6eef10|Emulator|fstab\.andy|fstab\.nox|fstab\.ttVM_x86|fstab\.vbox86|generic|Geny|Genymotion|goldfish|google_sdk|init\.nox\.rc|init\.svc\.qemu-props|init\.svc\.qemud|init\.ttVM_x86\.rc|init\.vbox86\.rc|Nox|nox|Pipes|qemu\.hw\.mainkeys|qemu\.sf\.fake_camera|qemu\.sf\.lcd_density|ro\.kernel\.android\.qemud|ro\.kernel\.qemu|ro\.kernel\.qemu\.gles|sdk|sdk_x86|ueventd\.android_x86\.rc|ueventd\.andy\.rc|ueventd\.nox\.rc|ueventd\.ttVM_x86\.rc|ueventd\.vbox86\.rc|unknown|vbox86|vbox86p|X86|x86\.prop)\""",
                "const-string $1, \"pinkypie$2pinkypie\""}
        };

        public static Dictionary<string, string> ReceiverPatch = new Dictionary<string, string>
        {
            {@"[\r\n]+\s+<receiver.*/>",
                ""},
            {@"[\r\n]+\s+<receiver.*>(?<!/>)(\r|\n|.)+?</receiver>",
                ""}
        };

        public static Dictionary<string, string> refLogPatch = new Dictionary<string, string>
        {
            {@"invoke-virtual \{([vp]\d+), ([vp]\d+), ([vp]\d+)\}, Ljava/lang/reflect/Method;->invoke\(Ljava/lang/Object;\[Ljava/lang/Object;\)Ljava/lang/Object;",
                "invoke-static {$1, $2, $3}, Lcom/anymy/ref_log;->invoke(Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;"}
        };

        public static Dictionary<string, string> GoogleServicesAddictionPatch = new Dictionary<string, string>
        {
            {@"(\(Landroid/content/Context;\)I|\(Landroid/content/Context;I\)I)[\r\n\s]+\.locals (\d+)[\r\n\s]+\.annotation runtime Ljava/lang/Deprecated;[\r\n\s]+\.end annotation",
                "$1\n    .locals $2\n    .annotation runtime Ljava/lang/Deprecated;\n    .end annotation\n    const/4 v0, 0x0\n    return v0"},
            {@"\(Landroid/content/Context;\)I[\r\n\s]+\.locals (\d+)[\r\n\s]+\.annotation runtime Ljava/lang/Deprecated;[\r\n\s]+\.end annotation",
                "(Landroid/content/Context;)I\n    .locals $1\n    .annotation runtime Ljava/lang/Deprecated;\n    .end annotation\n    const/4 v0, 0x0\n    return v0"},
            {@"invoke-virtual \{([pv]\d+), ([pv]\d+)\}, Ljava/security/Signature;->verify\(\[B\)Z[\r\n\s]+move-result ([pv]\d+)",
                "invoke-virtual {$1, $2}, Ljava/security/Signature;->verify([B)Z\n\n    const/4 $3, 0x1"}
        };

        public static Dictionary<string, string> ToastPatch = new Dictionary<string, string>
        {
            {@"invoke-virtual(.+)Landroid/widget/Toast;->show\(\)V",
              ""}
        };

        public static Dictionary<string, string> mockLocationPatch = new Dictionary<string, string>
        {
            {@"invoke-virtual {([pv]\d+)}, Landroid/location/Location;->isFromMockProvider\(\)Z[\r\n\s]+move-result ([pv]\d+)",
                "const/4 $2, 0x0"}
        };

        public static Dictionary<string, string> dpiPatch = new Dictionary<string, string>
        {
            {@"iget ([pv]\d+), ([pv]\d+), Landroid/util/DisplayMetrics;->(density|scaledDensity):F",
            "invoke-static {}, LfixDisplayM;->getDenorScal()F\n\n    move-result $1"},
            {@"iget ([pv]\d+), ([pv]\d+), Landroid/util/DisplayMetrics;->densityDpi:I",
            "invoke-static {}, LfixDisplayM;->getDensityDpi()I\n\n    move-result $1"}
        };

        public static Dictionary<string, string> RootPatch = new Dictionary<string, string>
        {
            {@"const-string ([pv]\d+), \""(test-keys|[^\""]*Superuser.apk[^\""]*|/[^\""]*bin/su|[^\""]*/failsafe/su|/data/[^\""]*/su|/system/xbin/which|[^\""]*/su|su)\""",
               "const-string $1, \"$2fusrodah\""},
            {@"const-string ([pv]\d+), \""[^\""]*\.(supersu|superuser)\""",
               "const-string $1, \"$2fusrodah\""},
            {@"const-string ([pv]\d+), \""([^\""]*/xbin/[^\""]*|[^\""]*\.su|[^\""]*/su-[^\""]*|[^\""]*which su|com\.zachspong\.temprootremovejb|com\.ramdroid\.appquarantine|com\.noshufou\.android\.su\.elite|com\.koushikdutta\.rommanager|com\.dimonvideo\.luckypatcher|com\.chelpus\.lackypatch|com\.devadvance\.rootcloak|de\.robv\.android\.xposed\.installer|com\.saurik\.substrate|com\.devadvance\.rootcloakplus|com\.amphoras\.hidemyroot|com\.formyhm\.hideroot|busybox)\""",
               "const-string $1, \"$2fusrodah\""},
            {@"const-string ([pv]\d+), \""[^\""]*(supersu|superuser|/su/|root|/data/local/|/system/[sx]*bin|/sbin)[^\""]*\""",
               "const-string $1, \"$2fusrodah\""}
        };

        public static Dictionary<string, string> FullscreenPatch = new Dictionary<string, string>
        {
            {@"(<style[^>]+>([\r\n\s]+<item[^\""]+\""(?!android:windowFullscreen)[^>]+>[^>]+>)+[\r\n\s]+)</style>",
               "$1\n    <item name=\"android:windowFullscreen\">true</item>\n    </style>"},
            {@"(<style[^>]+)/>",
               "$1>\n        <item name=\"android:windowFullscreen\">true</item>\n    </style>"}
        };

        public static Dictionary<string, string> AddSavePatch = new Dictionary<string, string>
        {
            {@"(\.method.+onCreate\(Landroid/os/Bundle;\)V[\r\n\s]+\.locals \d+)",
               "$1\n\n    invoke-static/range {p0 .. p0}, Lsave;->m(Landroid/content/Context;)V"}
        };

        public static Dictionary<string, string> GoogleBannerPatchXml = new Dictionary<string, string>
        {
            {@"(android|n\d+):visibility=\""(?:visible|invisible)\""(.*)((?:android|n\d+):id=\""@id/[^\""]*(?:[Aa][Dd][Ss]|[Bb][Aa][Nn][Nn][Ee][Rr]|[Aa][Dd][Vv][Ii][Ee][Ww]|[Aa][Dd][Vv][Ii][Ee][Ww]Layout)[^\""]*\"")",
                "$1:visibility=\"gone\" $2 $3 "},
            {@"((android|n\d+):id=\""@id/[^\""]*(?:[Aa][Dd][Ss]|[Bb][Aa][Nn][Nn][Ee][Rr]|[Aa][Dd][Vv][Ii][Ee][Ww]|[Aa][Dd][Vv][Ii][Ee][Ww]Layout)[^\""]*\"")(.*)(android|n\d+):visibility=\""(?:visible|invisible)\""",
                "$1 $3 $4:visibility=\"gone\" "},
            {@"(?<!visibility.*)((android|n\d+):id=\""@id/[^\""]*(?:[Aa][Dd][Ss]|[Bb][Aa][Nn][Nn][Ee][Rr]|[Aa][Dd][Vv][Ii][Ee][Ww]|[Aa][Dd][Vv][Ii][Ee][Ww]Layout)[^\""]*\"")(?!.*visibility)",
                "$1 $2:visibility=\"gone\" "},
            {@"(android|n\d+):layout_(height)=\""[^\""]+\""(.*)((?:android|n\d+):id=\""@id/[^\""]*(?:[Aa][Dd][Ss]|[Bb][Aa][Nn][Nn][Ee][Rr]|[Aa][Dd][Vv][Ii][Ee][Ww]|[Aa][Dd][Vv][Ii][Ee][Ww]Layout)[^\""]*\"")",
                "$1:layout_$2=\"0.0dip\" $3 $4"},
            {@"(android|n\d+):layout_(width)=\""[^\""]+\""(.*)((?:android|n\d+):id=\""@id/[^\""]*(?:[Aa][Dd][Ss]|[Bb][Aa][Nn][Nn][Ee][Rr]|[Aa][Dd][Vv][Ii][Ee][Ww]|[Aa][Dd][Vv][Ii][Ee][Ww]Layout)[^\""]*\"")",
                "$1:layout_$2=\"0.0dip\" $3 $4"},
            {@"((?:android|n\d+):id=\""@id/[^\""]*(?:[Aa][Dd][Ss]|[Bb][Aa][Nn][Nn][Ee][Rr]|[Aa][Dd][Vv][Ii][Ee][Ww]|[Aa][Dd][Vv][Ii][Ee][Ww]Layout)[^\""]*\"")(.*)(android|n\d+):layout_(height)=\""[^\""]+\""",
                "$1 $2 $3:layout_$4=\"0.0dip\" "},
            {@"((?:android|n\d+):id=\""@id/[^\""]*(?:[Aa][Dd][Ss]|[Bb][Aa][Nn][Nn][Ee][Rr]|[Aa][Dd][Vv][Ii][Ee][Ww]|[Aa][Dd][Vv][Ii][Ee][Ww]Layout)[^\""]*\"")(.*)(android|n\d+):layout_(width)=\""[^\""]+\""",
                "$1 $2 $3:layout_$4=\"0.0dip\" "},
            {@"(<com\.google\.android\.gms\.ads\.AdView.+)(android|n\d+):layout_(height)=\""[^\""]+\""",
                "$1 $2:layout_$3=\"0.0dip\""},
            {@"(<com\.google\.android\.gms\.ads\.AdView.+)(android|n\d+):layout_(width)=\""[^\""]+\""",
                "$1 $2:layout_$3=\"0.0dip\""},
            {@"(<com\.google\.android\.gms\.ads\.AdView)(?!.*?:visibility)(.*?\s(android|n\d+):\w+=\""[^\""]+\"")",
                "$1 $2 $3:visibility=\"gone\" "},
            {@"(<com\.google\.android\.gms\.ads\.AdView)(.*)(android|n\d+):visibility=\""(?:visible|invisible)\""",
                "$1$2 $3:visibility=\"gone\" "},
            {@"=\""ca-app-pub[^\""]+\""",
                "=\"ca-app-pub-0000000000000000~0000000000\""}
        };

        public static Dictionary<string, string> GoogleBannerPatchSmali = new Dictionary<string, string>
        {
            {@"const/(\d+) ([pv]\d+), 0x(4|0)[\r\n]+\s+invoke-virtual \{([pv]\d+), ([pv]\d+)\}, Lcom/google/android/gms/ads/AdView;->setVisibility\(I\)V",
               "const $2, 0x8\n\n    invoke-virtual {$4, $2}, Lcom/google/android/gms/ads/AdView;->setVisibility(I)V"}
        };

        public static Dictionary<string, string> DexExtractPatch = new Dictionary<string, string>
        {
            {@"invoke-virtual \{([vp]\d+), ([vp]\d+), ([vp]\d+)\}, Ljava/lang/reflect/Method;->invoke\(Ljava/lang/Object;\[Ljava/lang/Object;\)Ljava/lang/Object;",
               "invoke-static {$1, $2, $3}, Lcom/anymy/ref;->invoke(Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;)V\n\n    invoke-virtual {$1, $2, $3}, Ljava/lang/reflect/Method;->invoke(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;"}
        };

        public static Dictionary<string, string> SignRefPatch = new Dictionary<string, string>
        {
            {@"invoke-virtual \{([vp]\d+), ([vp]\d+), ([vp]\d+)\}, Ljava/lang/reflect/Method;->invoke\(Ljava/lang/Object;\[Ljava/lang/Object;\)Ljava/lang/Object;",
               "invoke-static {$1, $2, $3}, LfixSignReflection;->invoke(Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;"},
            {@"invoke-virtual \{([vp]\d+), ([vp]\d+), ([vp]\d+)\}, Landroid/content/pm/PackageManager;->getPackageInfo\(Ljava/lang/String;I\)Landroid/content/pm/PackageInfo;",
               "invoke-static {$1, $2, $3}, LfixSignReflection;->getPackageInfo(Landroid/content/pm/PackageManager;Ljava/lang/String;I)Landroid/content/pm/PackageInfo;"}
        };

        public static Dictionary<string, string> noInternetPatch = new Dictionary<string, string>
        {
            {@"[\r\n\s]*<uses-permission[^>]+(\.INTERNET|ACCESS_NETWORK_STATE)[^>]*>",
               ""}
        };

        public static Dictionary<string, string> noLocationPatch = new Dictionary<string, string>
        {
            {@"[\r\n\s]*<uses-permission[^>]+ACCESS_(FINE|MOCK|COARSE)_LOCATION[^>]*>",
               ""}
        };

        public static Dictionary<string, string> hideIconPatch = new Dictionary<string, string>
        {
            {@"android\.intent\.category\.LAUNCHER",
               "android.intent.category.DEFAULT"}
        };

        public static Dictionary<string, string> visibleIconPatch = new Dictionary<string, string>
        {
            {@"android\.intent\.category\.DEFAULT",
               "android.intent.category.LAUNCHER"}
        };

        public static Dictionary<string, string> darkLightPatchDhma = new Dictionary<string, string>
        {//DARK~Holo & Material & AppCompat
            {@"\""@android:style/Theme\.Holo\.Light\.DarkActionBar",
               "\"@android:style/Theme.Holo"},
            {@"\""@android:style/Theme\.Holo\.Light",
               "\"@android:style/Theme.Holo"},
            {@"\""@style/Theme\.AppCompat\.Light\.DarkActionBar",
               "\"@style/Theme.AppCompat"},
            {@"\""@style/Theme\.AppCompat\.Light",
               "\"@style/Theme.AppCompat"},
            {@"\""@android:style/Theme\.Material\.Light\.DarkActionBar",
               "\"@android:style/Theme.Material"},
            {@"\""@android:style/Theme\.Material\.Light",
               "\"@android:style/Theme.Material"}
        };

        public static Dictionary<string, string> darkLightPatchD = new Dictionary<string, string>
        {//Dark-Replace old styles
            {@"\""@android:style/Theme\.Light\.NoTitleBar",
               "\"@android:style/Theme.Holo.NoActionBar"},
            {@"\""@android:style/Theme\.Black\.NoTitleBar",
               "\"@android:style/Theme.Holo.NoActionBar"},
            {@"\""@android:style/Theme\""",
               "\"@android:style/Theme.Holo\""},
            {@"\""@android:style/Theme\.Dialog",
               "\"@android:style/Theme.Holo.Dialog"}
        };

        public static Dictionary<string, string> darkLightPatchLhma = new Dictionary<string, string>
        {//LIGHT~Holo & Material & AppCompat
            {@"\""@android:style/Theme\.Holo\""",
               "\"@android:style/Theme.Holo.Light\""},
            {@"\""@android:style/Theme\.Holo\.NoActionBar",
               "\"@android:style/Theme.Holo.Light.NoActionBar"},
            {@"\""@style/Theme\.AppCompat\""",
               "\"@style/Theme.AppCompat.Light\""},
            {@"\""@android:style/Theme\.Material\""",
               "\"@android:style/Theme.Material.Light\""},
            {@"\""@android:style/Theme\.Material\.NoActionBar",
               "\"@android:style/Theme.Material.Light.NoActionBar"}
        };

        public static Dictionary<string, string> darkLightPatchL = new Dictionary<string, string>
        {//Light-Replace old styles
            {@"\""@android:style/Theme\.Light\.NoTitleBar",
               "\"@android:style/Theme.Holo.Light.NoActionBar"},
            {@"\""@android:style/Theme\.Black\.NoTitleBar",
               "\"@android:style/Theme.Holo.Light.NoActionBar"},
            {@"\""@android:style/Theme\""",
               "\"@android:style/Theme.Holo.Light\""},
            {@"\""@android:style/Theme\.Dialog",
               "\"@android:style/Theme.Holo.Light.Dialog"}
        };

        public static Dictionary<string, string> GoogleMapsPattern = new Dictionary<string, string>
        {
            {@"<meta-data(.+)android:name=\""com\.google\.android\.(geo|maps)(.*)API_KEY\"" android:value=(.+)",
            "<meta-data$1android:name=\"com.google.android.$2$3API_KEY\" android:value=\"" + Settings.GoogleMapsApiKey + "\"/>"}
        };

        public static Dictionary<string, string> AutostartPattern = new Dictionary<string, string>
        {
            { @"[\r\n\s]+<receiver.+?>(?<!/>)[\r\n]+?(?:\s*?<(?!(?:receiver|service|activity)).+?>[\r\n]+)*?(?:\s*?<(?!(?:receiver|service|activity)).+android\.intent\.action\.BOOT_COMPLETED.+>[\r\n]+)+?(?:\s*?<(?!(?:receiver|service|activity)).+?>[\r\n]+)*?\s*?</receiver>",
            "" },
            { @"[\r\n\s]*<uses-permission[^>]+(\.RECEIVE_BOOT_COMPLETED)[^>]*>",
            ""}
        };

        public static Dictionary<string, string> screenshotPatch = new Dictionary<string, string>
        {
            {@"invoke-virtual \{([pv]\d+)\}, L(.+);->getWindow\(\)Landroid/view/Window;\n\n    move-result-object ([pv]\d+)\n\n    const/16 ([pv]\d+), 0x2000\n\n    invoke-virtual \{([pv]\d+), ([pv]\d+), ([pv]\d+)\}, Landroid/view/Window;->setFlags\(II\)V",
                "" }
        };

        public static Dictionary<string, string> fix_18_9Patch = new Dictionary<string, string>
        {
            {@"</application",
            "<meta-data android:name=\"android.max_aspect\" android:value=\"2.1\" />\n\n</application>"}
        };

        public static Dictionary<string, string> auto_screenOrientation = new Dictionary<string, string>
        {
           {@"android:screenOrientation=\""fullUser\""",
            "android:screenOrientation=\"fullSensor\""},
           {@"android:screenOrientation=\""portrait\""",
            "android:screenOrientation=\"fullSensor\""},
           {@"android:screenOrientation=\""landscape\""",
            "android:screenOrientation=\"fullSensor\""},
           {@"android:screenOrientation=\""sensorLandscape\""",
            "android:screenOrientation=\"fullSensor\""},
           {@"android:screenOrientation=\""sensorPortrait\""",
            "android:screenOrientation=\"fullSensor\""},
           {@"android:screenOrientation=\""user\""",
            "android:screenOrientation=\"fullSensor\""},
           {@"android:screenOrientation=\""locked\""",
            "android:screenOrientation=\"fullSensor\""}
        };

        public static Dictionary<string, string> landscape_screenOrientation = new Dictionary<string, string>
        {
           {@"android:screenOrientation=\""fullUser\""",
            "android:screenOrientation=\"sensorLandscape\""},
           {@"android:screenOrientation=\""portrait\""",
            "android:screenOrientation=\"sensorLandscape\""},
           {@"android:screenOrientation=\""landscape\""",
            "android:screenOrientation=\"sensorLandscape\""},
           {@"android:screenOrientation=\""fullSensor\""",
            "android:screenOrientation=\"sensorLandscape\""},
           {@"android:screenOrientation=\""sensorPortrait\""",
            "android:screenOrientation=\"sensorLandscape\""},
           {@"android:screenOrientation=\""user\""",
            "android:screenOrientation=\"sensorLandscape\""},
           {@"android:screenOrientation=\""locked\""",
            "android:screenOrientation=\"sensorLandscape\""}
        };

        public static Dictionary<string, string> portrait_screenOrientation = new Dictionary<string, string>
        {
           {@"android:screenOrientation=\""fullUser\""",
            "android:screenOrientation=\"portrait\""},

           {@"android:screenOrientation=\""sensorLandscape\""",
            "android:screenOrientation=\"portrait\""},

           {@"android:screenOrientation=\""landscape\""",
            "android:screenOrientation=\"portrait\""},

           {@"android:screenOrientation=\""sensorPortrait\""",
            "android:screenOrientation=\"portrait\""},

           {@"android:screenOrientation=\""user\""",
            "android:screenOrientation=\"portrait\""},

           {@"android:screenOrientation=\""locked\""",
            "android:screenOrientation=\"portrait\""},

           {@"android:screenOrientation=\""fullSensor\""",
            "android:screenOrientation=\"portrait\""}
        };

        public static Dictionary<string, string> fix_auth_fb_vkPatch = new Dictionary<string, string>
        {
            {@"(const-string|const-string/jumbo) ([pv]\d+), \""com\.vkontakte\.android\""",
            "${GROUP1} ${GROUP2}, \"com.allinone.fix\""},

           {@"(const-string|const-string/jumbo) ([pv]\d+), \""com\.facebook\.katana\""",
            "${GROUP1} ${GROUP2}, \"com.allinone.fix\""}
        };
    }
}
