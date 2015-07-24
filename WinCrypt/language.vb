Public Class language
    Public langname As String
    Public Sub check()
        Dim root As New System.IO.DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)
        Dim lang As New INIDatei(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\config.ini")
        If lang.WertLesen("Info", "Lang") = "English" Then 'ENGLISH
            startwindow.DateiToolStripMenuItem.Text = "file"
            startwindow.EinstellungToolStripMenuItem.Text = "setting"
            startwindow.BeendenToolStripMenuItem.Text = "exit"
            startwindow.DateiVerschlüsselnToolStripMenuItem.Text = "encrypt file"
            startwindow.DateiEntschlüsselnToolStripMenuItem.Text = "decrypt file"
            startwindow.TextVerschlüsselnToolStripMenuItem.Text = "text en- and decrypt"
            startwindow.PasswortgeneratorToolStripMenuItem.Text = "passwordgenerator"
            startwindow.DateiSicherLöschenToolStripMenuItem.Text = "delete files safely"
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
            startwindow.ToolsToolStripMenuItem.Text = "tools"
            startwindow.SystemidentifikationToolStripMenuItem.Text = "system identification"
            startwindow.InfoToolStripMenuItem.Text = "info"
            startwindow.UpdateToolStripMenuItem.Text = "update"
            startwindow.AboutToolStripMenuItem.Text = "about"
            startwindow.MD5KonverterToolStripMenuItem.Text = "MD5 converter"
            startwindow.MD5CrackerToolStripMenuItem.Text = "MD5 bruteforce"
            startwindow.MD5KonverterToolStripMenuItem1.Text = "MD5 converter"
            startwindow.MD5BruteforceToolStripMenuItem.Text = "MD5 bruteforce"
            startwindow.EntschlüsselnToolStripMenuItem.Text = "decryption"
            startwindow.VerschlüsselnToolStripMenuItem.Text = "encryption"
            startwindow.KeyErstellenToolStripMenuItem.Text = "create key's"
            startwindow.EMailSendenToolStripMenuItem.Text = "send e-mail"
            startwindow.EMailSendenToolStripMenuItem1.Text = "send e-mail"
            startwindow.PasswortmanagerToolStripMenuItem1.Text = "passwordmanager"
            startwindow.PasswortmanagerToolStripMenuItem.Text = "passwordmanager"
            startwindow.DatenbankExportierenToolStripMenuItem.Text = "export database"
            startwindow.DatenbankImportierenToolStripMenuItem.Text = "import database"
            startwindow.DatenbankLöschenToolStripMenuItem.Text = "delete database"
            startwindow.DatenbankExportierenToolStripMenuItem1.Text = "export database"
            startwindow.DatenbankImportierenToolStripMenuItem1.Text = "import database"
            startwindow.DatenbankLöschenToolStripMenuItem1.Text = "delete database"
            startwindow.DateiVerschlüsselnToolStripMenuItem1.Text = "encrypt file"
            startwindow.DateiEntschlüsselnToolStripMenuItem1.Text = "decrypt file"
            startwindow.TextVerUndEntschlüsselnToolStripMenuItem.Text = "text de- and encrypt"
            startwindow.MD5KonverterToolStripMenuItem1.Text = "MD5 converter"
            startwindow.EMailSendenToolStripMenuItem1.Text = "send e-mail"
            startwindow.SystemidentifikationToolStripMenuItem1.Text = "systemidentification"
            startwindow.PasswortGeneratorToolStripMenuItem1.Text = "password generator"
            startwindow.DateienSicherLöschenToolStripMenuItem.Text = "Delete files safely"
            startwindow.AboutToolStripMenuItem1.Text = "about"
            startwindow.UpdateToolStripMenuItem1.Text = "update"
            startwindow.ToolsToolStripMenuItem1.Text = "tools"
            startwindow.ÖffnenToolStripMenuItem.Text = "open"
            startwindow.BeendenToolStripMenuItem1.Text = "exit"

            'masterkey.vb
            masterkey.abort_bt.Text = "abort"

            'rsa_encrypt.vb
            rsa_encrypt.pubkey_path_bt.Text = "open"
            rsa_encrypt.message_lb.Text = "message"
            rsa_encrypt.encryption_message_lb.Text = "encryption message"
            rsa_encrypt.encryption_bt.Text = "encrypt"
            rsa_encrypt.Text = "RSA Encrypt"

            'rsa_decrypt.vb
            rsa_decrypt.open_privkey_bt.Text = "open"
            rsa_decrypt.encrypt_message_lb.Text = "encryption message"
            rsa_decrypt.message_lb.Text = "message"
            rsa_decrypt.decrypt_bt.Text = "decrypt"
            rsa_decrypt.Text = "RSA Decrypt"

            'rsa_create_keys.vb
            rsa_create_keys.save_privkey_bt.Text = "save as"
            rsa_create_keys.save_pubkey_bt.Text = "save as"
            rsa_create_keys.generate_key_bt.Text = "generate keys"
            rsa_create_keys.save_bt.Text = "save"
            rsa_create_keys.Text = "RSA create key's"

            'Form3
            systemidentification.off_rb.Text = "off"
            systemidentification.on_rb.Text = "on"
            systemidentification.Text = "system identification"
            systemidentification.Label1.Text = "The system identification allows the user passwords" _
                & vbCrLf & "more needs to enter. This can be very useful if you passwords to" _
                & vbCrLf & "can not remember well or you want the encrypted file / folder / -" _
                & vbCrLf & "Text / data carrier only be opened by a computer. This may have the advantage" _
                & vbCrLf & "if you lose a USB stick, so the data can be opened by anyone" _
                & vbCrLf & "other than the owner of the PC with which it encrypted the data."

            'passwortgenerator.vb
            passwordgenerator.Text = "WinCrypt - passwordgenerator"
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

            'textencrypt.vb
            textencrypt.encrypt_lb.Text = "encypt"
            textencrypt.decrypt_lb.Text = "decrypt"
            textencrypt.text_input.Text = "text entry"
            textencrypt.text_output.Text = "text output"
            textencrypt.password_lb.Text = "password:"
            textencrypt.generate_bt.Text = "generate"
            textencrypt.decrypt_bt.Text = "decrypt"
            textencrypt.encrypt_bt.Text = "encrypt"

            'DateiEntschlüsseln.vb
            filedecrypt.Text = "file decrypt"
            filedecrypt.filelb.Text = "file:"
            filedecrypt.pathlb.Text = "path:"
            filedecrypt.pwdlb.Text = "password:"
            filedecrypt.openfile.Text = "open"
            filedecrypt.savefile.Text = "safe as"
            filedecrypt.dencrypt.Text = "decrypt"

            'DateiVerschlüsseln.vb

            fileencrypt.Text = "file encrypt"
            fileencrypt.filelb.Text = "file:"
            fileencrypt.pathlb.Text = "path:"
            fileencrypt.passwordlb.Text = "password:"
            fileencrypt.fileopenbt.Text = "open"
            fileencrypt.savefilebt.Text = "safe as"
            fileencrypt.encryptbt.Text = "encrypt"
            fileencrypt.generatebt.Text = "generate"

            'Einstellung.vb
            wcSetting.Text = "setting"
            wcSetting.registfiletypegb.Text = "register WinCrypt file types"
            wcSetting.registfiletype.Text = "regist"
            wcSetting.languagegb.Text = "language"
            wcSetting.startwincb.Text = "WinCrypt start with Windows"
            wcSetting.startminwincryptrb.Text = "Start minimized WinCrypt"
            wcSetting.startnormalwincrypt.Text = "Start WinCrypt normal"
            langname = lang.WertLesen("Info", "Lang")

            'md5_main.vb
            converter.Text = "MD5 Converter"
            converter.convert_bt.Text = "Convert"

            'md5_bruteforce.vb
            bruteforce.passwordlist_lb.Text = "passwordlist:"
            bruteforce.openWordlist.Text = "open"
            bruteforce.showProgress.Text = "show progress"

            'sendmail.vb
            sendmail.Text = "send e-mail"
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
            passwordmanager.Text = "passwordmanager"
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
            newpwmgrdatabase.Text = "create database"
            newpwmgrdatabase.createdb_bt.Text = "create database"
            newpwmgrdatabase.password_lb.Text = "password:"

            'Passwordmanager_add.vb
            passwordmanager_add.Text = "passwordmanager - add"
            passwordmanager_add.user_lb.Text = "user:"
            passwordmanager_add.password_lb.Text = "password:"
            passwordmanager_add.source_lb.Text = "source:"
            passwordmanager_add.comment_lb.Text = "comment"
            passwordmanager_add.add_bt.Text = "add"

            'passwordmgr_pass.vb
            passwordmgr_pass.Text = "passwordmanager - password"
            passwordmgr_pass.password_lb.Text = "password:"
        End If



        If lang.WertLesen("Info", "Lang") = "German" Then 'DEUTSCH
            startwindow.DateiToolStripMenuItem.Text = "Datei"
            startwindow.EinstellungToolStripMenuItem.Text = "Einstellung"
            startwindow.BeendenToolStripMenuItem.Text = "Beenden"
            startwindow.DateiVerschlüsselnToolStripMenuItem.Text = "Datei verschlüsseln"
            startwindow.DateiEntschlüsselnToolStripMenuItem.Text = "Datei entschlüsseln"
            startwindow.TextVerschlüsselnToolStripMenuItem.Text = "Text ver- und entschlüsseln"
            startwindow.PasswortgeneratorToolStripMenuItem.Text = "Passwortgenerator"
            startwindow.DateiSicherLöschenToolStripMenuItem.Text = "Dateien sicher löschen"
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
            startwindow.ToolsToolStripMenuItem.Text = "Tools"
            startwindow.SystemidentifikationToolStripMenuItem.Text = "Systemidentifikation"
            startwindow.InfoToolStripMenuItem.Text = "Info"
            startwindow.UpdateToolStripMenuItem.Text = "Update"
            startwindow.AboutToolStripMenuItem.Text = "About"
            startwindow.MD5KonverterToolStripMenuItem.Text = "MD5 Konverter"
            startwindow.MD5CrackerToolStripMenuItem.Text = "MD5 Brute-force"
            startwindow.MD5KonverterToolStripMenuItem1.Text = "MD5 Konverter"
            startwindow.MD5BruteforceToolStripMenuItem.Text = "MD5 Brute-force"
            startwindow.EntschlüsselnToolStripMenuItem.Text = "Entschlüsselung"
            startwindow.VerschlüsselnToolStripMenuItem.Text = "Verschlüsselung"
            startwindow.KeyErstellenToolStripMenuItem.Text = "Schlüssel erstellen"
            startwindow.EMailSendenToolStripMenuItem.Text = "E-Mail Senden"
            startwindow.EMailSendenToolStripMenuItem1.Text = "E-Mail Senden"
            startwindow.PasswortmanagerToolStripMenuItem1.Text = "Passwortmanager"
            startwindow.PasswortmanagerToolStripMenuItem.Text = "Passwortmanager"
            startwindow.DatenbankExportierenToolStripMenuItem.Text = "Datenbank exportieren"
            startwindow.DatenbankImportierenToolStripMenuItem.Text = "Datenbank importieren"
            startwindow.DatenbankLöschenToolStripMenuItem.Text = "Datenbank löschen"
            startwindow.DatenbankExportierenToolStripMenuItem1.Text = "Datenbank exportieren"
            startwindow.DatenbankImportierenToolStripMenuItem1.Text = "Datenbank importieren"
            startwindow.DatenbankLöschenToolStripMenuItem1.Text = "Datenbank löschen"
            startwindow.DateiVerschlüsselnToolStripMenuItem1.Text = "Datei verschlüsseln"
            startwindow.DateiEntschlüsselnToolStripMenuItem1.Text = "Datei entschlüsseln"
            startwindow.TextVerUndEntschlüsselnToolStripMenuItem.Text = "Text ver- und entschlüsseln"
            startwindow.MD5KonverterToolStripMenuItem1.Text = "MD5 Konverter"
            startwindow.EMailSendenToolStripMenuItem1.Text = "E-Mail senden"
            startwindow.SystemidentifikationToolStripMenuItem1.Text = "Systemidentifikation"
            startwindow.PasswortGeneratorToolStripMenuItem1.Text = "Passwort generator"
            startwindow.DateienSicherLöschenToolStripMenuItem.Text = "Dateien sicher löschen"
            startwindow.AboutToolStripMenuItem1.Text = "About"
            startwindow.UpdateToolStripMenuItem1.Text = "Update"
            startwindow.ToolsToolStripMenuItem1.Text = "Tools"
            startwindow.ÖffnenToolStripMenuItem.Text = "Öffnen"
            startwindow.BeendenToolStripMenuItem1.Text = "Beenden"

            'rsa_encrypt.vb
            rsa_encrypt.pubkey_path_bt.Text = "Öffnen"
            rsa_encrypt.message_lb.Text = "Nachricht"
            rsa_encrypt.encryption_message_lb.Text = "Verschlüsselte Nachricht"
            rsa_encrypt.encryption_bt.Text = "Verschlüsseln"
            rsa_encrypt.Text = "RSA Verschlüsselung"

            'rsa_decrypt.vb
            rsa_decrypt.open_privkey_bt.Text = "Öffnen"
            rsa_decrypt.encrypt_message_lb.Text = "Verschlüsselte Nachricht"
            rsa_decrypt.message_lb.Text = "Nachricht"
            rsa_decrypt.decrypt_bt.Text = "Entschlüsseln"
            rsa_decrypt.Text = "RSA Entschlüsselung"

            'masterkey.vb
            masterkey.abort_bt.Text = "Abbrechen"

            'rsa_create_keys.vb
            rsa_create_keys.save_privkey_bt.Text = "Speichern unter"
            rsa_create_keys.save_pubkey_bt.Text = "Speichern unter"
            rsa_create_keys.generate_key_bt.Text = "Schlüssel generieren"
            rsa_create_keys.save_bt.Text = "Speichern"
            rsa_create_keys.Text = "RSA Schlüssel erstellen"

            'Form3
            systemidentification.off_rb.Text = "Ausschalten"
            systemidentification.on_rb.Text = "Einschalten"
            systemidentification.Text = "Systemidentifikation"
            systemidentification.Label1.Text = "Systemidentifikation:" _
                & vbCrLf & "Die Systemidentifikation ermöglicht es das der Benutzer keine Passwörter" _
                & vbCrLf & "mehr eingeben braucht. Dies kann sehr sinnvoll sein wenn man sich Passwörter" _
                & vbCrLf & "nicht gut merken kann oder man möchte dass die verschlüsselte Datei/Ordner/-" _
                & vbCrLf & "Text/Datenträger nur von einem Computer geöffnet werden. Dies kann den Vorteil haben" _
                & vbCrLf & "wenn man einen USB Stick verliert, so können die Daten von niemanden geöffnet werden" _
                & vbCrLf & "außer dem Besitzer mit dem PC mit dem er die Daten verschlüsselt hat."

            'passwortgenerator.vb
            passwordgenerator.Text = "WinCrypt - Passwortgenerator"
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


            'textencrypt.vb
            textencrypt.encrypt_lb.Text = "Verschlüsseln"
            textencrypt.decrypt_lb.Text = "Entschlüsseln"
            textencrypt.text_input.Text = "Texteingabe"
            textencrypt.text_output.Text = "Textausgabe"
            textencrypt.password_lb.Text = "Passwort:"
            textencrypt.generate_bt.Text = "Generieren"
            textencrypt.decrypt_bt.Text = "Entschlüsseln"
            textencrypt.encrypt_bt.Text = "Verschlüsseln"

            'DateiEntschlüsseln.vb
            filedecrypt.Text = "Datei entschlüsseln"
            filedecrypt.filelb.Text = "Datei:"
            filedecrypt.pathlb.Text = "Pfad:"
            filedecrypt.pwdlb.Text = "Passwort:"
            filedecrypt.openfile.Text = "Öffnen"
            filedecrypt.savefile.Text = "Speichern unter..."
            filedecrypt.dencrypt.Text = "Entschlüsseln"

            'DateiVerschlüsseln.vb

            fileencrypt.Text = "Datei verschlüsseln"
            fileencrypt.filelb.Text = "Datei:"
            fileencrypt.pathlb.Text = "Pfad:"
            fileencrypt.passwordlb.Text = "Passwort:"
            fileencrypt.fileopenbt.Text = "Öffnen"
            fileencrypt.savefilebt.Text = "Speichern unter..."
            fileencrypt.encryptbt.Text = "Verschlüsseln"
            fileencrypt.generatebt.Text = "Generieren"

            'Einstellung.vb
            wcSetting.Text = "Einstellung"
            wcSetting.registfiletypegb.Text = "WinCrypt Dateitypen registrieren"
            wcSetting.registfiletype.Text = "Registrieren"
            wcSetting.languagegb.Text = "Sprache"
            wcSetting.startwincb.Text = "WinCrypt mit Windows starten"
            wcSetting.startminwincryptrb.Text = "WinCrypt minimiert starten"
            wcSetting.startnormalwincrypt.Text = "WinCrypt normal starten"
            langname = lang.WertLesen("Info", "Lang")

            'md5_main.vb
            converter.Text = "MD5 Konverter"
            converter.convert_bt.Text = "Konvertieren"

            'md5_bruteforce.vb
            bruteforce.passwordlist_lb.Text = "Passwortliste:"
            bruteforce.openWordlist.Text = "Öffnen"
            bruteforce.showProgress.Text = "Zeige Fortschritt an"

            'sendmail.vb
            sendmail.Text = "E-Mail senden"
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
            passwordmanager.Text = "Passwortmanager"
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
            newpwmgrdatabase.Text = "Datenbank erstellen"
            newpwmgrdatabase.createdb_bt.Text = "Datenbank erstellen"
            newpwmgrdatabase.password_lb.Text = "Passwort:"

            'Passwordmanager_add.vb
            passwordmanager_add.Text = "Passwortmanager - Hinzufügen"
            passwordmanager_add.user_lb.Text = "Benutzer:"
            passwordmanager_add.password_lb.Text = "Passwort:"
            passwordmanager_add.source_lb.Text = "Quelle:"
            passwordmanager_add.comment_lb.Text = "Kommentar"
            passwordmanager_add.add_bt.Text = "Hinzufügen"

            'passwordmgr_pass.vb
            passwordmgr_pass.Text = "Passwortmanager - Passwort"
            passwordmgr_pass.password_lb.Text = "Passwort:"

        End If
    End Sub

End Class
