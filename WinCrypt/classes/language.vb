Option Strict On

Imports System.ComponentModel
Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports Project_WinCrypt.classes

Namespace classes

    Public Class Language

        Public Shared Sub ChangeLanguage(ByVal lang As String)
            Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(WcSetting))

            For Each c As Control In WcSetting.Controls
                resources.ApplyResources(c, c.Name, New CultureInfo(lang))
            Next c

            For Each g As GroupBox In WcSetting.Controls.OfType(Of GroupBox)()

                For Each t As Control In g.Controls
                    resources.ApplyResources(t, t.Name, New CultureInfo(lang))
                Next
            Next

            Dim resources_main As ComponentResourceManager = New ComponentResourceManager(GetType(Startwindow))

            For Each c As Control In Startwindow.Controls
                resources_main.ApplyResources(c, c.Name, New CultureInfo(lang))
            Next c

            For Each g As GroupBox In Startwindow.Controls.OfType(Of GroupBox)()

                For Each t As Control In g.Controls
                    resources_main.ApplyResources(t, t.Name, New CultureInfo(lang))
                Next
            Next

            For Each s As ToolStripMenuItem In Startwindow.MenuStrip.Items
                resources_main.ApplyResources(s, s.Name, New CultureInfo(lang))
                For Each s2 As ToolStripMenuItem In s.DropDownItems
                    resources_main.ApplyResources(s2, s2.Name, New CultureInfo(lang))
                Next
            Next

        End Sub

        Public langname As String

        Public Sub check()
            Dim _
                lang As _
                    New IniDatei(
                        String.Format("{0}\WinCrypt\config.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)))
            langname = lang.worthreading("Info", "Lang")
            If lang.worthreading("Info", "Lang") = "English" Then 'ENGLISH
                'masterkey.vb
                Masterkey.abort_bt.Text = "abort"

                'rsa_encrypt.vb
                tools.rsa.rsa_encrypt.pubkey_path_bt.Text = "open"
                tools.rsa.rsa_encrypt.message_lb.Text = "message"
                tools.rsa.rsa_encrypt.encryption_message_lb.Text = "encryption message"
                tools.rsa.rsa_encrypt.encryption_bt.Text = "encrypt"
                tools.rsa.rsa_encrypt.wincrypttitle.Text = "RSA Encrypt"
                tools.rsa.rsa_encrypt.Text = "RSA Encrypt"
                Startwindow.rsa_encrypt_bt_menu.Text = "encrypt"


                'rsa_decrypt.vb
                tools.rsa.rsa_decrypt.open_privkey_bt.Text = "open"
                tools.rsa.rsa_decrypt.encrypt_message_lb.Text = "encryption message"
                tools.rsa.rsa_decrypt.message_lb.Text = "message"
                tools.rsa.rsa_decrypt.decrypt_bt.Text = "decrypt"
                tools.rsa.rsa_decrypt.wincrypttitle.Text = "RSA Decrypt"
                tools.rsa.rsa_decrypt.Text = "RSA Decrypt"
                Startwindow.rsa_decrypt_bt_menu.Text = "decrypt"

                'rsa_create_keys.vb
                tools.rsa.rsa_create_keys.save_privkey_bt.Text = "save as"
                tools.rsa.rsa_create_keys.save_pubkey_bt.Text = "save as"
                tools.rsa.rsa_create_keys.generate_key_bt.Text = "generate keys"
                tools.rsa.rsa_create_keys.save_bt.Text = "save"
                tools.rsa.rsa_create_keys.wincrypttitle.Text = "RSA create key's"
                tools.rsa.rsa_create_keys.Text = "RSA create key's"
                Startwindow.rsa_create_keys_bt_menu.Text = "create key's"

                'systemidentification
                Systemidentification.off_rb.Text = "off"
                Systemidentification.on_rb.Text = "on"
                Systemidentification.wincrypttitle.Text = "system identification"
                Systemidentification.Text = "system identification"
                Systemidentification.systemidentification_lb.Text = String.Format("The system identification allows the user passwords{0}more needs to enter. This can be very useful if you passwords to{0}can not remember well or you want the encrypted file / folder / -{0}Text / data carrier only be opened by a computer. This may have the advantage{0}if you lose a USB stick, so the data can be opened by anyone{0}other than the owner of the PC with which it encrypted the data.", vbCrLf)

                'passwortgenerator.vb
                tools.passwordgenerator.passwordgenerator.Text = "WinCrypt - passwordgenerator"
                tools.passwordgenerator.passwordgenerator.wincrypttitle.Text = "WinCrypt - passwordgenerator"
                tools.passwordgenerator.passwordgenerator.specialchar.Text = "specialchar (!§$%&/()=?)"
                tools.passwordgenerator.passwordgenerator.uppercasecb.Text = "uppercase"
                tools.passwordgenerator.passwordgenerator.lowercasecb.Text = "lower case"
                tools.passwordgenerator.passwordgenerator.numberscb.Text = "numbers"
                tools.passwordgenerator.passwordgenerator.length_lb.Text = "length:"
                tools.passwordgenerator.passwordgenerator.copybt.Text = "copy"
                tools.passwordgenerator.passwordgenerator.generatebt.Text = "generate"
                tools.passwordgenerator.passwordgenerator.lines_lb.Text = "lines:"
                tools.passwordgenerator.passwordgenerator.pw_length.Text = "length: "
                tools.passwordgenerator.passwordgenerator.saveas_bt.Text = "save as..."
                tools.passwordgenerator.passwordgenerator.attachments.Text = "Attachments?"

                'safedelete.vb
                tools.safedelete.safedelete.selectpathbt.Text = "select"
                tools.safedelete.safedelete.filelb.Text = "Path:"
                tools.safedelete.safedelete.overwritelb.Text = "overwrite"
                tools.safedelete.safedelete.deletebt.Text = "delete"
                tools.safedelete.safedelete.fileaddbt.Text = "add file"
                tools.safedelete.safedelete.removeentrybt.Text = "remove entry"
                tools.safedelete.safedelete.wincrypttitle.Text = "safe delete"
                tools.safedelete.safedelete.Text = "safe delete"
                tools.safedelete.safedelete.abort_bt.Text = "abort"
                tools.safedelete.del_report.saveas_bt.Text = "save as..."
                tools.safedelete.safedelete.override_pb_lb.Text = "overwrite:"
                tools.safedelete.safedelete.statuslb.Text = "status:"

                'textencrypt.vb
                tools.text_encryption.Textencrypt.encrypt_lb.Text = "encypt"
                tools.text_encryption.Textencrypt.decrypt_lb.Text = "decrypt"
                tools.text_encryption.Textencrypt.text_input.Text = "text entry"
                tools.text_encryption.Textencrypt.text_output.Text = "text output"
                tools.text_encryption.Textencrypt.password_lb.Text = "password:"
                tools.text_encryption.Textencrypt.generate_bt.Text = "generate"
                tools.text_encryption.Textencrypt.decrypt_bt.Text = "decrypt"
                tools.text_encryption.Textencrypt.encrypt_bt.Text = "encrypt"
                tools.text_encryption.Textencrypt.wincrypttitle.Text = "Text en- and decrypt"
                tools.text_encryption.Textencrypt.Text = "Text en- and decrypt"
                Startwindow.text_encrypt_bt_menu.Text = "text de- and encrypt"

                'DateiEntschlüsseln.vb
                tools.data_encryption.Filedecrypt.wincrypttitle.Text = "file decrypt"
                tools.data_encryption.Filedecrypt.Text = "file decrypt"
                tools.data_encryption.Filedecrypt.filelb.Text = "file:"
                tools.data_encryption.Filedecrypt.pathlb.Text = "path:"
                tools.data_encryption.Filedecrypt.pwdlb.Text = "password:"
                tools.data_encryption.Filedecrypt.openfile.Text = "open"
                tools.data_encryption.Filedecrypt.savefile.Text = "safe as"
                tools.data_encryption.Filedecrypt.decrypt.Text = "decrypt"
                Startwindow.file_decrypt_bt_menu.Text = "file decrypt"

                'DateiVerschlüsseln.vb
                tools.data_encryption.Fileencrypt.wincrypttitle.Text = "file encrypt"
                tools.data_encryption.Fileencrypt.Text = "file encrypt"
                tools.data_encryption.Fileencrypt.filelb.Text = "file:"
                tools.data_encryption.Fileencrypt.pathlb.Text = "path:"
                tools.data_encryption.Fileencrypt.passwordlb.Text = "password:"
                tools.data_encryption.Fileencrypt.fileopenbt.Text = "open"
                tools.data_encryption.Fileencrypt.savefilebt.Text = "safe as"
                tools.data_encryption.Fileencrypt.encryptbt.Text = "encrypt"
                tools.data_encryption.Fileencrypt.generatebt.Text = "generate"
                Startwindow.file_encrypt_bt_menu.Text = "file encrypt"
                Startwindow.FileEncryptionToolStripMenuItem.Text = "file encryption"

                'main.vb
                tools.hash.converter.wincrypttitle.Text = "Converter"
                tools.hash.converter.Text = "Converter"
                tools.hash.converter.convert_bt.Text = "Convert"
                Startwindow.md5_converter_bt_menu.Text = "converter"

                'bruteforce.vb
                tools.hash.Bruteforce.passwordlist_lb.Text = "passwordlist:"
                tools.hash.Bruteforce.openWordlist.Text = "open"
                tools.hash.Bruteforce.showProgress.Text = "show progress"
                Startwindow.md5_bf_bt_menu.Text = "brute-force"

                'sendmail.vb
                tools.mail.Sendmail.wincrypttitle.Text = "send e-mail"
                tools.mail.Sendmail.Text = "send e-mail"
                tools.mail.Sendmail.email_lb.Text = "email:"
                tools.mail.Sendmail.password_lb.Text = "password:"
                tools.mail.Sendmail.server_lb.Text = "server:"
                tools.mail.Sendmail.emailto_lb.Text = "receiver:"
                tools.mail.Sendmail.fileadd_bt.Text = "add"
                tools.mail.Sendmail.fileadd_bt1.Text = "add"
                tools.mail.Sendmail.fileadd_bt2.Text = "add"
                tools.mail.Sendmail.fileadd_bt3.Text = "add"
                tools.mail.Sendmail.sendmail_bt.Text = "send"
                tools.mail.Sendmail.account_bt.Text = "delete account"
                tools.mail.Sendmail.rsa_open_bt.Text = "open"
                tools.mail.Sendmail.attachment_lb.Text = "attachment"
                tools.mail.Sendmail.attachment_lb1.Text = "attachment"
                tools.mail.Sendmail.attachment_lb2.Text = "attachment"
                tools.mail.Sendmail.attachment_lb3.Text = "attachment"
                tools.mail.Sendmail.subject_lb.Text = "subject"

                'passwordmanager.vb
                tools.passwordmanager.Passwordmanager.wincrypttitle.Text = "passwordmanager"
                tools.passwordmanager.Passwordmanager.Text = "passwordmanager"
                tools.passwordmanager.Passwordmanager.ColumnHeader1.Text = "user"
                tools.passwordmanager.Passwordmanager.ColumnHeader2.Text = "source"
                tools.passwordmanager.Passwordmanager.ColumnHeader3.Text = "index"
                tools.passwordmanager.Passwordmanager.delete_bt.Text = "delete"
                tools.passwordmanager.Passwordmanager.add_bt.Text = "add"
                tools.passwordmanager.Passwordmanager.user_lb.Text = "user:"
                tools.passwordmanager.Passwordmanager.password_lb.Text = "password:"
                tools.passwordmanager.Passwordmanager.source_lb.Text = "source:"
                tools.passwordmanager.Passwordmanager.comment_lb.Text = "comment"
                tools.passwordmanager.Passwordmanager.save_bt.Text = "save"
                tools.passwordmanager.Passwordmanager.copy_user_bt.Text = "copy"
                tools.passwordmanager.Passwordmanager.copy_source_bt.Text = "copy"
                tools.passwordmanager.Passwordmanager.copy_password_bt.Text = "copy"

                'newpwmgrdatabase.vb
                Newpwmgrdatabase.wincrypttitle.Text = "create database"
                Newpwmgrdatabase.Text = "create database"
                Newpwmgrdatabase.createdb_bt.Text = "create database"
                Newpwmgrdatabase.password_lb.Text = "password:"

                'Passwordmanager_add.vb
                tools.passwordmanager.passwordmanager_add.wincrypttitle.Text = "passwordmanager - add"
                tools.passwordmanager.passwordmanager_add.Text = "passwordmanager - add"
                tools.passwordmanager.passwordmanager_add.user_lb.Text = "user:"
                tools.passwordmanager.passwordmanager_add.password_lb.Text = "password:"
                tools.passwordmanager.passwordmanager_add.source_lb.Text = "source:"
                tools.passwordmanager.passwordmanager_add.comment_lb.Text = "comment"
                tools.passwordmanager.passwordmanager_add.add_bt.Text = "add"

                'passwordmgr_pass.vb
                tools.passwordmanager.passwordmgr_pass.wincrypttitle.Text = "passwordmanager - password"
                tools.passwordmanager.passwordmgr_pass.Text = "passwordmanager - password"
                tools.passwordmanager.passwordmgr_pass.password_lb.Text = "password:"

                'feedback.vb
                feedback.name_lb.Text = "name"
                feedback.email_lb.Text = "e-Mail"
                feedback.subject_lb.Text = "subject"
                Dim subitem0 As New ListBox
                subitem0.Items.Clear()
                feedback.subject_cb.Items.Clear()
                subitem0.Items.Add("error")
                subitem0.Items.Add("suggestion")
                subitem0.Items.Add("thanksgiving")
                subitem0.Items.Add("help")
                subitem0.Items.Add("other")
                For i = 0 To subitem0.Items.Count - 1
                    feedback.subject_cb.Items.Add(subitem0.Items.Item(i).ToString)
                Next
                feedback.message_lb.Text = "message"
                feedback.send_bt.Text = "send"


                'MD5fileHash.vb
                FileHash_frm.wincrypttitle.Text = "file checksum"
                FileHash_frm.file_lb.Text = "file:"
                FileHash_frm.md5_lb.Text = "Hash:"
                FileHash_frm.open_bt.Text = "open"
                FileHash_frm.copy_bt.Text = "copy"
                FileHash_frm.generate_bt.Text = "generate"

                Startwindow.MD5DateiChecksumToolStripMenuItem.Text = "file checksum"
                Startwindow.export_db_bt_menu.Text = "export database"
                Startwindow.import_db_bt_menu.Text = "import database"
                Startwindow.delete_db_menu.Text = "delete database"
                Startwindow.send_mail_bt_menu.Text = "send e-mail"


                Startwindow.exit_bt_systemtray.Text = "exit"
                Startwindow.open_bt_systemtray.Text = "open"
                Startwindow.tools_bt_systemtray.Text = "tools"
                Startwindow.update_bt_systemtray.Text = "update"
                Startwindow.feedback_bt_systemtray.Text = "feedback"
                Startwindow.about_bt_systemtray.Text = "about"
                Startwindow.file_encrypt__bt_systemtray.Text = "file encrypt"
                Startwindow.file_decrypt_bt_systemtray.Text = "file decrypt"
                Startwindow.text_encrypt_bt_systemtray.Text = "text de- and encrypt"
                Startwindow.converter_bt_systemtray.Text = "converter"
                Startwindow.bf_bt_systemtray.Text = "brute-force"
                Startwindow.file_checksum_systray.Text = "file checksum"
                Startwindow.rsa_encrypt_bt_systemtray.Text = "encrypt"
                Startwindow.rsa_decrypt_bt_systemtray.Text = "decrypt"
                Startwindow.rsa_create_keys_bt_systemtray.Text = "create key's"
                Startwindow.mail_bt_systemtray.Text = "e-mail"
                Startwindow.send_mail_bt_systemtray.Text = "send e-mail"
                Startwindow.pw_manager_bt_systemtray.Text = "passwordmanager"
                Startwindow.export_db_bt_systemtray.Text = "export database"
                Startwindow.import_db_bt_systemtray.Text = "import database"
                Startwindow.delete_db_bt_systemtray.Text = "delete database"
                Startwindow.systemidentification_bt_systemtray.Text = "systemidentification"
                Startwindow.pwg_bt_systemtray.Text = "passwordgenerator"
                Startwindow.file_delete_bt_systemtray.Text = "safe file delete"
            End If


            If lang.worthreading("Info", "Lang") = "German" Then 'DEUTSCH
                'rsa_encrypt.vb
                tools.rsa.rsa_encrypt.pubkey_path_bt.Text = "Öffnen"
                tools.rsa.rsa_encrypt.message_lb.Text = "Nachricht"
                tools.rsa.rsa_encrypt.encryption_message_lb.Text = "Verschlüsselte Nachricht"
                tools.rsa.rsa_encrypt.encryption_bt.Text = "Verschlüsseln"
                tools.rsa.rsa_encrypt.wincrypttitle.Text = "RSA Verschlüsselung"
                tools.rsa.rsa_encrypt.Text = "RSA Verschlüsselung"
                Startwindow.rsa_encrypt_bt_menu.Text = "Entschlüsseln"

                'rsa_decrypt.vb
                tools.rsa.rsa_decrypt.open_privkey_bt.Text = "Öffnen"
                tools.rsa.rsa_decrypt.encrypt_message_lb.Text = "Verschlüsselte Nachricht"
                tools.rsa.rsa_decrypt.message_lb.Text = "Nachricht"
                tools.rsa.rsa_decrypt.decrypt_bt.Text = "Entschlüsseln"
                tools.rsa.rsa_decrypt.wincrypttitle.Text = "RSA Entschlüsselung"
                tools.rsa.rsa_decrypt.Text = "RSA Entschlüsselung"

                'masterkey.vb
                Masterkey.abort_bt.Text = "Abbrechen"

                'rsa_create_keys.vb
                tools.rsa.rsa_create_keys.save_privkey_bt.Text = "Speichern unter"
                tools.rsa.rsa_create_keys.save_pubkey_bt.Text = "Speichern unter"
                tools.rsa.rsa_create_keys.generate_key_bt.Text = "Schlüssel generieren"
                tools.rsa.rsa_create_keys.save_bt.Text = "Speichern"
                tools.rsa.rsa_create_keys.wincrypttitle.Text = "RSA Schlüssel erstellen"
                tools.rsa.rsa_create_keys.Text = "RSA Schlüssel erstellen"

                'Form3
                Systemidentification.off_rb.Text = "Ausschalten"
                Systemidentification.on_rb.Text = "Einschalten"
                Systemidentification.wincrypttitle.Text = "Systemidentifikation"
                Systemidentification.Text = "Systemidentifikation"
                Systemidentification.systemidentification_lb.Text = "Systemidentifikation:" _
                                                                    & vbCrLf &
                                                                    "Die Systemidentifikation ermöglicht es das der Benutzer keine Passwörter" _
                                                                    & vbCrLf &
                                                                    "mehr eingeben braucht. Dies kann sehr sinnvoll sein wenn man sich Passwörter" _
                                                                    & vbCrLf &
                                                                    "nicht gut merken kann oder man möchte dass die verschlüsselte Datei/Ordner/-" _
                                                                    & vbCrLf &
                                                                    "Text/Datenträger nur von einem Computer geöffnet werden. Dies kann den Vorteil haben" _
                                                                    & vbCrLf &
                                                                    "wenn man einen USB Stick verliert, so können die Daten von niemanden geöffnet werden" _
                                                                    & vbCrLf &
                                                                    "außer dem Besitzer mit dem PC mit dem er die Daten verschlüsselt hat."

                'passwortgenerator.vb
                tools.passwordgenerator.passwordgenerator.wincrypttitle.Text = "WinCrypt - Passwortgenerator"
                tools.passwordgenerator.passwordgenerator.Text = "WinCrypt - Passwortgenerator"
                tools.passwordgenerator.passwordgenerator.uppercasecb.Text = "Großbuchstaben"
                tools.passwordgenerator.passwordgenerator.lowercasecb.Text = "Kleinbuchstaben"
                tools.passwordgenerator.passwordgenerator.numberscb.Text = "Zahlen"
                tools.passwordgenerator.passwordgenerator.length_lb.Text = "Länge:"
                tools.passwordgenerator.passwordgenerator.copybt.Text = "Kopieren"
                tools.passwordgenerator.passwordgenerator.generatebt.Text = "Generieren"
                tools.passwordgenerator.passwordgenerator.lines_lb.Text = "Zeilen:"
                tools.passwordgenerator.passwordgenerator.pw_length.Text = "Zeichen: "
                tools.passwordgenerator.passwordgenerator.saveas_bt.Text = "Speichern unter..."
                tools.passwordgenerator.passwordgenerator.attachments.Text = "Anhängen?"

                'safedelete.vb
                tools.safedelete.safedelete.Text = "Dateien sicher löschen"
                tools.safedelete.safedelete.selectpathbt.Text = "Auswählen"
                tools.safedelete.safedelete.filelb.Text = "Ordner:"
                tools.safedelete.safedelete.overwritelb.Text = "Überschreiben"
                tools.safedelete.safedelete.deletebt.Text = "Löschen"
                tools.safedelete.safedelete.fileaddbt.Text = "Datei hinzufügen"
                tools.safedelete.safedelete.removeentrybt.Text = "Eintrag entfernen"
                tools.safedelete.safedelete.wincrypttitle.Text = "Dateien sicher löschen"
                tools.safedelete.safedelete.Text = "Dateien sicher löschen"
                tools.safedelete.safedelete.abort_bt.Text = "Abbrechen"
                tools.safedelete.del_report.saveas_bt.Text = "Speichern unter..."
                tools.safedelete.safedelete.override_pb_lb.Text = "Überschrieben:"
                tools.safedelete.safedelete.statuslb.Text = "Status:"


                'textencrypt.vb
                tools.text_encryption.Textencrypt.encrypt_lb.Text = "Verschlüsseln"
                tools.text_encryption.Textencrypt.decrypt_lb.Text = "Entschlüsseln"
                tools.text_encryption.Textencrypt.text_input.Text = "Texteingabe"
                tools.text_encryption.Textencrypt.text_output.Text = "Textausgabe"
                tools.text_encryption.Textencrypt.password_lb.Text = "Passwort:"
                tools.text_encryption.Textencrypt.generate_bt.Text = "Generieren"
                tools.text_encryption.Textencrypt.decrypt_bt.Text = "Entschlüsseln"
                tools.text_encryption.Textencrypt.encrypt_bt.Text = "Verschlüsseln"
                tools.text_encryption.Textencrypt.wincrypttitle.Text = "Text ver- und entschlüsseln"
                tools.text_encryption.Textencrypt.Text = "Text ver- und entschlüsseln"
                Startwindow.text_encrypt_bt_menu.Text = "Text ver- und entschlüsseln"


                'DateiEntschlüsseln.vb
                tools.data_encryption.Filedecrypt.wincrypttitle.Text = "Datei entschlüsseln"
                tools.data_encryption.Filedecrypt.Text = "Datei entschlüsseln"
                tools.data_encryption.Filedecrypt.filelb.Text = "Datei:"
                tools.data_encryption.Filedecrypt.pathlb.Text = "Pfad:"
                tools.data_encryption.Filedecrypt.pwdlb.Text = "Passwort:"
                tools.data_encryption.Filedecrypt.openfile.Text = "Öffnen"
                tools.data_encryption.Filedecrypt.savefile.Text = "Speichern unter..."
                tools.data_encryption.Filedecrypt.decrypt.Text = "Entschlüsseln"

                'DateiVerschlüsseln.vb
                tools.data_encryption.Fileencrypt.wincrypttitle.Text = "Datei verschlüsseln"
                tools.data_encryption.Fileencrypt.Text = "Datei verschlüsseln"
                tools.data_encryption.Fileencrypt.filelb.Text = "Datei:"
                tools.data_encryption.Fileencrypt.pathlb.Text = "Pfad:"
                tools.data_encryption.Fileencrypt.passwordlb.Text = "Passwort:"
                tools.data_encryption.Fileencrypt.fileopenbt.Text = "Öffnen"
                tools.data_encryption.Fileencrypt.savefilebt.Text = "Speichern unter..."
                tools.data_encryption.Fileencrypt.encryptbt.Text = "Verschlüsseln"
                tools.data_encryption.Fileencrypt.generatebt.Text = "Generieren"
                Startwindow.FileEncryptionToolStripMenuItem.Text = "Dateiverschlüsselung"

                'Einstellung.vb
                WcSetting.wincrypttitle.Text = "Einstellung"
                WcSetting.Text = "Einstellung"
                WcSetting.registfiletypegb.Text = "Dateitypen registrieren"
                WcSetting.registfiletype.Text = "Registrieren"
                WcSetting.languagegb.Text = "Sprache"
                WcSetting.startwincb.Text = "mit Windows starten"
                WcSetting.startminwincryptrb.Text = "minimiert starten"
                WcSetting.startnormalwincrypt.Text = "normal starten"
                WcSetting.key_cb.Text = "Einschalten"
                langname = lang.worthreading("Info", "Lang")
                WcSetting.bgcolor_lb.Text = "Hintergrund"
                WcSetting.formhead_color_lb.Text = "Form Head"
                WcSetting.inputbackground_lb.Text = "Eingabe Hintergrund"
                WcSetting.buttoncolor_lb.Text = "Schaltfläche"
                WcSetting.textcolor_lb.Text = "Text"
                WcSetting.inputtextcolor_lb.Text = "Eingabe Text"
                WcSetting.design_export.Text = "Design exportieren"
                WcSetting.design_import.Text = "Design importieren"
                WcSetting.standard_restore_bt.Text = "Standard wiederherstellen"

                'md5_main.vb
                tools.hash.converter.wincrypttitle.Text = "Konverter"
                tools.hash.converter.Text = "Konverter"
                tools.hash.converter.convert_bt.Text = "Konvertieren"
                Startwindow.md5_converter_bt_menu.Text = "Konvertieren"

                'md5_bruteforce.vb
                tools.hash.Bruteforce.passwordlist_lb.Text = "Passwortliste:"
                tools.hash.Bruteforce.openWordlist.Text = "Öffnen"
                tools.hash.Bruteforce.showProgress.Text = "Zeige Fortschritt an"
                Startwindow.md5_bf_bt_menu.Text = "Brute-force"

                'sendmail.vb
                tools.mail.Sendmail.wincrypttitle.Text = "E-Mail senden"
                tools.mail.Sendmail.Text = "E-Mail senden"
                tools.mail.Sendmail.email_lb.Text = "E-Mail:"
                tools.mail.Sendmail.password_lb.Text = "Passwort:"
                tools.mail.Sendmail.server_lb.Text = "Server:"
                tools.mail.Sendmail.emailto_lb.Text = "Empfänger:"
                tools.mail.Sendmail.fileadd_bt.Text = "Hinzufügen"
                tools.mail.Sendmail.fileadd_bt1.Text = "Hinzufügen"
                tools.mail.Sendmail.fileadd_bt2.Text = "Hinzufügen"
                tools.mail.Sendmail.fileadd_bt3.Text = "Hinzufügen"
                tools.mail.Sendmail.sendmail_bt.Text = "Senden"
                tools.mail.Sendmail.account_bt.Text = "Konto entfernen"
                tools.mail.Sendmail.rsa_open_bt.Text = "Öffnen"
                tools.mail.Sendmail.attachment_lb.Text = "Anhang"
                tools.mail.Sendmail.attachment_lb1.Text = "Anhang"
                tools.mail.Sendmail.attachment_lb2.Text = "Anhang"
                tools.mail.Sendmail.attachment_lb3.Text = "Anhang"
                tools.mail.Sendmail.subject_lb.Text = "Betreff:"

                'passwordmanager.vb
                tools.passwordmanager.Passwordmanager.wincrypttitle.Text = "Passwortmanager"
                tools.passwordmanager.Passwordmanager.Text = "Passwortmanager"
                tools.passwordmanager.Passwordmanager.ColumnHeader1.Text = "Benutzer"
                tools.passwordmanager.Passwordmanager.ColumnHeader2.Text = "Quelle"
                tools.passwordmanager.Passwordmanager.ColumnHeader3.Text = "Index"
                tools.passwordmanager.Passwordmanager.delete_bt.Text = "Löschen"
                tools.passwordmanager.Passwordmanager.add_bt.Text = "Hinzufügen"
                tools.passwordmanager.Passwordmanager.user_lb.Text = "Benutzer:"
                tools.passwordmanager.Passwordmanager.password_lb.Text = "Passwort:"
                tools.passwordmanager.Passwordmanager.source_lb.Text = "Quelle:"
                tools.passwordmanager.Passwordmanager.comment_lb.Text = "Kommentar"
                tools.passwordmanager.Passwordmanager.save_bt.Text = "Speichern"
                tools.passwordmanager.Passwordmanager.copy_user_bt.Text = "Kopieren"
                tools.passwordmanager.Passwordmanager.copy_source_bt.Text = "Kopieren"
                tools.passwordmanager.Passwordmanager.copy_password_bt.Text = "Kopieren"

                'newpwmgrdatabase.vb
                Newpwmgrdatabase.wincrypttitle.Text = "Datenbank erstellen"
                Newpwmgrdatabase.Text = "Datenbank erstellen"
                Newpwmgrdatabase.createdb_bt.Text = "Datenbank erstellen"
                Newpwmgrdatabase.password_lb.Text = "Passwort:"

                'Passwordmanager_add.vb
                tools.passwordmanager.passwordmanager_add.wincrypttitle.Text = "Passwortmanager - Hinzufügen"
                tools.passwordmanager.passwordmanager_add.Text = "Passwortmanager - Hinzufügen"
                tools.passwordmanager.passwordmanager_add.user_lb.Text = "Benutzer:"
                tools.passwordmanager.passwordmanager_add.password_lb.Text = "Passwort:"
                tools.passwordmanager.passwordmanager_add.source_lb.Text = "Quelle:"
                tools.passwordmanager.passwordmanager_add.comment_lb.Text = "Kommentar"
                tools.passwordmanager.passwordmanager_add.add_bt.Text = "Hinzufügen"

                'passwordmgr_pass.vb
                tools.passwordmanager.passwordmgr_pass.wincrypttitle.Text = "Passwortmanager - Passwort"
                tools.passwordmanager.passwordmgr_pass.Text = "Passwortmanager - Passwort"
                tools.passwordmanager.passwordmgr_pass.password_lb.Text = "Passwort:"

                'feedback.vb
                feedback.name_lb.Text = "Name"
                feedback.email_lb.Text = "E-Mail"
                feedback.subject_lb.Text = "Betreff"
                Dim subitem0 As New ListBox
                subitem0.Items.Clear()
                feedback.subject_cb.Items.Clear()
                subitem0.Items.Add("Fehler")
                subitem0.Items.Add("Verbesserungsvorschlag")
                subitem0.Items.Add("Danksagung")
                subitem0.Items.Add("Hilfe")
                subitem0.Items.Add("anderes")
                For i = 0 To subitem0.Items.Count - 1
                    feedback.subject_cb.Items.Add(subitem0.Items.Item(i).ToString)
                Next
                feedback.message_lb.Text = "Nachricht"
                feedback.send_bt.Text = "Senden"

                'MD5fileHash.vb
                FileHash_frm.wincrypttitle.Text = "Datei checksum"
                FileHash_frm.file_lb.Text = "Datei:"
                FileHash_frm.md5_lb.Text = "Hash:"
                FileHash_frm.open_bt.Text = "Öffnen"
                FileHash_frm.copy_bt.Text = "Kopieren"
                FileHash_frm.generate_bt.Text = "Generieren"

                Startwindow.MD5DateiChecksumToolStripMenuItem.Text = "Datei checksum"
                Startwindow.file_checksum_systray.Text = "Datei checksum"
                Startwindow.export_db_bt_menu.Text = "Datenbank exportieren"
                Startwindow.import_db_bt_menu.Text = "Datenbank importieren"
                Startwindow.delete_db_menu.Text = "Datenbank löschen"
                Startwindow.send_mail_bt_menu.Text = "E-Mail senden"

                Startwindow.exit_bt_systemtray.Text = "Beenden"
                Startwindow.open_bt_systemtray.Text = "Öffnen"
                Startwindow.tools_bt_systemtray.Text = "Tools"
                Startwindow.update_bt_systemtray.Text = "Update"
                Startwindow.feedback_bt_systemtray.Text = "Feedback"
                Startwindow.about_bt_systemtray.Text = "About"
                Startwindow.file_encrypt__bt_systemtray.Text = "Datei verschlüsseln"
                Startwindow.file_decrypt_bt_systemtray.Text = "Datei entschlüsseln"
                Startwindow.text_encrypt_bt_systemtray.Text = "Text ver- und entschlüsseln"
                Startwindow.converter_bt_systemtray.Text = "Konverter"
                Startwindow.bf_bt_systemtray.Text = "Brute-force"
                Startwindow.file_checksum_systray.Text = "Datei checksum"
                Startwindow.rsa_encrypt_bt_systemtray.Text = "Verschlüsseln"
                Startwindow.rsa_decrypt_bt_systemtray.Text = "Entschlüsseln"
                Startwindow.rsa_create_keys_bt_systemtray.Text = "Schlüssel erstellen"
                Startwindow.mail_bt_systemtray.Text = "E-Mail"
                Startwindow.send_mail_bt_systemtray.Text = "E-Mail senden"
                Startwindow.pw_manager_bt_systemtray.Text = "Passwortmanager"
                Startwindow.export_db_bt_systemtray.Text = "Datenbank exportieren"
                Startwindow.import_db_bt_systemtray.Text = "Datenbank importieren"
                Startwindow.delete_db_bt_systemtray.Text = "Datenbank löschen"
                Startwindow.systemidentification_bt_systemtray.Text = "Systemidentifikation"
                Startwindow.pwg_bt_systemtray.Text = "Passwortgenerator"
                Startwindow.file_delete_bt_systemtray.Text = "Dateien sicher löschen"
            End If
        End Sub
    End Class
End Namespace