namespace AllInOne.Forms
{
    // Token: 0x02000008 RID: 8
    public partial class MainForm : global::System.Windows.Forms.Form
    {
        // Token: 0x0600005B RID: 91 RVA: 0x0000230A File Offset: 0x0000050A
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x0600005C RID: 92 RVA: 0x00008DB8 File Offset: 0x00006FB8
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.themesGBox = new System.Windows.Forms.GroupBox();
            this.themesLCB = new System.Windows.Forms.CheckBox();
            this.themesLHMACB = new System.Windows.Forms.CheckBox();
            this.themesDCB = new System.Windows.Forms.CheckBox();
            this.themesDHMACB = new System.Windows.Forms.CheckBox();
            this.analyticGBox = new System.Windows.Forms.GroupBox();
            this.analyticFirebaseCB = new System.Windows.Forms.CheckBox();
            this.analyticMethodCB = new System.Windows.Forms.CheckBox();
            this.analyticLinksCB = new System.Windows.Forms.CheckBox();
            this.analyticServiceCB = new System.Windows.Forms.CheckBox();
            this.analyticReceiverCB = new System.Windows.Forms.CheckBox();
            this.analyticActivityCB = new System.Windows.Forms.CheckBox();
            this.analyticLayoutCB = new System.Windows.Forms.CheckBox();
            this.deleteGBox = new System.Windows.Forms.GroupBox();
            this.deleteLangsCBox = new System.Windows.Forms.ComboBox();
            this.deleteResourcesCB = new System.Windows.Forms.CheckBox();
            this.emulatorCB = new System.Windows.Forms.CheckBox();
            this.locationCB = new System.Windows.Forms.CheckBox();
            this.gmsCB = new System.Windows.Forms.CheckBox();
            this.autostartCB = new System.Windows.Forms.CheckBox();
            this.internetCB = new System.Windows.Forms.CheckBox();
            this.allToastsCB = new System.Windows.Forms.CheckBox();
            this.signatureGBox = new System.Windows.Forms.GroupBox();
            this.binSignatureCB = new System.Windows.Forms.CheckBox();
            this.binSignatureInstallerCB = new System.Windows.Forms.CheckBox();
            this.binInstallerCBox = new System.Windows.Forms.ComboBox();
            this.licenseGBox = new System.Windows.Forms.GroupBox();
            this.licenseGoogleCB = new System.Windows.Forms.CheckBox();
            this.licenseAmazonCB = new System.Windows.Forms.CheckBox();
            this.installerGBox = new System.Windows.Forms.GroupBox();
            this.installerGoogleCB = new System.Windows.Forms.CheckBox();
            this.installerAmazonCB = new System.Windows.Forms.CheckBox();
            this.splashGBox = new System.Windows.Forms.GroupBox();
            this.splashInstallCB = new System.Windows.Forms.CheckBox();
            this.splashRemoveCB = new System.Windows.Forms.CheckBox();
            this.otherGBox = new System.Windows.Forms.GroupBox();
            this.screenshotCB = new System.Windows.Forms.CheckBox();
            this.backKillCB = new System.Windows.Forms.CheckBox();
            this.backKillCBox = new System.Windows.Forms.ComboBox();
            this.blockSensorsCBox = new System.Windows.Forms.ComboBox();
            this.blockSensorsCB = new System.Windows.Forms.CheckBox();
            this.cloneTBox = new System.Windows.Forms.TextBox();
            this.installLocationCBox = new System.Windows.Forms.ComboBox();
            this.cloneCB = new System.Windows.Forms.CheckBox();
            this.installLocationCB = new System.Windows.Forms.CheckBox();
            this.addSaveCB = new System.Windows.Forms.CheckBox();
            this.minSdkCB = new System.Windows.Forms.CheckBox();
            this.fullscreenCB = new System.Windows.Forms.CheckBox();
            this.addToastCB = new System.Windows.Forms.CheckBox();
            this.rootCheckCB = new System.Windows.Forms.CheckBox();
            this.minSdkCBox = new System.Windows.Forms.ComboBox();
            this.hideIconCB = new System.Windows.Forms.CheckBox();
            this.noUpdateCB = new System.Windows.Forms.CheckBox();
            this.toastMessageTBox = new System.Windows.Forms.TextBox();
            this.mockLocationCB = new System.Windows.Forms.CheckBox();
            this.googleMapsCB = new System.Windows.Forms.CheckBox();
            this.dexCB = new System.Windows.Forms.CheckBox();
            this.reflectionLogCB = new System.Windows.Forms.CheckBox();
            this.gpsLatitudeTBox = new System.Windows.Forms.TextBox();
            this.gpsLongitudeTBox = new System.Windows.Forms.TextBox();
            this.gpsCB = new System.Windows.Forms.CheckBox();
            this.timeCB = new System.Windows.Forms.CheckBox();
            this.deviceIdTBox = new System.Windows.Forms.TextBox();
            this.accountCB = new System.Windows.Forms.CheckBox();
            this.androidIdTBox = new System.Windows.Forms.TextBox();
            this.allAutoCB = new System.Windows.Forms.CheckBox();
            this.brandCB = new System.Windows.Forms.CheckBox();
            this.allManualCB = new System.Windows.Forms.CheckBox();
            this.wifiMacTBox = new System.Windows.Forms.TextBox();
            this.ipCB = new System.Windows.Forms.CheckBox();
            this.bluetoothMacTBox = new System.Windows.Forms.TextBox();
            this.bluetoothAddressTBox = new System.Windows.Forms.TextBox();
            this.serialTBox = new System.Windows.Forms.TextBox();
            this.bssidCB = new System.Windows.Forms.CheckBox();
            this.deviceIdCB = new System.Windows.Forms.CheckBox();
            this.deviceCB = new System.Windows.Forms.CheckBox();
            this.modelTBox = new System.Windows.Forms.TextBox();
            this.brandTBox = new System.Windows.Forms.TextBox();
            this.boardCB = new System.Windows.Forms.CheckBox();
            this.androidIdCB = new System.Windows.Forms.CheckBox();
            this.manufacturerCB = new System.Windows.Forms.CheckBox();
            this.ipTBox = new System.Windows.Forms.TextBox();
            this.productCB = new System.Windows.Forms.CheckBox();
            this.bssidTBox = new System.Windows.Forms.TextBox();
            this.operatorNameCB = new System.Windows.Forms.CheckBox();
            this.deviceTBox = new System.Windows.Forms.TextBox();
            this.operatorCB = new System.Windows.Forms.CheckBox();
            this.boardTBox = new System.Windows.Forms.TextBox();
            this.subscriberIdCB = new System.Windows.Forms.CheckBox();
            this.wifiMacAddressCB = new System.Windows.Forms.CheckBox();
            this.simSerialNumberCB = new System.Windows.Forms.CheckBox();
            this.manufacturerTBox = new System.Windows.Forms.TextBox();
            this.productTBox = new System.Windows.Forms.TextBox();
            this.modelCB = new System.Windows.Forms.CheckBox();
            this.operatorNameTBox = new System.Windows.Forms.TextBox();
            this.operatorTBox = new System.Windows.Forms.TextBox();
            this.bluetoothMacAddressCB = new System.Windows.Forms.CheckBox();
            this.subscriderIdTBox = new System.Windows.Forms.TextBox();
            this.simSerialNumberTBox = new System.Windows.Forms.TextBox();
            this.serialCB = new System.Windows.Forms.CheckBox();
            this.timeTBox = new System.Windows.Forms.TextBox();
            this.bluetoothAddressCB = new System.Windows.Forms.CheckBox();
            this.accountTBox = new System.Windows.Forms.TextBox();
            this.clearAll = new System.Windows.Forms.Button();
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.openFolderButton = new System.Windows.Forms.Button();
            this.saveCheckboxButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.orderLv = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolsTab = new System.Windows.Forms.TabPage();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.mehButton = new System.Windows.Forms.Button();
            this.mergeStringsButton = new System.Windows.Forms.Button();
            this.interestingPlacesButton = new System.Windows.Forms.Button();
            this.hideIdsButton = new System.Windows.Forms.Button();
            this.collectStringsButton = new System.Windows.Forms.Button();
            this.addDebugInfoButton = new System.Windows.Forms.Button();
            this.remDebugInfoButton = new System.Windows.Forms.Button();
            this.helpSmaliButton = new System.Windows.Forms.Button();
            this.aboutTab = new System.Windows.Forms.TabPage();
            this.Changelog_btn = new System.Windows.Forms.Button();
            this.authorLabel3 = new System.Windows.Forms.Label();
            this.new_author2 = new System.Windows.Forms.LinkLabel();
            this.authorLabel2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.buildDateLabel = new System.Windows.Forms.Label();
            this.lblBuild = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.yandexMoneyLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.yanMoneyLink = new System.Windows.Forms.LinkLabel();
            this.donateLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressTbox = new System.Windows.Forms.TextBox();
            this.taskCountLabel = new System.Windows.Forms.Label();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.countryIsoTBox = new System.Windows.Forms.TextBox();
            this.countryIsoCB = new System.Windows.Forms.CheckBox();
            this.mainTLP = new System.Windows.Forms.TableLayoutPanel();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.mainTabPage = new System.Windows.Forms.TabPage();
            this.replaceTabPage = new System.Windows.Forms.TabPage();
            this.replaceGBox = new System.Windows.Forms.GroupBox();
            this.idTBox = new System.Windows.Forms.TextBox();
            this.idCB = new System.Windows.Forms.CheckBox();
            this.deviceNameCB = new System.Windows.Forms.CheckBox();
            this.imeiCB = new System.Windows.Forms.CheckBox();
            this.deviceNameTBox = new System.Windows.Forms.TextBox();
            this.imeiTBox = new System.Windows.Forms.TextBox();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.progressTLP = new System.Windows.Forms.TableLayoutPanel();
            this.themesGBox.SuspendLayout();
            this.analyticGBox.SuspendLayout();
            this.deleteGBox.SuspendLayout();
            this.signatureGBox.SuspendLayout();
            this.licenseGBox.SuspendLayout();
            this.installerGBox.SuspendLayout();
            this.splashGBox.SuspendLayout();
            this.otherGBox.SuspendLayout();
            this.tabsControl.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.toolsTab.SuspendLayout();
            this.aboutTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainTLP.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.mainTabPage.SuspendLayout();
            this.replaceTabPage.SuspendLayout();
            this.replaceGBox.SuspendLayout();
            this.progressTLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // themesGBox
            // 
            this.themesGBox.Controls.Add(this.themesLCB);
            this.themesGBox.Controls.Add(this.themesLHMACB);
            this.themesGBox.Controls.Add(this.themesDCB);
            this.themesGBox.Controls.Add(this.themesDHMACB);
            this.themesGBox.Location = new System.Drawing.Point(8, 495);
            this.themesGBox.Margin = new System.Windows.Forms.Padding(4);
            this.themesGBox.Name = "themesGBox";
            this.themesGBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.themesGBox.Size = new System.Drawing.Size(307, 106);
            this.themesGBox.TabIndex = 10;
            this.themesGBox.TabStop = false;
            this.themesGBox.Text = "DARK/LIGHT темы";
            // 
            // themesLCB
            // 
            this.themesLCB.AutoSize = true;
            this.themesLCB.Location = new System.Drawing.Point(3, 81);
            this.themesLCB.Margin = new System.Windows.Forms.Padding(0);
            this.themesLCB.Name = "themesLCB";
            this.themesLCB.Size = new System.Drawing.Size(252, 21);
            this.themesLCB.TabIndex = 3;
            this.themesLCB.Text = "LIGHT (с заменой старых стилей)";
            this.themesLCB.UseVisualStyleBackColor = true;
            this.themesLCB.CheckedChanged += new System.EventHandler(this.themes_CheckedChanged);
            // 
            // themesLHMACB
            // 
            this.themesLHMACB.AutoSize = true;
            this.themesLHMACB.Location = new System.Drawing.Point(3, 60);
            this.themesLHMACB.Margin = new System.Windows.Forms.Padding(0);
            this.themesLHMACB.Name = "themesLHMACB";
            this.themesLHMACB.Size = new System.Drawing.Size(251, 21);
            this.themesLHMACB.TabIndex = 2;
            this.themesLHMACB.Text = "LIGHT Holo / Material / AppCompat";
            this.themesLHMACB.UseVisualStyleBackColor = true;
            this.themesLHMACB.CheckedChanged += new System.EventHandler(this.themes_CheckedChanged);
            // 
            // themesDCB
            // 
            this.themesDCB.AutoSize = true;
            this.themesDCB.Location = new System.Drawing.Point(3, 39);
            this.themesDCB.Margin = new System.Windows.Forms.Padding(0);
            this.themesDCB.Name = "themesDCB";
            this.themesDCB.Size = new System.Drawing.Size(249, 21);
            this.themesDCB.TabIndex = 1;
            this.themesDCB.Text = "DARK (с заменой старых стилей)";
            this.themesDCB.UseVisualStyleBackColor = true;
            this.themesDCB.CheckedChanged += new System.EventHandler(this.themes_CheckedChanged);
            // 
            // themesDHMACB
            // 
            this.themesDHMACB.AutoSize = true;
            this.themesDHMACB.Location = new System.Drawing.Point(3, 18);
            this.themesDHMACB.Margin = new System.Windows.Forms.Padding(0);
            this.themesDHMACB.Name = "themesDHMACB";
            this.themesDHMACB.Size = new System.Drawing.Size(248, 21);
            this.themesDHMACB.TabIndex = 0;
            this.themesDHMACB.Text = "DARK Holo / Material / AppCompat";
            this.themesDHMACB.UseVisualStyleBackColor = true;
            this.themesDHMACB.CheckedChanged += new System.EventHandler(this.themes_CheckedChanged);
            // 
            // analyticGBox
            // 
            this.analyticGBox.Controls.Add(this.analyticFirebaseCB);
            this.analyticGBox.Controls.Add(this.analyticMethodCB);
            this.analyticGBox.Controls.Add(this.analyticLinksCB);
            this.analyticGBox.Controls.Add(this.analyticServiceCB);
            this.analyticGBox.Controls.Add(this.analyticReceiverCB);
            this.analyticGBox.Controls.Add(this.analyticActivityCB);
            this.analyticGBox.Controls.Add(this.analyticLayoutCB);
            this.analyticGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.analyticGBox.Location = new System.Drawing.Point(8, 7);
            this.analyticGBox.Margin = new System.Windows.Forms.Padding(1);
            this.analyticGBox.MinimumSize = new System.Drawing.Size(307, 0);
            this.analyticGBox.Name = "analyticGBox";
            this.analyticGBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.analyticGBox.Size = new System.Drawing.Size(307, 106);
            this.analyticGBox.TabIndex = 25;
            this.analyticGBox.TabStop = false;
            this.analyticGBox.Text = "Аналитика/реклама";
            // 
            // analyticFirebaseCB
            // 
            this.analyticFirebaseCB.AutoSize = true;
            this.analyticFirebaseCB.Location = new System.Drawing.Point(3, 81);
            this.analyticFirebaseCB.Margin = new System.Windows.Forms.Padding(0);
            this.analyticFirebaseCB.Name = "analyticFirebaseCB";
            this.analyticFirebaseCB.Size = new System.Drawing.Size(85, 21);
            this.analyticFirebaseCB.TabIndex = 6;
            this.analyticFirebaseCB.Text = "Firebase";
            this.analyticFirebaseCB.UseVisualStyleBackColor = true;
            this.analyticFirebaseCB.CheckedChanged += new System.EventHandler(this.analytics_CheckedChanged);
            // 
            // analyticMethodCB
            // 
            this.analyticMethodCB.AutoSize = true;
            this.analyticMethodCB.Location = new System.Drawing.Point(140, 60);
            this.analyticMethodCB.Margin = new System.Windows.Forms.Padding(0);
            this.analyticMethodCB.Name = "analyticMethodCB";
            this.analyticMethodCB.Size = new System.Drawing.Size(82, 21);
            this.analyticMethodCB.TabIndex = 5;
            this.analyticMethodCB.Text = "Методы";
            this.analyticMethodCB.UseVisualStyleBackColor = true;
            this.analyticMethodCB.CheckedChanged += new System.EventHandler(this.analytics_CheckedChanged);
            // 
            // analyticLinksCB
            // 
            this.analyticLinksCB.AutoSize = true;
            this.analyticLinksCB.Location = new System.Drawing.Point(3, 60);
            this.analyticLinksCB.Margin = new System.Windows.Forms.Padding(0);
            this.analyticLinksCB.Name = "analyticLinksCB";
            this.analyticLinksCB.Size = new System.Drawing.Size(79, 21);
            this.analyticLinksCB.TabIndex = 4;
            this.analyticLinksCB.Text = "Ссылки";
            this.analyticLinksCB.UseVisualStyleBackColor = true;
            this.analyticLinksCB.CheckedChanged += new System.EventHandler(this.analytics_CheckedChanged);
            // 
            // analyticServiceCB
            // 
            this.analyticServiceCB.AutoSize = true;
            this.analyticServiceCB.Location = new System.Drawing.Point(3, 39);
            this.analyticServiceCB.Margin = new System.Windows.Forms.Padding(0);
            this.analyticServiceCB.Name = "analyticServiceCB";
            this.analyticServiceCB.Size = new System.Drawing.Size(87, 21);
            this.analyticServiceCB.TabIndex = 3;
            this.analyticServiceCB.Text = "Сервисы";
            this.analyticServiceCB.UseVisualStyleBackColor = true;
            this.analyticServiceCB.CheckedChanged += new System.EventHandler(this.analytics_CheckedChanged);
            // 
            // analyticReceiverCB
            // 
            this.analyticReceiverCB.AutoSize = true;
            this.analyticReceiverCB.Location = new System.Drawing.Point(140, 17);
            this.analyticReceiverCB.Margin = new System.Windows.Forms.Padding(0);
            this.analyticReceiverCB.Name = "analyticReceiverCB";
            this.analyticReceiverCB.Size = new System.Drawing.Size(95, 21);
            this.analyticReceiverCB.TabIndex = 2;
            this.analyticReceiverCB.Text = "Ресиверы";
            this.analyticReceiverCB.UseVisualStyleBackColor = true;
            this.analyticReceiverCB.CheckedChanged += new System.EventHandler(this.analytics_CheckedChanged);
            // 
            // analyticActivityCB
            // 
            this.analyticActivityCB.AutoSize = true;
            this.analyticActivityCB.Location = new System.Drawing.Point(3, 18);
            this.analyticActivityCB.Margin = new System.Windows.Forms.Padding(0);
            this.analyticActivityCB.Name = "analyticActivityCB";
            this.analyticActivityCB.Size = new System.Drawing.Size(91, 21);
            this.analyticActivityCB.TabIndex = 1;
            this.analyticActivityCB.Text = "Активити";
            this.analyticActivityCB.UseVisualStyleBackColor = true;
            this.analyticActivityCB.CheckedChanged += new System.EventHandler(this.analytics_CheckedChanged);
            // 
            // analyticLayoutCB
            // 
            this.analyticLayoutCB.AutoSize = true;
            this.analyticLayoutCB.Location = new System.Drawing.Point(140, 39);
            this.analyticLayoutCB.Margin = new System.Windows.Forms.Padding(0);
            this.analyticLayoutCB.Name = "analyticLayoutCB";
            this.analyticLayoutCB.Size = new System.Drawing.Size(140, 21);
            this.analyticLayoutCB.TabIndex = 0;
            this.analyticLayoutCB.Text = "Разметка Layout";
            this.analyticLayoutCB.UseVisualStyleBackColor = true;
            this.analyticLayoutCB.CheckedChanged += new System.EventHandler(this.analytics_CheckedChanged);
            // 
            // deleteGBox
            // 
            this.deleteGBox.Controls.Add(this.deleteLangsCBox);
            this.deleteGBox.Controls.Add(this.deleteResourcesCB);
            this.deleteGBox.Controls.Add(this.emulatorCB);
            this.deleteGBox.Controls.Add(this.locationCB);
            this.deleteGBox.Controls.Add(this.gmsCB);
            this.deleteGBox.Controls.Add(this.autostartCB);
            this.deleteGBox.Controls.Add(this.internetCB);
            this.deleteGBox.Controls.Add(this.allToastsCB);
            this.deleteGBox.Location = new System.Drawing.Point(8, 114);
            this.deleteGBox.Margin = new System.Windows.Forms.Padding(4);
            this.deleteGBox.MinimumSize = new System.Drawing.Size(307, 0);
            this.deleteGBox.Name = "deleteGBox";
            this.deleteGBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteGBox.Size = new System.Drawing.Size(307, 198);
            this.deleteGBox.TabIndex = 18;
            this.deleteGBox.TabStop = false;
            this.deleteGBox.Text = "Удалить";
            // 
            // deleteLangsCBox
            // 
            this.deleteLangsCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deleteLangsCBox.Enabled = false;
            this.deleteLangsCBox.FormattingEnabled = true;
            this.deleteLangsCBox.Location = new System.Drawing.Point(4, 165);
            this.deleteLangsCBox.Margin = new System.Windows.Forms.Padding(4);
            this.deleteLangsCBox.Name = "deleteLangsCBox";
            this.deleteLangsCBox.Size = new System.Drawing.Size(253, 24);
            this.deleteLangsCBox.TabIndex = 26;
            // 
            // deleteResourcesCB
            // 
            this.deleteResourcesCB.AutoSize = true;
            this.deleteResourcesCB.Location = new System.Drawing.Point(3, 140);
            this.deleteResourcesCB.Margin = new System.Windows.Forms.Padding(0);
            this.deleteResourcesCB.Name = "deleteResourcesCB";
            this.deleteResourcesCB.Size = new System.Drawing.Size(142, 21);
            this.deleteResourcesCB.TabIndex = 22;
            this.deleteResourcesCB.Text = "Лишние ресурсы";
            this.deleteResourcesCB.UseVisualStyleBackColor = true;
            this.deleteResourcesCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // emulatorCB
            // 
            this.emulatorCB.AutoSize = true;
            this.emulatorCB.Location = new System.Drawing.Point(3, 15);
            this.emulatorCB.Margin = new System.Windows.Forms.Padding(0);
            this.emulatorCB.Name = "emulatorCB";
            this.emulatorCB.Size = new System.Drawing.Size(232, 21);
            this.emulatorCB.TabIndex = 2;
            this.emulatorCB.Text = "Проверку на эмулятор Android";
            this.emulatorCB.UseVisualStyleBackColor = true;
            this.emulatorCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // locationCB
            // 
            this.locationCB.AutoSize = true;
            this.locationCB.Location = new System.Drawing.Point(3, 98);
            this.locationCB.Margin = new System.Windows.Forms.Padding(0);
            this.locationCB.Name = "locationCB";
            this.locationCB.Size = new System.Drawing.Size(207, 21);
            this.locationCB.TabIndex = 5;
            this.locationCB.Text = "Доступ к местоположению";
            this.locationCB.UseVisualStyleBackColor = true;
            this.locationCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // gmsCB
            // 
            this.gmsCB.AutoSize = true;
            this.gmsCB.Location = new System.Drawing.Point(3, 36);
            this.gmsCB.Margin = new System.Windows.Forms.Padding(0);
            this.gmsCB.Name = "gmsCB";
            this.gmsCB.Size = new System.Drawing.Size(270, 21);
            this.gmsCB.TabIndex = 1;
            this.gmsCB.Text = "Зависимость от Google play services";
            this.gmsCB.UseVisualStyleBackColor = true;
            this.gmsCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // autostartCB
            // 
            this.autostartCB.AutoSize = true;
            this.autostartCB.Location = new System.Drawing.Point(3, 57);
            this.autostartCB.Margin = new System.Windows.Forms.Padding(0);
            this.autostartCB.Name = "autostartCB";
            this.autostartCB.Size = new System.Drawing.Size(194, 21);
            this.autostartCB.TabIndex = 17;
            this.autostartCB.Text = "Автозапуск при загрузке";
            this.autostartCB.UseVisualStyleBackColor = true;
            this.autostartCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // internetCB
            // 
            this.internetCB.AutoSize = true;
            this.internetCB.Location = new System.Drawing.Point(3, 78);
            this.internetCB.Margin = new System.Windows.Forms.Padding(0);
            this.internetCB.Name = "internetCB";
            this.internetCB.Size = new System.Drawing.Size(155, 21);
            this.internetCB.TabIndex = 4;
            this.internetCB.Text = "Доступ в интернет";
            this.internetCB.UseVisualStyleBackColor = true;
            this.internetCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // allToastsCB
            // 
            this.allToastsCB.AutoSize = true;
            this.allToastsCB.Location = new System.Drawing.Point(3, 119);
            this.allToastsCB.Margin = new System.Windows.Forms.Padding(0);
            this.allToastsCB.Name = "allToastsCB";
            this.allToastsCB.Size = new System.Drawing.Size(173, 21);
            this.allToastsCB.TabIndex = 7;
            this.allToastsCB.Text = "Все Toast-сообщения";
            this.allToastsCB.UseVisualStyleBackColor = true;
            this.allToastsCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // signatureGBox
            // 
            this.signatureGBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signatureGBox.Controls.Add(this.binSignatureCB);
            this.signatureGBox.Controls.Add(this.binSignatureInstallerCB);
            this.signatureGBox.Controls.Add(this.binInstallerCBox);
            this.signatureGBox.Location = new System.Drawing.Point(8, 313);
            this.signatureGBox.Margin = new System.Windows.Forms.Padding(4);
            this.signatureGBox.MinimumSize = new System.Drawing.Size(307, 0);
            this.signatureGBox.Name = "signatureGBox";
            this.signatureGBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signatureGBox.Size = new System.Drawing.Size(307, 94);
            this.signatureGBox.TabIndex = 21;
            this.signatureGBox.TabStop = false;
            this.signatureGBox.Text = "Проверка подписи";
            // 
            // binSignatureCB
            // 
            this.binSignatureCB.AutoSize = true;
            this.binSignatureCB.Location = new System.Drawing.Point(3, 18);
            this.binSignatureCB.Margin = new System.Windows.Forms.Padding(0);
            this.binSignatureCB.Name = "binSignatureCB";
            this.binSignatureCB.Size = new System.Drawing.Size(102, 21);
            this.binSignatureCB.TabIndex = 0;
            this.binSignatureCB.Text = "патчем Bin";
            this.binSignatureCB.UseVisualStyleBackColor = true;
            this.binSignatureCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // binSignatureInstallerCB
            // 
            this.binSignatureInstallerCB.AutoSize = true;
            this.binSignatureInstallerCB.Location = new System.Drawing.Point(3, 39);
            this.binSignatureInstallerCB.Margin = new System.Windows.Forms.Padding(0);
            this.binSignatureInstallerCB.Name = "binSignatureInstallerCB";
            this.binSignatureInstallerCB.Size = new System.Drawing.Size(223, 21);
            this.binSignatureInstallerCB.TabIndex = 17;
            this.binSignatureInstallerCB.Text = "патчем от Bin (+Установщик)";
            this.binSignatureInstallerCB.UseVisualStyleBackColor = true;
            this.binSignatureInstallerCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // binInstallerCBox
            // 
            this.binInstallerCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.binInstallerCBox.Enabled = false;
            this.binInstallerCBox.FormattingEnabled = true;
            this.binInstallerCBox.Items.AddRange(new object[] {
            "Google",
            "Amazon"});
            this.binInstallerCBox.Location = new System.Drawing.Point(5, 63);
            this.binInstallerCBox.Margin = new System.Windows.Forms.Padding(1);
            this.binInstallerCBox.Name = "binInstallerCBox";
            this.binInstallerCBox.Size = new System.Drawing.Size(252, 24);
            this.binInstallerCBox.TabIndex = 18;
            // 
            // licenseGBox
            // 
            this.licenseGBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.licenseGBox.Controls.Add(this.licenseGoogleCB);
            this.licenseGBox.Controls.Add(this.licenseAmazonCB);
            this.licenseGBox.Location = new System.Drawing.Point(8, 450);
            this.licenseGBox.Margin = new System.Windows.Forms.Padding(4);
            this.licenseGBox.MinimumSize = new System.Drawing.Size(307, 0);
            this.licenseGBox.Name = "licenseGBox";
            this.licenseGBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.licenseGBox.Size = new System.Drawing.Size(307, 44);
            this.licenseGBox.TabIndex = 20;
            this.licenseGBox.TabStop = false;
            this.licenseGBox.Text = "Проверка лицензии";
            // 
            // licenseGoogleCB
            // 
            this.licenseGoogleCB.AutoSize = true;
            this.licenseGoogleCB.Location = new System.Drawing.Point(3, 18);
            this.licenseGoogleCB.Margin = new System.Windows.Forms.Padding(0);
            this.licenseGoogleCB.Name = "licenseGoogleCB";
            this.licenseGoogleCB.Size = new System.Drawing.Size(129, 21);
            this.licenseGoogleCB.TabIndex = 1;
            this.licenseGoogleCB.Text = "Google License";
            this.licenseGoogleCB.UseVisualStyleBackColor = true;
            this.licenseGoogleCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // licenseAmazonCB
            // 
            this.licenseAmazonCB.AutoSize = true;
            this.licenseAmazonCB.Location = new System.Drawing.Point(140, 18);
            this.licenseAmazonCB.Margin = new System.Windows.Forms.Padding(0);
            this.licenseAmazonCB.Name = "licenseAmazonCB";
            this.licenseAmazonCB.Size = new System.Drawing.Size(134, 21);
            this.licenseAmazonCB.TabIndex = 0;
            this.licenseAmazonCB.Text = "Amazon License";
            this.licenseAmazonCB.UseVisualStyleBackColor = true;
            this.licenseAmazonCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // installerGBox
            // 
            this.installerGBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.installerGBox.Controls.Add(this.installerGoogleCB);
            this.installerGBox.Controls.Add(this.installerAmazonCB);
            this.installerGBox.Location = new System.Drawing.Point(8, 406);
            this.installerGBox.Margin = new System.Windows.Forms.Padding(4);
            this.installerGBox.MinimumSize = new System.Drawing.Size(307, 0);
            this.installerGBox.Name = "installerGBox";
            this.installerGBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.installerGBox.Size = new System.Drawing.Size(307, 44);
            this.installerGBox.TabIndex = 19;
            this.installerGBox.TabStop = false;
            this.installerGBox.Text = "Проверка установщика";
            // 
            // installerGoogleCB
            // 
            this.installerGoogleCB.AutoSize = true;
            this.installerGoogleCB.Location = new System.Drawing.Point(3, 18);
            this.installerGoogleCB.Margin = new System.Windows.Forms.Padding(0);
            this.installerGoogleCB.Name = "installerGoogleCB";
            this.installerGoogleCB.Size = new System.Drawing.Size(129, 21);
            this.installerGoogleCB.TabIndex = 0;
            this.installerGoogleCB.Text = "Google Installer";
            this.installerGoogleCB.UseVisualStyleBackColor = true;
            this.installerGoogleCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // installerAmazonCB
            // 
            this.installerAmazonCB.AutoSize = true;
            this.installerAmazonCB.Location = new System.Drawing.Point(140, 17);
            this.installerAmazonCB.Margin = new System.Windows.Forms.Padding(0);
            this.installerAmazonCB.Name = "installerAmazonCB";
            this.installerAmazonCB.Size = new System.Drawing.Size(134, 21);
            this.installerAmazonCB.TabIndex = 1;
            this.installerAmazonCB.Text = "Amazon Installer";
            this.installerAmazonCB.UseVisualStyleBackColor = true;
            this.installerAmazonCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // splashGBox
            // 
            this.splashGBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.splashGBox.Controls.Add(this.splashInstallCB);
            this.splashGBox.Controls.Add(this.splashRemoveCB);
            this.splashGBox.Location = new System.Drawing.Point(658, 7);
            this.splashGBox.Margin = new System.Windows.Forms.Padding(4);
            this.splashGBox.MinimumSize = new System.Drawing.Size(327, 0);
            this.splashGBox.Name = "splashGBox";
            this.splashGBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splashGBox.Size = new System.Drawing.Size(327, 44);
            this.splashGBox.TabIndex = 22;
            this.splashGBox.TabStop = false;
            this.splashGBox.Text = "Сплэшскрин";
            // 
            // splashInstallCB
            // 
            this.splashInstallCB.AutoSize = true;
            this.splashInstallCB.Location = new System.Drawing.Point(3, 18);
            this.splashInstallCB.Margin = new System.Windows.Forms.Padding(0);
            this.splashInstallCB.Name = "splashInstallCB";
            this.splashInstallCB.Size = new System.Drawing.Size(94, 21);
            this.splashInstallCB.TabIndex = 0;
            this.splashInstallCB.Text = "Добавить";
            this.splashInstallCB.UseVisualStyleBackColor = true;
            this.splashInstallCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // splashRemoveCB
            // 
            this.splashRemoveCB.AutoSize = true;
            this.splashRemoveCB.Location = new System.Drawing.Point(165, 18);
            this.splashRemoveCB.Margin = new System.Windows.Forms.Padding(0);
            this.splashRemoveCB.Name = "splashRemoveCB";
            this.splashRemoveCB.Size = new System.Drawing.Size(77, 21);
            this.splashRemoveCB.TabIndex = 1;
            this.splashRemoveCB.Text = "Убрать";
            this.splashRemoveCB.UseVisualStyleBackColor = true;
            this.splashRemoveCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // otherGBox
            // 
            this.otherGBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.otherGBox.Controls.Add(this.screenshotCB);
            this.otherGBox.Controls.Add(this.backKillCB);
            this.otherGBox.Controls.Add(this.backKillCBox);
            this.otherGBox.Controls.Add(this.blockSensorsCBox);
            this.otherGBox.Controls.Add(this.blockSensorsCB);
            this.otherGBox.Controls.Add(this.cloneTBox);
            this.otherGBox.Controls.Add(this.installLocationCBox);
            this.otherGBox.Controls.Add(this.cloneCB);
            this.otherGBox.Controls.Add(this.installLocationCB);
            this.otherGBox.Controls.Add(this.addSaveCB);
            this.otherGBox.Controls.Add(this.minSdkCB);
            this.otherGBox.Controls.Add(this.fullscreenCB);
            this.otherGBox.Controls.Add(this.addToastCB);
            this.otherGBox.Controls.Add(this.rootCheckCB);
            this.otherGBox.Controls.Add(this.minSdkCBox);
            this.otherGBox.Controls.Add(this.hideIconCB);
            this.otherGBox.Controls.Add(this.noUpdateCB);
            this.otherGBox.Controls.Add(this.toastMessageTBox);
            this.otherGBox.Controls.Add(this.mockLocationCB);
            this.otherGBox.Controls.Add(this.googleMapsCB);
            this.otherGBox.Controls.Add(this.dexCB);
            this.otherGBox.Controls.Add(this.reflectionLogCB);
            this.otherGBox.Location = new System.Drawing.Point(323, 7);
            this.otherGBox.Margin = new System.Windows.Forms.Padding(4);
            this.otherGBox.MinimumSize = new System.Drawing.Size(327, 0);
            this.otherGBox.Name = "otherGBox";
            this.otherGBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.otherGBox.Size = new System.Drawing.Size(327, 594);
            this.otherGBox.TabIndex = 23;
            this.otherGBox.TabStop = false;
            this.otherGBox.Text = "Другое";
            // 
            // screenshotCB
            // 
            this.screenshotCB.AutoSize = true;
            this.screenshotCB.Location = new System.Drawing.Point(5, 485);
            this.screenshotCB.Margin = new System.Windows.Forms.Padding(0);
            this.screenshotCB.Name = "screenshotCB";
            this.screenshotCB.Size = new System.Drawing.Size(296, 21);
            this.screenshotCB.TabIndex = 14;
            this.screenshotCB.Text = "Убрать запрет на создание скриншотов";
            this.screenshotCB.UseVisualStyleBackColor = true;
            this.screenshotCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // backKillCB
            // 
            this.backKillCB.AutoSize = true;
            this.backKillCB.Location = new System.Drawing.Point(5, 506);
            this.backKillCB.Margin = new System.Windows.Forms.Padding(0);
            this.backKillCB.Name = "backKillCB";
            this.backKillCB.Size = new System.Drawing.Size(254, 21);
            this.backKillCB.TabIndex = 15;
            this.backKillCB.Text = "Выход понажатию кнопки \"Назад\"";
            this.backKillCB.UseVisualStyleBackColor = true;
            this.backKillCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // backKillCBox
            // 
            this.backKillCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.backKillCBox.Enabled = false;
            this.backKillCBox.FormattingEnabled = true;
            this.backKillCBox.Items.AddRange(new object[] {
            "Двойное нажатие",
            "Долгий тап",
            "Одно нажатие"});
            this.backKillCBox.Location = new System.Drawing.Point(7, 530);
            this.backKillCBox.Margin = new System.Windows.Forms.Padding(1);
            this.backKillCBox.Name = "backKillCBox";
            this.backKillCBox.Size = new System.Drawing.Size(277, 24);
            this.backKillCBox.TabIndex = 20;
            // 
            // blockSensorsCBox
            // 
            this.blockSensorsCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blockSensorsCBox.Enabled = false;
            this.blockSensorsCBox.FormattingEnabled = true;
            this.blockSensorsCBox.Location = new System.Drawing.Point(5, 308);
            this.blockSensorsCBox.Margin = new System.Windows.Forms.Padding(4);
            this.blockSensorsCBox.Name = "blockSensorsCBox";
            this.blockSensorsCBox.Size = new System.Drawing.Size(279, 24);
            this.blockSensorsCBox.TabIndex = 25;
            // 
            // blockSensorsCB
            // 
            this.blockSensorsCB.AutoSize = true;
            this.blockSensorsCB.Location = new System.Drawing.Point(4, 284);
            this.blockSensorsCB.Margin = new System.Windows.Forms.Padding(0);
            this.blockSensorsCB.Name = "blockSensorsCB";
            this.blockSensorsCB.Size = new System.Drawing.Size(175, 21);
            this.blockSensorsCB.TabIndex = 7;
            this.blockSensorsCB.Text = "Блокировать сенсоры";
            this.blockSensorsCB.UseVisualStyleBackColor = true;
            this.blockSensorsCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // cloneTBox
            // 
            this.cloneTBox.Enabled = false;
            this.cloneTBox.Location = new System.Drawing.Point(5, 194);
            this.cloneTBox.Margin = new System.Windows.Forms.Padding(4);
            this.cloneTBox.Name = "cloneTBox";
            this.cloneTBox.Size = new System.Drawing.Size(279, 22);
            this.cloneTBox.TabIndex = 23;
            // 
            // installLocationCBox
            // 
            this.installLocationCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.installLocationCBox.Enabled = false;
            this.installLocationCBox.FormattingEnabled = true;
            this.installLocationCBox.Items.AddRange(new object[] {
            "auto",
            "preferExternal (внешняя память)",
            "internalOnly (внутренняя)"});
            this.installLocationCBox.Location = new System.Drawing.Point(5, 41);
            this.installLocationCBox.Margin = new System.Windows.Forms.Padding(1);
            this.installLocationCBox.Name = "installLocationCBox";
            this.installLocationCBox.Size = new System.Drawing.Size(279, 24);
            this.installLocationCBox.TabIndex = 8;
            // 
            // cloneCB
            // 
            this.cloneCB.AutoSize = true;
            this.cloneCB.Location = new System.Drawing.Point(4, 171);
            this.cloneCB.Margin = new System.Windows.Forms.Padding(0);
            this.cloneCB.Name = "cloneCB";
            this.cloneCB.Size = new System.Drawing.Size(143, 21);
            this.cloneCB.TabIndex = 3;
            this.cloneCB.Text = "Клонировать апк";
            this.cloneCB.UseVisualStyleBackColor = true;
            this.cloneCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // installLocationCB
            // 
            this.installLocationCB.AutoSize = true;
            this.installLocationCB.Location = new System.Drawing.Point(4, 17);
            this.installLocationCB.Margin = new System.Windows.Forms.Padding(0);
            this.installLocationCB.Name = "installLocationCB";
            this.installLocationCB.Size = new System.Drawing.Size(142, 21);
            this.installLocationCB.TabIndex = 0;
            this.installLocationCB.Text = "Место установки";
            this.installLocationCB.UseVisualStyleBackColor = true;
            this.installLocationCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // addSaveCB
            // 
            this.addSaveCB.AutoSize = true;
            this.addSaveCB.Location = new System.Drawing.Point(4, 338);
            this.addSaveCB.Margin = new System.Windows.Forms.Padding(0);
            this.addSaveCB.Name = "addSaveCB";
            this.addSaveCB.Size = new System.Drawing.Size(312, 21);
            this.addSaveCB.TabIndex = 8;
            this.addSaveCB.Text = "Встроить сохранение (res1 в папку assets)";
            this.addSaveCB.UseVisualStyleBackColor = true;
            this.addSaveCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // minSdkCB
            // 
            this.minSdkCB.AutoSize = true;
            this.minSdkCB.Location = new System.Drawing.Point(4, 73);
            this.minSdkCB.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.minSdkCB.Name = "minSdkCB";
            this.minSdkCB.Size = new System.Drawing.Size(293, 21);
            this.minSdkCB.TabIndex = 1;
            this.minSdkCB.Text = "Изменить минимальную версию Android";
            this.minSdkCB.UseVisualStyleBackColor = true;
            this.minSdkCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // fullscreenCB
            // 
            this.fullscreenCB.AutoSize = true;
            this.fullscreenCB.Location = new System.Drawing.Point(4, 359);
            this.fullscreenCB.Margin = new System.Windows.Forms.Padding(0);
            this.fullscreenCB.Name = "fullscreenCB";
            this.fullscreenCB.Size = new System.Drawing.Size(283, 21);
            this.fullscreenCB.TabIndex = 9;
            this.fullscreenCB.Text = "Приложение на весь экран (fullscreen)";
            this.fullscreenCB.UseVisualStyleBackColor = true;
            this.fullscreenCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // addToastCB
            // 
            this.addToastCB.AutoSize = true;
            this.addToastCB.Location = new System.Drawing.Point(4, 122);
            this.addToastCB.Margin = new System.Windows.Forms.Padding(0);
            this.addToastCB.Name = "addToastCB";
            this.addToastCB.Size = new System.Drawing.Size(270, 21);
            this.addToastCB.TabIndex = 2;
            this.addToastCB.Text = "Добавить Toast при первом запуске";
            this.addToastCB.UseVisualStyleBackColor = true;
            this.addToastCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // rootCheckCB
            // 
            this.rootCheckCB.AutoSize = true;
            this.rootCheckCB.Location = new System.Drawing.Point(4, 263);
            this.rootCheckCB.Margin = new System.Windows.Forms.Padding(0);
            this.rootCheckCB.Name = "rootCheckCB";
            this.rootCheckCB.Size = new System.Drawing.Size(208, 21);
            this.rootCheckCB.TabIndex = 6;
            this.rootCheckCB.Text = "Скрыть рут от приложения";
            this.rootCheckCB.UseVisualStyleBackColor = true;
            this.rootCheckCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // minSdkCBox
            // 
            this.minSdkCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minSdkCBox.Enabled = false;
            this.minSdkCBox.FormattingEnabled = true;
            this.minSdkCBox.Items.AddRange(new object[] {
            "1 - Android 1.0",
            "2 - Android 1.1",
            "3 - Android 1.5",
            "4 - Android 1.6",
            "5 - Android 2.0",
            "6 - Android 2.0.1",
            "7 - Android 2.1.x",
            "8 - Android 2.2.x",
            "9 - Android 2.3, 2.3.1, 2.3.2",
            "10 - Android 2.3.3, 2.3.4",
            "11 - Android 3.0.x",
            "12 - Android 3.1.x",
            "13 - Android 3.2",
            "14 - Android 4.0, 4.0.1, 4.0.2",
            "15 - Android 4.0.3, 4.0.4",
            "16 - Android 4.1, 4.1.1",
            "17 - Android 4.2, 4.2.2",
            "18 - Android 4.3",
            "19 - Android 4.4",
            "20 - Android 4.4W",
            "21 - Android 5.0",
            "22 - Android 5.1",
            "23 - Android 6.0",
            "24 - Android 7.0",
            "25 - Android 7.1, 7.1.1",
            "26 - Android O 8.0",
            "27 - Android 8.1",
            "28 - Android 9"});
            this.minSdkCBox.Location = new System.Drawing.Point(5, 96);
            this.minSdkCBox.Margin = new System.Windows.Forms.Padding(1);
            this.minSdkCBox.Name = "minSdkCBox";
            this.minSdkCBox.Size = new System.Drawing.Size(279, 24);
            this.minSdkCBox.TabIndex = 7;
            // 
            // hideIconCB
            // 
            this.hideIconCB.AutoSize = true;
            this.hideIconCB.Location = new System.Drawing.Point(4, 380);
            this.hideIconCB.Margin = new System.Windows.Forms.Padding(0);
            this.hideIconCB.Name = "hideIconCB";
            this.hideIconCB.Size = new System.Drawing.Size(206, 21);
            this.hideIconCB.TabIndex = 10;
            this.hideIconCB.Text = "Скрыть иконку из лончера";
            this.hideIconCB.UseVisualStyleBackColor = true;
            this.hideIconCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // noUpdateCB
            // 
            this.noUpdateCB.AutoSize = true;
            this.noUpdateCB.Location = new System.Drawing.Point(4, 242);
            this.noUpdateCB.Margin = new System.Windows.Forms.Padding(0);
            this.noUpdateCB.Name = "noUpdateCB";
            this.noUpdateCB.Size = new System.Drawing.Size(186, 21);
            this.noUpdateCB.TabIndex = 5;
            this.noUpdateCB.Text = "Отключить обновление";
            this.noUpdateCB.UseVisualStyleBackColor = true;
            this.noUpdateCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // toastMessageTBox
            // 
            this.toastMessageTBox.Enabled = false;
            this.toastMessageTBox.Location = new System.Drawing.Point(5, 144);
            this.toastMessageTBox.Margin = new System.Windows.Forms.Padding(1);
            this.toastMessageTBox.Name = "toastMessageTBox";
            this.toastMessageTBox.Size = new System.Drawing.Size(279, 22);
            this.toastMessageTBox.TabIndex = 6;
            this.toastMessageTBox.Text = "Ваш текст";
            // 
            // mockLocationCB
            // 
            this.mockLocationCB.AutoSize = true;
            this.mockLocationCB.Location = new System.Drawing.Point(4, 401);
            this.mockLocationCB.Margin = new System.Windows.Forms.Padding(0);
            this.mockLocationCB.Name = "mockLocationCB";
            this.mockLocationCB.Size = new System.Drawing.Size(295, 21);
            this.mockLocationCB.TabIndex = 11;
            this.mockLocationCB.Text = "Разрешить фиктивное местоположение";
            this.mockLocationCB.UseVisualStyleBackColor = true;
            this.mockLocationCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // googleMapsCB
            // 
            this.googleMapsCB.AutoSize = true;
            this.googleMapsCB.Location = new System.Drawing.Point(4, 222);
            this.googleMapsCB.Margin = new System.Windows.Forms.Padding(0);
            this.googleMapsCB.Name = "googleMapsCB";
            this.googleMapsCB.Size = new System.Drawing.Size(194, 21);
            this.googleMapsCB.TabIndex = 4;
            this.googleMapsCB.Text = "Исправить карты Google";
            this.googleMapsCB.UseVisualStyleBackColor = true;
            this.googleMapsCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // dexCB
            // 
            this.dexCB.Location = new System.Drawing.Point(5, 443);
            this.dexCB.Margin = new System.Windows.Forms.Padding(0);
            this.dexCB.Name = "dexCB";
            this.dexCB.Size = new System.Drawing.Size(308, 42);
            this.dexCB.TabIndex = 13;
            this.dexCB.Text = "Извл/подмена dex в apk,защищенных DexGuard";
            this.dexCB.UseVisualStyleBackColor = true;
            this.dexCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // reflectionLogCB
            // 
            this.reflectionLogCB.AutoSize = true;
            this.reflectionLogCB.Location = new System.Drawing.Point(4, 422);
            this.reflectionLogCB.Margin = new System.Windows.Forms.Padding(0);
            this.reflectionLogCB.Name = "reflectionLogCB";
            this.reflectionLogCB.Size = new System.Drawing.Size(130, 21);
            this.reflectionLogCB.TabIndex = 12;
            this.reflectionLogCB.Text = "Лог рефлексии";
            this.reflectionLogCB.UseVisualStyleBackColor = true;
            this.reflectionLogCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // gpsLatitudeTBox
            // 
            this.gpsLatitudeTBox.Enabled = false;
            this.gpsLatitudeTBox.Location = new System.Drawing.Point(189, 503);
            this.gpsLatitudeTBox.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.gpsLatitudeTBox.Name = "gpsLatitudeTBox";
            this.gpsLatitudeTBox.Size = new System.Drawing.Size(77, 22);
            this.gpsLatitudeTBox.TabIndex = 83;
            // 
            // gpsLongitudeTBox
            // 
            this.gpsLongitudeTBox.Enabled = false;
            this.gpsLongitudeTBox.Location = new System.Drawing.Point(271, 503);
            this.gpsLongitudeTBox.Margin = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.gpsLongitudeTBox.Name = "gpsLongitudeTBox";
            this.gpsLongitudeTBox.Size = new System.Drawing.Size(77, 22);
            this.gpsLongitudeTBox.TabIndex = 84;
            // 
            // gpsCB
            // 
            this.gpsCB.Location = new System.Drawing.Point(5, 506);
            this.gpsCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.gpsCB.Name = "gpsCB";
            this.gpsCB.Size = new System.Drawing.Size(64, 22);
            this.gpsCB.TabIndex = 55;
            this.gpsCB.Text = "GPS";
            this.gpsCB.UseVisualStyleBackColor = true;
            this.gpsCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // timeCB
            // 
            this.timeCB.AutoSize = true;
            this.timeCB.Location = new System.Drawing.Point(5, 533);
            this.timeCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.timeCB.Name = "timeCB";
            this.timeCB.Size = new System.Drawing.Size(72, 21);
            this.timeCB.TabIndex = 58;
            this.timeCB.Text = "Время";
            this.timeCB.UseVisualStyleBackColor = true;
            this.timeCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // deviceIdTBox
            // 
            this.deviceIdTBox.Enabled = false;
            this.deviceIdTBox.Location = new System.Drawing.Point(188, 16);
            this.deviceIdTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.deviceIdTBox.Name = "deviceIdTBox";
            this.deviceIdTBox.Size = new System.Drawing.Size(159, 22);
            this.deviceIdTBox.TabIndex = 62;
            // 
            // accountCB
            // 
            this.accountCB.Location = new System.Drawing.Point(5, 559);
            this.accountCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.accountCB.Name = "accountCB";
            this.accountCB.Size = new System.Drawing.Size(129, 22);
            this.accountCB.TabIndex = 60;
            this.accountCB.Text = "Account Name";
            this.accountCB.UseVisualStyleBackColor = true;
            this.accountCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // androidIdTBox
            // 
            this.androidIdTBox.Enabled = false;
            this.androidIdTBox.Location = new System.Drawing.Point(188, 43);
            this.androidIdTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.androidIdTBox.Name = "androidIdTBox";
            this.androidIdTBox.Size = new System.Drawing.Size(159, 22);
            this.androidIdTBox.TabIndex = 63;
            // 
            // allAutoCB
            // 
            this.allAutoCB.AutoSize = true;
            this.allAutoCB.Location = new System.Drawing.Point(5, 613);
            this.allAutoCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.allAutoCB.Name = "allAutoCB";
            this.allAutoCB.Size = new System.Drawing.Size(98, 21);
            this.allAutoCB.TabIndex = 62;
            this.allAutoCB.Text = "Все (авто)";
            this.allAutoCB.UseVisualStyleBackColor = true;
            this.allAutoCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // brandCB
            // 
            this.brandCB.Location = new System.Drawing.Point(4, 208);
            this.brandCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.brandCB.Name = "brandCB";
            this.brandCB.Size = new System.Drawing.Size(72, 22);
            this.brandCB.TabIndex = 19;
            this.brandCB.Text = "Brand";
            this.brandCB.UseVisualStyleBackColor = true;
            this.brandCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // allManualCB
            // 
            this.allManualCB.AutoSize = true;
            this.allManualCB.Location = new System.Drawing.Point(189, 613);
            this.allManualCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.allManualCB.Name = "allManualCB";
            this.allManualCB.Size = new System.Drawing.Size(99, 21);
            this.allManualCB.TabIndex = 63;
            this.allManualCB.Text = "Все (ручн)";
            this.allManualCB.UseVisualStyleBackColor = true;
            this.allManualCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // wifiMacTBox
            // 
            this.wifiMacTBox.Enabled = false;
            this.wifiMacTBox.Location = new System.Drawing.Point(188, 70);
            this.wifiMacTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.wifiMacTBox.Name = "wifiMacTBox";
            this.wifiMacTBox.Size = new System.Drawing.Size(159, 22);
            this.wifiMacTBox.TabIndex = 64;
            // 
            // ipCB
            // 
            this.ipCB.Location = new System.Drawing.Point(4, 235);
            this.ipCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.ipCB.Name = "ipCB";
            this.ipCB.Size = new System.Drawing.Size(48, 22);
            this.ipCB.TabIndex = 22;
            this.ipCB.Text = "IP";
            this.ipCB.UseVisualStyleBackColor = true;
            this.ipCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // bluetoothMacTBox
            // 
            this.bluetoothMacTBox.Enabled = false;
            this.bluetoothMacTBox.Location = new System.Drawing.Point(188, 97);
            this.bluetoothMacTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.bluetoothMacTBox.Name = "bluetoothMacTBox";
            this.bluetoothMacTBox.Size = new System.Drawing.Size(159, 22);
            this.bluetoothMacTBox.TabIndex = 65;
            // 
            // bluetoothAddressTBox
            // 
            this.bluetoothAddressTBox.Enabled = false;
            this.bluetoothAddressTBox.Location = new System.Drawing.Point(188, 124);
            this.bluetoothAddressTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.bluetoothAddressTBox.Name = "bluetoothAddressTBox";
            this.bluetoothAddressTBox.Size = new System.Drawing.Size(159, 22);
            this.bluetoothAddressTBox.TabIndex = 79;
            // 
            // serialTBox
            // 
            this.serialTBox.Enabled = false;
            this.serialTBox.Location = new System.Drawing.Point(188, 151);
            this.serialTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.serialTBox.Name = "serialTBox";
            this.serialTBox.Size = new System.Drawing.Size(159, 22);
            this.serialTBox.TabIndex = 66;
            // 
            // bssidCB
            // 
            this.bssidCB.Location = new System.Drawing.Point(4, 262);
            this.bssidCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.bssidCB.Name = "bssidCB";
            this.bssidCB.Size = new System.Drawing.Size(77, 22);
            this.bssidCB.TabIndex = 25;
            this.bssidCB.Text = "BSSID";
            this.bssidCB.UseVisualStyleBackColor = true;
            this.bssidCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // deviceIdCB
            // 
            this.deviceIdCB.Location = new System.Drawing.Point(4, 18);
            this.deviceIdCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.deviceIdCB.Name = "deviceIdCB";
            this.deviceIdCB.Size = new System.Drawing.Size(99, 22);
            this.deviceIdCB.TabIndex = 1;
            this.deviceIdCB.Text = "Device ID";
            this.deviceIdCB.UseVisualStyleBackColor = true;
            this.deviceIdCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // deviceCB
            // 
            this.deviceCB.Location = new System.Drawing.Point(4, 289);
            this.deviceCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.deviceCB.Name = "deviceCB";
            this.deviceCB.Size = new System.Drawing.Size(80, 22);
            this.deviceCB.TabIndex = 28;
            this.deviceCB.Text = "Device";
            this.deviceCB.UseVisualStyleBackColor = true;
            this.deviceCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // modelTBox
            // 
            this.modelTBox.Enabled = false;
            this.modelTBox.Location = new System.Drawing.Point(188, 178);
            this.modelTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.modelTBox.Name = "modelTBox";
            this.modelTBox.Size = new System.Drawing.Size(159, 22);
            this.modelTBox.TabIndex = 67;
            // 
            // brandTBox
            // 
            this.brandTBox.Enabled = false;
            this.brandTBox.Location = new System.Drawing.Point(188, 206);
            this.brandTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.brandTBox.Name = "brandTBox";
            this.brandTBox.Size = new System.Drawing.Size(159, 22);
            this.brandTBox.TabIndex = 68;
            // 
            // boardCB
            // 
            this.boardCB.Location = new System.Drawing.Point(4, 316);
            this.boardCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.boardCB.Name = "boardCB";
            this.boardCB.Size = new System.Drawing.Size(72, 22);
            this.boardCB.TabIndex = 31;
            this.boardCB.Text = "Board";
            this.boardCB.UseVisualStyleBackColor = true;
            this.boardCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // androidIdCB
            // 
            this.androidIdCB.Location = new System.Drawing.Point(4, 46);
            this.androidIdCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.androidIdCB.Name = "androidIdCB";
            this.androidIdCB.Size = new System.Drawing.Size(101, 22);
            this.androidIdCB.TabIndex = 4;
            this.androidIdCB.Text = "Android ID";
            this.androidIdCB.UseVisualStyleBackColor = true;
            this.androidIdCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // manufacturerCB
            // 
            this.manufacturerCB.Location = new System.Drawing.Point(4, 343);
            this.manufacturerCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.manufacturerCB.Name = "manufacturerCB";
            this.manufacturerCB.Size = new System.Drawing.Size(119, 22);
            this.manufacturerCB.TabIndex = 34;
            this.manufacturerCB.Text = "Manufacturer";
            this.manufacturerCB.UseVisualStyleBackColor = true;
            this.manufacturerCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // ipTBox
            // 
            this.ipTBox.Enabled = false;
            this.ipTBox.Location = new System.Drawing.Point(188, 233);
            this.ipTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.ipTBox.Name = "ipTBox";
            this.ipTBox.Size = new System.Drawing.Size(159, 22);
            this.ipTBox.TabIndex = 69;
            // 
            // productCB
            // 
            this.productCB.Location = new System.Drawing.Point(4, 370);
            this.productCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.productCB.Name = "productCB";
            this.productCB.Size = new System.Drawing.Size(84, 22);
            this.productCB.TabIndex = 37;
            this.productCB.Text = "Product";
            this.productCB.UseVisualStyleBackColor = true;
            this.productCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // bssidTBox
            // 
            this.bssidTBox.Enabled = false;
            this.bssidTBox.Location = new System.Drawing.Point(188, 260);
            this.bssidTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.bssidTBox.Name = "bssidTBox";
            this.bssidTBox.Size = new System.Drawing.Size(159, 22);
            this.bssidTBox.TabIndex = 70;
            // 
            // operatorNameCB
            // 
            this.operatorNameCB.Location = new System.Drawing.Point(4, 398);
            this.operatorNameCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.operatorNameCB.Name = "operatorNameCB";
            this.operatorNameCB.Size = new System.Drawing.Size(131, 22);
            this.operatorNameCB.TabIndex = 40;
            this.operatorNameCB.Text = "Operator Name";
            this.operatorNameCB.UseVisualStyleBackColor = true;
            this.operatorNameCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // deviceTBox
            // 
            this.deviceTBox.Enabled = false;
            this.deviceTBox.Location = new System.Drawing.Point(188, 287);
            this.deviceTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.deviceTBox.Name = "deviceTBox";
            this.deviceTBox.Size = new System.Drawing.Size(159, 22);
            this.deviceTBox.TabIndex = 71;
            // 
            // operatorCB
            // 
            this.operatorCB.Location = new System.Drawing.Point(4, 425);
            this.operatorCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.operatorCB.Name = "operatorCB";
            this.operatorCB.Size = new System.Drawing.Size(89, 22);
            this.operatorCB.TabIndex = 43;
            this.operatorCB.Text = "Operator";
            this.operatorCB.UseVisualStyleBackColor = true;
            this.operatorCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // boardTBox
            // 
            this.boardTBox.Enabled = false;
            this.boardTBox.Location = new System.Drawing.Point(188, 314);
            this.boardTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.boardTBox.Name = "boardTBox";
            this.boardTBox.Size = new System.Drawing.Size(159, 22);
            this.boardTBox.TabIndex = 72;
            // 
            // subscriberIdCB
            // 
            this.subscriberIdCB.Location = new System.Drawing.Point(4, 452);
            this.subscriberIdCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.subscriberIdCB.Name = "subscriberIdCB";
            this.subscriberIdCB.Size = new System.Drawing.Size(120, 22);
            this.subscriberIdCB.TabIndex = 46;
            this.subscriberIdCB.Text = "Subscriber ID";
            this.subscriberIdCB.UseVisualStyleBackColor = true;
            this.subscriberIdCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // wifiMacAddressCB
            // 
            this.wifiMacAddressCB.Location = new System.Drawing.Point(4, 73);
            this.wifiMacAddressCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.wifiMacAddressCB.Name = "wifiMacAddressCB";
            this.wifiMacAddressCB.Size = new System.Drawing.Size(165, 22);
            this.wifiMacAddressCB.TabIndex = 7;
            this.wifiMacAddressCB.Text = "WiFi Mac Address";
            this.wifiMacAddressCB.UseVisualStyleBackColor = true;
            this.wifiMacAddressCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // simSerialNumberCB
            // 
            this.simSerialNumberCB.Location = new System.Drawing.Point(4, 479);
            this.simSerialNumberCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.simSerialNumberCB.Name = "simSerialNumberCB";
            this.simSerialNumberCB.Size = new System.Drawing.Size(149, 22);
            this.simSerialNumberCB.TabIndex = 49;
            this.simSerialNumberCB.Text = "Sim Serial Number";
            this.simSerialNumberCB.UseVisualStyleBackColor = true;
            this.simSerialNumberCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // manufacturerTBox
            // 
            this.manufacturerTBox.Enabled = false;
            this.manufacturerTBox.Location = new System.Drawing.Point(188, 341);
            this.manufacturerTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.manufacturerTBox.Name = "manufacturerTBox";
            this.manufacturerTBox.Size = new System.Drawing.Size(159, 22);
            this.manufacturerTBox.TabIndex = 73;
            // 
            // productTBox
            // 
            this.productTBox.Enabled = false;
            this.productTBox.Location = new System.Drawing.Point(188, 368);
            this.productTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.productTBox.Name = "productTBox";
            this.productTBox.Size = new System.Drawing.Size(159, 22);
            this.productTBox.TabIndex = 74;
            // 
            // modelCB
            // 
            this.modelCB.Location = new System.Drawing.Point(4, 181);
            this.modelCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.modelCB.Name = "modelCB";
            this.modelCB.Size = new System.Drawing.Size(73, 22);
            this.modelCB.TabIndex = 16;
            this.modelCB.Text = "Model";
            this.modelCB.UseVisualStyleBackColor = true;
            this.modelCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // operatorNameTBox
            // 
            this.operatorNameTBox.Enabled = false;
            this.operatorNameTBox.Location = new System.Drawing.Point(188, 395);
            this.operatorNameTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.operatorNameTBox.Name = "operatorNameTBox";
            this.operatorNameTBox.Size = new System.Drawing.Size(159, 22);
            this.operatorNameTBox.TabIndex = 75;
            // 
            // operatorTBox
            // 
            this.operatorTBox.Enabled = false;
            this.operatorTBox.Location = new System.Drawing.Point(188, 422);
            this.operatorTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.operatorTBox.Name = "operatorTBox";
            this.operatorTBox.Size = new System.Drawing.Size(159, 22);
            this.operatorTBox.TabIndex = 76;
            // 
            // bluetoothMacAddressCB
            // 
            this.bluetoothMacAddressCB.Location = new System.Drawing.Point(4, 100);
            this.bluetoothMacAddressCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.bluetoothMacAddressCB.Name = "bluetoothMacAddressCB";
            this.bluetoothMacAddressCB.Size = new System.Drawing.Size(181, 22);
            this.bluetoothMacAddressCB.TabIndex = 10;
            this.bluetoothMacAddressCB.Text = "Bluetooth Mac Address";
            this.bluetoothMacAddressCB.UseVisualStyleBackColor = true;
            this.bluetoothMacAddressCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // subscriderIdTBox
            // 
            this.subscriderIdTBox.Enabled = false;
            this.subscriderIdTBox.Location = new System.Drawing.Point(188, 449);
            this.subscriderIdTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.subscriderIdTBox.Name = "subscriderIdTBox";
            this.subscriderIdTBox.Size = new System.Drawing.Size(159, 22);
            this.subscriderIdTBox.TabIndex = 77;
            // 
            // simSerialNumberTBox
            // 
            this.simSerialNumberTBox.Enabled = false;
            this.simSerialNumberTBox.Location = new System.Drawing.Point(188, 476);
            this.simSerialNumberTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.simSerialNumberTBox.Name = "simSerialNumberTBox";
            this.simSerialNumberTBox.Size = new System.Drawing.Size(159, 22);
            this.simSerialNumberTBox.TabIndex = 78;
            // 
            // serialCB
            // 
            this.serialCB.Location = new System.Drawing.Point(4, 154);
            this.serialCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.serialCB.Name = "serialCB";
            this.serialCB.Size = new System.Drawing.Size(69, 22);
            this.serialCB.TabIndex = 13;
            this.serialCB.Text = "Serial";
            this.serialCB.UseVisualStyleBackColor = true;
            this.serialCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // timeTBox
            // 
            this.timeTBox.Enabled = false;
            this.timeTBox.Location = new System.Drawing.Point(189, 530);
            this.timeTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.timeTBox.Name = "timeTBox";
            this.timeTBox.Size = new System.Drawing.Size(159, 22);
            this.timeTBox.TabIndex = 81;
            // 
            // bluetoothAddressCB
            // 
            this.bluetoothAddressCB.Location = new System.Drawing.Point(4, 127);
            this.bluetoothAddressCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.bluetoothAddressCB.Name = "bluetoothAddressCB";
            this.bluetoothAddressCB.Size = new System.Drawing.Size(149, 22);
            this.bluetoothAddressCB.TabIndex = 52;
            this.bluetoothAddressCB.Text = "Bluetooth Address";
            this.bluetoothAddressCB.UseVisualStyleBackColor = true;
            this.bluetoothAddressCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // accountTBox
            // 
            this.accountTBox.Enabled = false;
            this.accountTBox.Location = new System.Drawing.Point(189, 558);
            this.accountTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.accountTBox.Name = "accountTBox";
            this.accountTBox.Size = new System.Drawing.Size(159, 22);
            this.accountTBox.TabIndex = 82;
            // 
            // clearAll
            // 
            this.clearAll.BackColor = System.Drawing.Color.LightSalmon;
            this.clearAll.Location = new System.Drawing.Point(233, 571);
            this.clearAll.Margin = new System.Windows.Forms.Padding(0);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(211, 28);
            this.clearAll.TabIndex = 10;
            this.clearAll.Text = "Очистить все";
            this.clearAll.UseVisualStyleBackColor = false;
            this.clearAll.Click += new System.EventHandler(this.clearBoxes_Click);
            // 
            // tabsControl
            // 
            this.tabsControl.Controls.Add(this.mainTab);
            this.tabsControl.Controls.Add(this.toolsTab);
            this.tabsControl.Controls.Add(this.aboutTab);
            this.tabsControl.Location = new System.Drawing.Point(1034, 1);
            this.tabsControl.Margin = new System.Windows.Forms.Padding(1);
            this.tabsControl.MinimumSize = new System.Drawing.Size(456, 0);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(456, 671);
            this.tabsControl.TabIndex = 13;
            // 
            // mainTab
            // 
            this.mainTab.BackColor = System.Drawing.SystemColors.Control;
            this.mainTab.Controls.Add(this.openFolderButton);
            this.mainTab.Controls.Add(this.saveCheckboxButton);
            this.mainTab.Controls.Add(this.startButton);
            this.mainTab.Controls.Add(this.orderLv);
            this.mainTab.Controls.Add(this.clearAll);
            this.mainTab.Location = new System.Drawing.Point(4, 25);
            this.mainTab.Margin = new System.Windows.Forms.Padding(4);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(4);
            this.mainTab.Size = new System.Drawing.Size(448, 642);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Главная";
            // 
            // openFolderButton
            // 
            this.openFolderButton.AutoSize = true;
            this.openFolderButton.Location = new System.Drawing.Point(4, 539);
            this.openFolderButton.Margin = new System.Windows.Forms.Padding(0);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(440, 33);
            this.openFolderButton.TabIndex = 20;
            this.openFolderButton.Text = "Открыть папку Apk";
            this.openFolderButton.UseVisualStyleBackColor = true;
            this.openFolderButton.Click += new System.EventHandler(this.openFoldersButton_Click);
            // 
            // saveCheckboxButton
            // 
            this.saveCheckboxButton.BackColor = System.Drawing.Color.MistyRose;
            this.saveCheckboxButton.Location = new System.Drawing.Point(4, 603);
            this.saveCheckboxButton.Margin = new System.Windows.Forms.Padding(0);
            this.saveCheckboxButton.Name = "saveCheckboxButton";
            this.saveCheckboxButton.Size = new System.Drawing.Size(440, 28);
            this.saveCheckboxButton.TabIndex = 20;
            this.saveCheckboxButton.Text = "Сохранить состояние чекбоксов";
            this.saveCheckboxButton.UseVisualStyleBackColor = false;
            this.saveCheckboxButton.Click += new System.EventHandler(this.saveCheckboxButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.GreenYellow;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.startButton.Location = new System.Drawing.Point(4, 571);
            this.startButton.Margin = new System.Windows.Forms.Padding(0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(211, 28);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "Пропатчить apk";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // orderLv
            // 
            this.orderLv.AllowDrop = true;
            this.orderLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName});
            this.orderLv.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderLv.FullRowSelect = true;
            this.orderLv.GridLines = true;
            this.orderLv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.orderLv.Location = new System.Drawing.Point(4, 4);
            this.orderLv.Margin = new System.Windows.Forms.Padding(4);
            this.orderLv.MultiSelect = false;
            this.orderLv.Name = "orderLv";
            this.orderLv.Size = new System.Drawing.Size(440, 531);
            this.orderLv.TabIndex = 13;
            this.orderLv.UseCompatibleStateImageBehavior = false;
            this.orderLv.View = System.Windows.Forms.View.Details;
            this.orderLv.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.orderLv_ItemDrag);
            this.orderLv.DragDrop += new System.Windows.Forms.DragEventHandler(this.orderLv_DragDrop);
            this.orderLv.DragEnter += new System.Windows.Forms.DragEventHandler(this.orderLv_DragEnter);
            // 
            // columnName
            // 
            this.columnName.Text = "Очередность патчей";
            this.columnName.Width = 302;
            // 
            // toolsTab
            // 
            this.toolsTab.BackColor = System.Drawing.SystemColors.Control;
            this.toolsTab.Controls.Add(this.btnSettings);
            this.toolsTab.Controls.Add(this.btnHelp);
            this.toolsTab.Controls.Add(this.mehButton);
            this.toolsTab.Controls.Add(this.mergeStringsButton);
            this.toolsTab.Controls.Add(this.interestingPlacesButton);
            this.toolsTab.Controls.Add(this.hideIdsButton);
            this.toolsTab.Controls.Add(this.collectStringsButton);
            this.toolsTab.Controls.Add(this.addDebugInfoButton);
            this.toolsTab.Controls.Add(this.remDebugInfoButton);
            this.toolsTab.Controls.Add(this.helpSmaliButton);
            this.toolsTab.Location = new System.Drawing.Point(4, 25);
            this.toolsTab.Margin = new System.Windows.Forms.Padding(4);
            this.toolsTab.Name = "toolsTab";
            this.toolsTab.Size = new System.Drawing.Size(448, 642);
            this.toolsTab.TabIndex = 3;
            this.toolsTab.Text = "Инструменты";
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSettings.Location = new System.Drawing.Point(4, 576);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(440, 28);
            this.btnSettings.TabIndex = 25;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHelp.ForeColor = System.Drawing.Color.Maroon;
            this.btnHelp.Location = new System.Drawing.Point(4, 610);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(440, 28);
            this.btnHelp.TabIndex = 24;
            this.btnHelp.Text = "H e l p";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // mehButton
            // 
            this.mehButton.Location = new System.Drawing.Point(4, 218);
            this.mehButton.Margin = new System.Windows.Forms.Padding(4);
            this.mehButton.Name = "mehButton";
            this.mehButton.Size = new System.Drawing.Size(440, 28);
            this.mehButton.TabIndex = 23;
            this.mehButton.Text = "¯\\_(ツ)_/¯";
            this.mehButton.UseVisualStyleBackColor = false;
            this.mehButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // mergeStringsButton
            // 
            this.mergeStringsButton.BackColor = System.Drawing.SystemColors.Control;
            this.mergeStringsButton.Location = new System.Drawing.Point(4, 182);
            this.mergeStringsButton.Margin = new System.Windows.Forms.Padding(4);
            this.mergeStringsButton.Name = "mergeStringsButton";
            this.mergeStringsButton.Size = new System.Drawing.Size(440, 28);
            this.mergeStringsButton.TabIndex = 22;
            this.mergeStringsButton.Text = "Перенос перевода из одного strings.xml в другой";
            this.mergeStringsButton.UseVisualStyleBackColor = false;
            this.mergeStringsButton.Click += new System.EventHandler(this.mergeStringsButton_Click);
            // 
            // interestingPlacesButton
            // 
            this.interestingPlacesButton.BackColor = System.Drawing.SystemColors.Control;
            this.interestingPlacesButton.Location = new System.Drawing.Point(4, 146);
            this.interestingPlacesButton.Margin = new System.Windows.Forms.Padding(4);
            this.interestingPlacesButton.Name = "interestingPlacesButton";
            this.interestingPlacesButton.Size = new System.Drawing.Size(440, 28);
            this.interestingPlacesButton.TabIndex = 21;
            this.interestingPlacesButton.Text = "Интересные места";
            this.interestingPlacesButton.UseVisualStyleBackColor = false;
            this.interestingPlacesButton.Click += new System.EventHandler(this.interestingPlacesButton_Click);
            // 
            // hideIdsButton
            // 
            this.hideIdsButton.BackColor = System.Drawing.SystemColors.Control;
            this.hideIdsButton.Location = new System.Drawing.Point(4, 111);
            this.hideIdsButton.Margin = new System.Windows.Forms.Padding(4);
            this.hideIdsButton.Name = "hideIdsButton";
            this.hideIdsButton.Size = new System.Drawing.Size(440, 28);
            this.hideIdsButton.TabIndex = 20;
            this.hideIdsButton.Text = "Список всех ID в layout";
            this.hideIdsButton.UseVisualStyleBackColor = false;
            this.hideIdsButton.Click += new System.EventHandler(this.hideIdsButton_Click);
            // 
            // collectStringsButton
            // 
            this.collectStringsButton.BackColor = System.Drawing.SystemColors.Control;
            this.collectStringsButton.Location = new System.Drawing.Point(4, 75);
            this.collectStringsButton.Margin = new System.Windows.Forms.Padding(4);
            this.collectStringsButton.Name = "collectStringsButton";
            this.collectStringsButton.Size = new System.Drawing.Size(440, 28);
            this.collectStringsButton.TabIndex = 19;
            this.collectStringsButton.Text = "Собрать все строки в values/strings.xml";
            this.collectStringsButton.UseVisualStyleBackColor = false;
            this.collectStringsButton.Click += new System.EventHandler(this.collectStringsButton_Click);
            // 
            // addDebugInfoButton
            // 
            this.addDebugInfoButton.BackColor = System.Drawing.Color.Ivory;
            this.addDebugInfoButton.Location = new System.Drawing.Point(4, 4);
            this.addDebugInfoButton.Margin = new System.Windows.Forms.Padding(4);
            this.addDebugInfoButton.Name = "addDebugInfoButton";
            this.addDebugInfoButton.Size = new System.Drawing.Size(313, 28);
            this.addDebugInfoButton.TabIndex = 17;
            this.addDebugInfoButton.Text = "Добавить отладочную информацию в smali";
            this.addDebugInfoButton.UseVisualStyleBackColor = false;
            this.addDebugInfoButton.Click += new System.EventHandler(this.addDebugInfoButton_Click);
            // 
            // remDebugInfoButton
            // 
            this.remDebugInfoButton.BackColor = System.Drawing.Color.Ivory;
            this.remDebugInfoButton.Location = new System.Drawing.Point(325, 4);
            this.remDebugInfoButton.Margin = new System.Windows.Forms.Padding(4);
            this.remDebugInfoButton.Name = "remDebugInfoButton";
            this.remDebugInfoButton.Size = new System.Drawing.Size(119, 28);
            this.remDebugInfoButton.TabIndex = 18;
            this.remDebugInfoButton.Text = "Удалить";
            this.remDebugInfoButton.UseVisualStyleBackColor = false;
            this.remDebugInfoButton.Click += new System.EventHandler(this.remDebugInfoButton_Click);
            // 
            // helpSmaliButton
            // 
            this.helpSmaliButton.BackColor = System.Drawing.SystemColors.Control;
            this.helpSmaliButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.helpSmaliButton.Location = new System.Drawing.Point(4, 39);
            this.helpSmaliButton.Margin = new System.Windows.Forms.Padding(4);
            this.helpSmaliButton.Name = "helpSmaliButton";
            this.helpSmaliButton.Size = new System.Drawing.Size(440, 28);
            this.helpSmaliButton.TabIndex = 16;
            this.helpSmaliButton.Text = "Добавить вспомогательную инфу в smali";
            this.helpSmaliButton.UseVisualStyleBackColor = false;
            this.helpSmaliButton.Click += new System.EventHandler(this.helpSmaliButton_Click);
            // 
            // aboutTab
            // 
            this.aboutTab.BackColor = System.Drawing.SystemColors.Control;
            this.aboutTab.Controls.Add(this.Changelog_btn);
            this.aboutTab.Controls.Add(this.authorLabel3);
            this.aboutTab.Controls.Add(this.new_author2);
            this.aboutTab.Controls.Add(this.authorLabel2);
            this.aboutTab.Controls.Add(this.linkLabel2);
            this.aboutTab.Controls.Add(this.buildDateLabel);
            this.aboutTab.Controls.Add(this.lblBuild);
            this.aboutTab.Controls.Add(this.lblVersion);
            this.aboutTab.Controls.Add(this.versionLabel);
            this.aboutTab.Controls.Add(this.textBox1);
            this.aboutTab.Controls.Add(this.label5);
            this.aboutTab.Controls.Add(this.yandexMoneyLabel);
            this.aboutTab.Controls.Add(this.authorLabel);
            this.aboutTab.Controls.Add(this.yanMoneyLink);
            this.aboutTab.Controls.Add(this.donateLabel);
            this.aboutTab.Controls.Add(this.linkLabel1);
            this.aboutTab.Controls.Add(this.pictureBox1);
            this.aboutTab.Location = new System.Drawing.Point(4, 25);
            this.aboutTab.Margin = new System.Windows.Forms.Padding(4);
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Size = new System.Drawing.Size(448, 642);
            this.aboutTab.TabIndex = 2;
            this.aboutTab.Text = "About";
            // 
            // Changelog_btn
            // 
            this.Changelog_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Changelog_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Changelog_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Changelog_btn.ForeColor = System.Drawing.Color.ForestGreen;
            this.Changelog_btn.Location = new System.Drawing.Point(156, 432);
            this.Changelog_btn.Name = "Changelog_btn";
            this.Changelog_btn.Size = new System.Drawing.Size(113, 34);
            this.Changelog_btn.TabIndex = 18;
            this.Changelog_btn.Text = "Changelog";
            this.Changelog_btn.UseVisualStyleBackColor = false;
            this.Changelog_btn.Click += new System.EventHandler(this.Changelog_btn_Click);
            // 
            // authorLabel3
            // 
            this.authorLabel3.AutoSize = true;
            this.authorLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLabel3.Location = new System.Drawing.Point(22, 225);
            this.authorLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.authorLabel3.Name = "authorLabel3";
            this.authorLabel3.Size = new System.Drawing.Size(140, 20);
            this.authorLabel3.TabIndex = 16;
            this.authorLabel3.Text = "Автор (v7b2-???):";
            this.authorLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // new_author2
            // 
            this.new_author2.AutoSize = true;
            this.new_author2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_author2.Location = new System.Drawing.Point(188, 224);
            this.new_author2.Margin = new System.Windows.Forms.Padding(4);
            this.new_author2.Name = "new_author2";
            this.new_author2.Size = new System.Drawing.Size(61, 20);
            this.new_author2.TabIndex = 17;
            this.new_author2.TabStop = true;
            this.new_author2.Text = "Mr Ikso";
            this.new_author2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.new_author2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.new_author2_LinkClicked);
            // 
            // authorLabel2
            // 
            this.authorLabel2.AutoSize = true;
            this.authorLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLabel2.Location = new System.Drawing.Point(21, 197);
            this.authorLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.authorLabel2.Name = "authorLabel2";
            this.authorLabel2.Size = new System.Drawing.Size(138, 20);
            this.authorLabel2.TabIndex = 14;
            this.authorLabel2.Text = "Автор (v6d-v7b2):";
            this.authorLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel2.Location = new System.Drawing.Point(188, 196);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(68, 20);
            this.linkLabel2.TabIndex = 15;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "plusodin";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAutor2_LinkClicked);
            // 
            // buildDateLabel
            // 
            this.buildDateLabel.AutoSize = true;
            this.buildDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buildDateLabel.Location = new System.Drawing.Point(22, 278);
            this.buildDateLabel.Margin = new System.Windows.Forms.Padding(4);
            this.buildDateLabel.Name = "buildDateLabel";
            this.buildDateLabel.Size = new System.Drawing.Size(91, 20);
            this.buildDateLabel.TabIndex = 13;
            this.buildDateLabel.Text = "Build Date: ";
            this.buildDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBuild
            // 
            this.lblBuild.AutoSize = true;
            this.lblBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBuild.Location = new System.Drawing.Point(188, 277);
            this.lblBuild.Margin = new System.Windows.Forms.Padding(4);
            this.lblBuild.Name = "lblBuild";
            this.lblBuild.Size = new System.Drawing.Size(41, 20);
            this.lblBuild.TabIndex = 12;
            this.lblBuild.Text = "date";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVersion.Location = new System.Drawing.Point(188, 252);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(59, 20);
            this.lblVersion.TabIndex = 11;
            this.lblVersion.Text = "version";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.versionLabel.Location = new System.Drawing.Point(22, 250);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(4);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(72, 20);
            this.versionLabel.TabIndex = 3;
            this.versionLabel.Text = "Версия: ";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(192, 402);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 6, 7, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(129, 18);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "+79281352466";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(21, 402);
            this.label5.Margin = new System.Windows.Forms.Padding(4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "QIWI:";
            // 
            // yandexMoneyLabel
            // 
            this.yandexMoneyLabel.AutoSize = true;
            this.yandexMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yandexMoneyLabel.Location = new System.Drawing.Point(21, 375);
            this.yandexMoneyLabel.Margin = new System.Windows.Forms.Padding(4);
            this.yandexMoneyLabel.Name = "yandexMoneyLabel";
            this.yandexMoneyLabel.Size = new System.Drawing.Size(129, 20);
            this.yandexMoneyLabel.TabIndex = 5;
            this.yandexMoneyLabel.Text = "Яндекс.Деньги:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLabel.Location = new System.Drawing.Point(21, 169);
            this.authorLabel.Margin = new System.Windows.Forms.Padding(4);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(119, 20);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Автор (v1-v6c):";
            this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yanMoneyLink
            // 
            this.yanMoneyLink.AutoSize = true;
            this.yanMoneyLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yanMoneyLink.Location = new System.Drawing.Point(188, 375);
            this.yanMoneyLink.Margin = new System.Windows.Forms.Padding(4);
            this.yanMoneyLink.Name = "yanMoneyLink";
            this.yanMoneyLink.Size = new System.Drawing.Size(66, 20);
            this.yanMoneyLink.TabIndex = 8;
            this.yanMoneyLink.TabStop = true;
            this.yanMoneyLink.Text = "Ссылка";
            this.yanMoneyLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.yanMoneyLink_LinkClicked);
            // 
            // donateLabel
            // 
            this.donateLabel.AutoSize = true;
            this.donateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Underline);
            this.donateLabel.Location = new System.Drawing.Point(21, 346);
            this.donateLabel.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.donateLabel.Name = "donateLabel";
            this.donateLabel.Size = new System.Drawing.Size(284, 20);
            this.donateLabel.TabIndex = 9;
            this.donateLabel.Text = "Если хотите поблагодарить 7lexer7:";
            this.donateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(188, 168);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(128, 20);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "7lexer7 (Anteiku)";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAutor_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::AllInOne.Properties.Resources.sloth;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 161);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // progressTbox
            // 
            this.progressTbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressTbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainTLP.SetColumnSpan(this.progressTbox, 2);
            this.progressTbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressTbox.Location = new System.Drawing.Point(1, 720);
            this.progressTbox.Margin = new System.Windows.Forms.Padding(1);
            this.progressTbox.Multiline = true;
            this.progressTbox.Name = "progressTbox";
            this.progressTbox.ReadOnly = true;
            this.progressTbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.progressTbox.Size = new System.Drawing.Size(1489, 141);
            this.progressTbox.TabIndex = 18;
            // 
            // taskCountLabel
            // 
            this.taskCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.taskCountLabel.AutoSize = true;
            this.taskCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskCountLabel.Location = new System.Drawing.Point(1380, 0);
            this.taskCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taskCountLabel.Name = "taskCountLabel";
            this.taskCountLabel.Size = new System.Drawing.Size(107, 17);
            this.taskCountLabel.TabIndex = 19;
            this.taskCountLabel.Text = "В процессе: [0]";
            // 
            // countryIsoTBox
            // 
            this.countryIsoTBox.Enabled = false;
            this.countryIsoTBox.Location = new System.Drawing.Point(189, 585);
            this.countryIsoTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.countryIsoTBox.Name = "countryIsoTBox";
            this.countryIsoTBox.Size = new System.Drawing.Size(159, 22);
            this.countryIsoTBox.TabIndex = 86;
            // 
            // countryIsoCB
            // 
            this.countryIsoCB.AutoSize = true;
            this.countryIsoCB.Location = new System.Drawing.Point(5, 586);
            this.countryIsoCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.countryIsoCB.Name = "countryIsoCB";
            this.countryIsoCB.Size = new System.Drawing.Size(141, 21);
            this.countryIsoCB.TabIndex = 85;
            this.countryIsoCB.Text = "Country ISO code";
            this.countryIsoCB.UseVisualStyleBackColor = true;
            this.countryIsoCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // mainTLP
            // 
            this.mainTLP.ColumnCount = 2;
            this.mainTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTLP.Controls.Add(this.mainTabControl, 0, 0);
            this.mainTLP.Controls.Add(this.tabsControl, 1, 0);
            this.mainTLP.Controls.Add(this.progressTbox, 0, 1);
            this.mainTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTLP.Location = new System.Drawing.Point(0, 0);
            this.mainTLP.Margin = new System.Windows.Forms.Padding(4);
            this.mainTLP.Name = "mainTLP";
            this.mainTLP.RowCount = 3;
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainTLP.Size = new System.Drawing.Size(1491, 888);
            this.mainTLP.TabIndex = 24;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.mainTabPage);
            this.mainTabControl.Controls.Add(this.replaceTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(4, 4);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1020, 711);
            this.mainTabControl.TabIndex = 27;
            // 
            // mainTabPage
            // 
            this.mainTabPage.AutoScroll = true;
            this.mainTabPage.Controls.Add(this.themesGBox);
            this.mainTabPage.Controls.Add(this.splashGBox);
            this.mainTabPage.Controls.Add(this.otherGBox);
            this.mainTabPage.Controls.Add(this.licenseGBox);
            this.mainTabPage.Controls.Add(this.installerGBox);
            this.mainTabPage.Controls.Add(this.signatureGBox);
            this.mainTabPage.Controls.Add(this.deleteGBox);
            this.mainTabPage.Controls.Add(this.analyticGBox);
            this.mainTabPage.Location = new System.Drawing.Point(4, 25);
            this.mainTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.mainTabPage.Name = "mainTabPage";
            this.mainTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.mainTabPage.Size = new System.Drawing.Size(1012, 682);
            this.mainTabPage.TabIndex = 0;
            this.mainTabPage.Text = "Main";
            this.mainTabPage.UseVisualStyleBackColor = true;
            // 
            // replaceTabPage
            // 
            this.replaceTabPage.AutoScroll = true;
            this.replaceTabPage.Controls.Add(this.replaceGBox);
            this.replaceTabPage.Location = new System.Drawing.Point(4, 25);
            this.replaceTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.replaceTabPage.Name = "replaceTabPage";
            this.replaceTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.replaceTabPage.Size = new System.Drawing.Size(1012, 682);
            this.replaceTabPage.TabIndex = 1;
            this.replaceTabPage.Text = "Replace";
            this.replaceTabPage.UseVisualStyleBackColor = true;
            // 
            // replaceGBox
            // 
            this.replaceGBox.Controls.Add(this.idTBox);
            this.replaceGBox.Controls.Add(this.idCB);
            this.replaceGBox.Controls.Add(this.deviceNameCB);
            this.replaceGBox.Controls.Add(this.imeiCB);
            this.replaceGBox.Controls.Add(this.deviceNameTBox);
            this.replaceGBox.Controls.Add(this.imeiTBox);
            this.replaceGBox.Controls.Add(this.countryIsoTBox);
            this.replaceGBox.Controls.Add(this.deviceIdCB);
            this.replaceGBox.Controls.Add(this.countryIsoCB);
            this.replaceGBox.Controls.Add(this.operatorNameTBox);
            this.replaceGBox.Controls.Add(this.allManualCB);
            this.replaceGBox.Controls.Add(this.operatorTBox);
            this.replaceGBox.Controls.Add(this.gpsLatitudeTBox);
            this.replaceGBox.Controls.Add(this.productTBox);
            this.replaceGBox.Controls.Add(this.deviceIdTBox);
            this.replaceGBox.Controls.Add(this.subscriderIdTBox);
            this.replaceGBox.Controls.Add(this.gpsLongitudeTBox);
            this.replaceGBox.Controls.Add(this.manufacturerTBox);
            this.replaceGBox.Controls.Add(this.wifiMacAddressCB);
            this.replaceGBox.Controls.Add(this.modelTBox);
            this.replaceGBox.Controls.Add(this.gpsCB);
            this.replaceGBox.Controls.Add(this.brandTBox);
            this.replaceGBox.Controls.Add(this.androidIdCB);
            this.replaceGBox.Controls.Add(this.subscriberIdCB);
            this.replaceGBox.Controls.Add(this.timeCB);
            this.replaceGBox.Controls.Add(this.ipTBox);
            this.replaceGBox.Controls.Add(this.boardTBox);
            this.replaceGBox.Controls.Add(this.accountCB);
            this.replaceGBox.Controls.Add(this.modelCB);
            this.replaceGBox.Controls.Add(this.wifiMacTBox);
            this.replaceGBox.Controls.Add(this.operatorCB);
            this.replaceGBox.Controls.Add(this.allAutoCB);
            this.replaceGBox.Controls.Add(this.serialTBox);
            this.replaceGBox.Controls.Add(this.brandCB);
            this.replaceGBox.Controls.Add(this.deviceTBox);
            this.replaceGBox.Controls.Add(this.androidIdTBox);
            this.replaceGBox.Controls.Add(this.bluetoothMacAddressCB);
            this.replaceGBox.Controls.Add(this.simSerialNumberCB);
            this.replaceGBox.Controls.Add(this.operatorNameCB);
            this.replaceGBox.Controls.Add(this.simSerialNumberTBox);
            this.replaceGBox.Controls.Add(this.bluetoothAddressTBox);
            this.replaceGBox.Controls.Add(this.bssidCB);
            this.replaceGBox.Controls.Add(this.bssidTBox);
            this.replaceGBox.Controls.Add(this.timeTBox);
            this.replaceGBox.Controls.Add(this.serialCB);
            this.replaceGBox.Controls.Add(this.deviceCB);
            this.replaceGBox.Controls.Add(this.productCB);
            this.replaceGBox.Controls.Add(this.accountTBox);
            this.replaceGBox.Controls.Add(this.bluetoothAddressCB);
            this.replaceGBox.Controls.Add(this.bluetoothMacTBox);
            this.replaceGBox.Controls.Add(this.manufacturerCB);
            this.replaceGBox.Controls.Add(this.boardCB);
            this.replaceGBox.Controls.Add(this.ipCB);
            this.replaceGBox.Location = new System.Drawing.Point(0, 0);
            this.replaceGBox.Margin = new System.Windows.Forms.Padding(4);
            this.replaceGBox.MinimumSize = new System.Drawing.Size(353, 0);
            this.replaceGBox.Name = "replaceGBox";
            this.replaceGBox.Padding = new System.Windows.Forms.Padding(4);
            this.replaceGBox.Size = new System.Drawing.Size(716, 641);
            this.replaceGBox.TabIndex = 26;
            this.replaceGBox.TabStop = false;
            this.replaceGBox.Text = "Подмена:";
            // 
            // idTBox
            // 
            this.idTBox.Enabled = false;
            this.idTBox.Location = new System.Drawing.Point(548, 43);
            this.idTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.idTBox.Name = "idTBox";
            this.idTBox.Size = new System.Drawing.Size(159, 22);
            this.idTBox.TabIndex = 71;
            // 
            // idCB
            // 
            this.idCB.Location = new System.Drawing.Point(364, 46);
            this.idCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.idCB.Name = "idCB";
            this.idCB.Size = new System.Drawing.Size(104, 22);
            this.idCB.TabIndex = 70;
            this.idCB.Text = "ID";
            this.idCB.UseVisualStyleBackColor = true;
            this.idCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // deviceNameCB
            // 
            this.deviceNameCB.Location = new System.Drawing.Point(364, 73);
            this.deviceNameCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.deviceNameCB.Name = "deviceNameCB";
            this.deviceNameCB.Size = new System.Drawing.Size(148, 22);
            this.deviceNameCB.TabIndex = 89;
            this.deviceNameCB.Text = "Device Name";
            this.deviceNameCB.UseVisualStyleBackColor = true;
            this.deviceNameCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // imeiCB
            // 
            this.imeiCB.Location = new System.Drawing.Point(364, 18);
            this.imeiCB.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.imeiCB.Name = "imeiCB";
            this.imeiCB.Size = new System.Drawing.Size(99, 22);
            this.imeiCB.TabIndex = 87;
            this.imeiCB.Text = "IMEI";
            this.imeiCB.UseVisualStyleBackColor = true;
            this.imeiCB.CheckedChanged += new System.EventHandler(this.uni_CheckedChanged);
            // 
            // deviceNameTBox
            // 
            this.deviceNameTBox.Enabled = false;
            this.deviceNameTBox.Location = new System.Drawing.Point(548, 70);
            this.deviceNameTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.deviceNameTBox.Name = "deviceNameTBox";
            this.deviceNameTBox.Size = new System.Drawing.Size(159, 22);
            this.deviceNameTBox.TabIndex = 90;
            // 
            // imeiTBox
            // 
            this.imeiTBox.Enabled = false;
            this.imeiTBox.Location = new System.Drawing.Point(548, 16);
            this.imeiTBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.imeiTBox.Name = "imeiTBox";
            this.imeiTBox.Size = new System.Drawing.Size(159, 22);
            this.imeiTBox.TabIndex = 88;
            // 
            // pBar
            // 
            this.pBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBar.Location = new System.Drawing.Point(1, 0);
            this.pBar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(1190, 24);
            this.pBar.Step = 1;
            this.pBar.TabIndex = 25;
            // 
            // progressTLP
            // 
            this.progressTLP.ColumnCount = 2;
            this.progressTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.progressTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.progressTLP.Controls.Add(this.pBar, 0, 0);
            this.progressTLP.Controls.Add(this.taskCountLabel, 1, 0);
            this.progressTLP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressTLP.Location = new System.Drawing.Point(0, 888);
            this.progressTLP.Margin = new System.Windows.Forms.Padding(4);
            this.progressTLP.MinimumSize = new System.Drawing.Size(0, 25);
            this.progressTLP.Name = "progressTLP";
            this.progressTLP.RowCount = 1;
            this.progressTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.progressTLP.Size = new System.Drawing.Size(1491, 25);
            this.progressTLP.TabIndex = 25;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 913);
            this.Controls.Add(this.mainTLP);
            this.Controls.Add(this.progressTLP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1214, 949);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllInOne - сборник патчей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.themesGBox.ResumeLayout(false);
            this.themesGBox.PerformLayout();
            this.analyticGBox.ResumeLayout(false);
            this.analyticGBox.PerformLayout();
            this.deleteGBox.ResumeLayout(false);
            this.deleteGBox.PerformLayout();
            this.signatureGBox.ResumeLayout(false);
            this.signatureGBox.PerformLayout();
            this.licenseGBox.ResumeLayout(false);
            this.licenseGBox.PerformLayout();
            this.installerGBox.ResumeLayout(false);
            this.installerGBox.PerformLayout();
            this.splashGBox.ResumeLayout(false);
            this.splashGBox.PerformLayout();
            this.otherGBox.ResumeLayout(false);
            this.otherGBox.PerformLayout();
            this.tabsControl.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            this.toolsTab.ResumeLayout(false);
            this.aboutTab.ResumeLayout(false);
            this.aboutTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainTLP.ResumeLayout(false);
            this.mainTLP.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.mainTabPage.ResumeLayout(false);
            this.replaceTabPage.ResumeLayout(false);
            this.replaceGBox.ResumeLayout(false);
            this.replaceGBox.PerformLayout();
            this.progressTLP.ResumeLayout(false);
            this.progressTLP.PerformLayout();
            this.ResumeLayout(false);

        }

        // Token: 0x04000047 RID: 71
        private global::System.ComponentModel.IContainer components;

        // Token: 0x04000048 RID: 72
        private global::System.Windows.Forms.Button clearAll;

        // Token: 0x04000049 RID: 73
        private global::System.Windows.Forms.TabControl tabsControl;

        // Token: 0x0400004A RID: 74
        private global::System.Windows.Forms.ListView orderLv;

        // Token: 0x0400004B RID: 75
        public global::System.Windows.Forms.TabPage mainTab;

        // Token: 0x0400004C RID: 76
        public global::System.Windows.Forms.ColumnHeader columnName;

        // Token: 0x0400004D RID: 77
        private global::System.Windows.Forms.Button startButton;

        // Token: 0x0400004E RID: 78
        public global::System.Windows.Forms.TextBox progressTbox;

        // Token: 0x0400004F RID: 79
        private global::System.Windows.Forms.Button addDebugInfoButton;

        // Token: 0x04000050 RID: 80
        private global::System.Windows.Forms.Button helpSmaliButton;

        // Token: 0x04000051 RID: 81
        private global::System.Windows.Forms.TabPage aboutTab;

        // Token: 0x04000052 RID: 82
        private global::System.Windows.Forms.TextBox textBox1;

        // Token: 0x04000053 RID: 83
        private global::System.Windows.Forms.LinkLabel linkLabel1;

        // Token: 0x04000054 RID: 84
        private global::System.Windows.Forms.Label authorLabel;

        // Token: 0x04000055 RID: 85
        private global::System.Windows.Forms.Label versionLabel;

        // Token: 0x04000056 RID: 86
        private global::System.Windows.Forms.Label yandexMoneyLabel;

        // Token: 0x04000057 RID: 87
        private global::System.Windows.Forms.Label label5;

        // Token: 0x04000058 RID: 88
        private global::System.Windows.Forms.LinkLabel yanMoneyLink;

        // Token: 0x04000059 RID: 89
        private global::System.Windows.Forms.Button remDebugInfoButton;

        // Token: 0x0400005A RID: 90
        private global::System.Windows.Forms.Button saveCheckboxButton;

        // Token: 0x0400005B RID: 91
        private global::System.Windows.Forms.GroupBox analyticGBox;

        // Token: 0x0400005C RID: 92
        public global::System.Windows.Forms.CheckBox analyticFirebaseCB;

        // Token: 0x0400005D RID: 93
        public global::System.Windows.Forms.CheckBox analyticMethodCB;

        // Token: 0x0400005E RID: 94
        public global::System.Windows.Forms.CheckBox analyticLinksCB;

        // Token: 0x0400005F RID: 95
        public global::System.Windows.Forms.CheckBox analyticServiceCB;

        // Token: 0x04000060 RID: 96
        public global::System.Windows.Forms.CheckBox analyticReceiverCB;

        // Token: 0x04000061 RID: 97
        public global::System.Windows.Forms.CheckBox analyticActivityCB;

        // Token: 0x04000062 RID: 98
        public global::System.Windows.Forms.CheckBox analyticLayoutCB;

        // Token: 0x04000063 RID: 99
        private global::System.Windows.Forms.GroupBox deleteGBox;

        // Token: 0x04000064 RID: 100
        private global::System.Windows.Forms.CheckBox emulatorCB;

        // Token: 0x04000065 RID: 101
        private global::System.Windows.Forms.CheckBox locationCB;

        // Token: 0x04000066 RID: 102
        private global::System.Windows.Forms.CheckBox gmsCB;

        // Token: 0x04000067 RID: 103
        public global::System.Windows.Forms.CheckBox autostartCB;

        // Token: 0x04000068 RID: 104
        private global::System.Windows.Forms.CheckBox internetCB;

        // Token: 0x04000069 RID: 105
        private global::System.Windows.Forms.CheckBox allToastsCB;

        // Token: 0x0400006A RID: 106
        private global::System.Windows.Forms.GroupBox signatureGBox;

        // Token: 0x0400006B RID: 107
        private global::System.Windows.Forms.CheckBox binSignatureCB;

        // Token: 0x0400006C RID: 108
        public global::System.Windows.Forms.CheckBox binSignatureInstallerCB;

        // Token: 0x0400006D RID: 109
        public global::System.Windows.Forms.ComboBox binInstallerCBox;

        // Token: 0x0400006E RID: 110
        private global::System.Windows.Forms.GroupBox licenseGBox;

        // Token: 0x0400006F RID: 111
        private global::System.Windows.Forms.CheckBox licenseGoogleCB;

        // Token: 0x04000070 RID: 112
        private global::System.Windows.Forms.CheckBox licenseAmazonCB;

        // Token: 0x04000071 RID: 113
        private global::System.Windows.Forms.GroupBox installerGBox;

        // Token: 0x04000072 RID: 114
        private global::System.Windows.Forms.CheckBox installerGoogleCB;

        // Token: 0x04000073 RID: 115
        private global::System.Windows.Forms.CheckBox installerAmazonCB;

        // Token: 0x04000074 RID: 116
        private global::System.Windows.Forms.GroupBox splashGBox;

        // Token: 0x04000075 RID: 117
        private global::System.Windows.Forms.CheckBox splashInstallCB;

        // Token: 0x04000076 RID: 118
        private global::System.Windows.Forms.CheckBox splashRemoveCB;

        // Token: 0x04000077 RID: 119
        private global::System.Windows.Forms.GroupBox otherGBox;

        // Token: 0x04000078 RID: 120
        public global::System.Windows.Forms.ComboBox installLocationCBox;

        // Token: 0x04000079 RID: 121
        private global::System.Windows.Forms.CheckBox installLocationCB;

        // Token: 0x0400007A RID: 122
        private global::System.Windows.Forms.CheckBox addSaveCB;

        // Token: 0x0400007B RID: 123
        private global::System.Windows.Forms.CheckBox minSdkCB;

        // Token: 0x0400007C RID: 124
        private global::System.Windows.Forms.CheckBox fullscreenCB;

        // Token: 0x0400007D RID: 125
        private global::System.Windows.Forms.CheckBox addToastCB;

        // Token: 0x0400007E RID: 126
        private global::System.Windows.Forms.CheckBox rootCheckCB;

        // Token: 0x0400007F RID: 127
        public global::System.Windows.Forms.ComboBox minSdkCBox;

        // Token: 0x04000080 RID: 128
        private global::System.Windows.Forms.CheckBox hideIconCB;

        // Token: 0x04000081 RID: 129
        private global::System.Windows.Forms.CheckBox noUpdateCB;

        // Token: 0x04000082 RID: 130
        public global::System.Windows.Forms.TextBox toastMessageTBox;

        // Token: 0x04000083 RID: 131
        private global::System.Windows.Forms.CheckBox mockLocationCB;

        // Token: 0x04000084 RID: 132
        private global::System.Windows.Forms.CheckBox googleMapsCB;

        // Token: 0x04000085 RID: 133
        private global::System.Windows.Forms.CheckBox dexCB;

        // Token: 0x04000086 RID: 134
        private global::System.Windows.Forms.CheckBox reflectionLogCB;

        // Token: 0x04000087 RID: 135
        private global::System.Windows.Forms.CheckBox gpsCB;

        // Token: 0x04000088 RID: 136
        private global::System.Windows.Forms.CheckBox timeCB;

        // Token: 0x04000089 RID: 137
        public global::System.Windows.Forms.TextBox deviceIdTBox;

        // Token: 0x0400008A RID: 138
        private global::System.Windows.Forms.CheckBox accountCB;

        // Token: 0x0400008B RID: 139
        public global::System.Windows.Forms.TextBox androidIdTBox;

        // Token: 0x0400008C RID: 140
        private global::System.Windows.Forms.CheckBox allAutoCB;

        // Token: 0x0400008D RID: 141
        private global::System.Windows.Forms.CheckBox brandCB;

        // Token: 0x0400008E RID: 142
        private global::System.Windows.Forms.CheckBox allManualCB;

        // Token: 0x0400008F RID: 143
        public global::System.Windows.Forms.TextBox wifiMacTBox;

        // Token: 0x04000090 RID: 144
        private global::System.Windows.Forms.CheckBox ipCB;

        // Token: 0x04000091 RID: 145
        public global::System.Windows.Forms.TextBox bluetoothMacTBox;

        // Token: 0x04000092 RID: 146
        public global::System.Windows.Forms.TextBox bluetoothAddressTBox;

        // Token: 0x04000093 RID: 147
        public global::System.Windows.Forms.TextBox serialTBox;

        // Token: 0x04000094 RID: 148
        private global::System.Windows.Forms.CheckBox bssidCB;

        // Token: 0x04000095 RID: 149
        private global::System.Windows.Forms.CheckBox deviceIdCB;

        // Token: 0x04000096 RID: 150
        private global::System.Windows.Forms.CheckBox deviceCB;

        // Token: 0x04000097 RID: 151
        public global::System.Windows.Forms.TextBox modelTBox;

        // Token: 0x04000098 RID: 152
        public global::System.Windows.Forms.TextBox brandTBox;

        // Token: 0x04000099 RID: 153
        private global::System.Windows.Forms.CheckBox boardCB;

        // Token: 0x0400009A RID: 154
        private global::System.Windows.Forms.CheckBox androidIdCB;

        // Token: 0x0400009B RID: 155
        private global::System.Windows.Forms.CheckBox manufacturerCB;

        // Token: 0x0400009C RID: 156
        public global::System.Windows.Forms.TextBox ipTBox;

        // Token: 0x0400009D RID: 157
        private global::System.Windows.Forms.CheckBox productCB;

        // Token: 0x0400009E RID: 158
        public global::System.Windows.Forms.TextBox bssidTBox;

        // Token: 0x0400009F RID: 159
        private global::System.Windows.Forms.CheckBox operatorNameCB;

        // Token: 0x040000A0 RID: 160
        public global::System.Windows.Forms.TextBox deviceTBox;

        // Token: 0x040000A1 RID: 161
        private global::System.Windows.Forms.CheckBox operatorCB;

        // Token: 0x040000A2 RID: 162
        public global::System.Windows.Forms.TextBox boardTBox;

        // Token: 0x040000A3 RID: 163
        private global::System.Windows.Forms.CheckBox subscriberIdCB;

        // Token: 0x040000A4 RID: 164
        private global::System.Windows.Forms.CheckBox wifiMacAddressCB;

        // Token: 0x040000A5 RID: 165
        private global::System.Windows.Forms.CheckBox simSerialNumberCB;

        // Token: 0x040000A6 RID: 166
        public global::System.Windows.Forms.TextBox manufacturerTBox;

        // Token: 0x040000A7 RID: 167
        public global::System.Windows.Forms.TextBox productTBox;

        // Token: 0x040000A8 RID: 168
        private global::System.Windows.Forms.CheckBox modelCB;

        // Token: 0x040000A9 RID: 169
        public global::System.Windows.Forms.TextBox operatorNameTBox;

        // Token: 0x040000AA RID: 170
        public global::System.Windows.Forms.TextBox operatorTBox;

        // Token: 0x040000AB RID: 171
        private global::System.Windows.Forms.CheckBox bluetoothMacAddressCB;

        // Token: 0x040000AC RID: 172
        public global::System.Windows.Forms.TextBox subscriderIdTBox;

        // Token: 0x040000AD RID: 173
        public global::System.Windows.Forms.TextBox simSerialNumberTBox;

        // Token: 0x040000AE RID: 174
        private global::System.Windows.Forms.CheckBox serialCB;

        // Token: 0x040000AF RID: 175
        public global::System.Windows.Forms.TextBox timeTBox;

        // Token: 0x040000B0 RID: 176
        private global::System.Windows.Forms.CheckBox bluetoothAddressCB;

        // Token: 0x040000B1 RID: 177
        public global::System.Windows.Forms.TextBox accountTBox;

        // Token: 0x040000B2 RID: 178
        public global::System.Windows.Forms.TextBox gpsLatitudeTBox;

        // Token: 0x040000B3 RID: 179
        public global::System.Windows.Forms.TextBox gpsLongitudeTBox;

        // Token: 0x040000B4 RID: 180
        private global::System.Windows.Forms.Label donateLabel;

        // Token: 0x040000B5 RID: 181
        private global::System.Windows.Forms.GroupBox themesGBox;

        // Token: 0x040000B6 RID: 182
        private global::System.Windows.Forms.CheckBox themesLCB;

        // Token: 0x040000B7 RID: 183
        private global::System.Windows.Forms.CheckBox themesLHMACB;

        // Token: 0x040000B8 RID: 184
        private global::System.Windows.Forms.CheckBox themesDCB;

        // Token: 0x040000B9 RID: 185
        private global::System.Windows.Forms.CheckBox themesDHMACB;

        // Token: 0x040000BA RID: 186
        private global::System.Windows.Forms.Button openFolderButton;

        // Token: 0x040000BB RID: 187
        private global::System.Windows.Forms.FolderBrowserDialog folderBrowser;

        // Token: 0x040000BC RID: 188
        private global::System.Windows.Forms.PictureBox pictureBox1;

        // Token: 0x040000BD RID: 189
        private global::System.Windows.Forms.TabPage toolsTab;

        // Token: 0x040000BE RID: 190
        private global::System.Windows.Forms.Button collectStringsButton;

        // Token: 0x040000BF RID: 191
        private global::System.Windows.Forms.Button hideIdsButton;

        // Token: 0x040000C0 RID: 192
        private global::System.Windows.Forms.Button interestingPlacesButton;

        // Token: 0x040000C1 RID: 193
        private global::System.Windows.Forms.CheckBox deleteResourcesCB;

        // Token: 0x040000C2 RID: 194
        private global::System.Windows.Forms.Button mergeStringsButton;

        // Token: 0x040000C3 RID: 195
        private global::System.Windows.Forms.CheckBox cloneCB;

        // Token: 0x040000C4 RID: 196
        public global::System.Windows.Forms.TextBox cloneTBox;

        // Token: 0x040000C5 RID: 197
        public global::System.Windows.Forms.ComboBox deleteLangsCBox;

        // Token: 0x040000C6 RID: 198
        private global::System.Windows.Forms.Button mehButton;

        // Token: 0x040000C7 RID: 199
        private global::System.Windows.Forms.CheckBox countryIsoCB;

        // Token: 0x040000C8 RID: 200
        public global::System.Windows.Forms.TextBox countryIsoTBox;

        // Token: 0x040000C9 RID: 201
        private global::System.Windows.Forms.TableLayoutPanel mainTLP;

        // Token: 0x040000CA RID: 202
        private global::System.Windows.Forms.GroupBox replaceGBox;

        // Token: 0x040000CC RID: 204
        public global::System.Windows.Forms.Label taskCountLabel;

        // Token: 0x040000CD RID: 205
        public global::System.Windows.Forms.ProgressBar pBar;

        // Token: 0x040000CE RID: 206
        private global::System.Windows.Forms.CheckBox blockSensorsCB;

        // Token: 0x040000CF RID: 207
        public global::System.Windows.Forms.ComboBox blockSensorsCBox;

        // Token: 0x040000D0 RID: 208
        private global::System.Windows.Forms.Button btnHelp;

        // Token: 0x040000D2 RID: 210
        private global::System.Windows.Forms.Label lblBuild;

        // Token: 0x040000D3 RID: 211
        private global::System.Windows.Forms.Label buildDateLabel;

        // Token: 0x040000D4 RID: 212
        private global::System.Windows.Forms.Label authorLabel2;

        // Token: 0x040000D5 RID: 213
        private global::System.Windows.Forms.LinkLabel linkLabel2;

        // Token: 0x040000D6 RID: 214
        private global::System.Windows.Forms.CheckBox imeiCB;

        // Token: 0x040000D7 RID: 215
        public global::System.Windows.Forms.TextBox imeiTBox;

        // Token: 0x040000D8 RID: 216
        private global::System.Windows.Forms.CheckBox deviceNameCB;

        // Token: 0x040000D9 RID: 217
        public global::System.Windows.Forms.TextBox deviceNameTBox;

        // Token: 0x040000DA RID: 218
        public global::System.Windows.Forms.TextBox idTBox;

        // Token: 0x040000DB RID: 219
        private global::System.Windows.Forms.CheckBox idCB;

        // Token: 0x040000DC RID: 220
        private global::System.Windows.Forms.Button btnSettings;

        // Token: 0x040000DE RID: 222
        private global::System.Windows.Forms.TabControl mainTabControl;

        // Token: 0x040000DF RID: 223
        private global::System.Windows.Forms.TabPage mainTabPage;

        // Token: 0x040000E0 RID: 224
        private global::System.Windows.Forms.TabPage replaceTabPage;
        private System.Windows.Forms.TableLayoutPanel progressTLP;
        private System.Windows.Forms.Label authorLabel3;
        private System.Windows.Forms.LinkLabel new_author2;
        private System.Windows.Forms.Button Changelog_btn;
        public System.Windows.Forms.ComboBox backKillCBox;
        private System.Windows.Forms.CheckBox screenshotCB;
        private System.Windows.Forms.CheckBox backKillCB;
        public System.Windows.Forms.Label lblVersion;
    }
}
