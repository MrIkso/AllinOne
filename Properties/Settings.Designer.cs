using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace AllInOne.Properties
{
	// Token: 0x02000038 RID: 56
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00002B9C File Offset: 0x00000D9C
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00002BA3 File Offset: 0x00000DA3
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00002BB5 File Offset: 0x00000DB5
		[DefaultSettingValue("915, 780")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public Size WindowSize
		{
			get
			{
				return (Size)this["WindowSize"];
			}
			set
			{
				this["WindowSize"] = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00002BC8 File Offset: 0x00000DC8
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00002BDA File Offset: 0x00000DDA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Normal")]
		public FormWindowState WindowState
		{
			get
			{
				return (FormWindowState)this["WindowState"];
			}
			set
			{
				this["WindowState"] = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00002BED File Offset: 0x00000DED
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00002BFF File Offset: 0x00000DFF
		[UserScopedSetting]
		[DefaultSettingValue("0, 0")]
		[DebuggerNonUserCode]
		public Point WindowLocation
		{
			get
			{
				return (Point)this["WindowLocation"];
			}
			set
			{
				this["WindowLocation"] = value;
			}
		}

		// Token: 0x04000224 RID: 548
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
