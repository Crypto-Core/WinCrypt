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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Startwindow))
        Me.folder_dialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.encrypttimer = New System.Windows.Forms.Timer(Me.components)
        Me.encryptmounttimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.file_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.setting_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.exit_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.tools_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncryptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rsa_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.rsa_encrypt_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.rsa_decrypt_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.rsa_create_keys_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.hash_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.md5_converter_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.md5_bf_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MD5DateiChecksumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.text_encrypt_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileEncryptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.file_encrypt_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.file_decrypt_bt_menu = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.systemtray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.systemtray_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.about_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.feedback_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.update_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.tools_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.file_encrypt__bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.file_decrypt_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.text_encrypt_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.hash_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.converter_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.bf_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.file_checksum_systray = New System.Windows.Forms.ToolStripMenuItem()
        Me.rsa_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.rsa_encrypt_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.rsa_decrypt_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.rsa_create_keys_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.mail_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.send_mail_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.pw_manager_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.export_db_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.import_db_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.delete_db_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.systemidentification_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.pwg_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.file_delete_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.open_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
        Me.exit_bt_systemtray = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.import_db_dialog = New System.Windows.Forms.OpenFileDialog()
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
        Me.form_head = New System.Windows.Forms.MenuStrip()
        Me.exit_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.minimize_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.XToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.gethotkey = New System.Windows.Forms.Timer(Me.components)
        Me.export_db_dialog = New System.Windows.Forms.SaveFileDialog()
        Me.open_encrypt_dialog = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip.SuspendLayout()
        Me.systemtray_menu.SuspendLayout()
        Me.mount_gb.SuspendLayout()
        Me.encrypt_gb.SuspendLayout()
        CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.form_head.SuspendLayout()
        Me.SuspendLayout()
        '
        'encrypttimer
        '
        '
        'encryptmounttimer
        '
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.file_bt_menu, Me.tools_bt_menu, Me.info_bt_menu})
        resources.ApplyResources(Me.MenuStrip, "MenuStrip")
        Me.MenuStrip.Name = "MenuStrip"
        '
        'file_bt_menu
        '
        Me.file_bt_menu.BackColor = System.Drawing.Color.Transparent
        Me.file_bt_menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.setting_bt_menu, Me.exit_bt_menu})
        Me.file_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.file_bt_menu.Name = "file_bt_menu"
        resources.ApplyResources(Me.file_bt_menu, "file_bt_menu")
        '
        'setting_bt_menu
        '
        Me.setting_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.setting_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.setting_bt_menu.Image = Global.Project_WinCrypt.My.Resources.Resources.setting
        Me.setting_bt_menu.Name = "setting_bt_menu"
        resources.ApplyResources(Me.setting_bt_menu, "setting_bt_menu")
        '
        'exit_bt_menu
        '
        Me.exit_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.exit_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.exit_bt_menu.Image = Global.Project_WinCrypt.My.Resources.Resources.Close16
        Me.exit_bt_menu.Name = "exit_bt_menu"
        resources.ApplyResources(Me.exit_bt_menu, "exit_bt_menu")
        '
        'tools_bt_menu
        '
        Me.tools_bt_menu.BackColor = System.Drawing.Color.Transparent
        Me.tools_bt_menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncryptionToolStripMenuItem, Me.mail_bt_menu, Me.pw_manager_bt_menu, Me.systemidentification_bt_menu, Me.pw_generator_bt_menu, Me.delete_file_bt_menu})
        Me.tools_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tools_bt_menu.Name = "tools_bt_menu"
        resources.ApplyResources(Me.tools_bt_menu, "tools_bt_menu")
        '
        'EncryptionToolStripMenuItem
        '
        Me.EncryptionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.EncryptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rsa_bt_menu, Me.hash_bt_menu, Me.text_encrypt_bt_menu, Me.FileEncryptionToolStripMenuItem})
        Me.EncryptionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EncryptionToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.Key16
        Me.EncryptionToolStripMenuItem.Name = "EncryptionToolStripMenuItem"
        resources.ApplyResources(Me.EncryptionToolStripMenuItem, "EncryptionToolStripMenuItem")
        '
        'rsa_bt_menu
        '
        Me.rsa_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.rsa_bt_menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rsa_encrypt_bt_menu, Me.rsa_decrypt_bt_menu, Me.rsa_create_keys_bt_menu})
        Me.rsa_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rsa_bt_menu.Name = "rsa_bt_menu"
        resources.ApplyResources(Me.rsa_bt_menu, "rsa_bt_menu")
        '
        'rsa_encrypt_bt_menu
        '
        Me.rsa_encrypt_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.rsa_encrypt_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rsa_encrypt_bt_menu.Image = Global.Project_WinCrypt.My.Resources.Resources.Lock16
        Me.rsa_encrypt_bt_menu.Name = "rsa_encrypt_bt_menu"
        resources.ApplyResources(Me.rsa_encrypt_bt_menu, "rsa_encrypt_bt_menu")
        '
        'rsa_decrypt_bt_menu
        '
        Me.rsa_decrypt_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.rsa_decrypt_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rsa_decrypt_bt_menu.Image = Global.Project_WinCrypt.My.Resources.Resources.unlock16
        Me.rsa_decrypt_bt_menu.Name = "rsa_decrypt_bt_menu"
        resources.ApplyResources(Me.rsa_decrypt_bt_menu, "rsa_decrypt_bt_menu")
        '
        'rsa_create_keys_bt_menu
        '
        Me.rsa_create_keys_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.rsa_create_keys_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rsa_create_keys_bt_menu.Image = Global.Project_WinCrypt.My.Resources.Resources.Key16
        Me.rsa_create_keys_bt_menu.Name = "rsa_create_keys_bt_menu"
        resources.ApplyResources(Me.rsa_create_keys_bt_menu, "rsa_create_keys_bt_menu")
        '
        'hash_bt_menu
        '
        Me.hash_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.hash_bt_menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.md5_converter_bt_menu, Me.md5_bf_bt_menu, Me.MD5DateiChecksumToolStripMenuItem})
        Me.hash_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.hash_bt_menu.Name = "hash_bt_menu"
        resources.ApplyResources(Me.hash_bt_menu, "hash_bt_menu")
        '
        'md5_converter_bt_menu
        '
        Me.md5_converter_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.md5_converter_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.md5_converter_bt_menu.Image = Global.Project_WinCrypt.My.Resources.Resources.Command_Refresh_16
        Me.md5_converter_bt_menu.Name = "md5_converter_bt_menu"
        resources.ApplyResources(Me.md5_converter_bt_menu, "md5_converter_bt_menu")
        '
        'md5_bf_bt_menu
        '
        Me.md5_bf_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.md5_bf_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.md5_bf_bt_menu.Image = Global.Project_WinCrypt.My.Resources.Resources.Search_Shield_16
        Me.md5_bf_bt_menu.Name = "md5_bf_bt_menu"
        resources.ApplyResources(Me.md5_bf_bt_menu, "md5_bf_bt_menu")
        '
        'MD5DateiChecksumToolStripMenuItem
        '
        Me.MD5DateiChecksumToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MD5DateiChecksumToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MD5DateiChecksumToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.Document_Check_16
        Me.MD5DateiChecksumToolStripMenuItem.Name = "MD5DateiChecksumToolStripMenuItem"
        resources.ApplyResources(Me.MD5DateiChecksumToolStripMenuItem, "MD5DateiChecksumToolStripMenuItem")
        '
        'text_encrypt_bt_menu
        '
        Me.text_encrypt_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.text_encrypt_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.text_encrypt_bt_menu.Image = Global.Project_WinCrypt.My.Resources.Resources.textencrypt
        Me.text_encrypt_bt_menu.Name = "text_encrypt_bt_menu"
        resources.ApplyResources(Me.text_encrypt_bt_menu, "text_encrypt_bt_menu")
        '
        'FileEncryptionToolStripMenuItem
        '
        Me.FileEncryptionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.FileEncryptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.file_encrypt_bt_menu, Me.file_decrypt_bt_menu})
        Me.FileEncryptionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FileEncryptionToolStripMenuItem.Name = "FileEncryptionToolStripMenuItem"
        resources.ApplyResources(Me.FileEncryptionToolStripMenuItem, "FileEncryptionToolStripMenuItem")
        '
        'file_encrypt_bt_menu
        '
        Me.file_encrypt_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.file_encrypt_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.file_encrypt_bt_menu.Image = Global.Project_WinCrypt.My.Resources.Resources.Lock16
        Me.file_encrypt_bt_menu.Name = "file_encrypt_bt_menu"
        resources.ApplyResources(Me.file_encrypt_bt_menu, "file_encrypt_bt_menu")
        '
        'file_decrypt_bt_menu
        '
        Me.file_decrypt_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        resources.ApplyResources(Me.file_decrypt_bt_menu, "file_decrypt_bt_menu")
        Me.file_decrypt_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.file_decrypt_bt_menu.Image = Global.Project_WinCrypt.My.Resources.Resources.unlock16
        Me.file_decrypt_bt_menu.Name = "file_decrypt_bt_menu"
        '
        'mail_bt_menu
        '
        Me.mail_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.mail_bt_menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.send_mail_bt_menu})
        Me.mail_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mail_bt_menu.Image = Global.Project_WinCrypt.My.Resources.Resources.mail
        Me.mail_bt_menu.Name = "mail_bt_menu"
        resources.ApplyResources(Me.mail_bt_menu, "mail_bt_menu")
        '
        'send_mail_bt_menu
        '
        Me.send_mail_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.send_mail_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.send_mail_bt_menu.Image = Global.Project_WinCrypt.My.Resources.Resources.MailSend16
        Me.send_mail_bt_menu.Name = "send_mail_bt_menu"
        resources.ApplyResources(Me.send_mail_bt_menu, "send_mail_bt_menu")
        '
        'pw_manager_bt_menu
        '
        Me.pw_manager_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pw_manager_bt_menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.export_db_bt_menu, Me.import_db_bt_menu, Me.delete_db_menu})
        Me.pw_manager_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pw_manager_bt_menu.Image = Global.Project_WinCrypt.My.Resources.Resources.pwmanager
        Me.pw_manager_bt_menu.Name = "pw_manager_bt_menu"
        resources.ApplyResources(Me.pw_manager_bt_menu, "pw_manager_bt_menu")
        '
        'export_db_bt_menu
        '
        Me.export_db_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.export_db_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.export_db_bt_menu.Image = Global.Project_WinCrypt.My.Resources.Resources.Data_Export_16
        Me.export_db_bt_menu.Name = "export_db_bt_menu"
        resources.ApplyResources(Me.export_db_bt_menu, "export_db_bt_menu")
        '
        'import_db_bt_menu
        '
        Me.import_db_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.import_db_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.import_db_bt_menu.Image = Global.Project_WinCrypt.My.Resources.Resources.Data_Import_16
        Me.import_db_bt_menu.Name = "import_db_bt_menu"
        resources.ApplyResources(Me.import_db_bt_menu, "import_db_bt_menu")
        '
        'delete_db_menu
        '
        Me.delete_db_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.delete_db_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.delete_db_menu.Image = Global.Project_WinCrypt.My.Resources.Resources.Data_Erase_16
        Me.delete_db_menu.Name = "delete_db_menu"
        resources.ApplyResources(Me.delete_db_menu, "delete_db_menu")
        '
        'systemidentification_bt_menu
        '
        Me.systemidentification_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.systemidentification_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.systemidentification_bt_menu.Image = Global.Project_WinCrypt.My.Resources.Resources.Identity
        Me.systemidentification_bt_menu.Name = "systemidentification_bt_menu"
        resources.ApplyResources(Me.systemidentification_bt_menu, "systemidentification_bt_menu")
        '
        'pw_generator_bt_menu
        '
        Me.pw_generator_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pw_generator_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pw_generator_bt_menu.Image = Global.Project_WinCrypt.My.Resources.Resources.Password16
        Me.pw_generator_bt_menu.Name = "pw_generator_bt_menu"
        resources.ApplyResources(Me.pw_generator_bt_menu, "pw_generator_bt_menu")
        '
        'delete_file_bt_menu
        '
        Me.delete_file_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.delete_file_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.delete_file_bt_menu.Image = Global.Project_WinCrypt.My.Resources.Resources.Delete16
        Me.delete_file_bt_menu.Name = "delete_file_bt_menu"
        resources.ApplyResources(Me.delete_file_bt_menu, "delete_file_bt_menu")
        '
        'info_bt_menu
        '
        Me.info_bt_menu.BackColor = System.Drawing.Color.Transparent
        Me.info_bt_menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.update_bt_menu, Me.feedback_bt_menu, Me.about_bt_menu})
        Me.info_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.info_bt_menu.Name = "info_bt_menu"
        resources.ApplyResources(Me.info_bt_menu, "info_bt_menu")
        '
        'update_bt_menu
        '
        Me.update_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.update_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.update_bt_menu.Image = Global.Project_WinCrypt.My.Resources.Resources.updateflat
        Me.update_bt_menu.Name = "update_bt_menu"
        resources.ApplyResources(Me.update_bt_menu, "update_bt_menu")
        '
        'feedback_bt_menu
        '
        Me.feedback_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.feedback_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.feedback_bt_menu.Image = Global.Project_WinCrypt.My.Resources.Resources.feedback16
        Me.feedback_bt_menu.Name = "feedback_bt_menu"
        resources.ApplyResources(Me.feedback_bt_menu, "feedback_bt_menu")
        '
        'about_bt_menu
        '
        Me.about_bt_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.about_bt_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.about_bt_menu.Image = Global.Project_WinCrypt.My.Resources.Resources.Information16
        Me.about_bt_menu.Name = "about_bt_menu"
        resources.ApplyResources(Me.about_bt_menu, "about_bt_menu")
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EinstellungToolStripMenuItem, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        resources.ApplyResources(Me.DateiToolStripMenuItem, "DateiToolStripMenuItem")
        '
        'EinstellungToolStripMenuItem
        '
        Me.EinstellungToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.EinstellungToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EinstellungToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.setting
        Me.EinstellungToolStripMenuItem.Name = "EinstellungToolStripMenuItem"
        resources.ApplyResources(Me.EinstellungToolStripMenuItem, "EinstellungToolStripMenuItem")
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BeendenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BeendenToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.Close16
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        resources.ApplyResources(Me.BeendenToolStripMenuItem, "BeendenToolStripMenuItem")
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiVerschlüsselnToolStripMenuItem, Me.DateiEntschlüsselnToolStripMenuItem, Me.TextVerschlüsselnToolStripMenuItem, Me.MD5ToolStripMenuItem, Me.RSAToolStripMenuItem, Me.EMailToolStripMenuItem, Me.PasswortmanagerToolStripMenuItem, Me.SystemidentifikationToolStripMenuItem, Me.PasswortgeneratorToolStripMenuItem, Me.DateiSicherLöschenToolStripMenuItem})
        Me.ToolsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        resources.ApplyResources(Me.ToolsToolStripMenuItem, "ToolsToolStripMenuItem")
        '
        'DateiVerschlüsselnToolStripMenuItem
        '
        Me.DateiVerschlüsselnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DateiVerschlüsselnToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateiVerschlüsselnToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.Lock16
        Me.DateiVerschlüsselnToolStripMenuItem.Name = "DateiVerschlüsselnToolStripMenuItem"
        resources.ApplyResources(Me.DateiVerschlüsselnToolStripMenuItem, "DateiVerschlüsselnToolStripMenuItem")
        '
        'DateiEntschlüsselnToolStripMenuItem
        '
        Me.DateiEntschlüsselnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DateiEntschlüsselnToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateiEntschlüsselnToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.unlock16
        Me.DateiEntschlüsselnToolStripMenuItem.Name = "DateiEntschlüsselnToolStripMenuItem"
        resources.ApplyResources(Me.DateiEntschlüsselnToolStripMenuItem, "DateiEntschlüsselnToolStripMenuItem")
        '
        'TextVerschlüsselnToolStripMenuItem
        '
        Me.TextVerschlüsselnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TextVerschlüsselnToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextVerschlüsselnToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.textencrypt
        Me.TextVerschlüsselnToolStripMenuItem.Name = "TextVerschlüsselnToolStripMenuItem"
        resources.ApplyResources(Me.TextVerschlüsselnToolStripMenuItem, "TextVerschlüsselnToolStripMenuItem")
        '
        'MD5ToolStripMenuItem
        '
        Me.MD5ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MD5ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MD5KonverterToolStripMenuItem, Me.MD5CrackerToolStripMenuItem})
        Me.MD5ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MD5ToolStripMenuItem.Name = "MD5ToolStripMenuItem"
        resources.ApplyResources(Me.MD5ToolStripMenuItem, "MD5ToolStripMenuItem")
        '
        'MD5KonverterToolStripMenuItem
        '
        Me.MD5KonverterToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MD5KonverterToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MD5KonverterToolStripMenuItem.Name = "MD5KonverterToolStripMenuItem"
        resources.ApplyResources(Me.MD5KonverterToolStripMenuItem, "MD5KonverterToolStripMenuItem")
        '
        'MD5CrackerToolStripMenuItem
        '
        Me.MD5CrackerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MD5CrackerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MD5CrackerToolStripMenuItem.Name = "MD5CrackerToolStripMenuItem"
        resources.ApplyResources(Me.MD5CrackerToolStripMenuItem, "MD5CrackerToolStripMenuItem")
        '
        'RSAToolStripMenuItem
        '
        Me.RSAToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.RSAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntschlüsselnToolStripMenuItem, Me.VerschlüsselnToolStripMenuItem, Me.KeyErstellenToolStripMenuItem})
        Me.RSAToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RSAToolStripMenuItem.Name = "RSAToolStripMenuItem"
        resources.ApplyResources(Me.RSAToolStripMenuItem, "RSAToolStripMenuItem")
        '
        'EntschlüsselnToolStripMenuItem
        '
        Me.EntschlüsselnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.EntschlüsselnToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EntschlüsselnToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.unlock16
        Me.EntschlüsselnToolStripMenuItem.Name = "EntschlüsselnToolStripMenuItem"
        resources.ApplyResources(Me.EntschlüsselnToolStripMenuItem, "EntschlüsselnToolStripMenuItem")
        '
        'VerschlüsselnToolStripMenuItem
        '
        Me.VerschlüsselnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.VerschlüsselnToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.VerschlüsselnToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.Lock16
        Me.VerschlüsselnToolStripMenuItem.Name = "VerschlüsselnToolStripMenuItem"
        resources.ApplyResources(Me.VerschlüsselnToolStripMenuItem, "VerschlüsselnToolStripMenuItem")
        '
        'KeyErstellenToolStripMenuItem
        '
        Me.KeyErstellenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.KeyErstellenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.KeyErstellenToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.Key16
        Me.KeyErstellenToolStripMenuItem.Name = "KeyErstellenToolStripMenuItem"
        resources.ApplyResources(Me.KeyErstellenToolStripMenuItem, "KeyErstellenToolStripMenuItem")
        '
        'EMailToolStripMenuItem
        '
        Me.EMailToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.EMailToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EMailSendenToolStripMenuItem})
        Me.EMailToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EMailToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.mail
        Me.EMailToolStripMenuItem.Name = "EMailToolStripMenuItem"
        resources.ApplyResources(Me.EMailToolStripMenuItem, "EMailToolStripMenuItem")
        '
        'EMailSendenToolStripMenuItem
        '
        Me.EMailSendenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.EMailSendenToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EMailSendenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EMailSendenToolStripMenuItem.Name = "EMailSendenToolStripMenuItem"
        resources.ApplyResources(Me.EMailSendenToolStripMenuItem, "EMailSendenToolStripMenuItem")
        '
        'PasswortmanagerToolStripMenuItem
        '
        Me.PasswortmanagerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.PasswortmanagerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatenbankExportierenToolStripMenuItem, Me.DatenbankImportierenToolStripMenuItem, Me.DatenbankLöschenToolStripMenuItem})
        Me.PasswortmanagerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PasswortmanagerToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.pwmanager
        Me.PasswortmanagerToolStripMenuItem.Name = "PasswortmanagerToolStripMenuItem"
        resources.ApplyResources(Me.PasswortmanagerToolStripMenuItem, "PasswortmanagerToolStripMenuItem")
        '
        'DatenbankExportierenToolStripMenuItem
        '
        Me.DatenbankExportierenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DatenbankExportierenToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DatenbankExportierenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DatenbankExportierenToolStripMenuItem.Name = "DatenbankExportierenToolStripMenuItem"
        resources.ApplyResources(Me.DatenbankExportierenToolStripMenuItem, "DatenbankExportierenToolStripMenuItem")
        '
        'DatenbankImportierenToolStripMenuItem
        '
        Me.DatenbankImportierenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DatenbankImportierenToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DatenbankImportierenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DatenbankImportierenToolStripMenuItem.Name = "DatenbankImportierenToolStripMenuItem"
        resources.ApplyResources(Me.DatenbankImportierenToolStripMenuItem, "DatenbankImportierenToolStripMenuItem")
        '
        'DatenbankLöschenToolStripMenuItem
        '
        Me.DatenbankLöschenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DatenbankLöschenToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DatenbankLöschenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DatenbankLöschenToolStripMenuItem.Name = "DatenbankLöschenToolStripMenuItem"
        resources.ApplyResources(Me.DatenbankLöschenToolStripMenuItem, "DatenbankLöschenToolStripMenuItem")
        '
        'SystemidentifikationToolStripMenuItem
        '
        Me.SystemidentifikationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SystemidentifikationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SystemidentifikationToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.Identity
        Me.SystemidentifikationToolStripMenuItem.Name = "SystemidentifikationToolStripMenuItem"
        resources.ApplyResources(Me.SystemidentifikationToolStripMenuItem, "SystemidentifikationToolStripMenuItem")
        '
        'PasswortgeneratorToolStripMenuItem
        '
        Me.PasswortgeneratorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.PasswortgeneratorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PasswortgeneratorToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.Password16
        Me.PasswortgeneratorToolStripMenuItem.Name = "PasswortgeneratorToolStripMenuItem"
        resources.ApplyResources(Me.PasswortgeneratorToolStripMenuItem, "PasswortgeneratorToolStripMenuItem")
        '
        'DateiSicherLöschenToolStripMenuItem
        '
        Me.DateiSicherLöschenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DateiSicherLöschenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateiSicherLöschenToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.Delete16
        Me.DateiSicherLöschenToolStripMenuItem.Name = "DateiSicherLöschenToolStripMenuItem"
        resources.ApplyResources(Me.DateiSicherLöschenToolStripMenuItem, "DateiSicherLöschenToolStripMenuItem")
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        resources.ApplyResources(Me.InfoToolStripMenuItem, "InfoToolStripMenuItem")
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.UpdateToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.UpdateToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.updateflat
        resources.ApplyResources(Me.UpdateToolStripMenuItem, "UpdateToolStripMenuItem")
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        '
        'FeedbackToolStripMenuItem
        '
        Me.FeedbackToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.FeedbackToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FeedbackToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.feedback16
        resources.ApplyResources(Me.FeedbackToolStripMenuItem, "FeedbackToolStripMenuItem")
        Me.FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AboutToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.Information16
        resources.ApplyResources(Me.AboutToolStripMenuItem, "AboutToolStripMenuItem")
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        '
        'systemtray
        '
        Me.systemtray.ContextMenuStrip = Me.systemtray_menu
        resources.ApplyResources(Me.systemtray, "systemtray")
        '
        'systemtray_menu
        '
        Me.systemtray_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.systemtray_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.about_bt_systemtray, Me.feedback_bt_systemtray, Me.update_bt_systemtray, Me.tools_bt_systemtray, Me.open_bt_systemtray, Me.exit_bt_systemtray})
        Me.systemtray_menu.Name = "ContextMenuStrip1"
        Me.systemtray_menu.ShowImageMargin = False
        resources.ApplyResources(Me.systemtray_menu, "systemtray_menu")
        '
        'about_bt_systemtray
        '
        Me.about_bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.about_bt_systemtray.Image = Global.Project_WinCrypt.My.Resources.Resources.Information16
        resources.ApplyResources(Me.about_bt_systemtray, "about_bt_systemtray")
        Me.about_bt_systemtray.Name = "about_bt_systemtray"
        '
        'feedback_bt_systemtray
        '
        Me.feedback_bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.feedback_bt_systemtray.Image = Global.Project_WinCrypt.My.Resources.Resources.feedback16
        resources.ApplyResources(Me.feedback_bt_systemtray, "feedback_bt_systemtray")
        Me.feedback_bt_systemtray.Name = "feedback_bt_systemtray"
        '
        'update_bt_systemtray
        '
        Me.update_bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.update_bt_systemtray.Image = Global.Project_WinCrypt.My.Resources.Resources.updateflat
        resources.ApplyResources(Me.update_bt_systemtray, "update_bt_systemtray")
        Me.update_bt_systemtray.Name = "update_bt_systemtray"
        '
        'tools_bt_systemtray
        '
        Me.tools_bt_systemtray.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.file_encrypt__bt_systemtray, Me.file_decrypt_bt_systemtray, Me.text_encrypt_bt_systemtray, Me.hash_bt_systemtray, Me.rsa_bt_systemtray, Me.mail_bt_systemtray, Me.pw_manager_bt_systemtray, Me.systemidentification_bt_systemtray, Me.pwg_bt_systemtray, Me.file_delete_bt_systemtray})
        Me.tools_bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        resources.ApplyResources(Me.tools_bt_systemtray, "tools_bt_systemtray")
        Me.tools_bt_systemtray.Name = "tools_bt_systemtray"
        '
        'file_encrypt__bt_systemtray
        '
        Me.file_encrypt__bt_systemtray.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.file_encrypt__bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.file_encrypt__bt_systemtray.Image = Global.Project_WinCrypt.My.Resources.Resources.Lock16
        Me.file_encrypt__bt_systemtray.Name = "file_encrypt__bt_systemtray"
        resources.ApplyResources(Me.file_encrypt__bt_systemtray, "file_encrypt__bt_systemtray")
        '
        'file_decrypt_bt_systemtray
        '
        Me.file_decrypt_bt_systemtray.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.file_decrypt_bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.file_decrypt_bt_systemtray.Image = Global.Project_WinCrypt.My.Resources.Resources.unlock16
        Me.file_decrypt_bt_systemtray.Name = "file_decrypt_bt_systemtray"
        resources.ApplyResources(Me.file_decrypt_bt_systemtray, "file_decrypt_bt_systemtray")
        '
        'text_encrypt_bt_systemtray
        '
        Me.text_encrypt_bt_systemtray.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.text_encrypt_bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.text_encrypt_bt_systemtray.Image = Global.Project_WinCrypt.My.Resources.Resources.textencrypt
        Me.text_encrypt_bt_systemtray.Name = "text_encrypt_bt_systemtray"
        resources.ApplyResources(Me.text_encrypt_bt_systemtray, "text_encrypt_bt_systemtray")
        '
        'hash_bt_systemtray
        '
        Me.hash_bt_systemtray.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.hash_bt_systemtray.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.converter_bt_systemtray, Me.bf_bt_systemtray, Me.file_checksum_systray})
        Me.hash_bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.hash_bt_systemtray.Name = "hash_bt_systemtray"
        resources.ApplyResources(Me.hash_bt_systemtray, "hash_bt_systemtray")
        '
        'converter_bt_systemtray
        '
        Me.converter_bt_systemtray.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.converter_bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.converter_bt_systemtray.Name = "converter_bt_systemtray"
        resources.ApplyResources(Me.converter_bt_systemtray, "converter_bt_systemtray")
        '
        'bf_bt_systemtray
        '
        Me.bf_bt_systemtray.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.bf_bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bf_bt_systemtray.Name = "bf_bt_systemtray"
        resources.ApplyResources(Me.bf_bt_systemtray, "bf_bt_systemtray")
        '
        'file_checksum_systray
        '
        Me.file_checksum_systray.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.file_checksum_systray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.file_checksum_systray.Name = "file_checksum_systray"
        resources.ApplyResources(Me.file_checksum_systray, "file_checksum_systray")
        '
        'rsa_bt_systemtray
        '
        Me.rsa_bt_systemtray.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.rsa_bt_systemtray.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rsa_encrypt_bt_systemtray, Me.rsa_decrypt_bt_systemtray, Me.rsa_create_keys_bt_systemtray})
        Me.rsa_bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rsa_bt_systemtray.Name = "rsa_bt_systemtray"
        resources.ApplyResources(Me.rsa_bt_systemtray, "rsa_bt_systemtray")
        '
        'rsa_encrypt_bt_systemtray
        '
        Me.rsa_encrypt_bt_systemtray.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.rsa_encrypt_bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rsa_encrypt_bt_systemtray.Image = Global.Project_WinCrypt.My.Resources.Resources.unlock16
        Me.rsa_encrypt_bt_systemtray.Name = "rsa_encrypt_bt_systemtray"
        resources.ApplyResources(Me.rsa_encrypt_bt_systemtray, "rsa_encrypt_bt_systemtray")
        '
        'rsa_decrypt_bt_systemtray
        '
        Me.rsa_decrypt_bt_systemtray.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.rsa_decrypt_bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rsa_decrypt_bt_systemtray.Image = Global.Project_WinCrypt.My.Resources.Resources.Lock16
        Me.rsa_decrypt_bt_systemtray.Name = "rsa_decrypt_bt_systemtray"
        resources.ApplyResources(Me.rsa_decrypt_bt_systemtray, "rsa_decrypt_bt_systemtray")
        '
        'rsa_create_keys_bt_systemtray
        '
        Me.rsa_create_keys_bt_systemtray.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.rsa_create_keys_bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rsa_create_keys_bt_systemtray.Image = Global.Project_WinCrypt.My.Resources.Resources.Key16
        Me.rsa_create_keys_bt_systemtray.Name = "rsa_create_keys_bt_systemtray"
        resources.ApplyResources(Me.rsa_create_keys_bt_systemtray, "rsa_create_keys_bt_systemtray")
        '
        'mail_bt_systemtray
        '
        Me.mail_bt_systemtray.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.mail_bt_systemtray.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.send_mail_bt_systemtray})
        Me.mail_bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mail_bt_systemtray.Name = "mail_bt_systemtray"
        resources.ApplyResources(Me.mail_bt_systemtray, "mail_bt_systemtray")
        '
        'send_mail_bt_systemtray
        '
        Me.send_mail_bt_systemtray.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.send_mail_bt_systemtray.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.send_mail_bt_systemtray.Image = Global.Project_WinCrypt.My.Resources.Resources.mail
        Me.send_mail_bt_systemtray.Name = "send_mail_bt_systemtray"
        resources.ApplyResources(Me.send_mail_bt_systemtray, "send_mail_bt_systemtray")
        '
        'pw_manager_bt_systemtray
        '
        Me.pw_manager_bt_systemtray.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pw_manager_bt_systemtray.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.export_db_bt_systemtray, Me.import_db_bt_systemtray, Me.delete_db_bt_systemtray})
        Me.pw_manager_bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pw_manager_bt_systemtray.Image = Global.Project_WinCrypt.My.Resources.Resources.pwmanager
        Me.pw_manager_bt_systemtray.Name = "pw_manager_bt_systemtray"
        resources.ApplyResources(Me.pw_manager_bt_systemtray, "pw_manager_bt_systemtray")
        '
        'export_db_bt_systemtray
        '
        Me.export_db_bt_systemtray.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.export_db_bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.export_db_bt_systemtray.Name = "export_db_bt_systemtray"
        resources.ApplyResources(Me.export_db_bt_systemtray, "export_db_bt_systemtray")
        '
        'import_db_bt_systemtray
        '
        Me.import_db_bt_systemtray.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.import_db_bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.import_db_bt_systemtray.Name = "import_db_bt_systemtray"
        resources.ApplyResources(Me.import_db_bt_systemtray, "import_db_bt_systemtray")
        '
        'delete_db_bt_systemtray
        '
        Me.delete_db_bt_systemtray.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.delete_db_bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.delete_db_bt_systemtray.Name = "delete_db_bt_systemtray"
        resources.ApplyResources(Me.delete_db_bt_systemtray, "delete_db_bt_systemtray")
        '
        'systemidentification_bt_systemtray
        '
        Me.systemidentification_bt_systemtray.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.systemidentification_bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.systemidentification_bt_systemtray.Image = Global.Project_WinCrypt.My.Resources.Resources.Identity
        Me.systemidentification_bt_systemtray.Name = "systemidentification_bt_systemtray"
        resources.ApplyResources(Me.systemidentification_bt_systemtray, "systemidentification_bt_systemtray")
        '
        'pwg_bt_systemtray
        '
        Me.pwg_bt_systemtray.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pwg_bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pwg_bt_systemtray.Image = Global.Project_WinCrypt.My.Resources.Resources.Password16
        Me.pwg_bt_systemtray.Name = "pwg_bt_systemtray"
        resources.ApplyResources(Me.pwg_bt_systemtray, "pwg_bt_systemtray")
        '
        'file_delete_bt_systemtray
        '
        Me.file_delete_bt_systemtray.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.file_delete_bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.file_delete_bt_systemtray.Image = Global.Project_WinCrypt.My.Resources.Resources.Delete16
        Me.file_delete_bt_systemtray.Name = "file_delete_bt_systemtray"
        resources.ApplyResources(Me.file_delete_bt_systemtray, "file_delete_bt_systemtray")
        '
        'open_bt_systemtray
        '
        Me.open_bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        resources.ApplyResources(Me.open_bt_systemtray, "open_bt_systemtray")
        Me.open_bt_systemtray.Name = "open_bt_systemtray"
        '
        'exit_bt_systemtray
        '
        Me.exit_bt_systemtray.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.exit_bt_systemtray.Image = Global.Project_WinCrypt.My.Resources.Resources.Close16
        resources.ApplyResources(Me.exit_bt_systemtray, "exit_bt_systemtray")
        Me.exit_bt_systemtray.Name = "exit_bt_systemtray"
        '
        'DateiVerschlüsselnToolStripMenuItem1
        '
        Me.DateiVerschlüsselnToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.Lock16
        Me.DateiVerschlüsselnToolStripMenuItem1.Name = "DateiVerschlüsselnToolStripMenuItem1"
        resources.ApplyResources(Me.DateiVerschlüsselnToolStripMenuItem1, "DateiVerschlüsselnToolStripMenuItem1")
        '
        'DateiEntschlüsselnToolStripMenuItem1
        '
        Me.DateiEntschlüsselnToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.unlock16
        Me.DateiEntschlüsselnToolStripMenuItem1.Name = "DateiEntschlüsselnToolStripMenuItem1"
        resources.ApplyResources(Me.DateiEntschlüsselnToolStripMenuItem1, "DateiEntschlüsselnToolStripMenuItem1")
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        resources.ApplyResources(Me.ToolStripSeparator5, "ToolStripSeparator5")
        '
        'TextVerUndEntschlüsselnToolStripMenuItem
        '
        Me.TextVerUndEntschlüsselnToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.textencrypt
        Me.TextVerUndEntschlüsselnToolStripMenuItem.Name = "TextVerUndEntschlüsselnToolStripMenuItem"
        resources.ApplyResources(Me.TextVerUndEntschlüsselnToolStripMenuItem, "TextVerUndEntschlüsselnToolStripMenuItem")
        '
        'MD5ToolStripMenuItem1
        '
        Me.MD5ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MD5KonverterToolStripMenuItem1, Me.MD5BruteforceToolStripMenuItem})
        Me.MD5ToolStripMenuItem1.Name = "MD5ToolStripMenuItem1"
        resources.ApplyResources(Me.MD5ToolStripMenuItem1, "MD5ToolStripMenuItem1")
        '
        'MD5KonverterToolStripMenuItem1
        '
        Me.MD5KonverterToolStripMenuItem1.Name = "MD5KonverterToolStripMenuItem1"
        resources.ApplyResources(Me.MD5KonverterToolStripMenuItem1, "MD5KonverterToolStripMenuItem1")
        '
        'MD5BruteforceToolStripMenuItem
        '
        Me.MD5BruteforceToolStripMenuItem.Name = "MD5BruteforceToolStripMenuItem"
        resources.ApplyResources(Me.MD5BruteforceToolStripMenuItem, "MD5BruteforceToolStripMenuItem")
        '
        'RSAToolStripMenuItem1
        '
        Me.RSAToolStripMenuItem1.Name = "RSAToolStripMenuItem1"
        resources.ApplyResources(Me.RSAToolStripMenuItem1, "RSAToolStripMenuItem1")
        '
        'VerschlüsselnToolStripMenuItem1
        '
        Me.VerschlüsselnToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.Lock16
        Me.VerschlüsselnToolStripMenuItem1.Name = "VerschlüsselnToolStripMenuItem1"
        resources.ApplyResources(Me.VerschlüsselnToolStripMenuItem1, "VerschlüsselnToolStripMenuItem1")
        '
        'EntschlüsselnToolStripMenuItem1
        '
        Me.EntschlüsselnToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.unlock16
        Me.EntschlüsselnToolStripMenuItem1.Name = "EntschlüsselnToolStripMenuItem1"
        resources.ApplyResources(Me.EntschlüsselnToolStripMenuItem1, "EntschlüsselnToolStripMenuItem1")
        '
        'SchlüsselErstellenToolStripMenuItem
        '
        Me.SchlüsselErstellenToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.Key16
        Me.SchlüsselErstellenToolStripMenuItem.Name = "SchlüsselErstellenToolStripMenuItem"
        resources.ApplyResources(Me.SchlüsselErstellenToolStripMenuItem, "SchlüsselErstellenToolStripMenuItem")
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        resources.ApplyResources(Me.ToolStripSeparator10, "ToolStripSeparator10")
        '
        'EMailToolStripMenuItem1
        '
        Me.EMailToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EMailSendenToolStripMenuItem1})
        Me.EMailToolStripMenuItem1.Name = "EMailToolStripMenuItem1"
        resources.ApplyResources(Me.EMailToolStripMenuItem1, "EMailToolStripMenuItem1")
        '
        'EMailSendenToolStripMenuItem1
        '
        Me.EMailSendenToolStripMenuItem1.Name = "EMailSendenToolStripMenuItem1"
        resources.ApplyResources(Me.EMailSendenToolStripMenuItem1, "EMailSendenToolStripMenuItem1")
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        resources.ApplyResources(Me.ToolStripSeparator12, "ToolStripSeparator12")
        '
        'PasswortmanagerToolStripMenuItem1
        '
        Me.PasswortmanagerToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatenbankExportierenToolStripMenuItem1, Me.DatenbankImportierenToolStripMenuItem1, Me.DatenbankLöschenToolStripMenuItem1})
        Me.PasswortmanagerToolStripMenuItem1.Name = "PasswortmanagerToolStripMenuItem1"
        resources.ApplyResources(Me.PasswortmanagerToolStripMenuItem1, "PasswortmanagerToolStripMenuItem1")
        '
        'DatenbankExportierenToolStripMenuItem1
        '
        Me.DatenbankExportierenToolStripMenuItem1.Name = "DatenbankExportierenToolStripMenuItem1"
        resources.ApplyResources(Me.DatenbankExportierenToolStripMenuItem1, "DatenbankExportierenToolStripMenuItem1")
        '
        'DatenbankImportierenToolStripMenuItem1
        '
        Me.DatenbankImportierenToolStripMenuItem1.Name = "DatenbankImportierenToolStripMenuItem1"
        resources.ApplyResources(Me.DatenbankImportierenToolStripMenuItem1, "DatenbankImportierenToolStripMenuItem1")
        '
        'DatenbankLöschenToolStripMenuItem1
        '
        Me.DatenbankLöschenToolStripMenuItem1.Name = "DatenbankLöschenToolStripMenuItem1"
        resources.ApplyResources(Me.DatenbankLöschenToolStripMenuItem1, "DatenbankLöschenToolStripMenuItem1")
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        resources.ApplyResources(Me.ToolStripSeparator6, "ToolStripSeparator6")
        '
        'SystemidentifikationToolStripMenuItem1
        '
        Me.SystemidentifikationToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.Identity
        Me.SystemidentifikationToolStripMenuItem1.Name = "SystemidentifikationToolStripMenuItem1"
        resources.ApplyResources(Me.SystemidentifikationToolStripMenuItem1, "SystemidentifikationToolStripMenuItem1")
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        resources.ApplyResources(Me.ToolStripSeparator7, "ToolStripSeparator7")
        '
        'PasswortGeneratorToolStripMenuItem1
        '
        Me.PasswortGeneratorToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.Password16
        Me.PasswortGeneratorToolStripMenuItem1.Name = "PasswortGeneratorToolStripMenuItem1"
        resources.ApplyResources(Me.PasswortGeneratorToolStripMenuItem1, "PasswortGeneratorToolStripMenuItem1")
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        resources.ApplyResources(Me.ToolStripSeparator8, "ToolStripSeparator8")
        '
        'DateienSicherLöschenToolStripMenuItem
        '
        Me.DateienSicherLöschenToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.Delete16
        Me.DateienSicherLöschenToolStripMenuItem.Name = "DateienSicherLöschenToolStripMenuItem"
        resources.ApplyResources(Me.DateienSicherLöschenToolStripMenuItem, "DateienSicherLöschenToolStripMenuItem")
        '
        'import_db_dialog
        '
        resources.ApplyResources(Me.import_db_dialog, "import_db_dialog")
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
        resources.ApplyResources(Me.mount_gb, "mount_gb")
        Me.mount_gb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mount_gb.Name = "mount_gb"
        Me.mount_gb.TabStop = False
        '
        'cleanlb2
        '
        resources.ApplyResources(Me.cleanlb2, "cleanlb2")
        Me.cleanlb2.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cleanlb2.FlatAppearance.BorderSize = 0
        Me.cleanlb2.Image = Global.Project_WinCrypt.My.Resources.Resources.Clean_16
        Me.cleanlb2.Name = "cleanlb2"
        Me.cleanlb2.UseVisualStyleBackColor = False
        '
        'drive_lb
        '
        resources.ApplyResources(Me.drive_lb, "drive_lb")
        Me.drive_lb.Name = "drive_lb"
        '
        'key_lb
        '
        resources.ApplyResources(Me.key_lb, "key_lb")
        Me.key_lb.Name = "key_lb"
        '
        'file_lb
        '
        resources.ApplyResources(Me.file_lb, "file_lb")
        Me.file_lb.Name = "file_lb"
        '
        'decrypt_list_status
        '
        Me.decrypt_list_status.AllowDrop = True
        resources.ApplyResources(Me.decrypt_list_status, "decrypt_list_status")
        Me.decrypt_list_status.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.decrypt_list_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.decrypt_list_status.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.decrypt_list_status.FormattingEnabled = True
        Me.decrypt_list_status.Name = "decrypt_list_status"
        '
        'drivecb
        '
        resources.ApplyResources(Me.drivecb, "drivecb")
        Me.drivecb.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.drivecb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.drivecb.FormattingEnabled = True
        Me.drivecb.Items.AddRange(New Object() {resources.GetString("drivecb.Items"), resources.GetString("drivecb.Items1"), resources.GetString("drivecb.Items2"), resources.GetString("drivecb.Items3"), resources.GetString("drivecb.Items4"), resources.GetString("drivecb.Items5"), resources.GetString("drivecb.Items6"), resources.GetString("drivecb.Items7"), resources.GetString("drivecb.Items8"), resources.GetString("drivecb.Items9"), resources.GetString("drivecb.Items10"), resources.GetString("drivecb.Items11"), resources.GetString("drivecb.Items12"), resources.GetString("drivecb.Items13"), resources.GetString("drivecb.Items14"), resources.GetString("drivecb.Items15"), resources.GetString("drivecb.Items16"), resources.GetString("drivecb.Items17"), resources.GetString("drivecb.Items18"), resources.GetString("drivecb.Items19"), resources.GetString("drivecb.Items20"), resources.GetString("drivecb.Items21"), resources.GetString("drivecb.Items22"), resources.GetString("drivecb.Items23"), resources.GetString("drivecb.Items24"), resources.GetString("drivecb.Items25")})
        Me.drivecb.Name = "drivecb"
        '
        'keyencrypt
        '
        resources.ApplyResources(Me.keyencrypt, "keyencrypt")
        Me.keyencrypt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.keyencrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.keyencrypt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.keyencrypt.Name = "keyencrypt"
        '
        'decrypt_filepath
        '
        resources.ApplyResources(Me.decrypt_filepath, "decrypt_filepath")
        Me.decrypt_filepath.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.decrypt_filepath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.decrypt_filepath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.decrypt_filepath.Name = "decrypt_filepath"
        '
        'dismount
        '
        resources.ApplyResources(Me.dismount, "dismount")
        Me.dismount.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dismount.FlatAppearance.BorderSize = 0
        Me.dismount.Name = "dismount"
        Me.dismount.UseVisualStyleBackColor = False
        '
        'mount
        '
        resources.ApplyResources(Me.mount, "mount")
        Me.mount.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mount.FlatAppearance.BorderSize = 0
        Me.mount.Name = "mount"
        Me.mount.UseVisualStyleBackColor = False
        '
        'opencryptfile
        '
        resources.ApplyResources(Me.opencryptfile, "opencryptfile")
        Me.opencryptfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.opencryptfile.FlatAppearance.BorderSize = 0
        Me.opencryptfile.ForeColor = System.Drawing.Color.White
        Me.opencryptfile.Name = "opencryptfile"
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
        resources.ApplyResources(Me.encrypt_gb, "encrypt_gb")
        Me.encrypt_gb.Name = "encrypt_gb"
        Me.encrypt_gb.TabStop = False
        '
        'cleanlb1
        '
        resources.ApplyResources(Me.cleanlb1, "cleanlb1")
        Me.cleanlb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cleanlb1.FlatAppearance.BorderSize = 0
        Me.cleanlb1.Image = Global.Project_WinCrypt.My.Resources.Resources.Clean_16
        Me.cleanlb1.Name = "cleanlb1"
        Me.cleanlb1.UseVisualStyleBackColor = False
        '
        'encrypt_list_status
        '
        Me.encrypt_list_status.AllowDrop = True
        resources.ApplyResources(Me.encrypt_list_status, "encrypt_list_status")
        Me.encrypt_list_status.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.encrypt_list_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.encrypt_list_status.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.encrypt_list_status.FormattingEnabled = True
        Me.encrypt_list_status.Name = "encrypt_list_status"
        '
        'key_lb1
        '
        resources.ApplyResources(Me.key_lb1, "key_lb1")
        Me.key_lb1.Name = "key_lb1"
        '
        'create_container_encrypt
        '
        resources.ApplyResources(Me.create_container_encrypt, "create_container_encrypt")
        Me.create_container_encrypt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.create_container_encrypt.FlatAppearance.BorderSize = 0
        Me.create_container_encrypt.Name = "create_container_encrypt"
        Me.create_container_encrypt.UseVisualStyleBackColor = False
        '
        'path_encrypt
        '
        resources.ApplyResources(Me.path_encrypt, "path_encrypt")
        Me.path_encrypt.Name = "path_encrypt"
        '
        'generate_key_encrypt
        '
        resources.ApplyResources(Me.generate_key_encrypt, "generate_key_encrypt")
        Me.generate_key_encrypt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.generate_key_encrypt.FlatAppearance.BorderSize = 0
        Me.generate_key_encrypt.Name = "generate_key_encrypt"
        Me.generate_key_encrypt.UseVisualStyleBackColor = False
        '
        'crypt_file_pathbutton
        '
        resources.ApplyResources(Me.crypt_file_pathbutton, "crypt_file_pathbutton")
        Me.crypt_file_pathbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.crypt_file_pathbutton.FlatAppearance.BorderSize = 0
        Me.crypt_file_pathbutton.Name = "crypt_file_pathbutton"
        Me.crypt_file_pathbutton.UseVisualStyleBackColor = False
        '
        'keycrypt
        '
        resources.ApplyResources(Me.keycrypt, "keycrypt")
        Me.keycrypt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.keycrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.keycrypt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.keycrypt.Name = "keycrypt"
        '
        'pathtxt
        '
        resources.ApplyResources(Me.pathtxt, "pathtxt")
        Me.pathtxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pathtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pathtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pathtxt.Name = "pathtxt"
        '
        'wincrypt_icon
        '
        Me.wincrypt_icon.BackColor = System.Drawing.Color.Transparent
        Me.wincrypt_icon.Image = Global.Project_WinCrypt.My.Resources.Resources.wc_icon16
        resources.ApplyResources(Me.wincrypt_icon, "wincrypt_icon")
        Me.wincrypt_icon.Name = "wincrypt_icon"
        Me.wincrypt_icon.TabStop = False
        '
        'XToolStripMenuItem
        '
        resources.ApplyResources(Me.XToolStripMenuItem, "XToolStripMenuItem")
        Me.XToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.XToolStripMenuItem.Name = "XToolStripMenuItem"
        '
        'ToolStripMenuItem1
        '
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        '
        'wincrypttitle
        '
        resources.ApplyResources(Me.wincrypttitle, "wincrypttitle")
        Me.wincrypttitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.wincrypttitle.Name = "wincrypttitle"
        '
        'form_head
        '
        Me.form_head.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.form_head.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exit_bt, Me.minimize_bt})
        resources.ApplyResources(Me.form_head, "form_head")
        Me.form_head.Name = "form_head"
        '
        'exit_bt
        '
        resources.ApplyResources(Me.exit_bt, "exit_bt")
        Me.exit_bt.ForeColor = System.Drawing.Color.White
        Me.exit_bt.Name = "exit_bt"
        '
        'minimize_bt
        '
        resources.ApplyResources(Me.minimize_bt, "minimize_bt")
        Me.minimize_bt.ForeColor = System.Drawing.Color.White
        Me.minimize_bt.Name = "minimize_bt"
        '
        'XToolStripMenuItem1
        '
        resources.ApplyResources(Me.XToolStripMenuItem1, "XToolStripMenuItem1")
        Me.XToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.XToolStripMenuItem1.Name = "XToolStripMenuItem1"
        '
        'ToolStripMenuItem2
        '
        resources.ApplyResources(Me.ToolStripMenuItem2, "ToolStripMenuItem2")
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        '
        'gethotkey
        '
        Me.gethotkey.Enabled = True
        Me.gethotkey.Interval = 10
        '
        'export_db_dialog
        '
        Me.export_db_dialog.FileName = "export.db"
        resources.ApplyResources(Me.export_db_dialog, "export_db_dialog")
        '
        'Startwindow
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Controls.Add(Me.wincrypt_icon)
        Me.Controls.Add(Me.wincrypttitle)
        Me.Controls.Add(Me.mount_gb)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.encrypt_gb)
        Me.Controls.Add(Me.form_head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "Startwindow"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.systemtray_menu.ResumeLayout(False)
        Me.mount_gb.ResumeLayout(False)
        Me.mount_gb.PerformLayout()
        Me.encrypt_gb.ResumeLayout(False)
        Me.encrypt_gb.PerformLayout()
        CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.form_head.ResumeLayout(False)
        Me.form_head.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents folder_dialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents encrypttimer As System.Windows.Forms.Timer
    Friend WithEvents encryptmounttimer As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
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
    Friend WithEvents systemtray As System.Windows.Forms.NotifyIcon
    Friend WithEvents systemtray_menu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents exit_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents open_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tools_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents about_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents update_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents import_db_dialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DatenbankExportierenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatenbankImportierenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatenbankLöschenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents feedback_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents form_head As System.Windows.Forms.MenuStrip
    Friend WithEvents XToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents exit_bt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents minimize_bt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents file_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents setting_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents exit_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tools_bt_menu As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents file_encrypt__bt_systemtray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents file_decrypt_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents text_encrypt_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents hash_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents converter_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bf_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rsa_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rsa_encrypt_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rsa_decrypt_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rsa_create_keys_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mail_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents send_mail_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pw_manager_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents export_db_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents import_db_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents delete_db_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents systemidentification_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pwg_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents file_delete_bt_systemtray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cleanlb1 As System.Windows.Forms.Button
    Friend WithEvents cleanlb2 As System.Windows.Forms.Button
    Friend WithEvents gethotkey As System.Windows.Forms.Timer
    Friend WithEvents export_db_dialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents open_encrypt_dialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents file_checksum_systray As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EncryptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rsa_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rsa_encrypt_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rsa_decrypt_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rsa_create_keys_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents hash_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents md5_converter_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents md5_bf_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MD5DateiChecksumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents text_encrypt_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileEncryptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents file_encrypt_bt_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents file_decrypt_bt_menu As System.Windows.Forms.ToolStripMenuItem

End Class
