<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class startwindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(startwindow))
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.encrypttimer = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.encryptmounttimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateiVerschlüsselnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateiEntschlüsselnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TextVerschlüsselnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MD5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MD5KonverterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MD5CrackerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RSAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntschlüsselnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerschlüsselnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeyErstellenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EMailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMailSendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.PasswortmanagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenbankExportierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenbankImportierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenbankLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.SystemidentifikationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.PasswortgeneratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.DateiSicherLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.systemtray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedbackToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.mount_gb = New System.Windows.Forms.GroupBox()
        Me.opencryptfile = New System.Windows.Forms.Button()
        Me.mount = New System.Windows.Forms.Button()
        Me.dismount = New System.Windows.Forms.Button()
        Me.decrypt_filepath = New System.Windows.Forms.TextBox()
        Me.keyencrypt = New System.Windows.Forms.TextBox()
        Me.drivecb = New System.Windows.Forms.ComboBox()
        Me.decrypt_list_status = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.key_lb = New System.Windows.Forms.Label()
        Me.drive_lb = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.encrypt_gb = New System.Windows.Forms.GroupBox()
        Me.pathtxt = New System.Windows.Forms.TextBox()
        Me.keycrypt = New System.Windows.Forms.TextBox()
        Me.crypt_file_pathbutton = New System.Windows.Forms.Button()
        Me.generate_key_encrypt = New System.Windows.Forms.Button()
        Me.path_encrypt = New System.Windows.Forms.Label()
        Me.create_container_encrypt = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.encrypt_list_status = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.mount_gb.SuspendLayout()
        Me.encrypt_gb.SuspendLayout()
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
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(598, 24)
        Me.MenuStrip.TabIndex = 11
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EinstellungToolStripMenuItem, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'EinstellungToolStripMenuItem
        '
        Me.EinstellungToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.cog
        Me.EinstellungToolStripMenuItem.Name = "EinstellungToolStripMenuItem"
        Me.EinstellungToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.EinstellungToolStripMenuItem.Text = "Einstellung"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.closebox
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiVerschlüsselnToolStripMenuItem, Me.DateiEntschlüsselnToolStripMenuItem, Me.ToolStripSeparator1, Me.TextVerschlüsselnToolStripMenuItem, Me.MD5ToolStripMenuItem, Me.RSAToolStripMenuItem, Me.ToolStripSeparator2, Me.EMailToolStripMenuItem, Me.ToolStripSeparator11, Me.PasswortmanagerToolStripMenuItem, Me.ToolStripSeparator9, Me.SystemidentifikationToolStripMenuItem, Me.ToolStripSeparator3, Me.PasswortgeneratorToolStripMenuItem, Me.ToolStripSeparator4, Me.DateiSicherLöschenToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'DateiVerschlüsselnToolStripMenuItem
        '
        Me.DateiVerschlüsselnToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.lock
        Me.DateiVerschlüsselnToolStripMenuItem.Name = "DateiVerschlüsselnToolStripMenuItem"
        Me.DateiVerschlüsselnToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.DateiVerschlüsselnToolStripMenuItem.Text = "Datei verschlüsseln"
        '
        'DateiEntschlüsselnToolStripMenuItem
        '
        Me.DateiEntschlüsselnToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.unlock
        Me.DateiEntschlüsselnToolStripMenuItem.Name = "DateiEntschlüsselnToolStripMenuItem"
        Me.DateiEntschlüsselnToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.DateiEntschlüsselnToolStripMenuItem.Text = "Datei entschlüsseln"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(214, 6)
        '
        'TextVerschlüsselnToolStripMenuItem
        '
        Me.TextVerschlüsselnToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.document
        Me.TextVerschlüsselnToolStripMenuItem.Name = "TextVerschlüsselnToolStripMenuItem"
        Me.TextVerschlüsselnToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.TextVerschlüsselnToolStripMenuItem.Text = "Text ver- und entschlüsseln"
        '
        'MD5ToolStripMenuItem
        '
        Me.MD5ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MD5KonverterToolStripMenuItem, Me.MD5CrackerToolStripMenuItem})
        Me.MD5ToolStripMenuItem.Name = "MD5ToolStripMenuItem"
        Me.MD5ToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.MD5ToolStripMenuItem.Text = "Hash"
        '
        'MD5KonverterToolStripMenuItem
        '
        Me.MD5KonverterToolStripMenuItem.Name = "MD5KonverterToolStripMenuItem"
        Me.MD5KonverterToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.MD5KonverterToolStripMenuItem.Text = "Hash Konverter"
        '
        'MD5CrackerToolStripMenuItem
        '
        Me.MD5CrackerToolStripMenuItem.Name = "MD5CrackerToolStripMenuItem"
        Me.MD5CrackerToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.MD5CrackerToolStripMenuItem.Text = "Hash Brute-force"
        '
        'RSAToolStripMenuItem
        '
        Me.RSAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntschlüsselnToolStripMenuItem, Me.VerschlüsselnToolStripMenuItem, Me.KeyErstellenToolStripMenuItem})
        Me.RSAToolStripMenuItem.Name = "RSAToolStripMenuItem"
        Me.RSAToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.RSAToolStripMenuItem.Text = "RSA"
        '
        'EntschlüsselnToolStripMenuItem
        '
        Me.EntschlüsselnToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.unlock
        Me.EntschlüsselnToolStripMenuItem.Name = "EntschlüsselnToolStripMenuItem"
        Me.EntschlüsselnToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.EntschlüsselnToolStripMenuItem.Text = "Entschlüsseln"
        '
        'VerschlüsselnToolStripMenuItem
        '
        Me.VerschlüsselnToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.lock
        Me.VerschlüsselnToolStripMenuItem.Name = "VerschlüsselnToolStripMenuItem"
        Me.VerschlüsselnToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.VerschlüsselnToolStripMenuItem.Text = "Verschlüsseln"
        '
        'KeyErstellenToolStripMenuItem
        '
        Me.KeyErstellenToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.keyarrow
        Me.KeyErstellenToolStripMenuItem.Name = "KeyErstellenToolStripMenuItem"
        Me.KeyErstellenToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.KeyErstellenToolStripMenuItem.Text = "Schlüssel erstellen"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(214, 6)
        '
        'EMailToolStripMenuItem
        '
        Me.EMailToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EMailSendenToolStripMenuItem})
        Me.EMailToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.mailmessagenew
        Me.EMailToolStripMenuItem.Name = "EMailToolStripMenuItem"
        Me.EMailToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.EMailToolStripMenuItem.Text = "E-Mail"
        '
        'EMailSendenToolStripMenuItem
        '
        Me.EMailSendenToolStripMenuItem.Name = "EMailSendenToolStripMenuItem"
        Me.EMailSendenToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.EMailSendenToolStripMenuItem.Text = "E-Mail Senden"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(214, 6)
        '
        'PasswortmanagerToolStripMenuItem
        '
        Me.PasswortmanagerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatenbankExportierenToolStripMenuItem, Me.DatenbankImportierenToolStripMenuItem, Me.DatenbankLöschenToolStripMenuItem})
        Me.PasswortmanagerToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.systemfilemanager
        Me.PasswortmanagerToolStripMenuItem.Name = "PasswortmanagerToolStripMenuItem"
        Me.PasswortmanagerToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.PasswortmanagerToolStripMenuItem.Text = "Passwortmanager"
        '
        'DatenbankExportierenToolStripMenuItem
        '
        Me.DatenbankExportierenToolStripMenuItem.Name = "DatenbankExportierenToolStripMenuItem"
        Me.DatenbankExportierenToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.DatenbankExportierenToolStripMenuItem.Text = "Datenbank exportieren"
        '
        'DatenbankImportierenToolStripMenuItem
        '
        Me.DatenbankImportierenToolStripMenuItem.Name = "DatenbankImportierenToolStripMenuItem"
        Me.DatenbankImportierenToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.DatenbankImportierenToolStripMenuItem.Text = "Datenbank importieren"
        '
        'DatenbankLöschenToolStripMenuItem
        '
        Me.DatenbankLöschenToolStripMenuItem.Name = "DatenbankLöschenToolStripMenuItem"
        Me.DatenbankLöschenToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.DatenbankLöschenToolStripMenuItem.Text = "Datenbank löschen"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(214, 6)
        '
        'SystemidentifikationToolStripMenuItem
        '
        Me.SystemidentifikationToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.id
        Me.SystemidentifikationToolStripMenuItem.Name = "SystemidentifikationToolStripMenuItem"
        Me.SystemidentifikationToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.SystemidentifikationToolStripMenuItem.Text = "Systemidentifikation"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(214, 6)
        '
        'PasswortgeneratorToolStripMenuItem
        '
        Me.PasswortgeneratorToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.password
        Me.PasswortgeneratorToolStripMenuItem.Name = "PasswortgeneratorToolStripMenuItem"
        Me.PasswortgeneratorToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.PasswortgeneratorToolStripMenuItem.Text = "Passwortgenerator"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(214, 6)
        '
        'DateiSicherLöschenToolStripMenuItem
        '
        Me.DateiSicherLöschenToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.cross
        Me.DateiSicherLöschenToolStripMenuItem.Name = "DateiSicherLöschenToolStripMenuItem"
        Me.DateiSicherLöschenToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.DateiSicherLöschenToolStripMenuItem.Text = "Dateien sicher löschen"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.FeedbackToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.update
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'FeedbackToolStripMenuItem
        '
        Me.FeedbackToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.feedback
        Me.FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
        Me.FeedbackToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.FeedbackToolStripMenuItem.Text = "Feedback"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.information
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'systemtray
        '
        Me.systemtray.ContextMenuStrip = Me.ContextMenuStrip1
        Me.systemtray.Icon = CType(resources.GetObject("systemtray.Icon"), System.Drawing.Icon)
        Me.systemtray.Text = "WinCrypt"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1, Me.FeedbackToolStripMenuItem1, Me.UpdateToolStripMenuItem1, Me.ToolsToolStripMenuItem1, Me.ÖffnenToolStripMenuItem, Me.BeendenToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(125, 136)
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.information
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'FeedbackToolStripMenuItem1
        '
        Me.FeedbackToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.feedback
        Me.FeedbackToolStripMenuItem1.Name = "FeedbackToolStripMenuItem1"
        Me.FeedbackToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.FeedbackToolStripMenuItem1.Text = "Feedback"
        '
        'UpdateToolStripMenuItem1
        '
        Me.UpdateToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.update
        Me.UpdateToolStripMenuItem1.Name = "UpdateToolStripMenuItem1"
        Me.UpdateToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.UpdateToolStripMenuItem1.Text = "Update"
        '
        'ToolsToolStripMenuItem1
        '
        Me.ToolsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiVerschlüsselnToolStripMenuItem1, Me.DateiEntschlüsselnToolStripMenuItem1, Me.ToolStripSeparator5, Me.TextVerUndEntschlüsselnToolStripMenuItem, Me.MD5ToolStripMenuItem1, Me.RSAToolStripMenuItem1, Me.ToolStripSeparator10, Me.EMailToolStripMenuItem1, Me.ToolStripSeparator12, Me.PasswortmanagerToolStripMenuItem1, Me.ToolStripSeparator6, Me.SystemidentifikationToolStripMenuItem1, Me.ToolStripSeparator7, Me.PasswortGeneratorToolStripMenuItem1, Me.ToolStripSeparator8, Me.DateienSicherLöschenToolStripMenuItem})
        Me.ToolsToolStripMenuItem1.Name = "ToolsToolStripMenuItem1"
        Me.ToolsToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.ToolsToolStripMenuItem1.Text = "Tools"
        '
        'DateiVerschlüsselnToolStripMenuItem1
        '
        Me.DateiVerschlüsselnToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.lock
        Me.DateiVerschlüsselnToolStripMenuItem1.Name = "DateiVerschlüsselnToolStripMenuItem1"
        Me.DateiVerschlüsselnToolStripMenuItem1.Size = New System.Drawing.Size(217, 22)
        Me.DateiVerschlüsselnToolStripMenuItem1.Text = "Datei verschlüsseln"
        '
        'DateiEntschlüsselnToolStripMenuItem1
        '
        Me.DateiEntschlüsselnToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.unlock
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
        Me.TextVerUndEntschlüsselnToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.document
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
        Me.RSAToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerschlüsselnToolStripMenuItem1, Me.EntschlüsselnToolStripMenuItem1, Me.SchlüsselErstellenToolStripMenuItem})
        Me.RSAToolStripMenuItem1.Name = "RSAToolStripMenuItem1"
        Me.RSAToolStripMenuItem1.Size = New System.Drawing.Size(217, 22)
        Me.RSAToolStripMenuItem1.Text = "RSA"
        '
        'VerschlüsselnToolStripMenuItem1
        '
        Me.VerschlüsselnToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.lock
        Me.VerschlüsselnToolStripMenuItem1.Name = "VerschlüsselnToolStripMenuItem1"
        Me.VerschlüsselnToolStripMenuItem1.Size = New System.Drawing.Size(169, 22)
        Me.VerschlüsselnToolStripMenuItem1.Text = "Verschlüsseln"
        '
        'EntschlüsselnToolStripMenuItem1
        '
        Me.EntschlüsselnToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.unlock
        Me.EntschlüsselnToolStripMenuItem1.Name = "EntschlüsselnToolStripMenuItem1"
        Me.EntschlüsselnToolStripMenuItem1.Size = New System.Drawing.Size(169, 22)
        Me.EntschlüsselnToolStripMenuItem1.Text = "Entschlüsseln"
        '
        'SchlüsselErstellenToolStripMenuItem
        '
        Me.SchlüsselErstellenToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.keyarrow
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
        Me.EMailToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.mailmessagenew
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
        Me.PasswortmanagerToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.systemfilemanager
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
        Me.SystemidentifikationToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.id
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
        Me.PasswortGeneratorToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.password
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
        Me.DateienSicherLöschenToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.cross
        Me.DateienSicherLöschenToolStripMenuItem.Name = "DateienSicherLöschenToolStripMenuItem"
        Me.DateienSicherLöschenToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.DateienSicherLöschenToolStripMenuItem.Text = "Dateien sicher löschen"
        '
        'ÖffnenToolStripMenuItem
        '
        Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
        Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.ÖffnenToolStripMenuItem.Text = "Öffnen"
        '
        'BeendenToolStripMenuItem1
        '
        Me.BeendenToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.closebox
        Me.BeendenToolStripMenuItem1.Name = "BeendenToolStripMenuItem1"
        Me.BeendenToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.BeendenToolStripMenuItem1.Text = "Beenden"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "export"
        Me.SaveFileDialog1.Filter = "DB-Datei|*.db"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.Filter = "DB-Datei|*.db"
        '
        'mount_gb
        '
        Me.mount_gb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mount_gb.Controls.Add(Me.Label6)
        Me.mount_gb.Controls.Add(Me.drive_lb)
        Me.mount_gb.Controls.Add(Me.key_lb)
        Me.mount_gb.Controls.Add(Me.Label3)
        Me.mount_gb.Controls.Add(Me.decrypt_list_status)
        Me.mount_gb.Controls.Add(Me.drivecb)
        Me.mount_gb.Controls.Add(Me.keyencrypt)
        Me.mount_gb.Controls.Add(Me.decrypt_filepath)
        Me.mount_gb.Controls.Add(Me.dismount)
        Me.mount_gb.Controls.Add(Me.mount)
        Me.mount_gb.Controls.Add(Me.opencryptfile)
        Me.mount_gb.Location = New System.Drawing.Point(13, 318)
        Me.mount_gb.Name = "mount_gb"
        Me.mount_gb.Size = New System.Drawing.Size(573, 288)
        Me.mount_gb.TabIndex = 9
        Me.mount_gb.TabStop = False
        Me.mount_gb.Text = "Cryptdatei Mounten"
        '
        'opencryptfile
        '
        Me.opencryptfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opencryptfile.BackColor = System.Drawing.Color.Gainsboro
        Me.opencryptfile.FlatAppearance.BorderSize = 0
        Me.opencryptfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opencryptfile.Location = New System.Drawing.Point(492, 48)
        Me.opencryptfile.Name = "opencryptfile"
        Me.opencryptfile.Size = New System.Drawing.Size(75, 23)
        Me.opencryptfile.TabIndex = 0
        Me.opencryptfile.Text = "Öffnen"
        Me.opencryptfile.UseVisualStyleBackColor = False
        '
        'mount
        '
        Me.mount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mount.BackColor = System.Drawing.Color.Gainsboro
        Me.mount.Enabled = False
        Me.mount.FlatAppearance.BorderSize = 0
        Me.mount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mount.Location = New System.Drawing.Point(411, 244)
        Me.mount.Name = "mount"
        Me.mount.Size = New System.Drawing.Size(75, 23)
        Me.mount.TabIndex = 1
        Me.mount.Text = "Mount"
        Me.mount.UseVisualStyleBackColor = False
        '
        'dismount
        '
        Me.dismount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dismount.BackColor = System.Drawing.Color.Gainsboro
        Me.dismount.Enabled = False
        Me.dismount.FlatAppearance.BorderSize = 0
        Me.dismount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dismount.Location = New System.Drawing.Point(492, 244)
        Me.dismount.Name = "dismount"
        Me.dismount.Size = New System.Drawing.Size(75, 23)
        Me.dismount.TabIndex = 2
        Me.dismount.Text = "Dismount"
        Me.dismount.UseVisualStyleBackColor = False
        '
        'decrypt_filepath
        '
        Me.decrypt_filepath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.decrypt_filepath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.decrypt_filepath.Location = New System.Drawing.Point(16, 50)
        Me.decrypt_filepath.Name = "decrypt_filepath"
        Me.decrypt_filepath.Size = New System.Drawing.Size(471, 20)
        Me.decrypt_filepath.TabIndex = 3
        '
        'keyencrypt
        '
        Me.keyencrypt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.keyencrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.keyencrypt.Enabled = False
        Me.keyencrypt.Location = New System.Drawing.Point(16, 246)
        Me.keyencrypt.Name = "keyencrypt"
        Me.keyencrypt.Size = New System.Drawing.Size(261, 20)
        Me.keyencrypt.TabIndex = 4
        Me.keyencrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'drivecb
        '
        Me.drivecb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.drivecb.FormattingEnabled = True
        Me.drivecb.Items.AddRange(New Object() {"A:\", "B:\", "C:\", "D:\", "E:\", "F:\", "G:\", "H:\", "I:\", "J:\", "K:\", "L:\", "M:\", "N:\", "O:\", "P:\", "Q:\", "R:\", "S:\", "T:\", "U:\", "V:\", "W:\", "X:\", "Y:\", "Z:\"})
        Me.drivecb.Location = New System.Drawing.Point(353, 246)
        Me.drivecb.Name = "drivecb"
        Me.drivecb.Size = New System.Drawing.Size(46, 21)
        Me.drivecb.TabIndex = 5
        Me.drivecb.Text = "T:\"
        '
        'decrypt_list_status
        '
        Me.decrypt_list_status.AllowDrop = True
        Me.decrypt_list_status.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.decrypt_list_status.BackColor = System.Drawing.Color.Gray
        Me.decrypt_list_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.decrypt_list_status.ForeColor = System.Drawing.Color.Lime
        Me.decrypt_list_status.FormattingEnabled = True
        Me.decrypt_list_status.Location = New System.Drawing.Point(16, 76)
        Me.decrypt_list_status.Name = "decrypt_list_status"
        Me.decrypt_list_status.Size = New System.Drawing.Size(552, 145)
        Me.decrypt_list_status.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Datei:"
        '
        'key_lb
        '
        Me.key_lb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.key_lb.AutoSize = True
        Me.key_lb.Location = New System.Drawing.Point(13, 230)
        Me.key_lb.Name = "key_lb"
        Me.key_lb.Size = New System.Drawing.Size(55, 13)
        Me.key_lb.TabIndex = 8
        Me.key_lb.Text = "Schlüssel:"
        '
        'drive_lb
        '
        Me.drive_lb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.drive_lb.AutoSize = True
        Me.drive_lb.Location = New System.Drawing.Point(293, 249)
        Me.drive_lb.Name = "drive_lb"
        Me.drive_lb.Size = New System.Drawing.Size(54, 13)
        Me.drive_lb.TabIndex = 9
        Me.drive_lb.Text = "Laufwerk:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Gray
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(252, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Drag&Drop"
        '
        'encrypt_gb
        '
        Me.encrypt_gb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.encrypt_gb.Controls.Add(Me.Label7)
        Me.encrypt_gb.Controls.Add(Me.encrypt_list_status)
        Me.encrypt_gb.Controls.Add(Me.Label2)
        Me.encrypt_gb.Controls.Add(Me.create_container_encrypt)
        Me.encrypt_gb.Controls.Add(Me.path_encrypt)
        Me.encrypt_gb.Controls.Add(Me.generate_key_encrypt)
        Me.encrypt_gb.Controls.Add(Me.crypt_file_pathbutton)
        Me.encrypt_gb.Controls.Add(Me.keycrypt)
        Me.encrypt_gb.Controls.Add(Me.pathtxt)
        Me.encrypt_gb.Location = New System.Drawing.Point(13, 27)
        Me.encrypt_gb.Name = "encrypt_gb"
        Me.encrypt_gb.Size = New System.Drawing.Size(573, 285)
        Me.encrypt_gb.TabIndex = 8
        Me.encrypt_gb.TabStop = False
        Me.encrypt_gb.Text = "Ordner/Laufwerk Verschlüsseln"
        '
        'pathtxt
        '
        Me.pathtxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pathtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pathtxt.Location = New System.Drawing.Point(16, 33)
        Me.pathtxt.Name = "pathtxt"
        Me.pathtxt.Size = New System.Drawing.Size(471, 20)
        Me.pathtxt.TabIndex = 3
        '
        'keycrypt
        '
        Me.keycrypt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.keycrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.keycrypt.Location = New System.Drawing.Point(16, 92)
        Me.keycrypt.Name = "keycrypt"
        Me.keycrypt.Size = New System.Drawing.Size(351, 20)
        Me.keycrypt.TabIndex = 4
        Me.keycrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'crypt_file_pathbutton
        '
        Me.crypt_file_pathbutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crypt_file_pathbutton.BackColor = System.Drawing.Color.Gainsboro
        Me.crypt_file_pathbutton.FlatAppearance.BorderSize = 0
        Me.crypt_file_pathbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.crypt_file_pathbutton.Location = New System.Drawing.Point(492, 31)
        Me.crypt_file_pathbutton.Name = "crypt_file_pathbutton"
        Me.crypt_file_pathbutton.Size = New System.Drawing.Size(75, 23)
        Me.crypt_file_pathbutton.TabIndex = 2
        Me.crypt_file_pathbutton.Text = "Hinzufügen"
        Me.crypt_file_pathbutton.UseVisualStyleBackColor = False
        '
        'generate_key_encrypt
        '
        Me.generate_key_encrypt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.generate_key_encrypt.BackColor = System.Drawing.Color.Gainsboro
        Me.generate_key_encrypt.Enabled = False
        Me.generate_key_encrypt.FlatAppearance.BorderSize = 0
        Me.generate_key_encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.generate_key_encrypt.Location = New System.Drawing.Point(373, 90)
        Me.generate_key_encrypt.Name = "generate_key_encrypt"
        Me.generate_key_encrypt.Size = New System.Drawing.Size(75, 23)
        Me.generate_key_encrypt.TabIndex = 1
        Me.generate_key_encrypt.Text = "Generieren"
        Me.generate_key_encrypt.UseVisualStyleBackColor = False
        '
        'path_encrypt
        '
        Me.path_encrypt.AutoSize = True
        Me.path_encrypt.Location = New System.Drawing.Point(13, 17)
        Me.path_encrypt.Name = "path_encrypt"
        Me.path_encrypt.Size = New System.Drawing.Size(32, 13)
        Me.path_encrypt.TabIndex = 6
        Me.path_encrypt.Text = "Pfad:"
        '
        'create_container_encrypt
        '
        Me.create_container_encrypt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.create_container_encrypt.BackColor = System.Drawing.Color.Gainsboro
        Me.create_container_encrypt.Enabled = False
        Me.create_container_encrypt.FlatAppearance.BorderSize = 0
        Me.create_container_encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.create_container_encrypt.Location = New System.Drawing.Point(454, 90)
        Me.create_container_encrypt.Name = "create_container_encrypt"
        Me.create_container_encrypt.Size = New System.Drawing.Size(113, 23)
        Me.create_container_encrypt.TabIndex = 0
        Me.create_container_encrypt.Text = "Container erstellen"
        Me.create_container_encrypt.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Schlüssel:"
        '
        'encrypt_list_status
        '
        Me.encrypt_list_status.AllowDrop = True
        Me.encrypt_list_status.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.encrypt_list_status.BackColor = System.Drawing.Color.Gray
        Me.encrypt_list_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.encrypt_list_status.ForeColor = System.Drawing.Color.Lime
        Me.encrypt_list_status.FormattingEnabled = True
        Me.encrypt_list_status.Location = New System.Drawing.Point(16, 124)
        Me.encrypt_list_status.Name = "encrypt_list_status"
        Me.encrypt_list_status.Size = New System.Drawing.Size(551, 145)
        Me.encrypt_list_status.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Gray
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(253, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Drag&Drop"
        '
        'startwindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(598, 609)
        Me.Controls.Add(Me.mount_gb)
        Me.Controls.Add(Me.encrypt_gb)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "startwindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WinCrypt 1.2"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.mount_gb.ResumeLayout(False)
        Me.mount_gb.PerformLayout()
        Me.encrypt_gb.ResumeLayout(False)
        Me.encrypt_gb.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents encrypttimer As System.Windows.Forms.Timer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents encryptmounttimer As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateiVerschlüsselnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateiEntschlüsselnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TextVerschlüsselnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SystemidentifikationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PasswortgeneratorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EinstellungToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DateiSicherLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents systemtray As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BeendenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RSAToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerschlüsselnToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntschlüsselnToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SchlüsselErstellenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EMailToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EMailSendenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PasswortmanagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PasswortmanagerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatenbankExportierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatenbankImportierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatenbankLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DatenbankExportierenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatenbankImportierenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatenbankLöschenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mount_gb As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents drive_lb As System.Windows.Forms.Label
    Friend WithEvents key_lb As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents decrypt_list_status As System.Windows.Forms.ListBox
    Friend WithEvents drivecb As System.Windows.Forms.ComboBox
    Friend WithEvents keyencrypt As System.Windows.Forms.TextBox
    Friend WithEvents decrypt_filepath As System.Windows.Forms.TextBox
    Friend WithEvents dismount As System.Windows.Forms.Button
    Friend WithEvents mount As System.Windows.Forms.Button
    Friend WithEvents opencryptfile As System.Windows.Forms.Button
    Friend WithEvents encrypt_gb As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents encrypt_list_status As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents create_container_encrypt As System.Windows.Forms.Button
    Friend WithEvents path_encrypt As System.Windows.Forms.Label
    Friend WithEvents generate_key_encrypt As System.Windows.Forms.Button
    Friend WithEvents crypt_file_pathbutton As System.Windows.Forms.Button
    Friend WithEvents keycrypt As System.Windows.Forms.TextBox
    Friend WithEvents pathtxt As System.Windows.Forms.TextBox

End Class
