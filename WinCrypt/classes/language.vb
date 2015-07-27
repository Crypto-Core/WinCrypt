Option Strict On
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
            startwindow.key_lb1.Text = "key:"
            startwindow.mount_gb.Text = "mount cryptfile"
            startwindow.file_lb.Text = "file:"
            startwindow.opencryptfile.Text = "open"
            startwindow.key_lb.Text = "key:"
            startwindow.drive_lb.Text = "drive:"

            startwindow.file_bt_menu.Text = "file"
            startwindow.setting_bt_menu.Text = "setting"
            startwindow.exit_bt_menu.Text = "exit"
            startwindow.tools_bt_menu.Text = "tools"
            startwindow.file_encrypt_bt_menu.Text = "file encrypt"
            startwindow.file_decrypt_bt_menu.Text = "file decrypt"
            startwindow.text_encrypt_bt_menu.Text = "text de- and encrypt"
            startwindow.md5_converter_bt_menu.Text = "MD5 converter"
            startwindow.rsa_encrypt_bt_menu.Text = "encryption"
            startwindow.rsa_decrypt_bt_menu.Text = "decryption"
            startwindow.rsa_create_keys_bt_menu.Text = "create key's"
            startwindow.send_mail_bt_menu.Text = "send e-mail"
            startwindow.pw_manager_bt_menu.Text = "passwordmanager"
            startwindow.export_db_bt_menu.Text = "export database"
            startwindow.import_db_bt_menu.Text = "import database"
            startwindow.delete_db_menu.Text = "delete database"
            startwindow.systemidentification_bt_menu.Text = "systemidentification"
            startwindow.pw_generator_bt_menu.Text = "passwordgenerator"
            startwindow.delete_file_bt_menu.Text = "delete files safetly"
            startwindow.info_bt_menu.Text = "info"
            startwindow.update_bt_menu.Text = "update"
            startwindow.feedback_bt_menu.Text = "feedback"
            startwindow.about_bt_menu.Text = "about"

            startwindow.about_bt_systemtray.Text = "about"
            startwindow.feedback_bt_systemtray.Text = "feedback"
            startwindow.update_bt_systemtray.Text = "update"
            startwindow.tools_bt_systemtray.Text = "tools"
            startwindow.open_bt_systemtray.Text = "open"
            startwindow.exit_bt_systemtray.Text = "exit"
            startwindow.file_encrypt__bt_systemtray.Text = "file encrypt"
            startwindow.file_decrypt_bt_systemtray.Text = "file decrypt"
            startwindow.text_encrypt_bt_systemtray.Text = "text en- and decrypt"
            startwindow.md5_converter_bt_systemtray.Text = "MD5 converter"
            startwindow.rsa_encrypt_bt_systemtray.Text = "decryption"
            startwindow.rsa_decrypt_bt_systemtray.Text = "decryption"
            startwindow.rsa_create_keys_bt_systemtray.Text = "create key's"
            startwindow.send_mail_bt_systemtray.Text = "send e-mail"
            startwindow.pw_manager_bt_systemtray.Text = "passwordmanager"
            startwindow.export_db_bt_systemtray.Text = "export database"
            startwindow.import_db_bt_systemtray.Text = "import database"
            startwindow.delete_db_bt_systemtray.Text = "delete database"
            startwindow.systemidentification_bt_systemtray.Text = "systemidentification"
            startwindow.pwg_bt_systemtray.Text = "passwordgenerator"
            startwindow.file_delete_bt_systemtray.Text = "delete files safetly"


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
            systemidentification.systemidentification_lb.Text = "The system identification allows the user passwords" _
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
            filedecrypt.decrypt.Text = "decrypt"

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
            startwindow.key_lb1.Text = "Schlüssel:"
            startwindow.mount_gb.Text = "Cryptdatei Mounten"
            startwindow.file_lb.Text = "Datei:"
            startwindow.opencryptfile.Text = "Öffnen"
            startwindow.key_lb.Text = "Schlüssel:"
            startwindow.drive_lb.Text = "Laufwerk:"

            startwindow.file_bt_menu.Text = "Datei"
            startwindow.setting_bt_menu.Text = "Einstellung"
            startwindow.exit_bt_menu.Text = "Beenden"
            startwindow.tools_bt_menu.Text = "Tools"
            startwindow.file_encrypt_bt_menu.Text = "Datei verschlüsseln"
            startwindow.file_decrypt_bt_menu.Text = "Datei entschlüsseln"
            startwindow.text_encrypt_bt_menu.Text = "Text ver- und entschlüsseln"
            startwindow.md5_converter_bt_menu.Text = "MD5 Konverter"
            startwindow.rsa_encrypt_bt_menu.Text = "Verschlüsselung"
            startwindow.rsa_decrypt_bt_menu.Text = "Entschlüsselung"
            startwindow.rsa_create_keys_bt_menu.Text = "Schlüssel erstellen"
            startwindow.send_mail_bt_menu.Text = "E-Mail senden"
            startwindow.pw_manager_bt_menu.Text = "Passwortmanager"
            startwindow.export_db_bt_menu.Text = "Datenbank exportieren"
            startwindow.import_db_bt_menu.Text = "Datenbank importieren"
            startwindow.delete_db_menu.Text = "Datenbank löschen"
            startwindow.systemidentification_bt_menu.Text = "Systemidentifikation"
            startwindow.pw_generator_bt_menu.Text = "Passwortgenerator"
            startwindow.delete_file_bt_menu.Text = "Dateien sicher löschen"
            startwindow.info_bt_menu.Text = "Info"
            startwindow.update_bt_menu.Text = "Update"
            startwindow.feedback_bt_menu.Text = "Feedback"
            startwindow.about_bt_menu.Text = "About"

            startwindow.about_bt_systemtray.Text = "About"
            startwindow.feedback_bt_systemtray.Text = "Feedback"
            startwindow.update_bt_systemtray.Text = "Update"
            startwindow.tools_bt_systemtray.Text = "Tools"
            startwindow.open_bt_systemtray.Text = "Öffnen"
            startwindow.exit_bt_systemtray.Text = "Beenden"
            startwindow.file_encrypt__bt_systemtray.Text = "Datei verschlüsseln"
            startwindow.file_decrypt_bt_systemtray.Text = "Datei entschlüsseln"
            startwindow.text_encrypt_bt_systemtray.Text = "Text ver- und entschlüsseln"
            startwindow.md5_converter_bt_systemtray.Text = "MD5 Konverter"
            startwindow.rsa_encrypt_bt_systemtray.Text = "Entschlüsselung"
            startwindow.rsa_decrypt_bt_systemtray.Text = "Verschlüsselung"
            startwindow.rsa_create_keys_bt_systemtray.Text = "Schlüssel erstellen"
            startwindow.send_mail_bt_systemtray.Text = "E-Mail senden"
            startwindow.pw_manager_bt_systemtray.Text = "Passwortmanager"
            startwindow.export_db_bt_systemtray.Text = "Datenbank exportieren"
            startwindow.import_db_bt_systemtray.Text = "Datenbank importieren"
            startwindow.delete_db_bt_systemtray.Text = "Datenbank löschen"
            startwindow.systemidentification_bt_systemtray.Text = "Systemidentifikation"
            startwindow.pwg_bt_systemtray.Text = "Passwortgenerator"
            startwindow.file_delete_bt_systemtray.Text = "Dateien sicher löschen"

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
            systemidentification.systemidentification_lb.Text = "Systemidentifikation:" _
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
            filedecrypt.decrypt.Text = "Entschlüsseln"

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
