Public Class language
    Public langname As String
    Public Sub check()
        Dim root As New System.IO.DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)
        Dim lang As New INIDatei(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\config.ini")
        If lang.WertLesen("Info", "Lang") = "English" Then 'ENGLISH
            startwindow.encrypt_gb.Text = "encrypt folder / drive"
            startwindow.crypt_file_pathbutton.Text = "add"
            startwindow.generate_key_encrypt.Text = "generate"
            startwindow.create_container_encrypt.Text = "create container"
            startwindow.path_encrypt.Text = "path:"
            startwindow.Label2.Text = "key:"
            startwindow.mount_gb.Text = "mount cryptfile"
            startwindow.Label3.Text = "file:"
            startwindow.opencryptfile.Text = "open"
            startwindow.key_lb.Text = "key:"
            startwindow.drive_lb.Text = "drive:"

            startwindow.DateiToolStripMenuItem1.Text = "file"
            startwindow.EinstellungToolStripMenuItem1.Text = "setting"
            startwindow.BeendenToolStripMenuItem2.Text = "exit"
            startwindow.ToolsToolStripMenuItem2.Text = "tools"
            startwindow.DateiVerschlüsselnToolStripMenuItem2.Text = "file encrypt"
            startwindow.DateiEntschlüsselnToolStripMenuItem2.Text = "file decrypt"
            startwindow.TextVerUndEntschlüsselnToolStripMenuItem1.Text = "text de- and encrypt"
            startwindow.MD5KonverterToolStripMenuItem2.Text = "MD5 converter"
            startwindow.VerschlüsselungToolStripMenuItem.Text = "encryption"
            startwindow.EntschlüsselungToolStripMenuItem.Text = "decryption"
            startwindow.SchlüsselErstellenToolStripMenuItem1.Text = "create key's"
            startwindow.EMailSendenToolStripMenuItem2.Text = "send e-mail"
            startwindow.PasswortmanagerToolStripMenuItem2.Text = "passwordmanager"
            startwindow.DatenbankExportierenToolStripMenuItem2.Text = "export database"
            startwindow.DatenbankImportierenToolStripMenuItem2.Text = "import database"
            startwindow.DatenbankLöschenToolStripMenuItem2.Text = "delete database"
            startwindow.SystemidentifikationToolStripMenuItem2.Text = "systemidentification"
            startwindow.PasswortgeneratorToolStripMenuItem2.Text = "passwordgenerator"
            startwindow.DateienSicherLöschenToolStripMenuItem1.Text = "delete files safetly"
            startwindow.InfoToolStripMenuItem1.Text = "info"
            startwindow.UpdateToolStripMenuItem2.Text = "update"
            startwindow.FeedbackToolStripMenuItem2.Text = "feedback"
            startwindow.AboutToolStripMenuItem2.Text = "about"

            startwindow.AboutToolStripMenuItem1.Text = "about"
            startwindow.FeedbackToolStripMenuItem1.Text = "feedback"
            startwindow.UpdateToolStripMenuItem1.Text = "update"
            startwindow.ToolsToolStripMenuItem1.Text = "tools"
            startwindow.ÖffnenToolStripMenuItem.Text = "open"
            startwindow.BeendenToolStripMenuItem1.Text = "exit"
            startwindow.DateiVerschlüsselnToolStripMenuItem3.Text = "file encrypt"
            startwindow.DateiEntschlüsselnToolStripMenuItem3.Text = "file decrypt"
            startwindow.TextVerUndEntschlüsselnToolStripMenuItem2.Text = "text en- and decrypt"
            startwindow.MD5KonverterToolStripMenuItem3.Text = "MD5 converter"
            startwindow.EntschlüsselnToolStripMenuItem2.Text = "decryption"
            startwindow.VerschlüsselnToolStripMenuItem2.Text = "decryption"
            startwindow.SchlüsselErstellenToolStripMenuItem2.Text = "create key's"
            startwindow.EMailSendenToolStripMenuItem3.Text = "send e-mail"
            startwindow.PasswortmanagerToolStripMenuItem3.Text = "passwordmanager"
            startwindow.DatenbankExportierenToolStripMenuItem3.Text = "export database"
            startwindow.DatenbankImportierenToolStripMenuItem3.Text = "import database"
            startwindow.DatenbankLöschenToolStripMenuItem3.Text = "delete database"
            startwindow.SystemidentifikationToolStripMenuItem3.Text = "systemidentification"
            startwindow.PasswortgeneratorToolStripMenuItem3.Text = "passwordgenerator"
            startwindow.DateienSicherLöschenToolStripMenuItem2.Text = "delete files safetly"


            'masterkey.vb
            masterkey.abort_bt.Text = "abort"

            'rsa_encrypt.vb
            rsa_encrypt.pubkey_path_bt.Text = "open"
            rsa_encrypt.message_lb.Text = "message"
            rsa_encrypt.encryption_message_lb.Text = "encryption message"
            rsa_encrypt.encryption_bt.Text = "encrypt"
            rsa_encrypt.wincrypttitle.Text = "RSA Encrypt"

            'rsa_decrypt.vb
            rsa_decrypt.open_privkey_bt.Text = "open"
            rsa_decrypt.encrypt_message_lb.Text = "encryption message"
            rsa_decrypt.message_lb.Text = "message"
            rsa_decrypt.decrypt_bt.Text = "decrypt"
            rsa_decrypt.wincrypttitle.Text = "RSA Decrypt"

            'rsa_create_keys.vb
            rsa_create_keys.save_privkey_bt.Text = "save as"
            rsa_create_keys.save_pubkey_bt.Text = "save as"
            rsa_create_keys.generate_key_bt.Text = "generate keys"
            rsa_create_keys.save_bt.Text = "save"
            rsa_create_keys.wincrypttitle.Text = "RSA create key's"

            'Form3
            systemidentification.off_rb.Text = "off"
            systemidentification.on_rb.Text = "on"
            systemidentification.wincrypttitle.Text = "system identification"
            systemidentification.Label1.Text = "The system identification allows the user passwords" _
                & vbCrLf & "more needs to enter. This can be very useful if you passwords to" _
                & vbCrLf & "can not remember well or you want the encrypted file / folder / -" _
                & vbCrLf & "Text / data carrier only be opened by a computer. This may have the advantage" _
                & vbCrLf & "if you lose a USB stick, so the data can be opened by anyone" _
                & vbCrLf & "other than the owner of the PC with which it encrypted the data."

            'passwortgenerator.vb
            passwordgenerator.wincrypttitle.Text = "WinCrypt - passwordgenerator"
            passwordgenerator.uppercasecb.Text = "uppercase"
            passwordgenerator.lowercasecb.Text = "lower case"
            passwordgenerator.numberscb.Text = "numbers"
            passwordgenerator.lengthlb.Text = "length:"
            passwordgenerator.copybt.Text = "copy"
            passwordgenerator.generatebt.Text = "generate"

            'safedelete.vb
            safedelete.selectpathbt.Text = "select"
            safedelete.filelb.Text = "Path:"
            safedelete.overwritelb.Text = "overwrite"
            safedelete.generatebytelb.Text = "generated bytes:"
            safedelete.deletebt.Text = "delete"
            safedelete.fileaddbt.Text = "add file"
            safedelete.removeentrybt.Text = "remove entry"
            safedelete.wincrypttitle.Text = "safe delete"

            'textencrypt.vb
            textencrypt.encrypt_lb.Text = "encypt"
            textencrypt.decrypt_lb.Text = "decrypt"
            textencrypt.text_input.Text = "text entry"
            textencrypt.text_output.Text = "text output"
            textencrypt.password_lb.Text = "password:"
            textencrypt.generate_bt.Text = "generate"
            textencrypt.decrypt_bt.Text = "decrypt"
            textencrypt.encrypt_bt.Text = "encrypt"
            textencrypt.wincrypttitle.Text = "Text en- and decrypt"

            'DateiEntschlüsseln.vb
            filedecrypt.wincrypttitle.Text = "file decrypt"
            filedecrypt.filelb.Text = "file:"
            filedecrypt.pathlb.Text = "path:"
            filedecrypt.pwdlb.Text = "password:"
            filedecrypt.openfile.Text = "open"
            filedecrypt.savefile.Text = "safe as"
            filedecrypt.dencrypt.Text = "decrypt"

            'DateiVerschlüsseln.vb

            fileencrypt.wincrypttitle.Text = "file encrypt"
            fileencrypt.filelb.Text = "file:"
            fileencrypt.pathlb.Text = "path:"
            fileencrypt.passwordlb.Text = "password:"
            fileencrypt.fileopenbt.Text = "open"
            fileencrypt.savefilebt.Text = "safe as"
            fileencrypt.encryptbt.Text = "encrypt"
            fileencrypt.generatebt.Text = "generate"

            'Einstellung.vb
            wcSetting.wincrypttitle.Text = "setting"
            wcSetting.registfiletypegb.Text = "register WinCrypt file types"
            wcSetting.registfiletype.Text = "regist"
            wcSetting.languagegb.Text = "language"
            wcSetting.startwincb.Text = "WinCrypt start with Windows"
            wcSetting.startminwincryptrb.Text = "Start minimized WinCrypt"
            wcSetting.startnormalwincrypt.Text = "Start WinCrypt normal"
            wcSetting.key_cb.Text = "On"
            langname = lang.WertLesen("Info", "Lang")

            'md5_main.vb
            converter.wincrypttitle.Text = "MD5 Converter"
            converter.convert_bt.Text = "Convert"

            'md5_bruteforce.vb
            bruteforce.passwordlist_lb.Text = "passwordlist:"
            bruteforce.openWordlist.Text = "open"
            bruteforce.showProgress.Text = "show progress"

            'sendmail.vb
            sendmail.wincrypttitle.Text = "send e-mail"
            sendmail.email_lb.Text = "email:"
            sendmail.password_lb.Text = "password:"
            sendmail.server_lb.Text = "server:"
            sendmail.emailto_lb.Text = "receiver:"
            sendmail.fileadd_bt.Text = "add"
            sendmail.fileadd_bt1.Text = "add"
            sendmail.fileadd_bt2.Text = "add"
            sendmail.fileadd_bt3.Text = "add"
            sendmail.sendmail_bt.Text = "send"
            sendmail.account_bt.Text = "delete account"
            sendmail.rsa_open_bt.Text = "open"
            sendmail.attachment_lb.Text = "attachment"
            sendmail.attachment_lb1.Text = "attachment"
            sendmail.attachment_lb2.Text = "attachment"
            sendmail.attachment_lb3.Text = "attachment"

            'passwordmanager.vb
            passwordmanager.wincrypttitle.Text = "passwordmanager"
            passwordmanager.ColumnHeader1.Text = "user"
            passwordmanager.ColumnHeader2.Text = "source"
            passwordmanager.ColumnHeader3.Text = "index"
            passwordmanager.delete_bt.Text = "delete"
            passwordmanager.add_bt.Text = "add"
            passwordmanager.user_lb.Text = "user:"
            passwordmanager.password_lb.Text = "password:"
            passwordmanager.source_lb.Text = "source:"
            passwordmanager.comment_lb.Text = "comment"
            passwordmanager.save_bt.Text = "save"
            passwordmanager.copy_user_bt.Text = "copy"
            passwordmanager.copy_source_bt.Text = "copy"
            passwordmanager.copy_password_bt.Text = "copy"

            'newpwmgrdatabase.vb
            newpwmgrdatabase.wincrypttitle.Text = "create database"
            newpwmgrdatabase.createdb_bt.Text = "create database"
            newpwmgrdatabase.password_lb.Text = "password:"

            'Passwordmanager_add.vb
            passwordmanager_add.wincrypttitle.Text = "passwordmanager - add"
            passwordmanager_add.user_lb.Text = "user:"
            passwordmanager_add.password_lb.Text = "password:"
            passwordmanager_add.source_lb.Text = "source:"
            passwordmanager_add.comment_lb.Text = "comment"
            passwordmanager_add.add_bt.Text = "add"

            'passwordmgr_pass.vb
            passwordmgr_pass.wincrypttitle.Text = "passwordmanager - password"
            passwordmgr_pass.password_lb.Text = "password:"
        End If



        If lang.WertLesen("Info", "Lang") = "German" Then 'DEUTSCH
            startwindow.encrypt_gb.Text = "Ordner/Laufwerk Verschlüsseln"
            startwindow.crypt_file_pathbutton.Text = "Hinzufügen"
            startwindow.generate_key_encrypt.Text = "Generieren"
            startwindow.create_container_encrypt.Text = "Container erstellen"
            startwindow.path_encrypt.Text = "Pfad:"
            startwindow.Label2.Text = "Schlüssel:"
            startwindow.mount_gb.Text = "Cryptdatei Mounten"
            startwindow.Label3.Text = "Datei:"
            startwindow.opencryptfile.Text = "Öffnen"
            startwindow.key_lb.Text = "Schlüssel:"
            startwindow.drive_lb.Text = "Laufwerk:"

            startwindow.DateiToolStripMenuItem1.Text = "Datei"
            startwindow.EinstellungToolStripMenuItem1.Text = "Einstellung"
            startwindow.BeendenToolStripMenuItem2.Text = "Beenden"
            startwindow.ToolsToolStripMenuItem2.Text = "Tools"
            startwindow.DateiVerschlüsselnToolStripMenuItem2.Text = "Datei verschlüsseln"
            startwindow.DateiEntschlüsselnToolStripMenuItem2.Text = "Datei entschlüsseln"
            startwindow.TextVerUndEntschlüsselnToolStripMenuItem1.Text = "Text ver- und entschlüsseln"
            startwindow.MD5KonverterToolStripMenuItem2.Text = "MD5 Konverter"
            startwindow.VerschlüsselungToolStripMenuItem.Text = "Verschlüsselung"
            startwindow.EntschlüsselungToolStripMenuItem.Text = "Entschlüsselung"
            startwindow.SchlüsselErstellenToolStripMenuItem1.Text = "Schlüssel erstellen"
            startwindow.EMailSendenToolStripMenuItem2.Text = "E-Mail senden"
            startwindow.PasswortmanagerToolStripMenuItem2.Text = "Passwortmanager"
            startwindow.DatenbankExportierenToolStripMenuItem2.Text = "Datenbank exportieren"
            startwindow.DatenbankImportierenToolStripMenuItem2.Text = "Datenbank importieren"
            startwindow.DatenbankLöschenToolStripMenuItem2.Text = "Datenbank löschen"
            startwindow.SystemidentifikationToolStripMenuItem2.Text = "Systemidentifikation"
            startwindow.PasswortgeneratorToolStripMenuItem2.Text = "Passwortgenerator"
            startwindow.DateienSicherLöschenToolStripMenuItem1.Text = "Dateien sicher löschen"
            startwindow.InfoToolStripMenuItem1.Text = "Info"
            startwindow.UpdateToolStripMenuItem2.Text = "Update"
            startwindow.FeedbackToolStripMenuItem2.Text = "Feedback"
            startwindow.AboutToolStripMenuItem2.Text = "About"

            startwindow.AboutToolStripMenuItem1.Text = "About"
            startwindow.FeedbackToolStripMenuItem1.Text = "Feedback"
            startwindow.UpdateToolStripMenuItem1.Text = "Update"
            startwindow.ToolsToolStripMenuItem1.Text = "Tools"
            startwindow.ÖffnenToolStripMenuItem.Text = "Öffnen"
            startwindow.BeendenToolStripMenuItem1.Text = "Beenden"
            startwindow.DateiVerschlüsselnToolStripMenuItem3.Text = "Datei verschlüsseln"
            startwindow.DateiEntschlüsselnToolStripMenuItem3.Text = "Datei entschlüsseln"
            startwindow.TextVerUndEntschlüsselnToolStripMenuItem2.Text = "Text ver- und entschlüsseln"
            startwindow.MD5KonverterToolStripMenuItem3.Text = "MD5 Konverter"
            startwindow.EntschlüsselnToolStripMenuItem2.Text = "Entschlüsselung"
            startwindow.VerschlüsselnToolStripMenuItem2.Text = "Verschlüsselung"
            startwindow.SchlüsselErstellenToolStripMenuItem2.Text = "Schlüssel erstellen"
            startwindow.EMailSendenToolStripMenuItem3.Text = "E-Mail senden"
            startwindow.PasswortmanagerToolStripMenuItem3.Text = "Passwortmanager"
            startwindow.DatenbankExportierenToolStripMenuItem3.Text = "Datenbank exportieren"
            startwindow.DatenbankImportierenToolStripMenuItem3.Text = "Datenbank importieren"
            startwindow.DatenbankLöschenToolStripMenuItem3.Text = "Datenbank löschen"
            startwindow.SystemidentifikationToolStripMenuItem3.Text = "Systemidentifikation"
            startwindow.PasswortgeneratorToolStripMenuItem3.Text = "Passwortgenerator"
            startwindow.DateienSicherLöschenToolStripMenuItem2.Text = "Dateien sicher löschen"

            'rsa_encrypt.vb
            rsa_encrypt.pubkey_path_bt.Text = "Öffnen"
            rsa_encrypt.message_lb.Text = "Nachricht"
            rsa_encrypt.encryption_message_lb.Text = "Verschlüsselte Nachricht"
            rsa_encrypt.encryption_bt.Text = "Verschlüsseln"
            rsa_encrypt.wincrypttitle.Text = "RSA Verschlüsselung"

            'rsa_decrypt.vb
            rsa_decrypt.open_privkey_bt.Text = "Öffnen"
            rsa_decrypt.encrypt_message_lb.Text = "Verschlüsselte Nachricht"
            rsa_decrypt.message_lb.Text = "Nachricht"
            rsa_decrypt.decrypt_bt.Text = "Entschlüsseln"
            rsa_decrypt.wincrypttitle.Text = "RSA Entschlüsselung"

            'masterkey.vb
            masterkey.abort_bt.Text = "Abbrechen"

            'rsa_create_keys.vb
            rsa_create_keys.save_privkey_bt.Text = "Speichern unter"
            rsa_create_keys.save_pubkey_bt.Text = "Speichern unter"
            rsa_create_keys.generate_key_bt.Text = "Schlüssel generieren"
            rsa_create_keys.save_bt.Text = "Speichern"
            rsa_create_keys.wincrypttitle.Text = "RSA Schlüssel erstellen"

            'Form3
            systemidentification.off_rb.Text = "Ausschalten"
            systemidentification.on_rb.Text = "Einschalten"
            systemidentification.wincrypttitle.Text = "Systemidentifikation"
            systemidentification.Label1.Text = "Systemidentifikation:" _
                & vbCrLf & "Die Systemidentifikation ermöglicht es das der Benutzer keine Passwörter" _
                & vbCrLf & "mehr eingeben braucht. Dies kann sehr sinnvoll sein wenn man sich Passwörter" _
                & vbCrLf & "nicht gut merken kann oder man möchte dass die verschlüsselte Datei/Ordner/-" _
                & vbCrLf & "Text/Datenträger nur von einem Computer geöffnet werden. Dies kann den Vorteil haben" _
                & vbCrLf & "wenn man einen USB Stick verliert, so können die Daten von niemanden geöffnet werden" _
                & vbCrLf & "außer dem Besitzer mit dem PC mit dem er die Daten verschlüsselt hat."

            'passwortgenerator.vb
            passwordgenerator.wincrypttitle.Text = "WinCrypt - Passwortgenerator"
            passwordgenerator.uppercasecb.Text = "Großbuchstaben"
            passwordgenerator.lowercasecb.Text = "Kleinbuchstaben"
            passwordgenerator.numberscb.Text = "Zahlen"
            passwordgenerator.lengthlb.Text = "Länge:"
            passwordgenerator.copybt.Text = "Kopieren"
            passwordgenerator.generatebt.Text = "Generieren"

            'safedelete.vb
            safedelete.selectpathbt.Text = "Auswählen"
            safedelete.filelb.Text = "Ordner:"
            safedelete.overwritelb.Text = "Überschreiben"
            safedelete.generatebytelb.Text = "Generierte bytes:"
            safedelete.deletebt.Text = "Löschen"
            safedelete.fileaddbt.Text = "Datei hinzufügen"
            safedelete.removeentrybt.Text = "Eintrag entfernen"
            safedelete.wincrypttitle.Text = "Dateien sicher löschen"


            'textencrypt.vb
            textencrypt.encrypt_lb.Text = "Verschlüsseln"
            textencrypt.decrypt_lb.Text = "Entschlüsseln"
            textencrypt.text_input.Text = "Texteingabe"
            textencrypt.text_output.Text = "Textausgabe"
            textencrypt.password_lb.Text = "Passwort:"
            textencrypt.generate_bt.Text = "Generieren"
            textencrypt.decrypt_bt.Text = "Entschlüsseln"
            textencrypt.encrypt_bt.Text = "Verschlüsseln"
            textencrypt.wincrypttitle.Text = "Text ver- und entschlüsseln"

            'DateiEntschlüsseln.vb
            filedecrypt.wincrypttitle.Text = "Datei entschlüsseln"
            filedecrypt.filelb.Text = "Datei:"
            filedecrypt.pathlb.Text = "Pfad:"
            filedecrypt.pwdlb.Text = "Passwort:"
            filedecrypt.openfile.Text = "Öffnen"
            filedecrypt.savefile.Text = "Speichern unter..."
            filedecrypt.dencrypt.Text = "Entschlüsseln"

            'DateiVerschlüsseln.vb

            fileencrypt.wincrypttitle.Text = "Datei verschlüsseln"
            fileencrypt.filelb.Text = "Datei:"
            fileencrypt.pathlb.Text = "Pfad:"
            fileencrypt.passwordlb.Text = "Passwort:"
            fileencrypt.fileopenbt.Text = "Öffnen"
            fileencrypt.savefilebt.Text = "Speichern unter..."
            fileencrypt.encryptbt.Text = "Verschlüsseln"
            fileencrypt.generatebt.Text = "Generieren"

            'Einstellung.vb
            wcSetting.wincrypttitle.Text = "Einstellung"
            wcSetting.registfiletypegb.Text = "WinCrypt Dateitypen registrieren"
            wcSetting.registfiletype.Text = "Registrieren"
            wcSetting.languagegb.Text = "Sprache"
            wcSetting.startwincb.Text = "WinCrypt mit Windows starten"
            wcSetting.startminwincryptrb.Text = "WinCrypt minimiert starten"
            wcSetting.startnormalwincrypt.Text = "WinCrypt normal starten"
            wcSetting.key_cb.Text = "Einschalten"
            langname = lang.WertLesen("Info", "Lang")

            'md5_main.vb
            converter.wincrypttitle.Text = "MD5 Konverter"
            converter.convert_bt.Text = "Konvertieren"

            'md5_bruteforce.vb
            bruteforce.passwordlist_lb.Text = "Passwortliste:"
            bruteforce.openWordlist.Text = "Öffnen"
            bruteforce.showProgress.Text = "Zeige Fortschritt an"

            'sendmail.vb
            sendmail.wincrypttitle.Text = "E-Mail senden"
            sendmail.email_lb.Text = "E-Mail:"
            sendmail.password_lb.Text = "Passwort:"
            sendmail.server_lb.Text = "Server:"
            sendmail.emailto_lb.Text = "Empfänger:"
            sendmail.fileadd_bt.Text = "Hinzufügen"
            sendmail.fileadd_bt1.Text = "Hinzufügen"
            sendmail.fileadd_bt2.Text = "Hinzufügen"
            sendmail.fileadd_bt3.Text = "Hinzufügen"
            sendmail.sendmail_bt.Text = "Senden"
            sendmail.account_bt.Text = "Konto entfernen"
            sendmail.rsa_open_bt.Text = "Öffnen"
            sendmail.attachment_lb.Text = "Anhang"
            sendmail.attachment_lb1.Text = "Anhang"
            sendmail.attachment_lb2.Text = "Anhang"
            sendmail.attachment_lb3.Text = "Anhang"

            'passwordmanager.vb
            passwordmanager.wincrypttitle.Text = "Passwortmanager"
            passwordmanager.ColumnHeader1.Text = "Benutzer"
            passwordmanager.ColumnHeader2.Text = "Quelle"
            passwordmanager.ColumnHeader3.Text = "Index"
            passwordmanager.delete_bt.Text = "Löschen"
            passwordmanager.add_bt.Text = "Hinzufügen"
            passwordmanager.user_lb.Text = "Benutzer:"
            passwordmanager.password_lb.Text = "Passwort:"
            passwordmanager.source_lb.Text = "Quelle:"
            passwordmanager.comment_lb.Text = "Kommentar"
            passwordmanager.save_bt.Text = "Speichern"
            passwordmanager.copy_user_bt.Text = "Kopieren"
            passwordmanager.copy_source_bt.Text = "Kopieren"
            passwordmanager.copy_password_bt.Text = "Kopieren"

            'newpwmgrdatabase.vb
            newpwmgrdatabase.wincrypttitle.Text = "Datenbank erstellen"
            newpwmgrdatabase.createdb_bt.Text = "Datenbank erstellen"
            newpwmgrdatabase.password_lb.Text = "Passwort:"

            'Passwordmanager_add.vb
            passwordmanager_add.wincrypttitle.Text = "Passwortmanager - Hinzufügen"
            passwordmanager_add.user_lb.Text = "Benutzer:"
            passwordmanager_add.password_lb.Text = "Passwort:"
            passwordmanager_add.source_lb.Text = "Quelle:"
            passwordmanager_add.comment_lb.Text = "Kommentar"
            passwordmanager_add.add_bt.Text = "Hinzufügen"

            'passwordmgr_pass.vb
            passwordmgr_pass.wincrypttitle.Text = "Passwortmanager - Passwort"
            passwordmgr_pass.password_lb.Text = "Passwort:"

        End If
    End Sub

End Class
