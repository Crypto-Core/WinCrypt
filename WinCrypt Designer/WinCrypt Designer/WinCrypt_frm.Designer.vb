<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Startwindow
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Startwindow))
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateiVerschlüsselnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateiEntschlüsselnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextVerschlüsselnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MD5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MD5KonverterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MD5CrackerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RSAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntschlüsselnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerschlüsselnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeyErstellenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMailSendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasswortmanagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenbankExportierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenbankImportierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenbankLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemidentifikationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasswortgeneratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateiSicherLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateiVerschlüsselnToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateiEntschlüsselnToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.TextVerUndEntschlüsselnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MD5ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MD5KonverterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MD5BruteforceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RSAToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerschlüsselnToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntschlüsselnToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchlüsselErstellenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.EMailToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMailSendenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.PasswortmanagerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenbankExportierenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenbankImportierenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenbankLöschenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SystemidentifikationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.PasswortGeneratorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.DateienSicherLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mount_gb = New System.Windows.Forms.GroupBox()
        Me.cleanlb2 = New System.Windows.Forms.Button()
        Me.drive_lb = New System.Windows.Forms.Label()
        Me.key_lb = New System.Windows.Forms.Label()
        Me.file_lb = New System.Windows.Forms.Label()
        Me.decrypt_list_status = New System.Windows.Forms.ListBox()
        Me.drivecb = New System.Windows.Forms.ComboBox()
        Me.keyencrypt = New System.Windows.Forms.TextBox()
        Me.decrypt_filepath = New System.Windows.Forms.TextBox()
        Me.dismount = New System.Windows.Forms.Button()
        Me.mount = New System.Windows.Forms.Button()
        Me.opencryptfile = New System.Windows.Forms.Button()
        Me.encrypt_gb = New System.Windows.Forms.GroupBox()
        Me.cleanlb1 = New System.Windows.Forms.Button()
        Me.encrypt_list_status = New System.Windows.Forms.ListBox()
        Me.key_lb1 = New System.Windows.Forms.Label()
        Me.create_container_encrypt = New System.Windows.Forms.Button()
        Me.path_encrypt = New System.Windows.Forms.Label()
        Me.generate_key_encrypt = New System.Windows.Forms.Button()
        Me.crypt_file_pathbutton = New System.Windows.Forms.Button()
        Me.keycrypt = New System.Windows.Forms.TextBox()
        Me.pathtxt = New System.Windows.Forms.TextBox()
        Me.wincrypt_icon = New System.Windows.Forms.PictureBox()
        Me.XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.wincrypttitle = New System.Windows.Forms.Label()
        Me.XToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.file_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.setting_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.exit_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.tools_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.file_encrypt_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.file_decrypt_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.text_encrypt_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.hash_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.md5_converter_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.md5_bf_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.rsa_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.rsa_encrypt_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.rsa_decrypt_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.rsa_create_keys_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mail_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.send_mail_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.pw_manager_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.export_db_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.import_db_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.delete_db_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.systemidentification_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.pw_generator_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.delete_file_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.info_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.update_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.feedback_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.about_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.exit_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.minimize_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.form_head = New System.Windows.Forms.MenuStrip()
        Me.mount_gb.SuspendLayout()
        Me.encrypt_gb.SuspendLayout()
        CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.form_head.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EinstellungToolStripMenuItem, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'EinstellungToolStripMenuItem
        '
        Me.EinstellungToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.EinstellungToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EinstellungToolStripMenuItem.Image = Global.WinCrypt_Designer.My.Resources.Resources.setting
        Me.EinstellungToolStripMenuItem.Name = "EinstellungToolStripMenuItem"
        Me.EinstellungToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.EinstellungToolStripMenuItem.Text = "Einstellung"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BeendenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BeendenToolStripMenuItem.Image = Global.WinCrypt_Designer.My.Resources.Resources.Close16
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiVerschlüsselnToolStripMenuItem, Me.DateiEntschlüsselnToolStripMenuItem, Me.TextVerschlüsselnToolStripMenuItem, Me.MD5ToolStripMenuItem, Me.RSAToolStripMenuItem, Me.EMailToolStripMenuItem, Me.PasswortmanagerToolStripMenuItem, Me.SystemidentifikationToolStripMenuItem, Me.PasswortgeneratorToolStripMenuItem, Me.DateiSicherLöschenToolStripMenuItem})
        Me.ToolsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'DateiVerschlüsselnToolStripMenuItem
        '
        Me.DateiVerschlüsselnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DateiVerschlüsselnToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateiVerschlüsselnToolStripMenuItem.Image = Global.WinCrypt_Designer.My.Resources.Resources.Lock16
        Me.DateiVerschlüsselnToolStripMenuItem.Name = "DateiVerschlüsselnToolStripMenuItem"
        Me.DateiVerschlüsselnToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.DateiVerschlüsselnToolStripMenuItem.Text = "Datei verschlüsseln"
        '
        'DateiEntschlüsselnToolStripMenuItem
        '
        Me.DateiEntschlüsselnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DateiEntschlüsselnToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateiEntschlüsselnToolStripMenuItem.Image = Global.WinCrypt_Designer.My.Resources.Resources.unlock16
        Me.DateiEntschlüsselnToolStripMenuItem.Name = "DateiEntschlüsselnToolStripMenuItem"
        Me.DateiEntschlüsselnToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.DateiEntschlüsselnToolStripMenuItem.Text = "Datei entschlüsseln"
        '
        'TextVerschlüsselnToolStripMenuItem
        '
        Me.TextVerschlüsselnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TextVerschlüsselnToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextVerschlüsselnToolStripMenuItem.Image = Global.WinCrypt_Designer.My.Resources.Resources.textencrypt
        Me.TextVerschlüsselnToolStripMenuItem.Name = "TextVerschlüsselnToolStripMenuItem"
        Me.TextVerschlüsselnToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.TextVerschlüsselnToolStripMenuItem.Text = "Text ver- und entschlüsseln"
        '
        'MD5ToolStripMenuItem
        '
        Me.MD5ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MD5ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MD5KonverterToolStripMenuItem, Me.MD5CrackerToolStripMenuItem})
        Me.MD5ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MD5ToolStripMenuItem.Name = "MD5ToolStripMenuItem"
        Me.MD5ToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.MD5ToolStripMenuItem.Text = "Hash"
        '
        'MD5KonverterToolStripMenuItem
        '
        Me.MD5KonverterToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MD5KonverterToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MD5KonverterToolStripMenuItem.Name = "MD5KonverterToolStripMenuItem"
        Me.MD5KonverterToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.MD5KonverterToolStripMenuItem.Text = "Hash Konverter"
        '
        'MD5CrackerToolStripMenuItem
        '
        Me.MD5CrackerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MD5CrackerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MD5CrackerToolStripMenuItem.Name = "MD5CrackerToolStripMenuItem"
        Me.MD5CrackerToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.MD5CrackerToolStripMenuItem.Text = "Hash Brute-force"
        '
        'RSAToolStripMenuItem
        '
        Me.RSAToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.RSAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntschlüsselnToolStripMenuItem, Me.VerschlüsselnToolStripMenuItem, Me.KeyErstellenToolStripMenuItem})
        Me.RSAToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RSAToolStripMenuItem.Name = "RSAToolStripMenuItem"
        Me.RSAToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.RSAToolStripMenuItem.Text = "RSA"
        '
        'EntschlüsselnToolStripMenuItem
        '
        Me.EntschlüsselnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.EntschlüsselnToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EntschlüsselnToolStripMenuItem.Image = Global.WinCrypt_Designer.My.Resources.Resources.unlock16
        Me.EntschlüsselnToolStripMenuItem.Name = "EntschlüsselnToolStripMenuItem"
        Me.EntschlüsselnToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.EntschlüsselnToolStripMenuItem.Text = "Entschlüsseln"
        '
        'VerschlüsselnToolStripMenuItem
        '
        Me.VerschlüsselnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.VerschlüsselnToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.VerschlüsselnToolStripMenuItem.Image = Global.WinCrypt_Designer.My.Resources.Resources.Lock16
        Me.VerschlüsselnToolStripMenuItem.Name = "VerschlüsselnToolStripMenuItem"
        Me.VerschlüsselnToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.VerschlüsselnToolStripMenuItem.Text = "Verschlüsseln"
        '
        'KeyErstellenToolStripMenuItem
        '
        Me.KeyErstellenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.KeyErstellenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.KeyErstellenToolStripMenuItem.Image = Global.WinCrypt_Designer.My.Resources.Resources.Key16
        Me.KeyErstellenToolStripMenuItem.Name = "KeyErstellenToolStripMenuItem"
        Me.KeyErstellenToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.KeyErstellenToolStripMenuItem.Text = "Schlüssel erstellen"
        '
        'EMailToolStripMenuItem
        '
        Me.EMailToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.EMailToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EMailSendenToolStripMenuItem})
        Me.EMailToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EMailToolStripMenuItem.Image = Global.WinCrypt_Designer.My.Resources.Resources.mail
        Me.EMailToolStripMenuItem.Name = "EMailToolStripMenuItem"
        Me.EMailToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.EMailToolStripMenuItem.Text = "E-Mail"
        '
        'EMailSendenToolStripMenuItem
        '
        Me.EMailSendenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.EMailSendenToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EMailSendenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EMailSendenToolStripMenuItem.Name = "EMailSendenToolStripMenuItem"
        Me.EMailSendenToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.EMailSendenToolStripMenuItem.Text = "E-Mail Senden"
        '
        'PasswortmanagerToolStripMenuItem
        '
        Me.PasswortmanagerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.PasswortmanagerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatenbankExportierenToolStripMenuItem, Me.DatenbankImportierenToolStripMenuItem, Me.DatenbankLöschenToolStripMenuItem})
        Me.PasswortmanagerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PasswortmanagerToolStripMenuItem.Image = Global.WinCrypt_Designer.My.Resources.Resources.pwmanager
        Me.PasswortmanagerToolStripMenuItem.Name = "PasswortmanagerToolStripMenuItem"
        Me.PasswortmanagerToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.PasswortmanagerToolStripMenuItem.Text = "Passwortmanager"
        '
        'DatenbankExportierenToolStripMenuItem
        '
        Me.DatenbankExportierenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DatenbankExportierenToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DatenbankExportierenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DatenbankExportierenToolStripMenuItem.Name = "DatenbankExportierenToolStripMenuItem"
        Me.DatenbankExportierenToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.DatenbankExportierenToolStripMenuItem.Text = "Datenbank exportieren"
        '
        'DatenbankImportierenToolStripMenuItem
        '
        Me.DatenbankImportierenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DatenbankImportierenToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DatenbankImportierenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DatenbankImportierenToolStripMenuItem.Name = "DatenbankImportierenToolStripMenuItem"
        Me.DatenbankImportierenToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.DatenbankImportierenToolStripMenuItem.Text = "Datenbank importieren"
        '
        'DatenbankLöschenToolStripMenuItem
        '
        Me.DatenbankLöschenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DatenbankLöschenToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DatenbankLöschenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DatenbankLöschenToolStripMenuItem.Name = "DatenbankLöschenToolStripMenuItem"
        Me.DatenbankLöschenToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.DatenbankLöschenToolStripMenuItem.Text = "Datenbank löschen"
        '
        'SystemidentifikationToolStripMenuItem
        '
        Me.SystemidentifikationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SystemidentifikationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SystemidentifikationToolStripMenuItem.Image = Global.WinCrypt_Designer.My.Resources.Resources.Identity
        Me.SystemidentifikationToolStripMenuItem.Name = "SystemidentifikationToolStripMenuItem"
        Me.SystemidentifikationToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.SystemidentifikationToolStripMenuItem.Text = "Systemidentifikation"
        '
        'PasswortgeneratorToolStripMenuItem
        '
        Me.PasswortgeneratorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.PasswortgeneratorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PasswortgeneratorToolStripMenuItem.Image = Global.WinCrypt_Designer.My.Resources.Resources.Password16
        Me.PasswortgeneratorToolStripMenuItem.Name = "PasswortgeneratorToolStripMenuItem"
        Me.PasswortgeneratorToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.PasswortgeneratorToolStripMenuItem.Text = "Passwortgenerator"
        '
        'DateiSicherLöschenToolStripMenuItem
        '
        Me.DateiSicherLöschenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DateiSicherLöschenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateiSicherLöschenToolStripMenuItem.Image = Global.WinCrypt_Designer.My.Resources.Resources.Delete16
        Me.DateiSicherLöschenToolStripMenuItem.Name = "DateiSicherLöschenToolStripMenuItem"
        Me.DateiSicherLöschenToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.DateiSicherLöschenToolStripMenuItem.Text = "Dateien sicher löschen"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.InfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InfoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.UpdateToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.UpdateToolStripMenuItem.Image = Global.WinCrypt_Designer.My.Resources.Resources.updateflat
        Me.UpdateToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'FeedbackToolStripMenuItem
        '
        Me.FeedbackToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.FeedbackToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FeedbackToolStripMenuItem.Image = Global.WinCrypt_Designer.My.Resources.Resources.feedback16
        Me.FeedbackToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
        Me.FeedbackToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FeedbackToolStripMenuItem.Text = "Feedback"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AboutToolStripMenuItem.Image = Global.WinCrypt_Designer.My.Resources.Resources.Information16
        Me.AboutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'DateiVerschlüsselnToolStripMenuItem1
        '
        Me.DateiVerschlüsselnToolStripMenuItem1.Image = Global.WinCrypt_Designer.My.Resources.Resources.Lock16
        Me.DateiVerschlüsselnToolStripMenuItem1.Name = "DateiVerschlüsselnToolStripMenuItem1"
        Me.DateiVerschlüsselnToolStripMenuItem1.Size = New System.Drawing.Size(217, 22)
        Me.DateiVerschlüsselnToolStripMenuItem1.Text = "Datei verschlüsseln"
        '
        'DateiEntschlüsselnToolStripMenuItem1
        '
        Me.DateiEntschlüsselnToolStripMenuItem1.Image = Global.WinCrypt_Designer.My.Resources.Resources.unlock16
        Me.DateiEntschlüsselnToolStripMenuItem1.Name = "DateiEntschlüsselnToolStripMenuItem1"
        Me.DateiEntschlüsselnToolStripMenuItem1.Size = New System.Drawing.Size(217, 22)
        Me.DateiEntschlüsselnToolStripMenuItem1.Text = "Datei entschlüsseln"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(214, 6)
        '
        'TextVerUndEntschlüsselnToolStripMenuItem
        '
        Me.TextVerUndEntschlüsselnToolStripMenuItem.Image = Global.WinCrypt_Designer.My.Resources.Resources.textencrypt
        Me.TextVerUndEntschlüsselnToolStripMenuItem.Name = "TextVerUndEntschlüsselnToolStripMenuItem"
        Me.TextVerUndEntschlüsselnToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.TextVerUndEntschlüsselnToolStripMenuItem.Text = "Text ver- und entschlüsseln"
        '
        'MD5ToolStripMenuItem1
        '
        Me.MD5ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MD5KonverterToolStripMenuItem1, Me.MD5BruteforceToolStripMenuItem})
        Me.MD5ToolStripMenuItem1.Name = "MD5ToolStripMenuItem1"
        Me.MD5ToolStripMenuItem1.Size = New System.Drawing.Size(217, 22)
        Me.MD5ToolStripMenuItem1.Text = "MD5"
        '
        'MD5KonverterToolStripMenuItem1
        '
        Me.MD5KonverterToolStripMenuItem1.Name = "MD5KonverterToolStripMenuItem1"
        Me.MD5KonverterToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.MD5KonverterToolStripMenuItem1.Text = "MD5 Konverter"
        '
        'MD5BruteforceToolStripMenuItem
        '
        Me.MD5BruteforceToolStripMenuItem.Name = "MD5BruteforceToolStripMenuItem"
        Me.MD5BruteforceToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.MD5BruteforceToolStripMenuItem.Text = "MD5 Brute-force"
        '
        'RSAToolStripMenuItem1
        '
        Me.RSAToolStripMenuItem1.Name = "RSAToolStripMenuItem1"
        Me.RSAToolStripMenuItem1.Size = New System.Drawing.Size(217, 22)
        Me.RSAToolStripMenuItem1.Text = "RSA"
        '
        'VerschlüsselnToolStripMenuItem1
        '
        Me.VerschlüsselnToolStripMenuItem1.Image = Global.WinCrypt_Designer.My.Resources.Resources.Lock16
        Me.VerschlüsselnToolStripMenuItem1.Name = "VerschlüsselnToolStripMenuItem1"
        Me.VerschlüsselnToolStripMenuItem1.Size = New System.Drawing.Size(169, 22)
        Me.VerschlüsselnToolStripMenuItem1.Text = "Verschlüsseln"
        '
        'EntschlüsselnToolStripMenuItem1
        '
        Me.EntschlüsselnToolStripMenuItem1.Image = Global.WinCrypt_Designer.My.Resources.Resources.unlock16
        Me.EntschlüsselnToolStripMenuItem1.Name = "EntschlüsselnToolStripMenuItem1"
        Me.EntschlüsselnToolStripMenuItem1.Size = New System.Drawing.Size(169, 22)
        Me.EntschlüsselnToolStripMenuItem1.Text = "Entschlüsseln"
        '
        'SchlüsselErstellenToolStripMenuItem
        '
        Me.SchlüsselErstellenToolStripMenuItem.Image = Global.WinCrypt_Designer.My.Resources.Resources.Key16
        Me.SchlüsselErstellenToolStripMenuItem.Name = "SchlüsselErstellenToolStripMenuItem"
        Me.SchlüsselErstellenToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.SchlüsselErstellenToolStripMenuItem.Text = "Schlüssel erstellen"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(214, 6)
        '
        'EMailToolStripMenuItem1
        '
        Me.EMailToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EMailSendenToolStripMenuItem1})
        Me.EMailToolStripMenuItem1.Name = "EMailToolStripMenuItem1"
        Me.EMailToolStripMenuItem1.Size = New System.Drawing.Size(217, 22)
        Me.EMailToolStripMenuItem1.Text = "E-Mail"
        '
        'EMailSendenToolStripMenuItem1
        '
        Me.EMailSendenToolStripMenuItem1.Name = "EMailSendenToolStripMenuItem1"
        Me.EMailSendenToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.EMailSendenToolStripMenuItem1.Text = "E-Mail Senden"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(214, 6)
        '
        'PasswortmanagerToolStripMenuItem1
        '
        Me.PasswortmanagerToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatenbankExportierenToolStripMenuItem1, Me.DatenbankImportierenToolStripMenuItem1, Me.DatenbankLöschenToolStripMenuItem1})
        Me.PasswortmanagerToolStripMenuItem1.Name = "PasswortmanagerToolStripMenuItem1"
        Me.PasswortmanagerToolStripMenuItem1.Size = New System.Drawing.Size(217, 22)
        Me.PasswortmanagerToolStripMenuItem1.Text = "Passwortmanager"
        '
        'DatenbankExportierenToolStripMenuItem1
        '
        Me.DatenbankExportierenToolStripMenuItem1.Name = "DatenbankExportierenToolStripMenuItem1"
        Me.DatenbankExportierenToolStripMenuItem1.Size = New System.Drawing.Size(196, 22)
        Me.DatenbankExportierenToolStripMenuItem1.Text = "Datenbank exportieren"
        '
        'DatenbankImportierenToolStripMenuItem1
        '
        Me.DatenbankImportierenToolStripMenuItem1.Name = "DatenbankImportierenToolStripMenuItem1"
        Me.DatenbankImportierenToolStripMenuItem1.Size = New System.Drawing.Size(196, 22)
        Me.DatenbankImportierenToolStripMenuItem1.Text = "Datenbank importieren"
        '
        'DatenbankLöschenToolStripMenuItem1
        '
        Me.DatenbankLöschenToolStripMenuItem1.Name = "DatenbankLöschenToolStripMenuItem1"
        Me.DatenbankLöschenToolStripMenuItem1.Size = New System.Drawing.Size(196, 22)
        Me.DatenbankLöschenToolStripMenuItem1.Text = "Datenbank löschen"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(214, 6)
        '
        'SystemidentifikationToolStripMenuItem1
        '
        Me.SystemidentifikationToolStripMenuItem1.Image = Global.WinCrypt_Designer.My.Resources.Resources.Identity
        Me.SystemidentifikationToolStripMenuItem1.Name = "SystemidentifikationToolStripMenuItem1"
        Me.SystemidentifikationToolStripMenuItem1.Size = New System.Drawing.Size(217, 22)
        Me.SystemidentifikationToolStripMenuItem1.Text = "Systemidentifikation"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(214, 6)
        '
        'PasswortGeneratorToolStripMenuItem1
        '
        Me.PasswortGeneratorToolStripMenuItem1.Image = Global.WinCrypt_Designer.My.Resources.Resources.Password16
        Me.PasswortGeneratorToolStripMenuItem1.Name = "PasswortGeneratorToolStripMenuItem1"
        Me.PasswortGeneratorToolStripMenuItem1.Size = New System.Drawing.Size(217, 22)
        Me.PasswortGeneratorToolStripMenuItem1.Text = "Passwort generator"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(214, 6)
        '
        'DateienSicherLöschenToolStripMenuItem
        '
        Me.DateienSicherLöschenToolStripMenuItem.Image = Global.WinCrypt_Designer.My.Resources.Resources.Delete16
        Me.DateienSicherLöschenToolStripMenuItem.Name = "DateienSicherLöschenToolStripMenuItem"
        Me.DateienSicherLöschenToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.DateienSicherLöschenToolStripMenuItem.Text = "Dateien sicher löschen"
        '
        'mount_gb
        '
        Me.mount_gb.BackColor = System.Drawing.Color.Transparent
        Me.mount_gb.Controls.Add(Me.cleanlb2)
        Me.mount_gb.Controls.Add(Me.drive_lb)
        Me.mount_gb.Controls.Add(Me.key_lb)
        Me.mount_gb.Controls.Add(Me.file_lb)
        Me.mount_gb.Controls.Add(Me.decrypt_list_status)
        Me.mount_gb.Controls.Add(Me.drivecb)
        Me.mount_gb.Controls.Add(Me.keyencrypt)
        Me.mount_gb.Controls.Add(Me.decrypt_filepath)
        Me.mount_gb.Controls.Add(Me.dismount)
        Me.mount_gb.Controls.Add(Me.mount)
        Me.mount_gb.Controls.Add(Me.opencryptfile)
        Me.mount_gb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mount_gb.Location = New System.Drawing.Point(12, 309)
        Me.mount_gb.Name = "mount_gb"
        Me.mount_gb.Size = New System.Drawing.Size(573, 288)
        Me.mount_gb.TabIndex = 9
        Me.mount_gb.TabStop = False
        Me.mount_gb.Text = "mount cryptfile"
        '
        'cleanlb2
        '
        Me.cleanlb2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cleanlb2.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cleanlb2.FlatAppearance.BorderSize = 0
        Me.cleanlb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cleanlb2.Image = Global.WinCrypt_Designer.My.Resources.Resources.Clean16
        Me.cleanlb2.Location = New System.Drawing.Point(525, 215)
        Me.cleanlb2.Name = "cleanlb2"
        Me.cleanlb2.Size = New System.Drawing.Size(37, 23)
        Me.cleanlb2.TabIndex = 9
        Me.cleanlb2.UseVisualStyleBackColor = False
        '
        'drive_lb
        '
        Me.drive_lb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.drive_lb.AutoSize = True
        Me.drive_lb.Location = New System.Drawing.Point(309, 248)
        Me.drive_lb.Name = "drive_lb"
        Me.drive_lb.Size = New System.Drawing.Size(33, 13)
        Me.drive_lb.TabIndex = 9
        Me.drive_lb.Text = "drive:"
        '
        'key_lb
        '
        Me.key_lb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.key_lb.AutoSize = True
        Me.key_lb.Location = New System.Drawing.Point(8, 230)
        Me.key_lb.Name = "key_lb"
        Me.key_lb.Size = New System.Drawing.Size(27, 13)
        Me.key_lb.TabIndex = 8
        Me.key_lb.Text = "key:"
        '
        'file_lb
        '
        Me.file_lb.AutoSize = True
        Me.file_lb.Location = New System.Drawing.Point(8, 16)
        Me.file_lb.Name = "file_lb"
        Me.file_lb.Size = New System.Drawing.Size(23, 13)
        Me.file_lb.TabIndex = 7
        Me.file_lb.Text = "file:"
        '
        'decrypt_list_status
        '
        Me.decrypt_list_status.AllowDrop = True
        Me.decrypt_list_status.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.decrypt_list_status.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.decrypt_list_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.decrypt_list_status.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.decrypt_list_status.FormattingEnabled = True
        Me.decrypt_list_status.Location = New System.Drawing.Point(11, 63)
        Me.decrypt_list_status.Name = "decrypt_list_status"
        Me.decrypt_list_status.Size = New System.Drawing.Size(552, 145)
        Me.decrypt_list_status.TabIndex = 6
        '
        'drivecb
        '
        Me.drivecb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.drivecb.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.drivecb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.drivecb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.drivecb.FormattingEnabled = True
        Me.drivecb.Items.AddRange(New Object() {"A:\", "B:\", "C:\", "D:\", "E:\", "F:\", "G:\", "H:\", "I:\", "J:\", "K:\", "L:\", "M:\", "N:\", "O:\", "P:\", "Q:\", "R:\", "S:\", "T:\", "U:\", "V:\", "W:\", "X:\", "Y:\", "Z:\"})
        Me.drivecb.Location = New System.Drawing.Point(348, 246)
        Me.drivecb.Name = "drivecb"
        Me.drivecb.Size = New System.Drawing.Size(46, 21)
        Me.drivecb.TabIndex = 5
        Me.drivecb.Text = "T:\"
        '
        'keyencrypt
        '
        Me.keyencrypt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.keyencrypt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.keyencrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.keyencrypt.Enabled = False
        Me.keyencrypt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.keyencrypt.Location = New System.Drawing.Point(11, 246)
        Me.keyencrypt.Name = "keyencrypt"
        Me.keyencrypt.Size = New System.Drawing.Size(261, 20)
        Me.keyencrypt.TabIndex = 4
        Me.keyencrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'decrypt_filepath
        '
        Me.decrypt_filepath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.decrypt_filepath.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.decrypt_filepath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.decrypt_filepath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.decrypt_filepath.Location = New System.Drawing.Point(11, 32)
        Me.decrypt_filepath.Name = "decrypt_filepath"
        Me.decrypt_filepath.Size = New System.Drawing.Size(471, 20)
        Me.decrypt_filepath.TabIndex = 3
        '
        'dismount
        '
        Me.dismount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dismount.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dismount.Enabled = False
        Me.dismount.FlatAppearance.BorderSize = 0
        Me.dismount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dismount.Location = New System.Drawing.Point(487, 244)
        Me.dismount.Name = "dismount"
        Me.dismount.Size = New System.Drawing.Size(75, 23)
        Me.dismount.TabIndex = 2
        Me.dismount.Text = "dismount"
        Me.dismount.UseVisualStyleBackColor = False
        '
        'mount
        '
        Me.mount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mount.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mount.Enabled = False
        Me.mount.FlatAppearance.BorderSize = 0
        Me.mount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mount.Location = New System.Drawing.Point(406, 244)
        Me.mount.Name = "mount"
        Me.mount.Size = New System.Drawing.Size(75, 23)
        Me.mount.TabIndex = 1
        Me.mount.Text = "mount"
        Me.mount.UseVisualStyleBackColor = False
        '
        'opencryptfile
        '
        Me.opencryptfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opencryptfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.opencryptfile.FlatAppearance.BorderSize = 0
        Me.opencryptfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opencryptfile.ForeColor = System.Drawing.Color.White
        Me.opencryptfile.Location = New System.Drawing.Point(487, 30)
        Me.opencryptfile.Name = "opencryptfile"
        Me.opencryptfile.Size = New System.Drawing.Size(75, 23)
        Me.opencryptfile.TabIndex = 0
        Me.opencryptfile.Text = "open"
        Me.opencryptfile.UseVisualStyleBackColor = False
        '
        'encrypt_gb
        '
        Me.encrypt_gb.BackColor = System.Drawing.Color.Transparent
        Me.encrypt_gb.Controls.Add(Me.cleanlb1)
        Me.encrypt_gb.Controls.Add(Me.encrypt_list_status)
        Me.encrypt_gb.Controls.Add(Me.key_lb1)
        Me.encrypt_gb.Controls.Add(Me.create_container_encrypt)
        Me.encrypt_gb.Controls.Add(Me.path_encrypt)
        Me.encrypt_gb.Controls.Add(Me.generate_key_encrypt)
        Me.encrypt_gb.Controls.Add(Me.crypt_file_pathbutton)
        Me.encrypt_gb.Controls.Add(Me.keycrypt)
        Me.encrypt_gb.Controls.Add(Me.pathtxt)
        Me.encrypt_gb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.encrypt_gb.Location = New System.Drawing.Point(13, 55)
        Me.encrypt_gb.Name = "encrypt_gb"
        Me.encrypt_gb.Size = New System.Drawing.Size(573, 248)
        Me.encrypt_gb.TabIndex = 8
        Me.encrypt_gb.TabStop = False
        Me.encrypt_gb.Text = "encrypt folder / drive"
        '
        'cleanlb1
        '
        Me.cleanlb1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cleanlb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cleanlb1.FlatAppearance.BorderSize = 0
        Me.cleanlb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cleanlb1.Image = Global.WinCrypt_Designer.My.Resources.Resources.Clean16
        Me.cleanlb1.Location = New System.Drawing.Point(525, 220)
        Me.cleanlb1.Name = "cleanlb1"
        Me.cleanlb1.Size = New System.Drawing.Size(37, 23)
        Me.cleanlb1.TabIndex = 8
        Me.cleanlb1.UseVisualStyleBackColor = False
        '
        'encrypt_list_status
        '
        Me.encrypt_list_status.AllowDrop = True
        Me.encrypt_list_status.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.encrypt_list_status.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.encrypt_list_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.encrypt_list_status.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.encrypt_list_status.FormattingEnabled = True
        Me.encrypt_list_status.Location = New System.Drawing.Point(11, 98)
        Me.encrypt_list_status.Name = "encrypt_list_status"
        Me.encrypt_list_status.Size = New System.Drawing.Size(551, 119)
        Me.encrypt_list_status.TabIndex = 5
        '
        'key_lb1
        '
        Me.key_lb1.AutoSize = True
        Me.key_lb1.Location = New System.Drawing.Point(11, 56)
        Me.key_lb1.Name = "key_lb1"
        Me.key_lb1.Size = New System.Drawing.Size(27, 13)
        Me.key_lb1.TabIndex = 7
        Me.key_lb1.Text = "key:"
        '
        'create_container_encrypt
        '
        Me.create_container_encrypt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.create_container_encrypt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.create_container_encrypt.Enabled = False
        Me.create_container_encrypt.FlatAppearance.BorderSize = 0
        Me.create_container_encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.create_container_encrypt.Location = New System.Drawing.Point(449, 70)
        Me.create_container_encrypt.Name = "create_container_encrypt"
        Me.create_container_encrypt.Size = New System.Drawing.Size(113, 23)
        Me.create_container_encrypt.TabIndex = 0
        Me.create_container_encrypt.Text = "create container"
        Me.create_container_encrypt.UseVisualStyleBackColor = False
        '
        'path_encrypt
        '
        Me.path_encrypt.AutoSize = True
        Me.path_encrypt.Location = New System.Drawing.Point(8, 17)
        Me.path_encrypt.Name = "path_encrypt"
        Me.path_encrypt.Size = New System.Drawing.Size(31, 13)
        Me.path_encrypt.TabIndex = 6
        Me.path_encrypt.Text = "path:"
        '
        'generate_key_encrypt
        '
        Me.generate_key_encrypt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.generate_key_encrypt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.generate_key_encrypt.Enabled = False
        Me.generate_key_encrypt.FlatAppearance.BorderSize = 0
        Me.generate_key_encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.generate_key_encrypt.Location = New System.Drawing.Point(368, 70)
        Me.generate_key_encrypt.Name = "generate_key_encrypt"
        Me.generate_key_encrypt.Size = New System.Drawing.Size(75, 23)
        Me.generate_key_encrypt.TabIndex = 1
        Me.generate_key_encrypt.Text = "generate"
        Me.generate_key_encrypt.UseVisualStyleBackColor = False
        '
        'crypt_file_pathbutton
        '
        Me.crypt_file_pathbutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crypt_file_pathbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.crypt_file_pathbutton.FlatAppearance.BorderSize = 0
        Me.crypt_file_pathbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.crypt_file_pathbutton.Location = New System.Drawing.Point(487, 31)
        Me.crypt_file_pathbutton.Name = "crypt_file_pathbutton"
        Me.crypt_file_pathbutton.Size = New System.Drawing.Size(75, 23)
        Me.crypt_file_pathbutton.TabIndex = 2
        Me.crypt_file_pathbutton.Text = "add"
        Me.crypt_file_pathbutton.UseVisualStyleBackColor = False
        '
        'keycrypt
        '
        Me.keycrypt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.keycrypt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.keycrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.keycrypt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.keycrypt.Location = New System.Drawing.Point(11, 72)
        Me.keycrypt.Name = "keycrypt"
        Me.keycrypt.Size = New System.Drawing.Size(351, 20)
        Me.keycrypt.TabIndex = 4
        Me.keycrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pathtxt
        '
        Me.pathtxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pathtxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pathtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pathtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pathtxt.Location = New System.Drawing.Point(11, 33)
        Me.pathtxt.Name = "pathtxt"
        Me.pathtxt.Size = New System.Drawing.Size(471, 20)
        Me.pathtxt.TabIndex = 3
        '
        'wincrypt_icon
        '
        Me.wincrypt_icon.BackColor = System.Drawing.Color.Transparent
        Me.wincrypt_icon.Image = Global.WinCrypt_Designer.My.Resources.Resources.wcicon16
        Me.wincrypt_icon.Location = New System.Drawing.Point(9, 6)
        Me.wincrypt_icon.Name = "wincrypt_icon"
        Me.wincrypt_icon.Size = New System.Drawing.Size(16, 16)
        Me.wincrypt_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wincrypt_icon.TabIndex = 12
        Me.wincrypt_icon.TabStop = False
        '
        'XToolStripMenuItem
        '
        Me.XToolStripMenuItem.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.XToolStripMenuItem.Name = "XToolStripMenuItem"
        Me.XToolStripMenuItem.Size = New System.Drawing.Size(29, 23)
        Me.XToolStripMenuItem.Text = "X"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(32, 23)
        Me.ToolStripMenuItem1.Text = "─"
        '
        'wincrypttitle
        '
        Me.wincrypttitle.AutoSize = True
        Me.wincrypttitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wincrypttitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.wincrypttitle.Location = New System.Drawing.Point(34, 6)
        Me.wincrypttitle.Name = "wincrypttitle"
        Me.wincrypttitle.Size = New System.Drawing.Size(82, 16)
        Me.wincrypttitle.TabIndex = 13
        Me.wincrypttitle.Text = "WinCrypt 0.0"
        '
        'XToolStripMenuItem1
        '
        Me.XToolStripMenuItem1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.XToolStripMenuItem1.Name = "XToolStripMenuItem1"
        Me.XToolStripMenuItem1.Size = New System.Drawing.Size(29, 20)
        Me.XToolStripMenuItem1.Text = "X"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(32, 23)
        Me.ToolStripMenuItem2.Text = "─"
        '
        'file_bt_menu
        '
        Me.file_bt_menu.BackColor = System.Drawing.Color.Transparent
        Me.file_bt_menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.setting_bt_menu, Me.exit_bt_menu})
        Me.file_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.file_bt_menu.Name = "file_bt_menu"
        Me.file_bt_menu.Size = New System.Drawing.Size(35, 20)
        Me.file_bt_menu.Text = "file"
        '
        'setting_bt_menu
        '
        Me.setting_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.setting_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.setting_bt_menu.Image = Global.WinCrypt_Designer.My.Resources.Resources.setting
        Me.setting_bt_menu.Name = "setting_bt_menu"
        Me.setting_bt_menu.Size = New System.Drawing.Size(152, 22)
        Me.setting_bt_menu.Text = "setting"
        '
        'exit_bt_menu
        '
        Me.exit_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.exit_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.exit_bt_menu.Image = Global.WinCrypt_Designer.My.Resources.Resources.Close16
        Me.exit_bt_menu.Name = "exit_bt_menu"
        Me.exit_bt_menu.Size = New System.Drawing.Size(152, 22)
        Me.exit_bt_menu.Text = "exit"
        '
        'tools_bt_menu
        '
        Me.tools_bt_menu.BackColor = System.Drawing.Color.Transparent
        Me.tools_bt_menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.file_encrypt_bt_menu, Me.file_decrypt_bt_menu, Me.text_encrypt_bt_menu, Me.hash_bt_menu, Me.rsa_bt_menu, Me.mail_bt_menu, Me.pw_manager_bt_menu, Me.systemidentification_bt_menu, Me.pw_generator_bt_menu, Me.delete_file_bt_menu})
        Me.tools_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tools_bt_menu.Name = "tools_bt_menu"
        Me.tools_bt_menu.Size = New System.Drawing.Size(45, 20)
        Me.tools_bt_menu.Text = "tools"
        '
        'file_encrypt_bt_menu
        '
        Me.file_encrypt_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.file_encrypt_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.file_encrypt_bt_menu.Image = Global.WinCrypt_Designer.My.Resources.Resources.Lock16
        Me.file_encrypt_bt_menu.Name = "file_encrypt_bt_menu"
        Me.file_encrypt_bt_menu.Size = New System.Drawing.Size(183, 22)
        Me.file_encrypt_bt_menu.Text = "encrypt file"
        '
        'file_decrypt_bt_menu
        '
        Me.file_decrypt_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.file_decrypt_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.file_decrypt_bt_menu.Image = Global.WinCrypt_Designer.My.Resources.Resources.unlock16
        Me.file_decrypt_bt_menu.Name = "file_decrypt_bt_menu"
        Me.file_decrypt_bt_menu.Size = New System.Drawing.Size(183, 22)
        Me.file_decrypt_bt_menu.Text = "decrypt file"
        '
        'text_encrypt_bt_menu
        '
        Me.text_encrypt_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.text_encrypt_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.text_encrypt_bt_menu.Image = Global.WinCrypt_Designer.My.Resources.Resources.textencrypt
        Me.text_encrypt_bt_menu.Name = "text_encrypt_bt_menu"
        Me.text_encrypt_bt_menu.Size = New System.Drawing.Size(183, 22)
        Me.text_encrypt_bt_menu.Text = "text en - and decrypt"
        '
        'hash_bt_menu
        '
        Me.hash_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.hash_bt_menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.md5_converter_bt_menu, Me.md5_bf_bt_menu})
        Me.hash_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.hash_bt_menu.Name = "hash_bt_menu"
        Me.hash_bt_menu.Size = New System.Drawing.Size(183, 22)
        Me.hash_bt_menu.Text = "hash"
        '
        'md5_converter_bt_menu
        '
        Me.md5_converter_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.md5_converter_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.md5_converter_bt_menu.Name = "md5_converter_bt_menu"
        Me.md5_converter_bt_menu.Size = New System.Drawing.Size(162, 22)
        Me.md5_converter_bt_menu.Text = "MD5 converter"
        '
        'md5_bf_bt_menu
        '
        Me.md5_bf_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.md5_bf_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.md5_bf_bt_menu.Name = "md5_bf_bt_menu"
        Me.md5_bf_bt_menu.Size = New System.Drawing.Size(162, 22)
        Me.md5_bf_bt_menu.Text = "MD5 Brute-force"
        '
        'rsa_bt_menu
        '
        Me.rsa_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.rsa_bt_menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rsa_encrypt_bt_menu, Me.rsa_decrypt_bt_menu, Me.rsa_create_keys_bt_menu})
        Me.rsa_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rsa_bt_menu.Name = "rsa_bt_menu"
        Me.rsa_bt_menu.Size = New System.Drawing.Size(183, 22)
        Me.rsa_bt_menu.Text = "RSA"
        '
        'rsa_encrypt_bt_menu
        '
        Me.rsa_encrypt_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.rsa_encrypt_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rsa_encrypt_bt_menu.Image = Global.WinCrypt_Designer.My.Resources.Resources.Lock16
        Me.rsa_encrypt_bt_menu.Name = "rsa_encrypt_bt_menu"
        Me.rsa_encrypt_bt_menu.Size = New System.Drawing.Size(152, 22)
        Me.rsa_encrypt_bt_menu.Text = "encryption"
        '
        'rsa_decrypt_bt_menu
        '
        Me.rsa_decrypt_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.rsa_decrypt_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rsa_decrypt_bt_menu.Image = Global.WinCrypt_Designer.My.Resources.Resources.unlock16
        Me.rsa_decrypt_bt_menu.Name = "rsa_decrypt_bt_menu"
        Me.rsa_decrypt_bt_menu.Size = New System.Drawing.Size(152, 22)
        Me.rsa_decrypt_bt_menu.Text = "decryption"
        '
        'rsa_create_keys_bt_menu
        '
        Me.rsa_create_keys_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.rsa_create_keys_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rsa_create_keys_bt_menu.Image = Global.WinCrypt_Designer.My.Resources.Resources.Key16
        Me.rsa_create_keys_bt_menu.Name = "rsa_create_keys_bt_menu"
        Me.rsa_create_keys_bt_menu.Size = New System.Drawing.Size(152, 22)
        Me.rsa_create_keys_bt_menu.Text = "create key's"
        '
        'mail_bt_menu
        '
        Me.mail_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.mail_bt_menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.send_mail_bt_menu})
        Me.mail_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mail_bt_menu.Image = Global.WinCrypt_Designer.My.Resources.Resources.mail
        Me.mail_bt_menu.Name = "mail_bt_menu"
        Me.mail_bt_menu.Size = New System.Drawing.Size(183, 22)
        Me.mail_bt_menu.Text = "E-Mail"
        '
        'send_mail_bt_menu
        '
        Me.send_mail_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.send_mail_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.send_mail_bt_menu.Image = Global.WinCrypt_Designer.My.Resources.Resources.MailSend16
        Me.send_mail_bt_menu.Name = "send_mail_bt_menu"
        Me.send_mail_bt_menu.Size = New System.Drawing.Size(152, 22)
        Me.send_mail_bt_menu.Text = "send e-mail"
        '
        'pw_manager_bt_menu
        '
        Me.pw_manager_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pw_manager_bt_menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.export_db_bt_menu, Me.import_db_bt_menu, Me.delete_db_menu})
        Me.pw_manager_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pw_manager_bt_menu.Image = Global.WinCrypt_Designer.My.Resources.Resources.pwmanager
        Me.pw_manager_bt_menu.Name = "pw_manager_bt_menu"
        Me.pw_manager_bt_menu.Size = New System.Drawing.Size(183, 22)
        Me.pw_manager_bt_menu.Text = "passwordmanager"
        '
        'export_db_bt_menu
        '
        Me.export_db_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.export_db_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.export_db_bt_menu.Image = Global.WinCrypt_Designer.My.Resources.Resources.DataExport16
        Me.export_db_bt_menu.Name = "export_db_bt_menu"
        Me.export_db_bt_menu.Size = New System.Drawing.Size(160, 22)
        Me.export_db_bt_menu.Text = "export database"
        '
        'import_db_bt_menu
        '
        Me.import_db_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.import_db_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.import_db_bt_menu.Image = Global.WinCrypt_Designer.My.Resources.Resources.DataImport16
        Me.import_db_bt_menu.Name = "import_db_bt_menu"
        Me.import_db_bt_menu.Size = New System.Drawing.Size(160, 22)
        Me.import_db_bt_menu.Text = "import database"
        '
        'delete_db_menu
        '
        Me.delete_db_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.delete_db_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.delete_db_menu.Image = Global.WinCrypt_Designer.My.Resources.Resources.DataErase16
        Me.delete_db_menu.Name = "delete_db_menu"
        Me.delete_db_menu.Size = New System.Drawing.Size(160, 22)
        Me.delete_db_menu.Text = "delete database"
        '
        'systemidentification_bt_menu
        '
        Me.systemidentification_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.systemidentification_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.systemidentification_bt_menu.Image = Global.WinCrypt_Designer.My.Resources.Resources.Identity
        Me.systemidentification_bt_menu.Name = "systemidentification_bt_menu"
        Me.systemidentification_bt_menu.Size = New System.Drawing.Size(183, 22)
        Me.systemidentification_bt_menu.Text = "systemidentification"
        '
        'pw_generator_bt_menu
        '
        Me.pw_generator_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pw_generator_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pw_generator_bt_menu.Image = Global.WinCrypt_Designer.My.Resources.Resources.Password16
        Me.pw_generator_bt_menu.Name = "pw_generator_bt_menu"
        Me.pw_generator_bt_menu.Size = New System.Drawing.Size(183, 22)
        Me.pw_generator_bt_menu.Text = "passwordgenerator"
        '
        'delete_file_bt_menu
        '
        Me.delete_file_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.delete_file_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.delete_file_bt_menu.Image = Global.WinCrypt_Designer.My.Resources.Resources.Delete16
        Me.delete_file_bt_menu.Name = "delete_file_bt_menu"
        Me.delete_file_bt_menu.Size = New System.Drawing.Size(183, 22)
        Me.delete_file_bt_menu.Text = "delete file savetly"
        '
        'info_bt_menu
        '
        Me.info_bt_menu.BackColor = System.Drawing.Color.Transparent
        Me.info_bt_menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.update_bt_menu, Me.feedback_bt_menu, Me.about_bt_menu})
        Me.info_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.info_bt_menu.Name = "info_bt_menu"
        Me.info_bt_menu.Size = New System.Drawing.Size(40, 20)
        Me.info_bt_menu.Text = "info"
        '
        'update_bt_menu
        '
        Me.update_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.update_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.update_bt_menu.Image = Global.WinCrypt_Designer.My.Resources.Resources.updateflat
        Me.update_bt_menu.Name = "update_bt_menu"
        Me.update_bt_menu.Size = New System.Drawing.Size(152, 22)
        Me.update_bt_menu.Text = "update"
        '
        'feedback_bt_menu
        '
        Me.feedback_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.feedback_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.feedback_bt_menu.Image = Global.WinCrypt_Designer.My.Resources.Resources.feedback16
        Me.feedback_bt_menu.Name = "feedback_bt_menu"
        Me.feedback_bt_menu.Size = New System.Drawing.Size(152, 22)
        Me.feedback_bt_menu.Text = "feedback"
        '
        'about_bt_menu
        '
        Me.about_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.about_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.about_bt_menu.Image = Global.WinCrypt_Designer.My.Resources.Resources.Information16
        Me.about_bt_menu.Name = "about_bt_menu"
        Me.about_bt_menu.Size = New System.Drawing.Size(152, 22)
        Me.about_bt_menu.Text = "about"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.file_bt_menu, Me.tools_bt_menu, Me.info_bt_menu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 27)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(598, 24)
        Me.MenuStrip.TabIndex = 11
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'exit_bt
        '
        Me.exit_bt.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_bt.ForeColor = System.Drawing.Color.White
        Me.exit_bt.Name = "exit_bt"
        Me.exit_bt.Size = New System.Drawing.Size(29, 23)
        Me.exit_bt.Text = "X"
        '
        'minimize_bt
        '
        Me.minimize_bt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimize_bt.ForeColor = System.Drawing.Color.White
        Me.minimize_bt.Name = "minimize_bt"
        Me.minimize_bt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.minimize_bt.Size = New System.Drawing.Size(32, 23)
        Me.minimize_bt.Text = "─"
        '
        'form_head
        '
        Me.form_head.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.form_head.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exit_bt, Me.minimize_bt})
        Me.form_head.Location = New System.Drawing.Point(0, 0)
        Me.form_head.Name = "form_head"
        Me.form_head.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.form_head.Size = New System.Drawing.Size(598, 27)
        Me.form_head.TabIndex = 12
        Me.form_head.Text = "WinCrypt"
        '
        'Startwindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(598, 609)
        Me.Controls.Add(Me.wincrypt_icon)
        Me.Controls.Add(Me.wincrypttitle)
        Me.Controls.Add(Me.mount_gb)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.encrypt_gb)
        Me.Controls.Add(Me.form_head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "Startwindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WinCrypt 1.3"
        Me.mount_gb.ResumeLayout(False)
        Me.mount_gb.PerformLayout()
        Me.encrypt_gb.ResumeLayout(False)
        Me.encrypt_gb.PerformLayout()
        CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.form_head.ResumeLayout(False)
        Me.form_head.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateiVerschlüsselnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateiEntschlüsselnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextVerschlüsselnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemidentifikationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasswortgeneratorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EinstellungToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateiSicherLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateiVerschlüsselnToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateiEntschlüsselnToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TextVerUndEntschlüsselnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SystemidentifikationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PasswortGeneratorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DateienSicherLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MD5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MD5KonverterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MD5CrackerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MD5ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MD5KonverterToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MD5BruteforceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RSAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntschlüsselnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerschlüsselnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeyErstellenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EMailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EMailSendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RSAToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerschlüsselnToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntschlüsselnToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SchlüsselErstellenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EMailToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EMailSendenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasswortmanagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PasswortmanagerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatenbankExportierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatenbankImportierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatenbankLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatenbankExportierenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatenbankImportierenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatenbankLöschenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mount_gb As System.Windows.Forms.GroupBox
    Friend WithEvents drive_lb As System.Windows.Forms.Label
    Friend WithEvents key_lb As System.Windows.Forms.Label
    Friend WithEvents file_lb As System.Windows.Forms.Label
    Friend WithEvents decrypt_list_status As System.Windows.Forms.ListBox
    Friend WithEvents drivecb As System.Windows.Forms.ComboBox
    Friend WithEvents keyencrypt As System.Windows.Forms.TextBox
    Friend WithEvents decrypt_filepath As System.Windows.Forms.TextBox
    Friend WithEvents dismount As System.Windows.Forms.Button
    Friend WithEvents mount As System.Windows.Forms.Button
    Friend WithEvents opencryptfile As System.Windows.Forms.Button
    Friend WithEvents encrypt_gb As System.Windows.Forms.GroupBox
    Friend WithEvents encrypt_list_status As System.Windows.Forms.ListBox
    Friend WithEvents key_lb1 As System.Windows.Forms.Label
    Friend WithEvents create_container_encrypt As System.Windows.Forms.Button
    Friend WithEvents path_encrypt As System.Windows.Forms.Label
    Friend WithEvents generate_key_encrypt As System.Windows.Forms.Button
    Friend WithEvents crypt_file_pathbutton As System.Windows.Forms.Button
    Friend WithEvents keycrypt As System.Windows.Forms.TextBox
    Friend WithEvents pathtxt As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents wincrypttitle As System.Windows.Forms.Label
    Friend WithEvents wincrypt_icon As System.Windows.Forms.PictureBox
    Friend WithEvents XToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cleanlb1 As System.Windows.Forms.Button
    Friend WithEvents cleanlb2 As System.Windows.Forms.Button
    Friend WithEvents file_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents setting_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents exit_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tools_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents file_encrypt_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents file_decrypt_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents text_encrypt_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents hash_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents md5_converter_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents md5_bf_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rsa_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rsa_encrypt_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rsa_decrypt_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rsa_create_keys_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mail_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents send_mail_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pw_manager_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents export_db_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents import_db_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents delete_db_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents systemidentification_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pw_generator_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents delete_file_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents info_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents update_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents feedback_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents about_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents exit_bt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents minimize_bt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents form_head As System.Windows.Forms.MenuStrip

End Class
