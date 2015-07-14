Public Class language
    Public langname As String
    Public Function check()
        Dim root As New System.IO.DirectoryInfo(My.Computer.FileSystem.CurrentDirectory)
        Dim lang As New INIDatei(root.Root.FullName & "Users\" & Environment.UserName & "\AppData\Roaming\WinCrypt\config.ini")
        If lang.WertLesen("Info", "Lang") = "English" Then 'ENGLISH
            startwindow.DateiToolStripMenuItem.Text = "file"
            startwindow.EinstellungToolStripMenuItem.Text = "setting"
            startwindow.BeendenToolStripMenuItem.Text = "exit"
            startwindow.DateiVerschlüsselnToolStripMenuItem.Text = "file encrypt"
            startwindow.DateiEntschlüsselnToolStripMenuItem.Text = "file decrypt"
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
            passwortgenerator.Text = "WinCrypt - passwordgenerator"
            passwortgenerator.uppercasecb.Text = "uppercase"
            passwortgenerator.lowercasecb.Text = "lower case"
            passwortgenerator.numberscb.Text = "numbers"
            passwortgenerator.lengthlb.Text = "length:"
            passwortgenerator.copybt.Text = "copy"
            passwortgenerator.generatebt.Text = "generate"

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
            Einstellungen.Text = "setting"
            Einstellungen.registfiletypegb.Text = "register WinCrypt file types"
            Einstellungen.registfiletype.Text = "regist"
            Einstellungen.languagegb.Text = "language"
            Einstellungen.startwincb.Text = "WinCrypt start with Windows"
            Einstellungen.startminwincryptrb.Text = "Start minimized WinCrypt"
            Einstellungen.startnormalwincrypt.Text = "Start WinCrypt normal"
            langname = lang.WertLesen("Info", "Lang")

            'md5_main.vb
            md5main.Text = "MD5 Converter"
            md5main.convert_bt.Text = "Convert"

            'md5_bruteforce.vb
            md5bruteforce.passwordlist_lb.Text = "passwordlist:"
            md5bruteforce.open_bt.Text = "open"
            md5bruteforce.progresscheck.Text = "show progress"

            'sendmail.vb
            sendmail.email_lb.Text = "email:"
            sendmail.password_lb.Text = "password:"
            sendmail.server_lb.Text = "server:"
            sendmail.emailto_lb.Text = "receiver:"
            sendmail.Label1.Text = "attachments:"
            sendmail.file_txt.Size = New System.Drawing.Size(366, 20)
            sendmail.file_txt.Location = New System.Drawing.Point(86, 416)
            sendmail.file_bt.Text = "open"
            sendmail.sendmail_bt.Text = "send"


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
            passwortgenerator.Text = "WinCrypt - Passwortgenerator"
            passwortgenerator.uppercasecb.Text = "Großbuchstaben"
            passwortgenerator.lowercasecb.Text = "Kleinbuchstaben"
            passwortgenerator.numberscb.Text = "Zahlen"
            passwortgenerator.lengthlb.Text = "Länge:"
            passwortgenerator.copybt.Text = "Kopieren"
            passwortgenerator.generatebt.Text = "Generieren"

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
            Einstellungen.Text = "Einstellung"
            Einstellungen.registfiletypegb.Text = "WinCrypt Dateitypen registrieren"
            Einstellungen.registfiletype.Text = "Registrieren"
            Einstellungen.languagegb.Text = "Sprache"
            Einstellungen.startwincb.Text = "WinCrypt mit Windows starten"
            Einstellungen.startminwincryptrb.Text = "WinCrypt minimiert starten"
            Einstellungen.startnormalwincrypt.Text = "WinCrypt normal starten"
            langname = lang.WertLesen("Info", "Lang")

            'md5_main.vb
            md5main.Text = "MD5 Konverter"
            md5main.convert_bt.Text = "Konvertieren"

            'md5_bruteforce.vb
            md5bruteforce.passwordlist_lb.Text = "Passwortliste:"
            md5bruteforce.open_bt.Text = "Öffnen"
            md5bruteforce.progresscheck.Text = "Zeige Fortschritt an"

            'sendmail.vb
            sendmail.email_lb.Text = "E-Mail:"
            sendmail.password_lb.Text = "Passwort:"
            sendmail.server_lb.Text = "Server:"
            sendmail.emailto_lb.Text = "Empfänger:"
            sendmail.Label1.Text = "Anhang:"
            sendmail.file_txt.Size = New System.Drawing.Size(387, 20)
            sendmail.file_txt.Location = New System.Drawing.Point(65, 416)
            sendmail.file_bt.Text = "Öffnen"
            sendmail.sendmail_bt.Text = "Senden"

        End If
    End Function

End Class
