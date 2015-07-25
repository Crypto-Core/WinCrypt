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
        Me.DateiToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateiVerschlüsselnToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateiEntschlüsselnToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextVerUndEntschlüsselnToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MD5KonverterToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MD5BruteforceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RSAToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerschlüsselungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntschlüsselungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchlüsselErstellenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMailToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMailSendenToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasswortmanagerToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenbankExportierenToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenbankImportierenToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenbankLöschenToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemidentifikationToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasswortgeneratorToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateienSicherLöschenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedbackToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedbackToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateiVerschlüsselnToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateiEntschlüsselnToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextVerUndEntschlüsselnToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HashToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MD5KonverterToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MD5BruteforceToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RSAToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntschlüsselnToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerschlüsselnToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchlüsselErstellenToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMailToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMailSendenToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasswortmanagerToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenbankExportierenToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenbankImportierenToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenbankLöschenToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemidentifikationToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasswortgeneratorToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateienSicherLöschenToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.mount_gb = New System.Windows.Forms.GroupBox()
        Me.cleanlb2 = New System.Windows.Forms.Button()
        Me.drive_lb = New System.Windows.Forms.Label()
        Me.key_lb = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.create_container_encrypt = New System.Windows.Forms.Button()
        Me.path_encrypt = New System.Windows.Forms.Label()
        Me.generate_key_encrypt = New System.Windows.Forms.Button()
        Me.crypt_file_pathbutton = New System.Windows.Forms.Button()
        Me.keycrypt = New System.Windows.Forms.TextBox()
        Me.pathtxt = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.wincrypttitle = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.XToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.gethotkey = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.mount_gb.SuspendLayout()
        Me.encrypt_gb.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
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
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem1, Me.ToolsToolStripMenuItem2, Me.InfoToolStripMenuItem1})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 27)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(598, 24)
        Me.MenuStrip.TabIndex = 11
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem1
        '
        Me.DateiToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DateiToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EinstellungToolStripMenuItem1, Me.BeendenToolStripMenuItem2})
        Me.DateiToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateiToolStripMenuItem1.Name = "DateiToolStripMenuItem1"
        Me.DateiToolStripMenuItem1.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem1.Text = "Datei"
        '
        'EinstellungToolStripMenuItem1
        '
        Me.EinstellungToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.EinstellungToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EinstellungToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.setting
        Me.EinstellungToolStripMenuItem1.Name = "EinstellungToolStripMenuItem1"
        Me.EinstellungToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.EinstellungToolStripMenuItem1.Text = "Einstellung"
        '
        'BeendenToolStripMenuItem2
        '
        Me.BeendenToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BeendenToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BeendenToolStripMenuItem2.Image = Global.Project_WinCrypt.My.Resources.Resources.Close16
        Me.BeendenToolStripMenuItem2.Name = "BeendenToolStripMenuItem2"
        Me.BeendenToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.BeendenToolStripMenuItem2.Text = "Beenden"
        '
        'ToolsToolStripMenuItem2
        '
        Me.ToolsToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiVerschlüsselnToolStripMenuItem2, Me.DateiEntschlüsselnToolStripMenuItem2, Me.TextVerUndEntschlüsselnToolStripMenuItem1, Me.HashToolStripMenuItem, Me.RSAToolStripMenuItem2, Me.EMailToolStripMenuItem2, Me.PasswortmanagerToolStripMenuItem2, Me.SystemidentifikationToolStripMenuItem2, Me.PasswortgeneratorToolStripMenuItem2, Me.DateienSicherLöschenToolStripMenuItem1})
        Me.ToolsToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolsToolStripMenuItem2.Name = "ToolsToolStripMenuItem2"
        Me.ToolsToolStripMenuItem2.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem2.Text = "Tools"
        '
        'DateiVerschlüsselnToolStripMenuItem2
        '
        Me.DateiVerschlüsselnToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DateiVerschlüsselnToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateiVerschlüsselnToolStripMenuItem2.Image = Global.Project_WinCrypt.My.Resources.Resources.Lock16
        Me.DateiVerschlüsselnToolStripMenuItem2.Name = "DateiVerschlüsselnToolStripMenuItem2"
        Me.DateiVerschlüsselnToolStripMenuItem2.Size = New System.Drawing.Size(217, 22)
        Me.DateiVerschlüsselnToolStripMenuItem2.Text = "Datei verschlüsseln"
        '
        'DateiEntschlüsselnToolStripMenuItem2
        '
        Me.DateiEntschlüsselnToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DateiEntschlüsselnToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateiEntschlüsselnToolStripMenuItem2.Image = Global.Project_WinCrypt.My.Resources.Resources.unlock16
        Me.DateiEntschlüsselnToolStripMenuItem2.Name = "DateiEntschlüsselnToolStripMenuItem2"
        Me.DateiEntschlüsselnToolStripMenuItem2.Size = New System.Drawing.Size(217, 22)
        Me.DateiEntschlüsselnToolStripMenuItem2.Text = "Datei entschlüsseln"
        '
        'TextVerUndEntschlüsselnToolStripMenuItem1
        '
        Me.TextVerUndEntschlüsselnToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TextVerUndEntschlüsselnToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextVerUndEntschlüsselnToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.textencrypt
        Me.TextVerUndEntschlüsselnToolStripMenuItem1.Name = "TextVerUndEntschlüsselnToolStripMenuItem1"
        Me.TextVerUndEntschlüsselnToolStripMenuItem1.Size = New System.Drawing.Size(217, 22)
        Me.TextVerUndEntschlüsselnToolStripMenuItem1.Text = "Text ver- und entschlüsseln"
        '
        'HashToolStripMenuItem
        '
        Me.HashToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.HashToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MD5KonverterToolStripMenuItem2, Me.MD5BruteforceToolStripMenuItem1})
        Me.HashToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HashToolStripMenuItem.Name = "HashToolStripMenuItem"
        Me.HashToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.HashToolStripMenuItem.Text = "Hash"
        '
        'MD5KonverterToolStripMenuItem2
        '
        Me.MD5KonverterToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MD5KonverterToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MD5KonverterToolStripMenuItem2.Name = "MD5KonverterToolStripMenuItem2"
        Me.MD5KonverterToolStripMenuItem2.Size = New System.Drawing.Size(162, 22)
        Me.MD5KonverterToolStripMenuItem2.Text = "MD5 Konverter"
        '
        'MD5BruteforceToolStripMenuItem1
        '
        Me.MD5BruteforceToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MD5BruteforceToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MD5BruteforceToolStripMenuItem1.Name = "MD5BruteforceToolStripMenuItem1"
        Me.MD5BruteforceToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.MD5BruteforceToolStripMenuItem1.Text = "MD5 Brute-force"
        '
        'RSAToolStripMenuItem2
        '
        Me.RSAToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.RSAToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerschlüsselungToolStripMenuItem, Me.EntschlüsselungToolStripMenuItem, Me.SchlüsselErstellenToolStripMenuItem1})
        Me.RSAToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RSAToolStripMenuItem2.Name = "RSAToolStripMenuItem2"
        Me.RSAToolStripMenuItem2.Size = New System.Drawing.Size(217, 22)
        Me.RSAToolStripMenuItem2.Text = "RSA"
        '
        'VerschlüsselungToolStripMenuItem
        '
        Me.VerschlüsselungToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.VerschlüsselungToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.VerschlüsselungToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.Lock16
        Me.VerschlüsselungToolStripMenuItem.Name = "VerschlüsselungToolStripMenuItem"
        Me.VerschlüsselungToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.VerschlüsselungToolStripMenuItem.Text = "Verschlüsselung"
        '
        'EntschlüsselungToolStripMenuItem
        '
        Me.EntschlüsselungToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.EntschlüsselungToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EntschlüsselungToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.unlock16
        Me.EntschlüsselungToolStripMenuItem.Name = "EntschlüsselungToolStripMenuItem"
        Me.EntschlüsselungToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.EntschlüsselungToolStripMenuItem.Text = "Entschlüsselung"
        '
        'SchlüsselErstellenToolStripMenuItem1
        '
        Me.SchlüsselErstellenToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SchlüsselErstellenToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SchlüsselErstellenToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.Key16
        Me.SchlüsselErstellenToolStripMenuItem1.Name = "SchlüsselErstellenToolStripMenuItem1"
        Me.SchlüsselErstellenToolStripMenuItem1.Size = New System.Drawing.Size(169, 22)
        Me.SchlüsselErstellenToolStripMenuItem1.Text = "Schlüssel erstellen"
        '
        'EMailToolStripMenuItem2
        '
        Me.EMailToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.EMailToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EMailSendenToolStripMenuItem2})
        Me.EMailToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EMailToolStripMenuItem2.Image = Global.Project_WinCrypt.My.Resources.Resources.mail
        Me.EMailToolStripMenuItem2.Name = "EMailToolStripMenuItem2"
        Me.EMailToolStripMenuItem2.Size = New System.Drawing.Size(217, 22)
        Me.EMailToolStripMenuItem2.Text = "E-Mail"
        '
        'EMailSendenToolStripMenuItem2
        '
        Me.EMailSendenToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.EMailSendenToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EMailSendenToolStripMenuItem2.Image = Global.Project_WinCrypt.My.Resources.Resources.MailSend16
        Me.EMailSendenToolStripMenuItem2.Name = "EMailSendenToolStripMenuItem2"
        Me.EMailSendenToolStripMenuItem2.Size = New System.Drawing.Size(149, 22)
        Me.EMailSendenToolStripMenuItem2.Text = "E-Mail senden"
        '
        'PasswortmanagerToolStripMenuItem2
        '
        Me.PasswortmanagerToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.PasswortmanagerToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatenbankExportierenToolStripMenuItem2, Me.DatenbankImportierenToolStripMenuItem2, Me.DatenbankLöschenToolStripMenuItem2})
        Me.PasswortmanagerToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PasswortmanagerToolStripMenuItem2.Image = Global.Project_WinCrypt.My.Resources.Resources.pwmanager
        Me.PasswortmanagerToolStripMenuItem2.Name = "PasswortmanagerToolStripMenuItem2"
        Me.PasswortmanagerToolStripMenuItem2.Size = New System.Drawing.Size(217, 22)
        Me.PasswortmanagerToolStripMenuItem2.Text = "Passwortmanager"
        '
        'DatenbankExportierenToolStripMenuItem2
        '
        Me.DatenbankExportierenToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DatenbankExportierenToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DatenbankExportierenToolStripMenuItem2.Image = Global.Project_WinCrypt.My.Resources.Resources.Data_Export_16
        Me.DatenbankExportierenToolStripMenuItem2.Name = "DatenbankExportierenToolStripMenuItem2"
        Me.DatenbankExportierenToolStripMenuItem2.Size = New System.Drawing.Size(196, 22)
        Me.DatenbankExportierenToolStripMenuItem2.Text = "Datenbank exportieren"
        '
        'DatenbankImportierenToolStripMenuItem2
        '
        Me.DatenbankImportierenToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DatenbankImportierenToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DatenbankImportierenToolStripMenuItem2.Image = Global.Project_WinCrypt.My.Resources.Resources.Data_Import_16
        Me.DatenbankImportierenToolStripMenuItem2.Name = "DatenbankImportierenToolStripMenuItem2"
        Me.DatenbankImportierenToolStripMenuItem2.Size = New System.Drawing.Size(196, 22)
        Me.DatenbankImportierenToolStripMenuItem2.Text = "Datenbank importieren"
        '
        'DatenbankLöschenToolStripMenuItem2
        '
        Me.DatenbankLöschenToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DatenbankLöschenToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DatenbankLöschenToolStripMenuItem2.Image = Global.Project_WinCrypt.My.Resources.Resources.Data_Erase_16
        Me.DatenbankLöschenToolStripMenuItem2.Name = "DatenbankLöschenToolStripMenuItem2"
        Me.DatenbankLöschenToolStripMenuItem2.Size = New System.Drawing.Size(196, 22)
        Me.DatenbankLöschenToolStripMenuItem2.Text = "Datenbank löschen"
        '
        'SystemidentifikationToolStripMenuItem2
        '
        Me.SystemidentifikationToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SystemidentifikationToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SystemidentifikationToolStripMenuItem2.Image = Global.Project_WinCrypt.My.Resources.Resources.Identity
        Me.SystemidentifikationToolStripMenuItem2.Name = "SystemidentifikationToolStripMenuItem2"
        Me.SystemidentifikationToolStripMenuItem2.Size = New System.Drawing.Size(217, 22)
        Me.SystemidentifikationToolStripMenuItem2.Text = "Systemidentifikation"
        '
        'PasswortgeneratorToolStripMenuItem2
        '
        Me.PasswortgeneratorToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.PasswortgeneratorToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PasswortgeneratorToolStripMenuItem2.Image = Global.Project_WinCrypt.My.Resources.Resources.Password16
        Me.PasswortgeneratorToolStripMenuItem2.Name = "PasswortgeneratorToolStripMenuItem2"
        Me.PasswortgeneratorToolStripMenuItem2.Size = New System.Drawing.Size(217, 22)
        Me.PasswortgeneratorToolStripMenuItem2.Text = "Passwortgenerator"
        '
        'DateienSicherLöschenToolStripMenuItem1
        '
        Me.DateienSicherLöschenToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DateienSicherLöschenToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateienSicherLöschenToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.Delete16
        Me.DateienSicherLöschenToolStripMenuItem1.Name = "DateienSicherLöschenToolStripMenuItem1"
        Me.DateienSicherLöschenToolStripMenuItem1.Size = New System.Drawing.Size(217, 22)
        Me.DateienSicherLöschenToolStripMenuItem1.Text = "Dateien sicher löschen"
        '
        'InfoToolStripMenuItem1
        '
        Me.InfoToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.InfoToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem2, Me.FeedbackToolStripMenuItem2, Me.AboutToolStripMenuItem2})
        Me.InfoToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.InfoToolStripMenuItem1.Name = "InfoToolStripMenuItem1"
        Me.InfoToolStripMenuItem1.Size = New System.Drawing.Size(40, 20)
        Me.InfoToolStripMenuItem1.Text = "Info"
        '
        'UpdateToolStripMenuItem2
        '
        Me.UpdateToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.UpdateToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.UpdateToolStripMenuItem2.Image = Global.Project_WinCrypt.My.Resources.Resources.updateflat
        Me.UpdateToolStripMenuItem2.Name = "UpdateToolStripMenuItem2"
        Me.UpdateToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.UpdateToolStripMenuItem2.Text = "Update"
        '
        'FeedbackToolStripMenuItem2
        '
        Me.FeedbackToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.FeedbackToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FeedbackToolStripMenuItem2.Image = Global.Project_WinCrypt.My.Resources.Resources.feedback16
        Me.FeedbackToolStripMenuItem2.Name = "FeedbackToolStripMenuItem2"
        Me.FeedbackToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.FeedbackToolStripMenuItem2.Text = "Feedback"
        '
        'AboutToolStripMenuItem2
        '
        Me.AboutToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.AboutToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AboutToolStripMenuItem2.Image = Global.Project_WinCrypt.My.Resources.Resources.Information16
        Me.AboutToolStripMenuItem2.Name = "AboutToolStripMenuItem2"
        Me.AboutToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem2.Text = "About"
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
        Me.EinstellungToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.setting
        Me.EinstellungToolStripMenuItem.Name = "EinstellungToolStripMenuItem"
        Me.EinstellungToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.EinstellungToolStripMenuItem.Text = "Einstellung"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BeendenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BeendenToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.Close16
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
        Me.DateiVerschlüsselnToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.Lock16
        Me.DateiVerschlüsselnToolStripMenuItem.Name = "DateiVerschlüsselnToolStripMenuItem"
        Me.DateiVerschlüsselnToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.DateiVerschlüsselnToolStripMenuItem.Text = "Datei verschlüsseln"
        '
        'DateiEntschlüsselnToolStripMenuItem
        '
        Me.DateiEntschlüsselnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DateiEntschlüsselnToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateiEntschlüsselnToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.unlock16
        Me.DateiEntschlüsselnToolStripMenuItem.Name = "DateiEntschlüsselnToolStripMenuItem"
        Me.DateiEntschlüsselnToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.DateiEntschlüsselnToolStripMenuItem.Text = "Datei entschlüsseln"
        '
        'TextVerschlüsselnToolStripMenuItem
        '
        Me.TextVerschlüsselnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TextVerschlüsselnToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextVerschlüsselnToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.textencrypt
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
        Me.EntschlüsselnToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.unlock16
        Me.EntschlüsselnToolStripMenuItem.Name = "EntschlüsselnToolStripMenuItem"
        Me.EntschlüsselnToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.EntschlüsselnToolStripMenuItem.Text = "Entschlüsseln"
        '
        'VerschlüsselnToolStripMenuItem
        '
        Me.VerschlüsselnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.VerschlüsselnToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.VerschlüsselnToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.Lock16
        Me.VerschlüsselnToolStripMenuItem.Name = "VerschlüsselnToolStripMenuItem"
        Me.VerschlüsselnToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.VerschlüsselnToolStripMenuItem.Text = "Verschlüsseln"
        '
        'KeyErstellenToolStripMenuItem
        '
        Me.KeyErstellenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.KeyErstellenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.KeyErstellenToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.Key16
        Me.KeyErstellenToolStripMenuItem.Name = "KeyErstellenToolStripMenuItem"
        Me.KeyErstellenToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.KeyErstellenToolStripMenuItem.Text = "Schlüssel erstellen"
        '
        'EMailToolStripMenuItem
        '
        Me.EMailToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.EMailToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EMailSendenToolStripMenuItem})
        Me.EMailToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EMailToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.mail
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
        Me.PasswortmanagerToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.pwmanager
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
        Me.SystemidentifikationToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.Identity
        Me.SystemidentifikationToolStripMenuItem.Name = "SystemidentifikationToolStripMenuItem"
        Me.SystemidentifikationToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.SystemidentifikationToolStripMenuItem.Text = "Systemidentifikation"
        '
        'PasswortgeneratorToolStripMenuItem
        '
        Me.PasswortgeneratorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.PasswortgeneratorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PasswortgeneratorToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.Password16
        Me.PasswortgeneratorToolStripMenuItem.Name = "PasswortgeneratorToolStripMenuItem"
        Me.PasswortgeneratorToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.PasswortgeneratorToolStripMenuItem.Text = "Passwortgenerator"
        '
        'DateiSicherLöschenToolStripMenuItem
        '
        Me.DateiSicherLöschenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DateiSicherLöschenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateiSicherLöschenToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.Delete16
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
        Me.UpdateToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.updateflat
        Me.UpdateToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'FeedbackToolStripMenuItem
        '
        Me.FeedbackToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.FeedbackToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FeedbackToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.feedback16
        Me.FeedbackToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
        Me.FeedbackToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FeedbackToolStripMenuItem.Text = "Feedback"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AboutToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.Information16
        Me.AboutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1, Me.FeedbackToolStripMenuItem1, Me.UpdateToolStripMenuItem1, Me.ToolsToolStripMenuItem1, Me.ÖffnenToolStripMenuItem, Me.BeendenToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(125, 136)
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AboutToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.Information16
        Me.AboutToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'FeedbackToolStripMenuItem1
        '
        Me.FeedbackToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FeedbackToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.feedback16
        Me.FeedbackToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.FeedbackToolStripMenuItem1.Name = "FeedbackToolStripMenuItem1"
        Me.FeedbackToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.FeedbackToolStripMenuItem1.Text = "Feedback"
        '
        'UpdateToolStripMenuItem1
        '
        Me.UpdateToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.UpdateToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.updateflat
        Me.UpdateToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.UpdateToolStripMenuItem1.Name = "UpdateToolStripMenuItem1"
        Me.UpdateToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.UpdateToolStripMenuItem1.Text = "Update"
        '
        'ToolsToolStripMenuItem1
        '
        Me.ToolsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiVerschlüsselnToolStripMenuItem3, Me.DateiEntschlüsselnToolStripMenuItem3, Me.TextVerUndEntschlüsselnToolStripMenuItem2, Me.HashToolStripMenuItem1, Me.RSAToolStripMenuItem3, Me.EMailToolStripMenuItem3, Me.PasswortmanagerToolStripMenuItem3, Me.SystemidentifikationToolStripMenuItem3, Me.PasswortgeneratorToolStripMenuItem3, Me.DateienSicherLöschenToolStripMenuItem2})
        Me.ToolsToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolsToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ToolsToolStripMenuItem1.Name = "ToolsToolStripMenuItem1"
        Me.ToolsToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.ToolsToolStripMenuItem1.Text = "Tools"
        '
        'DateiVerschlüsselnToolStripMenuItem3
        '
        Me.DateiVerschlüsselnToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DateiVerschlüsselnToolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateiVerschlüsselnToolStripMenuItem3.Image = Global.Project_WinCrypt.My.Resources.Resources.Lock16
        Me.DateiVerschlüsselnToolStripMenuItem3.Name = "DateiVerschlüsselnToolStripMenuItem3"
        Me.DateiVerschlüsselnToolStripMenuItem3.Size = New System.Drawing.Size(217, 22)
        Me.DateiVerschlüsselnToolStripMenuItem3.Text = "Datei verschlüsseln"
        '
        'DateiEntschlüsselnToolStripMenuItem3
        '
        Me.DateiEntschlüsselnToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DateiEntschlüsselnToolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateiEntschlüsselnToolStripMenuItem3.Image = Global.Project_WinCrypt.My.Resources.Resources.unlock16
        Me.DateiEntschlüsselnToolStripMenuItem3.Name = "DateiEntschlüsselnToolStripMenuItem3"
        Me.DateiEntschlüsselnToolStripMenuItem3.Size = New System.Drawing.Size(217, 22)
        Me.DateiEntschlüsselnToolStripMenuItem3.Text = "Datei entschlüsseln"
        '
        'TextVerUndEntschlüsselnToolStripMenuItem2
        '
        Me.TextVerUndEntschlüsselnToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TextVerUndEntschlüsselnToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextVerUndEntschlüsselnToolStripMenuItem2.Image = Global.Project_WinCrypt.My.Resources.Resources.textencrypt
        Me.TextVerUndEntschlüsselnToolStripMenuItem2.Name = "TextVerUndEntschlüsselnToolStripMenuItem2"
        Me.TextVerUndEntschlüsselnToolStripMenuItem2.Size = New System.Drawing.Size(217, 22)
        Me.TextVerUndEntschlüsselnToolStripMenuItem2.Text = "Text ver- und entschlüsseln"
        '
        'HashToolStripMenuItem1
        '
        Me.HashToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.HashToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MD5KonverterToolStripMenuItem3, Me.MD5BruteforceToolStripMenuItem2})
        Me.HashToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HashToolStripMenuItem1.Name = "HashToolStripMenuItem1"
        Me.HashToolStripMenuItem1.Size = New System.Drawing.Size(217, 22)
        Me.HashToolStripMenuItem1.Text = "Hash"
        '
        'MD5KonverterToolStripMenuItem3
        '
        Me.MD5KonverterToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MD5KonverterToolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MD5KonverterToolStripMenuItem3.Name = "MD5KonverterToolStripMenuItem3"
        Me.MD5KonverterToolStripMenuItem3.Size = New System.Drawing.Size(162, 22)
        Me.MD5KonverterToolStripMenuItem3.Text = "MD5 Konverter"
        '
        'MD5BruteforceToolStripMenuItem2
        '
        Me.MD5BruteforceToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MD5BruteforceToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MD5BruteforceToolStripMenuItem2.Name = "MD5BruteforceToolStripMenuItem2"
        Me.MD5BruteforceToolStripMenuItem2.Size = New System.Drawing.Size(162, 22)
        Me.MD5BruteforceToolStripMenuItem2.Text = "MD5 Brute-force"
        '
        'RSAToolStripMenuItem3
        '
        Me.RSAToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.RSAToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntschlüsselnToolStripMenuItem2, Me.VerschlüsselnToolStripMenuItem2, Me.SchlüsselErstellenToolStripMenuItem2})
        Me.RSAToolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RSAToolStripMenuItem3.Name = "RSAToolStripMenuItem3"
        Me.RSAToolStripMenuItem3.Size = New System.Drawing.Size(217, 22)
        Me.RSAToolStripMenuItem3.Text = "RSA"
        '
        'EntschlüsselnToolStripMenuItem2
        '
        Me.EntschlüsselnToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.EntschlüsselnToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EntschlüsselnToolStripMenuItem2.Image = Global.Project_WinCrypt.My.Resources.Resources.unlock16
        Me.EntschlüsselnToolStripMenuItem2.Name = "EntschlüsselnToolStripMenuItem2"
        Me.EntschlüsselnToolStripMenuItem2.Size = New System.Drawing.Size(169, 22)
        Me.EntschlüsselnToolStripMenuItem2.Text = "Entschlüsseln"
        '
        'VerschlüsselnToolStripMenuItem2
        '
        Me.VerschlüsselnToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.VerschlüsselnToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.VerschlüsselnToolStripMenuItem2.Image = Global.Project_WinCrypt.My.Resources.Resources.Lock16
        Me.VerschlüsselnToolStripMenuItem2.Name = "VerschlüsselnToolStripMenuItem2"
        Me.VerschlüsselnToolStripMenuItem2.Size = New System.Drawing.Size(169, 22)
        Me.VerschlüsselnToolStripMenuItem2.Text = "Verschlüsseln"
        '
        'SchlüsselErstellenToolStripMenuItem2
        '
        Me.SchlüsselErstellenToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SchlüsselErstellenToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SchlüsselErstellenToolStripMenuItem2.Image = Global.Project_WinCrypt.My.Resources.Resources.Key16
        Me.SchlüsselErstellenToolStripMenuItem2.Name = "SchlüsselErstellenToolStripMenuItem2"
        Me.SchlüsselErstellenToolStripMenuItem2.Size = New System.Drawing.Size(169, 22)
        Me.SchlüsselErstellenToolStripMenuItem2.Text = "Schlüssel erstellen"
        '
        'EMailToolStripMenuItem3
        '
        Me.EMailToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.EMailToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EMailSendenToolStripMenuItem3})
        Me.EMailToolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EMailToolStripMenuItem3.Name = "EMailToolStripMenuItem3"
        Me.EMailToolStripMenuItem3.Size = New System.Drawing.Size(217, 22)
        Me.EMailToolStripMenuItem3.Text = "E-Mail"
        '
        'EMailSendenToolStripMenuItem3
        '
        Me.EMailSendenToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.EMailSendenToolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EMailSendenToolStripMenuItem3.Image = Global.Project_WinCrypt.My.Resources.Resources.mail
        Me.EMailSendenToolStripMenuItem3.Name = "EMailSendenToolStripMenuItem3"
        Me.EMailSendenToolStripMenuItem3.Size = New System.Drawing.Size(149, 22)
        Me.EMailSendenToolStripMenuItem3.Text = "E-Mail senden"
        '
        'PasswortmanagerToolStripMenuItem3
        '
        Me.PasswortmanagerToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.PasswortmanagerToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatenbankExportierenToolStripMenuItem3, Me.DatenbankImportierenToolStripMenuItem3, Me.DatenbankLöschenToolStripMenuItem3})
        Me.PasswortmanagerToolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PasswortmanagerToolStripMenuItem3.Image = Global.Project_WinCrypt.My.Resources.Resources.pwmanager
        Me.PasswortmanagerToolStripMenuItem3.Name = "PasswortmanagerToolStripMenuItem3"
        Me.PasswortmanagerToolStripMenuItem3.Size = New System.Drawing.Size(217, 22)
        Me.PasswortmanagerToolStripMenuItem3.Text = "Passwortmanager"
        '
        'DatenbankExportierenToolStripMenuItem3
        '
        Me.DatenbankExportierenToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DatenbankExportierenToolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DatenbankExportierenToolStripMenuItem3.Name = "DatenbankExportierenToolStripMenuItem3"
        Me.DatenbankExportierenToolStripMenuItem3.Size = New System.Drawing.Size(196, 22)
        Me.DatenbankExportierenToolStripMenuItem3.Text = "Datenbank exportieren"
        '
        'DatenbankImportierenToolStripMenuItem3
        '
        Me.DatenbankImportierenToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DatenbankImportierenToolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DatenbankImportierenToolStripMenuItem3.Name = "DatenbankImportierenToolStripMenuItem3"
        Me.DatenbankImportierenToolStripMenuItem3.Size = New System.Drawing.Size(196, 22)
        Me.DatenbankImportierenToolStripMenuItem3.Text = "Datenbank importieren"
        '
        'DatenbankLöschenToolStripMenuItem3
        '
        Me.DatenbankLöschenToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DatenbankLöschenToolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DatenbankLöschenToolStripMenuItem3.Name = "DatenbankLöschenToolStripMenuItem3"
        Me.DatenbankLöschenToolStripMenuItem3.Size = New System.Drawing.Size(196, 22)
        Me.DatenbankLöschenToolStripMenuItem3.Text = "Datenbank löschen"
        '
        'SystemidentifikationToolStripMenuItem3
        '
        Me.SystemidentifikationToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SystemidentifikationToolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SystemidentifikationToolStripMenuItem3.Image = Global.Project_WinCrypt.My.Resources.Resources.Identity
        Me.SystemidentifikationToolStripMenuItem3.Name = "SystemidentifikationToolStripMenuItem3"
        Me.SystemidentifikationToolStripMenuItem3.Size = New System.Drawing.Size(217, 22)
        Me.SystemidentifikationToolStripMenuItem3.Text = "Systemidentifikation"
        '
        'PasswortgeneratorToolStripMenuItem3
        '
        Me.PasswortgeneratorToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.PasswortgeneratorToolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PasswortgeneratorToolStripMenuItem3.Image = Global.Project_WinCrypt.My.Resources.Resources.Password16
        Me.PasswortgeneratorToolStripMenuItem3.Name = "PasswortgeneratorToolStripMenuItem3"
        Me.PasswortgeneratorToolStripMenuItem3.Size = New System.Drawing.Size(217, 22)
        Me.PasswortgeneratorToolStripMenuItem3.Text = "Passwortgenerator"
        '
        'DateienSicherLöschenToolStripMenuItem2
        '
        Me.DateienSicherLöschenToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DateienSicherLöschenToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateienSicherLöschenToolStripMenuItem2.Image = Global.Project_WinCrypt.My.Resources.Resources.Delete16
        Me.DateienSicherLöschenToolStripMenuItem2.Name = "DateienSicherLöschenToolStripMenuItem2"
        Me.DateienSicherLöschenToolStripMenuItem2.Size = New System.Drawing.Size(217, 22)
        Me.DateienSicherLöschenToolStripMenuItem2.Text = "Dateien sicher löschen"
        '
        'ÖffnenToolStripMenuItem
        '
        Me.ÖffnenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ÖffnenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
        Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.ÖffnenToolStripMenuItem.Text = "Öffnen"
        '
        'BeendenToolStripMenuItem1
        '
        Me.BeendenToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BeendenToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.Close16
        Me.BeendenToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BeendenToolStripMenuItem1.Name = "BeendenToolStripMenuItem1"
        Me.BeendenToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.BeendenToolStripMenuItem1.Text = "Beenden"
        '
        'DateiVerschlüsselnToolStripMenuItem1
        '
        Me.DateiVerschlüsselnToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.Lock16
        Me.DateiVerschlüsselnToolStripMenuItem1.Name = "DateiVerschlüsselnToolStripMenuItem1"
        Me.DateiVerschlüsselnToolStripMenuItem1.Size = New System.Drawing.Size(217, 22)
        Me.DateiVerschlüsselnToolStripMenuItem1.Text = "Datei verschlüsseln"
        '
        'DateiEntschlüsselnToolStripMenuItem1
        '
        Me.DateiEntschlüsselnToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.unlock16
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
        Me.TextVerUndEntschlüsselnToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.textencrypt
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
        Me.VerschlüsselnToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.Lock16
        Me.VerschlüsselnToolStripMenuItem1.Name = "VerschlüsselnToolStripMenuItem1"
        Me.VerschlüsselnToolStripMenuItem1.Size = New System.Drawing.Size(169, 22)
        Me.VerschlüsselnToolStripMenuItem1.Text = "Verschlüsseln"
        '
        'EntschlüsselnToolStripMenuItem1
        '
        Me.EntschlüsselnToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.unlock16
        Me.EntschlüsselnToolStripMenuItem1.Name = "EntschlüsselnToolStripMenuItem1"
        Me.EntschlüsselnToolStripMenuItem1.Size = New System.Drawing.Size(169, 22)
        Me.EntschlüsselnToolStripMenuItem1.Text = "Entschlüsseln"
        '
        'SchlüsselErstellenToolStripMenuItem
        '
        Me.SchlüsselErstellenToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.Key16
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
        Me.SystemidentifikationToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.Identity
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
        Me.PasswortGeneratorToolStripMenuItem1.Image = Global.Project_WinCrypt.My.Resources.Resources.Password16
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
        Me.DateienSicherLöschenToolStripMenuItem.Image = Global.Project_WinCrypt.My.Resources.Resources.Delete16
        Me.DateienSicherLöschenToolStripMenuItem.Name = "DateienSicherLöschenToolStripMenuItem"
        Me.DateienSicherLöschenToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.DateienSicherLöschenToolStripMenuItem.Text = "Dateien sicher löschen"
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
        Me.mount_gb.Controls.Add(Me.cleanlb2)
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
        Me.mount_gb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mount_gb.Location = New System.Drawing.Point(12, 309)
        Me.mount_gb.Name = "mount_gb"
        Me.mount_gb.Size = New System.Drawing.Size(573, 288)
        Me.mount_gb.TabIndex = 9
        Me.mount_gb.TabStop = False
        Me.mount_gb.Text = "Cryptdatei Mounten"
        '
        'cleanlb2
        '
        Me.cleanlb2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cleanlb2.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cleanlb2.FlatAppearance.BorderSize = 0
        Me.cleanlb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cleanlb2.Image = Global.Project_WinCrypt.My.Resources.Resources.Clean_16
        Me.cleanlb2.Location = New System.Drawing.Point(530, 215)
        Me.cleanlb2.Name = "cleanlb2"
        Me.cleanlb2.Size = New System.Drawing.Size(37, 23)
        Me.cleanlb2.TabIndex = 9
        Me.cleanlb2.UseVisualStyleBackColor = False
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Datei:"
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
        Me.decrypt_list_status.Location = New System.Drawing.Point(16, 63)
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
        Me.drivecb.Location = New System.Drawing.Point(353, 246)
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
        Me.keyencrypt.Location = New System.Drawing.Point(16, 246)
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
        Me.decrypt_filepath.Location = New System.Drawing.Point(16, 32)
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
        Me.dismount.Location = New System.Drawing.Point(492, 244)
        Me.dismount.Name = "dismount"
        Me.dismount.Size = New System.Drawing.Size(75, 23)
        Me.dismount.TabIndex = 2
        Me.dismount.Text = "Dismount"
        Me.dismount.UseVisualStyleBackColor = False
        '
        'mount
        '
        Me.mount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mount.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
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
        'opencryptfile
        '
        Me.opencryptfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opencryptfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.opencryptfile.FlatAppearance.BorderSize = 0
        Me.opencryptfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opencryptfile.ForeColor = System.Drawing.Color.White
        Me.opencryptfile.Location = New System.Drawing.Point(492, 30)
        Me.opencryptfile.Name = "opencryptfile"
        Me.opencryptfile.Size = New System.Drawing.Size(75, 23)
        Me.opencryptfile.TabIndex = 0
        Me.opencryptfile.Text = "Öffnen"
        Me.opencryptfile.UseVisualStyleBackColor = False
        '
        'encrypt_gb
        '
        Me.encrypt_gb.Controls.Add(Me.cleanlb1)
        Me.encrypt_gb.Controls.Add(Me.encrypt_list_status)
        Me.encrypt_gb.Controls.Add(Me.Label2)
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
        Me.encrypt_gb.Text = "Ordner/Laufwerk Verschlüsseln"
        '
        'cleanlb1
        '
        Me.cleanlb1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cleanlb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cleanlb1.FlatAppearance.BorderSize = 0
        Me.cleanlb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cleanlb1.Image = Global.Project_WinCrypt.My.Resources.Resources.Clean_16
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Schlüssel:"
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
        Me.create_container_encrypt.Text = "Container erstellen"
        Me.create_container_encrypt.UseVisualStyleBackColor = False
        '
        'path_encrypt
        '
        Me.path_encrypt.AutoSize = True
        Me.path_encrypt.Location = New System.Drawing.Point(8, 17)
        Me.path_encrypt.Name = "path_encrypt"
        Me.path_encrypt.Size = New System.Drawing.Size(32, 13)
        Me.path_encrypt.TabIndex = 6
        Me.path_encrypt.Text = "Pfad:"
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
        Me.generate_key_encrypt.Text = "Generieren"
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
        Me.crypt_file_pathbutton.Text = "Hinzufügen"
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project_WinCrypt.My.Resources.Resources.icon
        Me.PictureBox1.Location = New System.Drawing.Point(9, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
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
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(598, 27)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "WinCrypt"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(29, 23)
        Me.ToolStripMenuItem3.Text = "X"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem4.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(32, 23)
        Me.ToolStripMenuItem4.Text = "─"
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
        'gethotkey
        '
        Me.gethotkey.Enabled = True
        Me.gethotkey.Interval = 10
        '
        'startwindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(598, 609)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.wincrypttitle)
        Me.Controls.Add(Me.mount_gb)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.encrypt_gb)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "startwindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WinCrypt 1.3"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.mount_gb.ResumeLayout(False)
        Me.mount_gb.PerformLayout()
        Me.encrypt_gb.ResumeLayout(False)
        Me.encrypt_gb.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents TextVerschlüsselnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemidentifikationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasswortgeneratorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EinstellungToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DatenbankExportierenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatenbankImportierenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatenbankLöschenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mount_gb As System.Windows.Forms.GroupBox
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
    Friend WithEvents encrypt_list_status As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents create_container_encrypt As System.Windows.Forms.Button
    Friend WithEvents path_encrypt As System.Windows.Forms.Label
    Friend WithEvents generate_key_encrypt As System.Windows.Forms.Button
    Friend WithEvents crypt_file_pathbutton As System.Windows.Forms.Button
    Friend WithEvents keycrypt As System.Windows.Forms.TextBox
    Friend WithEvents pathtxt As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents wincrypttitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents XToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateiToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EinstellungToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateiVerschlüsselnToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateiEntschlüsselnToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextVerUndEntschlüsselnToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HashToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MD5KonverterToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MD5BruteforceToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RSAToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerschlüsselungToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntschlüsselungToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SchlüsselErstellenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EMailToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EMailSendenToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasswortmanagerToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatenbankExportierenToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatenbankImportierenToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatenbankLöschenToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemidentifikationToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasswortgeneratorToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateienSicherLöschenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateiVerschlüsselnToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateiEntschlüsselnToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextVerUndEntschlüsselnToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HashToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MD5KonverterToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MD5BruteforceToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RSAToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntschlüsselnToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerschlüsselnToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SchlüsselErstellenToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EMailToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EMailSendenToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasswortmanagerToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatenbankExportierenToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatenbankImportierenToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatenbankLöschenToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemidentifikationToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasswortgeneratorToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateienSicherLöschenToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cleanlb1 As System.Windows.Forms.Button
    Friend WithEvents cleanlb2 As System.Windows.Forms.Button
    Friend WithEvents gethotkey As System.Windows.Forms.Timer

End Class
