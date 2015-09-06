Imports System.IO

Public Class designcolor
    ReadOnly _
        _ini As _
            New classes.IniDatei(String.Format("{0}\WinCrypt\config.ini", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)))
    Public UseTemplate As String = _ini.worthreading("Design", "UseTemplate")
    Public bgcolor As Color = ColorTranslator.FromHtml(_ini.worthreading("Design", "BackgroundColor"))
    Public formheadcolor As Color = ColorTranslator.FromHtml(_ini.worthreading("Design", "FormHeadColor"))
    Public inputbackgroundcolor As Color = ColorTranslator.FromHtml(_ini.worthreading("Design", "InputBackgroundColor"))
    Public buttoncolor As Color = ColorTranslator.FromHtml(_ini.worthreading("Design", "ButtonColor"))
    Public textcolor As Color = ColorTranslator.FromHtml(_ini.worthreading("Design", "TextColor"))
    Public inputtextcolor As Color = ColorTranslator.FromHtml(_ini.worthreading("Design", "InputTextColor"))
    Public Event reload()
    Sub color()
        '// Überprüfen ob die Werte existieren und wenn nicht, Werte schreiben
        If ColorTranslator.ToHtml(bgcolor).Length = 0 Then
            _ini.WertSchreiben("Design", "BackgroundColor", "#2d2d30")
        End If

        If ColorTranslator.ToHtml(formheadcolor).Length = 0 Then
            _ini.WertSchreiben("Design", "FormHeadColor", "#2d2d30")
        End If

        If ColorTranslator.ToHtml(inputbackgroundcolor).Length = 0 Then
            _ini.WertSchreiben("Design", "InputBackgroundColor", "#333337")
        End If

        If ColorTranslator.ToHtml(buttoncolor).Length = 0 Then
            _ini.WertSchreiben("Design", "buttoncolor", "#3e3e40")
        End If

        If ColorTranslator.ToHtml(textcolor).Length = 0 Then
            _ini.WertSchreiben("Design", "TextColor", "#ffffff")
        End If

        If UseTemplate.Length = 0 Then
            _ini.WertSchreiben("Design", "UseTemplate", "Standard")
        End If


        '// Farben von Startwindow.vb werden angepasst
        startwindows_color()

        '// Farben von wcSetting.vb werden angepasst
        wcSetting_color()

        '// Farben von systemidentification.vb werden angepasst
        systemidentification_color()

        '// Farben von masterkey.vb werden angepasst
        masterkey_color()

        '// Farben von about.vb werden angepasst
        about_color()

        '// Farben von feedback.vb werden angepasst
        feedback_color()

        '// Farben von Filedecrypt.vb werden angepasst
        Filedecrypt_color()

        '// Farben von Fileencrypt.vb werden angepasst
        fileencrypt_color()

        '// Farben von bruteforce.vb werden angepasst
        bruteforce_color()

        '// Farben von converter.vb werden angepasst
        converter_color()

        '// Farben von sendmail.vb werden angepasst
        sendmail_color()

        '// Farben von passwordgenerator.vb werden angepasst
        passwordgenerator_color()

        '// Farben von Newpwmgrdatabase.vb werden angepasst
        Newpwmgrdatabase_color()

        '// Farben von Passwordmanager.vb werden angepasst
        Passwordmanager_color()

        '// Farben von passwordmanager_add.vb werden angepasst
        passwordmanager_add_color()

        '// Farben von passwordmgr_pass.vb werden angepasst
        passwordmgr_pass_color()

        '// Farben von rsa_create_keys.vb werden angepasst
        rsa_create_keys_color()

        '// Farben von rsa_decrypt.vb werden angepasst
        rsa_decrypt_color()

        '// Farben von rsa_encrypt.vb werden angepasst
        rsa_encrypt_color()

        '// Farben von del_report.vb werden angepasst
        del_report_color()

        '// Farben von safedelete.vb werden angepasst
        safedelete_color()

        '// Farben von Textencrypt.vb werden angepasst
        Textencrypt_color()

        md5filehash()
    End Sub
    Private Sub startwindows_color()
        '// Die Farben werden in den Einstellungen geladen
        WcSetting.bgcolor_bt.BackColor = bgcolor
        WcSetting.formhead_color_bt.BackColor = formheadcolor
        WcSetting.inputbackground_bt.BackColor = inputbackgroundcolor
        WcSetting.buttoncolor_bt.BackColor = buttoncolor
        WcSetting.textcolor_bt.BackColor = textcolor
        WcSetting.inputtextcolor_bt.BackColor = inputtextcolor

        '// Das Form Head wird farblich angepasst
        Startwindow.form_head.BackColor = formheadcolor

        '// Die Titelfarbe wird farblich angepasst
        Startwindow.wincrypttitle.ForeColor = textcolor
        Startwindow.wincrypttitle.BackColor = formheadcolor

        '// Die Exit Schaltfläche wird Farblich angepasst
        Startwindow.exit_bt.ForeColor = textcolor
        Startwindow.exit_bt.BackColor = formheadcolor

        '// Die minimize Schaltfläche wird farblich angepasst
        Startwindow.minimize_bt.BackColor = formheadcolor
        Startwindow.minimize_bt.ForeColor = textcolor

        '// Der Hintegrund vom Icon wird farblich angepasst
        Startwindow.wincrypt_icon.BackColor = formheadcolor

        '// Das MenuStrip wird farblich angepasst
        Startwindow.MenuStrip.BackColor = inputbackgroundcolor
        Startwindow.MenuStrip.ForeColor = textcolor
        Startwindow.file_bt_menu.ForeColor = textcolor
        Startwindow.tools_bt_menu.ForeColor = textcolor
        Startwindow.info_bt_menu.ForeColor = textcolor

        '// Der Hintergrund vom Startfenster wird farblich angepasst
        Startwindow.BackColor = bgcolor
        Startwindow.ForeColor = textcolor

        '// Die verschlüsselungs GroupBox wird farblich angepasst
        Startwindow.encrypt_gb.BackColor = bgcolor
        Startwindow.encrypt_gb.ForeColor = textcolor

        '// Das path_encrypt label wird farblich angepasst
        Startwindow.path_encrypt.BackColor = bgcolor
        Startwindow.path_encrypt.ForeColor = textcolor

        '// Das key_lb1 Label wird farblich angepasst
        Startwindow.key_lb1.BackColor = bgcolor
        Startwindow.key_lb1.ForeColor = textcolor

        '// Das crypt_file_pathbutton wird farblichen angepasst
        Startwindow.crypt_file_pathbutton.ForeColor = textcolor
        Startwindow.crypt_file_pathbutton.BackColor = buttoncolor

        '// Das generate_key_encrypt button wird farblich angepasst
        Startwindow.generate_key_encrypt.ForeColor = textcolor
        Startwindow.generate_key_encrypt.BackColor = buttoncolor

        '// Das create_container_encrypt Button wird farblich angepasst
        Startwindow.create_container_encrypt.ForeColor = textcolor
        Startwindow.create_container_encrypt.BackColor = buttoncolor

        '// Die pathtxt wird farblich angepasst
        Startwindow.pathtxt.ForeColor = inputtextcolor
        Startwindow.pathtxt.BackColor = inputbackgroundcolor

        '// Die keycrypt wird farblich angepasst
        Startwindow.keycrypt.ForeColor = inputtextcolor
        Startwindow.keycrypt.BackColor = inputbackgroundcolor

        '// encrypt_list_status wird farblich angepasst
        Startwindow.encrypt_list_status.ForeColor = inputtextcolor
        Startwindow.encrypt_list_status.BackColor = inputbackgroundcolor

        '// cleanlb1 wird farblich angepasst
        Startwindow.cleanlb1.BackColor = buttoncolor

        '// mount_gb wird farblich angepasst
        Startwindow.mount_gb.ForeColor = textcolor

        '// file_lb wird farblich angepasst
        Startwindow.file_lb.ForeColor = textcolor

        '// opencryptfile wird farblich angepasst
        Startwindow.opencryptfile.ForeColor = textcolor
        Startwindow.opencryptfile.BackColor = buttoncolor

        '// decrypt_filepath wird angepasst
        Startwindow.decrypt_filepath.ForeColor = inputtextcolor
        Startwindow.decrypt_filepath.BackColor = inputbackgroundcolor

        '// decrypt_list_status wird farblich angepasst
        Startwindow.decrypt_list_status.ForeColor = inputtextcolor
        Startwindow.decrypt_list_status.BackColor = inputbackgroundcolor

        '// key_lb wird angepasst
        Startwindow.key_lb.ForeColor = textcolor

        '// keyencrypt wird angepasst
        Startwindow.keyencrypt.BackColor = inputbackgroundcolor
        Startwindow.keyencrypt.ForeColor = inputtextcolor

        '// drive_lb wird angepasst
        Startwindow.drive_lb.ForeColor = textcolor

        '// drivecb wird angepasst
        Startwindow.drivecb.ForeColor = inputtextcolor
        Startwindow.drivecb.BackColor = inputbackgroundcolor

        '// mount wird angepasst
        Startwindow.mount.ForeColor = textcolor
        Startwindow.mount.BackColor = buttoncolor

        '// dismount wird angepasst
        Startwindow.dismount.ForeColor = textcolor
        Startwindow.dismount.BackColor = buttoncolor

        '// cleanlb2 wird angepasst
        Startwindow.cleanlb2.BackColor = buttoncolor

        '// setting_bt_menu wird angepasst
        Startwindow.setting_bt_menu.ForeColor = textcolor
        Startwindow.setting_bt_menu.BackColor = bgcolor

        '// exit_bt_menu wird angepasst
        Startwindow.exit_bt_menu.ForeColor = textcolor
        Startwindow.exit_bt_menu.BackColor = bgcolor

        '// file_encrypt_bt_menu wird angepasst
        Startwindow.file_encrypt_bt_menu.ForeColor = textcolor
        Startwindow.file_encrypt_bt_menu.BackColor = bgcolor

        '// file_decrypt_bt_menu
        Startwindow.file_decrypt_bt_menu.ForeColor = textcolor
        Startwindow.file_decrypt_bt_menu.BackColor = bgcolor

        '// text_encrypt_bt_menu
        Startwindow.text_encrypt_bt_menu.ForeColor = textcolor
        Startwindow.text_encrypt_bt_menu.BackColor = bgcolor

        '//text_encrypt_bt_menu
        Startwindow.text_encrypt_bt_menu.ForeColor = textcolor
        Startwindow.text_encrypt_bt_menu.BackColor = bgcolor

        '// hash_bt_menu
        Startwindow.hash_bt_menu.ForeColor = textcolor
        Startwindow.hash_bt_menu.BackColor = bgcolor

        '//md5_converter_bt_menu
        Startwindow.md5_converter_bt_menu.ForeColor = textcolor
        Startwindow.md5_converter_bt_menu.BackColor = bgcolor

        '//md5_bf_bt_menu
        Startwindow.md5_bf_bt_menu.ForeColor = textcolor
        Startwindow.md5_bf_bt_menu.BackColor = bgcolor

        '//rsa_bt_menu
        Startwindow.rsa_bt_menu.ForeColor = textcolor
        Startwindow.rsa_bt_menu.BackColor = bgcolor

        '//rsa_encrypt_bt_menu
        Startwindow.rsa_encrypt_bt_menu.ForeColor = textcolor
        Startwindow.rsa_encrypt_bt_menu.BackColor = bgcolor

        '//rsa_decrypt_bt_menu
        Startwindow.rsa_decrypt_bt_menu.ForeColor = textcolor
        Startwindow.rsa_decrypt_bt_menu.BackColor = bgcolor

        '//rsa_create_keys_bt_menu
        Startwindow.rsa_create_keys_bt_menu.ForeColor = textcolor
        Startwindow.rsa_create_keys_bt_menu.BackColor = bgcolor

        '//mail_bt_menu
        Startwindow.mail_bt_menu.ForeColor = textcolor
        Startwindow.mail_bt_menu.BackColor = bgcolor

        '//EncryptionToolStripMenuItem
        Startwindow.EncryptionToolStripMenuItem.ForeColor = textcolor
        Startwindow.EncryptionToolStripMenuItem.BackColor = bgcolor

        '//FileEncryptionToolStripMenuItem
        Startwindow.FileEncryptionToolStripMenuItem.ForeColor = textcolor
        Startwindow.FileEncryptionToolStripMenuItem.BackColor = bgcolor

        '//send_mail_bt_menu
        Startwindow.send_mail_bt_menu.ForeColor = textcolor
        Startwindow.send_mail_bt_menu.BackColor = bgcolor

        '// pw_manager_bt_menu
        Startwindow.pw_manager_bt_menu.ForeColor = textcolor
        Startwindow.pw_manager_bt_menu.BackColor = bgcolor

        '// export_db_bt_menu
        Startwindow.export_db_bt_menu.ForeColor = textcolor
        Startwindow.export_db_bt_menu.BackColor = bgcolor

        '//import_db_bt_menu
        Startwindow.import_db_bt_menu.ForeColor = textcolor
        Startwindow.import_db_bt_menu.BackColor = bgcolor

        '// delete_db_menu
        Startwindow.delete_db_menu.ForeColor = textcolor
        Startwindow.delete_db_menu.BackColor = bgcolor

        '// systemidentification_bt_menu
        Startwindow.systemidentification_bt_menu.ForeColor = textcolor
        Startwindow.systemidentification_bt_menu.BackColor = bgcolor

        '//pw_generator_bt_menu
        Startwindow.pw_generator_bt_menu.ForeColor = textcolor
        Startwindow.pw_generator_bt_menu.BackColor = bgcolor

        '// delete_file_bt_menu
        Startwindow.delete_file_bt_menu.ForeColor = textcolor
        Startwindow.delete_file_bt_menu.BackColor = bgcolor

        '// update_bt_menu
        Startwindow.update_bt_menu.ForeColor = textcolor
        Startwindow.update_bt_menu.BackColor = bgcolor

        '// feedback_bt_menu
        Startwindow.feedback_bt_menu.ForeColor = textcolor
        Startwindow.feedback_bt_menu.BackColor = bgcolor

        '// about_bt_menu
        Startwindow.about_bt_menu.ForeColor = textcolor
        Startwindow.about_bt_menu.BackColor = bgcolor

        '// drivecb
        Startwindow.drivecb.BackColor = buttoncolor
        Startwindow.drivecb.ForeColor = textcolor

        '// mount
        Startwindow.mount.BackColor = buttoncolor
        Startwindow.mount.ForeColor = textcolor

        '// dismount
        Startwindow.dismount.BackColor = buttoncolor
        Startwindow.dismount.ForeColor = textcolor

        '// generate_key_encrypt
        Startwindow.generate_key_encrypt.BackColor = buttoncolor
        Startwindow.generate_key_encrypt.ForeColor = textcolor

        '// create_container_encrypt
        Startwindow.create_container_encrypt.BackColor = buttoncolor
        Startwindow.create_container_encrypt.ForeColor = textcolor

        

        Startwindow.MD5DateiChecksumToolStripMenuItem.ForeColor = textcolor
        Startwindow.MD5DateiChecksumToolStripMenuItem.BackColor = bgcolor
    End Sub
    Private Sub wcSetting_color()
        '// form_head
        WcSetting.form_head.ForeColor = textcolor
        WcSetting.form_head.BackColor = formheadcolor

        '// wincrypt_icon
        WcSetting.wincrypt_icon.BackColor = formheadcolor

        '//wincrypttitle
        WcSetting.wincrypttitle.ForeColor = textcolor
        WcSetting.wincrypttitle.BackColor = formheadcolor

        '// standard_restore_bt
        WcSetting.standard_restore_bt.ForeColor = textcolor
        WcSetting.standard_restore_bt.BackColor = buttoncolor

        '// design_export
        WcSetting.design_export.ForeColor = textcolor
        WcSetting.design_export.BackColor = buttoncolor

        '// design_import
        WcSetting.design_import.ForeColor = textcolor
        WcSetting.design_import.BackColor = buttoncolor

        '// exit_bt
        WcSetting.exit_bt.ForeColor = textcolor
        WcSetting.exit_bt.BackColor = formheadcolor

        '// minimize_bt
        WcSetting.minimize_bt.ForeColor = textcolor
        WcSetting.minimize_bt.BackColor = formheadcolor

        '// WcSetting
        WcSetting.ForeColor = textcolor
        WcSetting.BackColor = bgcolor

        '// registfiletypegb
        WcSetting.registfiletypegb.ForeColor = textcolor
        WcSetting.registfiletypegb.BackColor = bgcolor

        '// registfiletype
        WcSetting.registfiletype.ForeColor = textcolor
        WcSetting.registfiletype.BackColor = buttoncolor

        '// autostartgb
        WcSetting.autostartgb.ForeColor = textcolor
        WcSetting.BackColor = bgcolor

        '// startwincb
        WcSetting.startwincb.ForeColor = textcolor
        WcSetting.startwincb.BackColor = bgcolor

        '// line
        WcSetting.line.ForeColor = textcolor
        WcSetting.line.BackColor = bgcolor

        '// startminwincryptrb
        WcSetting.startminwincryptrb.ForeColor = textcolor
        WcSetting.startminwincryptrb.BackColor = bgcolor

        '// startnormalwincrypt
        WcSetting.startnormalwincrypt.ForeColor = textcolor
        WcSetting.startnormalwincrypt.BackColor = bgcolor

        '// line2
        WcSetting.line2.ForeColor = textcolor
        WcSetting.line2.BackColor = bgcolor

        '// line3
        WcSetting.line3.ForeColor = textcolor
        WcSetting.line3.BackColor = bgcolor

        '//languagegb
        WcSetting.languagegb.ForeColor = textcolor
        WcSetting.languagegb.BackColor = bgcolor

        '// languagecb
        WcSetting.languagecb.ForeColor = inputtextcolor
        WcSetting.languagecb.BackColor = inputbackgroundcolor

        '// masterkey_gb
        WcSetting.masterkey_gb.ForeColor = textcolor
        WcSetting.masterkey_gb.BackColor = bgcolor

        '// key_txt
        WcSetting.key_txt.ForeColor = inputtextcolor
        WcSetting.key_txt.BackColor = inputbackgroundcolor

        '// key_cb
        WcSetting.key_cb.ForeColor = textcolor
        WcSetting.key_cb.BackColor = bgcolor

        '// design_gb
        WcSetting.design_gb.ForeColor = textcolor
        WcSetting.design_gb.BackColor = bgcolor

        '// bgcolor_lb
        WcSetting.bgcolor_lb.ForeColor = textcolor
        WcSetting.bgcolor_lb.BackColor = bgcolor

        '// formhead_color_lb
        WcSetting.formhead_color_lb.ForeColor = textcolor
        WcSetting.formhead_color_lb.BackColor = bgcolor

        '// inputbackground_lb
        WcSetting.inputbackground_lb.ForeColor = textcolor
        WcSetting.inputbackground_lb.BackColor = bgcolor

        '// buttoncolor_lb
        WcSetting.buttoncolor_lb.ForeColor = textcolor
        WcSetting.buttoncolor_lb.BackColor = bgcolor

        '// textcolor_lb
        WcSetting.textcolor_lb.ForeColor = textcolor
        WcSetting.textcolor_lb.BackColor = bgcolor

        '// inputtextcolor_lb
        WcSetting.inputtextcolor_lb.ForeColor = textcolor
        WcSetting.inputtextcolor_lb.BackColor = bgcolor

        '// okbt
        WcSetting.okbt.ForeColor = textcolor
        WcSetting.okbt.BackColor = buttoncolor

        '// ComboBox1
        WcSetting.useTemplate_cb.BackColor = buttoncolor
        WcSetting.useTemplate_cb.ForeColor = textcolor

    End Sub
    Private Sub systemidentification_color()
        '// form_head
        Systemidentification.form_head.ForeColor = textcolor
        Systemidentification.form_head.BackColor = formheadcolor

        '// exit_bt
        Systemidentification.exit_bt.ForeColor = textcolor
        Systemidentification.exit_bt.BackColor = formheadcolor

        '// minimize_bt
        Systemidentification.minimize_bt.ForeColor = textcolor
        Systemidentification.minimize_bt.BackColor = formheadcolor

        '// wincrypttitle
        Systemidentification.wincrypttitle.ForeColor = textcolor
        Systemidentification.wincrypttitle.BackColor = formheadcolor

        '// wincrypt_icon
        Systemidentification.wincrypt_icon.BackColor = formheadcolor

        '// systemidentification_lb
        Systemidentification.systemidentification_lb.ForeColor = inputtextcolor
        Systemidentification.systemidentification_lb.BackColor = inputbackgroundcolor

        '// off_rb
        Systemidentification.off_rb.ForeColor = textcolor
        Systemidentification.off_rb.BackColor = inputbackgroundcolor

        '// on_rb
        Systemidentification.on_rb.ForeColor = textcolor
        Systemidentification.on_rb.BackColor = inputbackgroundcolor

        '// ok_bt
        Systemidentification.ok_bt.ForeColor = textcolor
        Systemidentification.ok_bt.BackColor = buttoncolor

        '// Systemidentification
        Systemidentification.ForeColor = textcolor
        Systemidentification.BackColor = bgcolor

    End Sub
    Private Sub masterkey_color()
        '// form_head
        Masterkey.form_head.BackColor = formheadcolor
        Masterkey.form_head.ForeColor = textcolor

        '// exit_bt
        Masterkey.exit_bt.ForeColor = textcolor
        Masterkey.exit_bt.BackColor = formheadcolor

        '// wincrypttitle
        Masterkey.wincrypttitle.ForeColor = textcolor
        Masterkey.wincrypttitle.BackColor = formheadcolor

        '// wincrypt_icon
        Masterkey.wincrypt_icon.BackColor = formheadcolor

        '// Masterkey
        Masterkey.ForeColor = textcolor
        Masterkey.BackColor = bgcolor

        '// key_pic
        Masterkey.key_pic.BackColor = bgcolor

        '// key_lb
        Masterkey.key_lb.ForeColor = textcolor
        Masterkey.key_lb.BackColor = bgcolor

        '// key_txt
        Masterkey.key_txt.ForeColor = inputtextcolor
        Masterkey.key_txt.BackColor = inputbackgroundcolor

        '// ok_bt
        Masterkey.ok_bt.ForeColor = textcolor
        Masterkey.ok_bt.BackColor = buttoncolor

        '// abort_bt
        Masterkey.abort_bt.ForeColor = textcolor
        Masterkey.abort_bt.BackColor = buttoncolor

    End Sub
    Private Sub about_color()
        '// form_head
        about.form_head.BackColor = formheadcolor
        about.form_head.ForeColor = textcolor

        '// exit_bt
        about.exit_bt.ForeColor = textcolor
        about.exit_bt.BackColor = formheadcolor

        '// wincrypttitle
        about.wincrypttitle.ForeColor = textcolor
        about.wincrypttitle.BackColor = formheadcolor

        '// wincrypt_icon
        about.wincrypt_icon.BackColor = formheadcolor

        '// about
        about.ForeColor = textcolor
        about.BackColor = bgcolor

        '// wincrypt_logo
        about.wincrypt_logo.BackColor = bgcolor

        '// product_lb
        about.product_lb.ForeColor = textcolor
        about.product_lb.BackColor = bgcolor

        '// version_lb
        about.version_lb.ForeColor = textcolor
        about.version_lb.BackColor = bgcolor

        '// dev_txt
        about.dev_txt.ForeColor = inputtextcolor
        about.dev_txt.BackColor = inputbackgroundcolor

        '// gpl_txt
        about.gpl_txt.ForeColor = inputtextcolor
        about.gpl_txt.BackColor = inputbackgroundcolor

        '// ok_bt
        about.ok_bt.ForeColor = textcolor
        about.ok_bt.BackColor = buttoncolor

        '// copyright_lb
        about.copyright_lb.ForeColor = textcolor
        about.copyright_lb.BackColor = bgcolor


    End Sub
    Private Sub feedback_color()
        '//form_head
        feedback.form_head.BackColor = formheadcolor
        feedback.form_head.ForeColor = textcolor

        '// exit_bt
        feedback.exit_bt.ForeColor = textcolor
        feedback.exit_bt.BackColor = formheadcolor

        '// minimize_bt
        feedback.minimize_bt.ForeColor = textcolor
        feedback.minimize_bt.BackColor = formheadcolor

        '// wincrypt_icon
        feedback.wincrypt_icon.BackColor = formheadcolor

        '// wincrypttitle
        feedback.wincrypttitle.ForeColor = textcolor
        feedback.wincrypttitle.BackColor = formheadcolor

        '// feedback
        feedback.ForeColor = textcolor
        feedback.BackColor = bgcolor

        '// name_lb
        feedback.name_lb.ForeColor = textcolor
        feedback.name_lb.BackColor = bgcolor

        '// name_txt
        feedback.name_txt.ForeColor = inputtextcolor
        feedback.name_txt.BackColor = inputbackgroundcolor

        '// email_lb
        feedback.email_lb.ForeColor = textcolor
        feedback.email_lb.BackColor = bgcolor

        '// mail_txt
        feedback.mail_txt.ForeColor = inputtextcolor
        feedback.mail_txt.BackColor = inputbackgroundcolor

        '// subject_lb
        feedback.subject_lb.ForeColor = textcolor
        feedback.subject_lb.BackColor = bgcolor

        '// subject_cb
        feedback.subject_cb.ForeColor = inputtextcolor
        feedback.subject_cb.BackColor = inputbackgroundcolor

        '// message_lb
        feedback.message_lb.ForeColor = textcolor
        feedback.message_lb.BackColor = bgcolor

        '// message_txt
        feedback.message_txt.BackColor = inputbackgroundcolor
        feedback.message_txt.ForeColor = inputtextcolor

        '// send_bt
        feedback.send_bt.ForeColor = textcolor
        feedback.send_bt.BackColor = buttoncolor

    End Sub
    Private Sub Filedecrypt_color()
        '//tools.data_encryption.Filedecrypt.form_head
        tools.data_encryption.Filedecrypt.form_head.ForeColor = textcolor
        tools.data_encryption.Filedecrypt.form_head.BackColor = formheadcolor

        '//exit_bt
        tools.data_encryption.Filedecrypt.exit_bt.ForeColor = textcolor
        tools.data_encryption.Filedecrypt.exit_bt.BackColor = formheadcolor

        '//minimize_bt
        tools.data_encryption.Filedecrypt.minimize_bt.ForeColor = textcolor
        tools.data_encryption.Filedecrypt.minimize_bt.BackColor = formheadcolor

        '// wincrypttitle
        tools.data_encryption.Filedecrypt.wincrypttitle.ForeColor = textcolor
        tools.data_encryption.Filedecrypt.wincrypttitle.BackColor = formheadcolor

        '// wincrypt_icon
        tools.data_encryption.Filedecrypt.wincrypt_icon.BackColor = formheadcolor

        '// Filedecrypt
        tools.data_encryption.Filedecrypt.ForeColor = textcolor
        tools.data_encryption.Filedecrypt.BackColor = bgcolor

        '// filelb
        tools.data_encryption.Filedecrypt.filelb.ForeColor = textcolor
        tools.data_encryption.Filedecrypt.filelb.BackColor = bgcolor

        '// filetxt
        tools.data_encryption.Filedecrypt.filetxt.ForeColor = inputtextcolor
        tools.data_encryption.Filedecrypt.filetxt.BackColor = inputbackgroundcolor

        '// openfile
        tools.data_encryption.Filedecrypt.openfile.ForeColor = textcolor
        tools.data_encryption.Filedecrypt.openfile.BackColor = buttoncolor

        '// pathlb
        tools.data_encryption.Filedecrypt.pathlb.ForeColor = textcolor
        tools.data_encryption.Filedecrypt.pathlb.BackColor = bgcolor

        '// pathtxt
        tools.data_encryption.Filedecrypt.pathtxt.ForeColor = inputtextcolor
        tools.data_encryption.Filedecrypt.pathtxt.BackColor = inputbackgroundcolor

        '// savefile
        tools.data_encryption.Filedecrypt.savefile.ForeColor = textcolor
        tools.data_encryption.Filedecrypt.savefile.BackColor = buttoncolor

        '// pwdlb
        tools.data_encryption.Filedecrypt.pwdlb.ForeColor = textcolor
        tools.data_encryption.Filedecrypt.pwdlb.BackColor = bgcolor

        '// passwordtxt
        tools.data_encryption.Filedecrypt.passwordtxt.ForeColor = inputtextcolor
        tools.data_encryption.Filedecrypt.passwordtxt.BackColor = inputbackgroundcolor

        '// statuslb
        tools.data_encryption.Filedecrypt.statuslb.ForeColor = inputtextcolor

        '// decrypt
        tools.data_encryption.Filedecrypt.decrypt.ForeColor = textcolor
        tools.data_encryption.Filedecrypt.decrypt.BackColor = buttoncolor

    End Sub
    Private Sub fileencrypt_color()
        '// form_head
        tools.data_encryption.Fileencrypt.form_head.BackColor = formheadcolor
        tools.data_encryption.Fileencrypt.form_head.ForeColor = textcolor

        '// exit_bt
        tools.data_encryption.Fileencrypt.exit_bt.ForeColor = textcolor
        tools.data_encryption.Fileencrypt.exit_bt.BackColor = formheadcolor

        '// minimize_bt
        tools.data_encryption.Fileencrypt.minimize_bt.ForeColor = textcolor
        tools.data_encryption.Fileencrypt.minimize_bt.BackColor = formheadcolor

        '// wincrypttitle
        tools.data_encryption.Fileencrypt.wincrypttitle.ForeColor = textcolor
        tools.data_encryption.Fileencrypt.wincrypttitle.BackColor = formheadcolor

        '// wincrypt_icon
        tools.data_encryption.Fileencrypt.wincrypt_icon.BackColor = formheadcolor

        '// Fileencrypt
        tools.data_encryption.Fileencrypt.ForeColor = textcolor
        tools.data_encryption.Fileencrypt.BackColor = bgcolor

        '// filelb
        tools.data_encryption.Fileencrypt.filelb.ForeColor = textcolor
        tools.data_encryption.Fileencrypt.filelb.BackColor = bgcolor

        '// filetxt
        tools.data_encryption.Fileencrypt.filetxt.ForeColor = inputtextcolor
        tools.data_encryption.Fileencrypt.filetxt.BackColor = inputbackgroundcolor

        '// fileopenbt
        tools.data_encryption.Fileencrypt.fileopenbt.ForeColor = textcolor
        tools.data_encryption.Fileencrypt.fileopenbt.BackColor = buttoncolor

        '// pathlb
        tools.data_encryption.Fileencrypt.pathlb.ForeColor = textcolor
        tools.data_encryption.Fileencrypt.pathlb.BackColor = bgcolor

        '// savepathtxt
        tools.data_encryption.Fileencrypt.savepathtxt.ForeColor = inputtextcolor
        tools.data_encryption.Fileencrypt.savepathtxt.BackColor = inputbackgroundcolor

        '// savefilebt
        tools.data_encryption.Fileencrypt.savefilebt.ForeColor = textcolor
        tools.data_encryption.Fileencrypt.savefilebt.BackColor = buttoncolor

        '// passwordlb
        tools.data_encryption.Fileencrypt.passwordlb.ForeColor = textcolor
        tools.data_encryption.Fileencrypt.passwordlb.BackColor = bgcolor

        '// passwordtxt
        tools.data_encryption.Fileencrypt.passwordtxt.ForeColor = inputtextcolor
        tools.data_encryption.Fileencrypt.passwordtxt.BackColor = inputbackgroundcolor

        '// generatebt
        tools.data_encryption.Fileencrypt.generatebt.ForeColor = textcolor
        tools.data_encryption.Fileencrypt.generatebt.BackColor = buttoncolor

        '// statuslb
        tools.data_encryption.Fileencrypt.statuslb.ForeColor = inputtextcolor

        '// encryptbt
        tools.data_encryption.Fileencrypt.encryptbt.ForeColor = textcolor
        tools.data_encryption.Fileencrypt.encryptbt.BackColor = buttoncolor
    End Sub
    Private Sub bruteforce_color()
        '// form_head
        tools.hash.Bruteforce.form_head.ForeColor = textcolor
        tools.hash.Bruteforce.form_head.BackColor = formheadcolor

        '//exit_bt
        tools.hash.Bruteforce.exit_bt.ForeColor = textcolor
        tools.hash.Bruteforce.exit_bt.BackColor = formheadcolor

        '// minimize_bt
        tools.hash.Bruteforce.minimize_bt.ForeColor = textcolor
        tools.hash.Bruteforce.minimize_bt.BackColor = formheadcolor

        '// wincrypttitle
        tools.hash.Bruteforce.wincrypttitle.ForeColor = textcolor
        tools.hash.Bruteforce.wincrypttitle.BackColor = formheadcolor

        '// wincrypt_icon
        tools.hash.Bruteforce.wincrypt_icon.BackColor = formheadcolor

        '// Bruteforce
        tools.hash.Bruteforce.ForeColor = textcolor
        tools.hash.Bruteforce.BackColor = bgcolor

        '// md5_lb
        tools.hash.Bruteforce.md5_lb.ForeColor = textcolor
        tools.hash.Bruteforce.md5_lb.BackColor = bgcolor

        '// bruteforcesearchedHash
        tools.hash.Bruteforce.bruteforcesearchedHash.ForeColor = inputtextcolor
        tools.hash.Bruteforce.bruteforcesearchedHash.BackColor = inputbackgroundcolor

        '// art_lb
        tools.hash.Bruteforce.art_lb.ForeColor = textcolor
        tools.hash.Bruteforce.art_lb.BackColor = bgcolor

        '// bruteforceHashtype
        tools.hash.Bruteforce.bruteforceHashtype.ForeColor = inputtextcolor
        tools.hash.Bruteforce.bruteforceHashtype.BackColor = inputbackgroundcolor

        '// passwordlist_lb
        tools.hash.Bruteforce.passwordlist_lb.ForeColor = textcolor
        tools.hash.Bruteforce.passwordlist_lb.BackColor = bgcolor

        '// fileWordlist
        tools.hash.Bruteforce.fileWordlist.ForeColor = inputtextcolor
        tools.hash.Bruteforce.fileWordlist.BackColor = inputbackgroundcolor

        '// openWordlist
        tools.hash.Bruteforce.openWordlist.ForeColor = textcolor
        tools.hash.Bruteforce.openWordlist.BackColor = buttoncolor

        '// showProgress
        tools.hash.Bruteforce.showProgress.ForeColor = textcolor
        tools.hash.Bruteforce.showProgress.BackColor = bgcolor

        '// bruteforceToggle
        tools.hash.Bruteforce.bruteforceToggle.ForeColor = textcolor
        tools.hash.Bruteforce.bruteforceToggle.BackColor = buttoncolor

    End Sub
    Private Sub converter_color()
        '// form_head
        tools.hash.converter.form_head.ForeColor = textcolor
        tools.hash.converter.form_head.BackColor = formheadcolor

        '// exit_bt
        tools.hash.converter.exit_bt.ForeColor = textcolor
        tools.hash.converter.exit_bt.BackColor = formheadcolor

        '// minimize_bt
        tools.hash.converter.minimize_bt.ForeColor = textcolor
        tools.hash.converter.minimize_bt.BackColor = formheadcolor

        '// wincrypttitle
        tools.hash.converter.wincrypttitle.ForeColor = textcolor
        tools.hash.converter.wincrypttitle.BackColor = formheadcolor

        '// wincrypt_icon
        tools.hash.converter.wincrypt_icon.BackColor = formheadcolor

        '// converter
        tools.hash.converter.ForeColor = textcolor
        tools.hash.converter.BackColor = bgcolor

        '// text_lb
        tools.hash.converter.text_lb.ForeColor = textcolor
        tools.hash.converter.text_lb.BackColor = bgcolor


        '// noHash_Textbox
        tools.hash.converter.noHash_Textbox.ForeColor = inputtextcolor
        tools.hash.converter.noHash_Textbox.BackColor = inputbackgroundcolor

        '// art_lb
        tools.hash.converter.art_lb.ForeColor = textcolor
        tools.hash.converter.art_lb.BackColor = bgcolor

        '// toHash_ComboBox
        tools.hash.converter.toHash_ComboBox.ForeColor = inputtextcolor
        tools.hash.converter.toHash_ComboBox.BackColor = inputbackgroundcolor

        '// isHash_Textbox
        tools.hash.converter.isHash_Textbox.ForeColor = inputtextcolor
        tools.hash.converter.isHash_Textbox.BackColor = inputbackgroundcolor

        '// convert_bt
        tools.hash.converter.convert_bt.ForeColor = textcolor
        tools.hash.converter.convert_bt.BackColor = buttoncolor
    End Sub
    Private Sub sendmail_color()
        '// form_head
        tools.mail.Sendmail.form_head.ForeColor = textcolor
        tools.mail.Sendmail.form_head.BackColor = formheadcolor

        '// exit_bt
        tools.mail.Sendmail.exit_bt.ForeColor = textcolor
        tools.mail.Sendmail.exit_bt.BackColor = formheadcolor

        '// minimize_bt
        tools.mail.Sendmail.minimize_bt.ForeColor = textcolor
        tools.mail.Sendmail.minimize_bt.BackColor = formheadcolor

        '// wincrypttitle
        tools.mail.Sendmail.wincrypttitle.ForeColor = textcolor
        tools.mail.Sendmail.wincrypttitle.BackColor = formheadcolor

        '// wincrypt_icon
        tools.mail.Sendmail.wincrypt_icon.BackColor = formheadcolor

        '// Sendmail
        tools.mail.Sendmail.ForeColor = textcolor
        tools.mail.Sendmail.BackColor = bgcolor

        '// email_lb
        tools.mail.Sendmail.email_lb.ForeColor = textcolor
        tools.mail.Sendmail.email_lb.BackColor = bgcolor

        '// email_txt
        tools.mail.Sendmail.email_txt.ForeColor = inputtextcolor
        tools.mail.Sendmail.email_txt.BackColor = inputbackgroundcolor

        '// password_lb
        tools.mail.Sendmail.password_lb.ForeColor = textcolor
        tools.mail.Sendmail.password_lb.BackColor = bgcolor

        '// password_txt
        tools.mail.Sendmail.password_txt.ForeColor = inputtextcolor
        tools.mail.Sendmail.password_txt.BackColor = inputbackgroundcolor

        '// server_lb
        tools.mail.Sendmail.server_lb.ForeColor = textcolor
        tools.mail.Sendmail.server_lb.BackColor = bgcolor

        '// server_txt
        tools.mail.Sendmail.server_txt.ForeColor = inputtextcolor
        tools.mail.Sendmail.server_txt.BackColor = inputbackgroundcolor

        '// emailto_lb
        tools.mail.Sendmail.emailto_lb.ForeColor = textcolor
        tools.mail.Sendmail.emailto_lb.BackColor = bgcolor

        '// emailto_txt
        tools.mail.Sendmail.emailto_txt.ForeColor = inputtextcolor
        tools.mail.Sendmail.emailto_txt.BackColor = inputbackgroundcolor

        '// subject_lb
        tools.mail.Sendmail.subject_lb.ForeColor = textcolor
        tools.mail.Sendmail.subject_lb.BackColor = bgcolor

        '// subject_txt
        tools.mail.Sendmail.subject_txt.ForeColor = inputtextcolor
        tools.mail.Sendmail.subject_txt.BackColor = inputbackgroundcolor

        '// account_bt
        tools.mail.Sendmail.account_bt.ForeColor = textcolor
        tools.mail.Sendmail.account_bt.BackColor = buttoncolor

        '// message_txt
        tools.mail.Sendmail.message_txt.ForeColor = inputtextcolor
        tools.mail.Sendmail.message_txt.BackColor = inputbackgroundcolor

        '// pubkey_lb
        tools.mail.Sendmail.pubkey_lb.ForeColor = textcolor
        tools.mail.Sendmail.pubkey_lb.BackColor = bgcolor

        '// pubkey_txt
        tools.mail.Sendmail.pubkey_txt.ForeColor = inputtextcolor
        tools.mail.Sendmail.pubkey_txt.BackColor = inputbackgroundcolor

        '// rsa_open_bt
        tools.mail.Sendmail.rsa_open_bt.ForeColor = textcolor
        tools.mail.Sendmail.rsa_open_bt.BackColor = buttoncolor

        '// rsa_cb
        tools.mail.Sendmail.rsa_cb.ForeColor = textcolor
        tools.mail.Sendmail.rsa_cb.BackColor = bgcolor

        '// attachment_lb
        tools.mail.Sendmail.attachment_lb.ForeColor = textcolor
        tools.mail.Sendmail.attachment_lb.BackColor = bgcolor

        '// file_txt
        tools.mail.Sendmail.file_txt.ForeColor = inputtextcolor
        tools.mail.Sendmail.file_txt.BackColor = inputbackgroundcolor

        '// fileadd_bt
        tools.mail.Sendmail.fileadd_bt.ForeColor = textcolor
        tools.mail.Sendmail.fileadd_bt.BackColor = buttoncolor

        '// add_bt
        tools.mail.Sendmail.add_bt.BackColor = buttoncolor

        '// sendmail_bt
        tools.mail.Sendmail.sendmail_bt.ForeColor = textcolor
        tools.mail.Sendmail.sendmail_bt.BackColor = buttoncolor

        '// attachment_lb1
        tools.mail.Sendmail.attachment_lb1.ForeColor = textcolor
        tools.mail.Sendmail.attachment_lb1.BackColor = bgcolor

        '// file_txt1
        tools.mail.Sendmail.file_txt1.ForeColor = inputtextcolor
        tools.mail.Sendmail.file_txt1.BackColor = inputbackgroundcolor

        '// fileadd_bt1
        tools.mail.Sendmail.fileadd_bt1.ForeColor = textcolor
        tools.mail.Sendmail.fileadd_bt1.BackColor = buttoncolor

        '// attachment_lb2
        tools.mail.Sendmail.attachment_lb2.ForeColor = textcolor
        tools.mail.Sendmail.attachment_lb2.BackColor = bgcolor

        '// file_txt2
        tools.mail.Sendmail.file_txt2.ForeColor = inputtextcolor
        tools.mail.Sendmail.file_txt2.BackColor = inputbackgroundcolor

        '// fileadd_bt2
        tools.mail.Sendmail.fileadd_bt2.ForeColor = textcolor
        tools.mail.Sendmail.fileadd_bt2.BackColor = buttoncolor

        '// attachment_lb3
        tools.mail.Sendmail.attachment_lb3.ForeColor = textcolor
        tools.mail.Sendmail.attachment_lb3.BackColor = bgcolor

        '// file_txt3
        tools.mail.Sendmail.file_txt3.ForeColor = inputtextcolor
        tools.mail.Sendmail.file_txt3.BackColor = inputbackgroundcolor

        '// fileadd_bt3
        tools.mail.Sendmail.fileadd_bt3.ForeColor = textcolor
        tools.mail.Sendmail.fileadd_bt3.BackColor = buttoncolor
    End Sub
    Private Sub passwordgenerator_color()
        '// form_head
        tools.passwordgenerator.passwordgenerator.form_head.ForeColor = textcolor
        tools.passwordgenerator.passwordgenerator.form_head.BackColor = formheadcolor

        '// exit_bt
        tools.passwordgenerator.passwordgenerator.exit_bt.ForeColor = textcolor
        tools.passwordgenerator.passwordgenerator.exit_bt.BackColor = formheadcolor

        '// minimize_bt
        tools.passwordgenerator.passwordgenerator.minimize_bt.ForeColor = textcolor
        tools.passwordgenerator.passwordgenerator.minimize_bt.BackColor = formheadcolor

        '// wincrypt_title
        tools.passwordgenerator.passwordgenerator.wincrypttitle.ForeColor = textcolor
        tools.passwordgenerator.passwordgenerator.wincrypttitle.BackColor = formheadcolor

        '// wincrypt_icon
        tools.passwordgenerator.passwordgenerator.wincrypt_icon.BackColor = formheadcolor

        '// passwortgenerator
        tools.passwordgenerator.passwordgenerator.ForeColor = textcolor
        tools.passwordgenerator.passwordgenerator.BackColor = bgcolor

        '// generatetxt
        tools.passwordgenerator.passwordgenerator.generatetxt.ForeColor = inputtextcolor
        tools.passwordgenerator.passwordgenerator.generatetxt.BackColor = inputbackgroundcolor

        '// specialchar
        tools.passwordgenerator.passwordgenerator.specialchar.ForeColor = textcolor
        tools.passwordgenerator.passwordgenerator.specialchar.BackColor = bgcolor

        '// uppercasecb
        tools.passwordgenerator.passwordgenerator.uppercasecb.ForeColor = textcolor
        tools.passwordgenerator.passwordgenerator.uppercasecb.BackColor = bgcolor

        '// lowercasecb
        tools.passwordgenerator.passwordgenerator.lowercasecb.ForeColor = textcolor
        tools.passwordgenerator.passwordgenerator.lowercasecb.BackColor = bgcolor

        '// numberscb
        tools.passwordgenerator.passwordgenerator.numberscb.ForeColor = textcolor
        tools.passwordgenerator.passwordgenerator.numberscb.BackColor = bgcolor

        '// lengthlb
        tools.passwordgenerator.passwordgenerator.length_lb.ForeColor = textcolor
        tools.passwordgenerator.passwordgenerator.length_lb.BackColor = bgcolor

        '// length
        tools.passwordgenerator.passwordgenerator.length.ForeColor = inputtextcolor
        tools.passwordgenerator.passwordgenerator.length.BackColor = inputbackgroundcolor

        '// copybt
        tools.passwordgenerator.passwordgenerator.copybt.ForeColor = textcolor
        tools.passwordgenerator.passwordgenerator.copybt.BackColor = buttoncolor

        '// generatebt
        tools.passwordgenerator.passwordgenerator.generatebt.ForeColor = textcolor
        tools.passwordgenerator.passwordgenerator.generatebt.BackColor = buttoncolor

        '// lines
        tools.passwordgenerator.passwordgenerator.lines.ForeColor = inputtextcolor
        tools.passwordgenerator.passwordgenerator.lines.BackColor = inputbackgroundcolor

        '// lines_lb
        tools.passwordgenerator.passwordgenerator.lines_lb.BackColor = bgcolor
        tools.passwordgenerator.passwordgenerator.lines_lb.ForeColor = textcolor

        '// minus
        tools.passwordgenerator.passwordgenerator.minus.BackColor = buttoncolor

        '// plus
        tools.passwordgenerator.passwordgenerator.plus.BackColor = buttoncolor

        '// lengthlb
        tools.passwordgenerator.passwordgenerator.length_lb.ForeColor = textcolor
        tools.passwordgenerator.passwordgenerator.length_lb.BackColor = bgcolor

        '// saveas_bt
        tools.passwordgenerator.passwordgenerator.saveas_bt.ForeColor = textcolor
        tools.passwordgenerator.passwordgenerator.saveas_bt.BackColor = buttoncolor

        '// pw_length
        tools.passwordgenerator.passwordgenerator.pw_length.ForeColor = textcolor
        tools.passwordgenerator.passwordgenerator.pw_length.BackColor = bgcolor

        '// attachments
        tools.passwordgenerator.passwordgenerator.attachments.ForeColor = textcolor
        tools.passwordgenerator.passwordgenerator.attachments.BackColor = bgcolor
    End Sub
    Private Sub Newpwmgrdatabase_color()
        '// Newpwmgrdatabase
        Newpwmgrdatabase.form_head.ForeColor = textcolor
        Newpwmgrdatabase.form_head.BackColor = formheadcolor

        '// exit_bt
        Newpwmgrdatabase.exit_bt.ForeColor = textcolor
        Newpwmgrdatabase.exit_bt.BackColor = formheadcolor

        '// minimize_bt
        Newpwmgrdatabase.minimize_bt.ForeColor = textcolor
        Newpwmgrdatabase.minimize_bt.BackColor = formheadcolor

        '// wincrypt_title
        Newpwmgrdatabase.wincrypttitle.ForeColor = textcolor
        Newpwmgrdatabase.wincrypttitle.BackColor = formheadcolor

        '// wincrypt_icon
        Newpwmgrdatabase.wincrypt_icon.BackColor = formheadcolor

        '// Newpwmgrdatabase
        Newpwmgrdatabase.ForeColor = textcolor
        Newpwmgrdatabase.BackColor = bgcolor

        '// password_lb
        Newpwmgrdatabase.password_lb.ForeColor = textcolor
        Newpwmgrdatabase.password_lb.BackColor = bgcolor

        '// password_txt
        Newpwmgrdatabase.password_txt.ForeColor = inputtextcolor
        Newpwmgrdatabase.password_txt.BackColor = inputbackgroundcolor

        '// createdb_bt
        Newpwmgrdatabase.createdb_bt.ForeColor = textcolor
        Newpwmgrdatabase.createdb_bt.BackColor = buttoncolor
    End Sub
    Private Sub Passwordmanager_color()
        '// form_head
        tools.passwordmanager.Passwordmanager.form_head.ForeColor = textcolor
        tools.passwordmanager.Passwordmanager.form_head.BackColor = formheadcolor

        '// exit_bt
        tools.passwordmanager.Passwordmanager.exit_bt.ForeColor = textcolor
        tools.passwordmanager.Passwordmanager.exit_bt.BackColor = formheadcolor

        '// minimize_bt
        tools.passwordmanager.Passwordmanager.minimize_bt.ForeColor = textcolor
        tools.passwordmanager.Passwordmanager.minimize_bt.BackColor = formheadcolor

        '// wincrypttitle
        tools.passwordmanager.Passwordmanager.wincrypttitle.ForeColor = textcolor
        tools.passwordmanager.Passwordmanager.wincrypttitle.BackColor = formheadcolor

        '// wincrypt_icon
        tools.passwordmanager.Passwordmanager.wincrypt_icon.BackColor = formheadcolor

        '// Passwordmanager
        tools.passwordmanager.Passwordmanager.ForeColor = textcolor
        tools.passwordmanager.Passwordmanager.BackColor = bgcolor

        '// database_viewer
        tools.passwordmanager.Passwordmanager.database_viewer.ForeColor = inputtextcolor
        tools.passwordmanager.Passwordmanager.database_viewer.BackColor = inputbackgroundcolor

        '// user_lb
        tools.passwordmanager.Passwordmanager.user_lb.ForeColor = textcolor
        tools.passwordmanager.Passwordmanager.user_lb.BackColor = bgcolor

        '// password_lb
        tools.passwordmanager.Passwordmanager.password_lb.ForeColor = textcolor
        tools.passwordmanager.Passwordmanager.password_lb.BackColor = bgcolor

        '// source_lb
        tools.passwordmanager.Passwordmanager.source_lb.ForeColor = textcolor
        tools.passwordmanager.Passwordmanager.source_lb.BackColor = bgcolor

        '// comment_lb
        tools.passwordmanager.Passwordmanager.comment_lb.ForeColor = textcolor
        tools.passwordmanager.Passwordmanager.comment_lb.BackColor = bgcolor

        '// user_txt
        tools.passwordmanager.Passwordmanager.user_txt.ForeColor = inputtextcolor
        tools.passwordmanager.Passwordmanager.user_txt.BackColor = inputbackgroundcolor

        '// password_txt
        tools.passwordmanager.Passwordmanager.password_txt.ForeColor = inputtextcolor
        tools.passwordmanager.Passwordmanager.password_txt.BackColor = inputbackgroundcolor

        '// source_txt
        tools.passwordmanager.Passwordmanager.source_txt.ForeColor = inputtextcolor
        tools.passwordmanager.Passwordmanager.source_txt.BackColor = inputbackgroundcolor

        '// comment_txt
        tools.passwordmanager.Passwordmanager.comment_txt.ForeColor = inputtextcolor
        tools.passwordmanager.Passwordmanager.comment_txt.BackColor = inputbackgroundcolor

        '// save_bt
        tools.passwordmanager.Passwordmanager.save_bt.ForeColor = textcolor
        tools.passwordmanager.Passwordmanager.save_bt.BackColor = buttoncolor

        '// add_bt
        tools.passwordmanager.Passwordmanager.add_bt.ForeColor = textcolor
        tools.passwordmanager.Passwordmanager.add_bt.BackColor = buttoncolor

        '// delete_bt
        tools.passwordmanager.Passwordmanager.delete_bt.ForeColor = textcolor
        tools.passwordmanager.Passwordmanager.delete_bt.BackColor = buttoncolor

        '// copy_user_bt
        tools.passwordmanager.Passwordmanager.copy_user_bt.ForeColor = textcolor
        tools.passwordmanager.Passwordmanager.copy_user_bt.BackColor = buttoncolor

        '// copy_password_bt
        tools.passwordmanager.Passwordmanager.copy_password_bt.ForeColor = textcolor
        tools.passwordmanager.Passwordmanager.copy_password_bt.BackColor = buttoncolor

        '// copy_source_bt
        tools.passwordmanager.Passwordmanager.copy_source_bt.ForeColor = textcolor
        tools.passwordmanager.Passwordmanager.copy_source_bt.BackColor = buttoncolor
    End Sub
    Private Sub passwordmanager_add_color()
        '// form_head
        tools.passwordmanager.passwordmanager_add.form_head.ForeColor = textcolor
        tools.passwordmanager.passwordmanager_add.form_head.BackColor = formheadcolor

        '// exit_bt
        tools.passwordmanager.passwordmanager_add.exit_bt.ForeColor = textcolor
        tools.passwordmanager.passwordmanager_add.exit_bt.BackColor = formheadcolor

        '// wincrypttitle
        tools.passwordmanager.passwordmanager_add.wincrypttitle.ForeColor = textcolor
        tools.passwordmanager.passwordmanager_add.wincrypttitle.BackColor = formheadcolor

        '// wincrypt_icon
        tools.passwordmanager.passwordmanager_add.wincrypt_icon.BackColor = formheadcolor

        '// passwordmanager_add
        tools.passwordmanager.passwordmanager_add.ForeColor = textcolor
        tools.passwordmanager.passwordmanager_add.BackColor = bgcolor

        '// user_lb
        tools.passwordmanager.passwordmanager_add.user_lb.ForeColor = textcolor
        tools.passwordmanager.passwordmanager_add.user_lb.BackColor = bgcolor

        '// password_lb
        tools.passwordmanager.passwordmanager_add.password_lb.ForeColor = textcolor
        tools.passwordmanager.passwordmanager_add.password_lb.BackColor = bgcolor

        '// source_lb
        tools.passwordmanager.passwordmanager_add.source_lb.ForeColor = textcolor
        tools.passwordmanager.passwordmanager_add.source_lb.BackColor = bgcolor

        '// comment_lb
        tools.passwordmanager.passwordmanager_add.comment_lb.ForeColor = textcolor
        tools.passwordmanager.passwordmanager_add.comment_lb.BackColor = bgcolor

        '// user_txt
        tools.passwordmanager.passwordmanager_add.user_txt.ForeColor = inputtextcolor
        tools.passwordmanager.passwordmanager_add.user_txt.BackColor = inputbackgroundcolor

        '// password_txt
        tools.passwordmanager.passwordmanager_add.password_txt.ForeColor = inputtextcolor
        tools.passwordmanager.passwordmanager_add.password_txt.BackColor = inputbackgroundcolor

        '// source_txt
        tools.passwordmanager.passwordmanager_add.source_txt.ForeColor = inputtextcolor
        tools.passwordmanager.passwordmanager_add.source_txt.BackColor = inputbackgroundcolor

        '// comment_txt
        tools.passwordmanager.passwordmanager_add.comment_txt.ForeColor = inputtextcolor
        tools.passwordmanager.passwordmanager_add.comment_txt.BackColor = inputbackgroundcolor

        '// add_bt
        tools.passwordmanager.passwordmanager_add.add_bt.ForeColor = textcolor
        tools.passwordmanager.passwordmanager_add.add_bt.BackColor = buttoncolor
    End Sub
    Private Sub passwordmgr_pass_color()
        '// form_head
        tools.passwordmanager.passwordmgr_pass.form_head.ForeColor = textcolor
        tools.passwordmanager.passwordmgr_pass.form_head.BackColor = formheadcolor

        '// exit_bt
        tools.passwordmanager.passwordmgr_pass.exit_bt.ForeColor = textcolor
        tools.passwordmanager.passwordmgr_pass.exit_bt.BackColor = formheadcolor

        '// wincrypttitle
        tools.passwordmanager.passwordmgr_pass.wincrypttitle.ForeColor = textcolor
        tools.passwordmanager.passwordmgr_pass.wincrypttitle.BackColor = formheadcolor

        '// wincrypt_icon
        tools.passwordmanager.passwordmgr_pass.wincrypt_icon.BackColor = formheadcolor

        '// passwordmgr_pass
        tools.passwordmanager.passwordmgr_pass.ForeColor = textcolor
        tools.passwordmanager.passwordmgr_pass.BackColor = bgcolor

        '// password_lb
        tools.passwordmanager.passwordmgr_pass.password_lb.ForeColor = textcolor
        tools.passwordmanager.passwordmgr_pass.password_lb.BackColor = bgcolor

        '// password_txt
        tools.passwordmanager.passwordmgr_pass.password_txt.ForeColor = inputtextcolor
        tools.passwordmanager.passwordmgr_pass.password_txt.BackColor = inputbackgroundcolor

        '// ok_bt
        tools.passwordmanager.passwordmgr_pass.ok_bt.ForeColor = textcolor
        tools.passwordmanager.passwordmgr_pass.ok_bt.BackColor = buttoncolor

    End Sub
    Private Sub rsa_create_keys_color()
        '// form_head
        tools.rsa.rsa_create_keys.form_head.ForeColor = textcolor
        tools.rsa.rsa_create_keys.form_head.BackColor = formheadcolor

        '// exit_bt
        tools.rsa.rsa_create_keys.exit_bt.ForeColor = textcolor
        tools.rsa.rsa_create_keys.exit_bt.BackColor = formheadcolor

        '// minimize_bt
        tools.rsa.rsa_create_keys.minimize_bt.ForeColor = textcolor
        tools.rsa.rsa_create_keys.minimize_bt.BackColor = formheadcolor

        '// wincrypttitle
        tools.rsa.rsa_create_keys.wincrypttitle.ForeColor = textcolor
        tools.rsa.rsa_create_keys.wincrypttitle.BackColor = formheadcolor

        '// wincrypt_icon
        tools.rsa.rsa_create_keys.wincrypt_icon.BackColor = formheadcolor

        '// rsa_create_keys
        tools.rsa.rsa_create_keys.ForeColor = textcolor
        tools.rsa.rsa_create_keys.BackColor = bgcolor

        '// private_key_lb1
        tools.rsa.rsa_create_keys.private_key_lb1.ForeColor = textcolor
        tools.rsa.rsa_create_keys.private_key_lb1.BackColor = bgcolor

        '// public_key_lb1
        tools.rsa.rsa_create_keys.public_key_lb1.ForeColor = textcolor
        tools.rsa.rsa_create_keys.public_key_lb1.BackColor = bgcolor

        '// private_key_path_txt
        tools.rsa.rsa_create_keys.private_key_path_txt.ForeColor = inputtextcolor
        tools.rsa.rsa_create_keys.private_key_path_txt.BackColor = inputbackgroundcolor

        '// public_key_path_txt
        tools.rsa.rsa_create_keys.public_key_path_txt.ForeColor = inputtextcolor
        tools.rsa.rsa_create_keys.public_key_path_txt.BackColor = inputbackgroundcolor

        '// save_privkey_bt
        tools.rsa.rsa_create_keys.save_privkey_bt.ForeColor = textcolor
        tools.rsa.rsa_create_keys.save_privkey_bt.BackColor = buttoncolor

        '// save_pubkey_bt
        tools.rsa.rsa_create_keys.save_pubkey_bt.ForeColor = textcolor
        tools.rsa.rsa_create_keys.save_pubkey_bt.BackColor = buttoncolor

        '// private_key_lb2
        tools.rsa.rsa_create_keys.private_key_lb2.ForeColor = textcolor
        tools.rsa.rsa_create_keys.private_key_lb2.BackColor = bgcolor

        '// privatekey_txt
        tools.rsa.rsa_create_keys.privatekey_txt.ForeColor = inputtextcolor
        tools.rsa.rsa_create_keys.privatekey_txt.BackColor = inputbackgroundcolor

        '// public_key_lb2
        tools.rsa.rsa_create_keys.public_key_lb2.ForeColor = textcolor
        tools.rsa.rsa_create_keys.public_key_lb2.BackColor = bgcolor

        '// publickey_txt
        tools.rsa.rsa_create_keys.publickey_txt.ForeColor = inputtextcolor
        tools.rsa.rsa_create_keys.publickey_txt.BackColor = inputbackgroundcolor

        '// generate_key_bt
        tools.rsa.rsa_create_keys.generate_key_bt.ForeColor = textcolor
        tools.rsa.rsa_create_keys.generate_key_bt.BackColor = buttoncolor

        '// save_bt
        tools.rsa.rsa_create_keys.save_bt.ForeColor = textcolor
        tools.rsa.rsa_create_keys.save_bt.BackColor = buttoncolor

        '// bit_cb
        tools.rsa.rsa_create_keys.bit_cb.ForeColor = inputtextcolor
        tools.rsa.rsa_create_keys.bit_cb.BackColor = inputbackgroundcolor
    End Sub
    Private Sub rsa_decrypt_color()
        '// form_head
        tools.rsa.rsa_decrypt.form_head.ForeColor = textcolor
        tools.rsa.rsa_decrypt.form_head.BackColor = formheadcolor

        '// exit_bt
        tools.rsa.rsa_decrypt.exit_bt.ForeColor = textcolor
        tools.rsa.rsa_decrypt.exit_bt.BackColor = formheadcolor

        '// minimize_bt
        tools.rsa.rsa_decrypt.minimize_bt.ForeColor = textcolor
        tools.rsa.rsa_decrypt.minimize_bt.BackColor = formheadcolor

        '// wincrypttitle
        tools.rsa.rsa_decrypt.wincrypttitle.ForeColor = textcolor
        tools.rsa.rsa_decrypt.wincrypttitle.BackColor = formheadcolor

        '// wincrypt_icon
        tools.rsa.rsa_decrypt.wincrypt_icon.BackColor = formheadcolor

        '// rsa_decrypt
        tools.rsa.rsa_decrypt.ForeColor = textcolor
        tools.rsa.rsa_decrypt.BackColor = bgcolor

        '// privkey_lb
        tools.rsa.rsa_decrypt.privkey_lb.ForeColor = textcolor
        tools.rsa.rsa_decrypt.privkey_lb.BackColor = bgcolor

        '// privkey_path_txt
        tools.rsa.rsa_decrypt.privkey_path_txt.ForeColor = inputtextcolor
        tools.rsa.rsa_decrypt.privkey_path_txt.BackColor = inputbackgroundcolor

        '// open_privkey_bt
        tools.rsa.rsa_decrypt.open_privkey_bt.ForeColor = textcolor
        tools.rsa.rsa_decrypt.open_privkey_bt.BackColor = buttoncolor

        '// encrypt_message_lb
        tools.rsa.rsa_decrypt.encrypt_message_lb.ForeColor = textcolor
        tools.rsa.rsa_decrypt.encrypt_message_lb.BackColor = bgcolor

        '// encrypt_message_txt
        tools.rsa.rsa_decrypt.encrypt_message_txt.ForeColor = inputtextcolor
        tools.rsa.rsa_decrypt.encrypt_message_txt.BackColor = inputbackgroundcolor

        '// message_lb
        tools.rsa.rsa_decrypt.message_lb.ForeColor = textcolor
        tools.rsa.rsa_decrypt.message_lb.BackColor = bgcolor

        '// message_txt
        tools.rsa.rsa_decrypt.message_txt.ForeColor = inputtextcolor
        tools.rsa.rsa_decrypt.message_txt.BackColor = inputbackgroundcolor

        '// decrypt_bt
        tools.rsa.rsa_decrypt.decrypt_bt.ForeColor = textcolor
        tools.rsa.rsa_decrypt.decrypt_bt.BackColor = buttoncolor

        '// bit_cb
        tools.rsa.rsa_decrypt.bit_cb.ForeColor = inputtextcolor
        tools.rsa.rsa_decrypt.bit_cb.BackColor = inputbackgroundcolor
    End Sub
    Private Sub rsa_encrypt_color()
        '// form_head
        tools.rsa.rsa_encrypt.form_head.ForeColor = textcolor
        tools.rsa.rsa_encrypt.form_head.BackColor = formheadcolor

        '// exit_bt
        tools.rsa.rsa_encrypt.exit_bt.ForeColor = textcolor
        tools.rsa.rsa_encrypt.exit_bt.BackColor = formheadcolor

        '// minimize_bt
        tools.rsa.rsa_encrypt.minimze_bt.ForeColor = textcolor
        tools.rsa.rsa_encrypt.minimze_bt.BackColor = formheadcolor

        '// wincrypttitle
        tools.rsa.rsa_encrypt.wincrypttitle.ForeColor = textcolor
        tools.rsa.rsa_encrypt.wincrypttitle.BackColor = formheadcolor

        '// wincrypt_icon
        tools.rsa.rsa_encrypt.wincrypt_icon.BackColor = formheadcolor

        '// rsa_encrypt
        tools.rsa.rsa_encrypt.ForeColor = textcolor
        tools.rsa.rsa_encrypt.BackColor = bgcolor

        '// pubkey_lb
        tools.rsa.rsa_encrypt.pubkey_lb.ForeColor = textcolor
        tools.rsa.rsa_encrypt.pubkey_lb.BackColor = bgcolor

        '// pubkey_path_txt
        tools.rsa.rsa_encrypt.pubkey_path_txt.ForeColor = inputtextcolor
        tools.rsa.rsa_encrypt.pubkey_path_txt.BackColor = inputbackgroundcolor

        '// pubkey_path_bt
        tools.rsa.rsa_encrypt.pubkey_path_bt.ForeColor = textcolor
        tools.rsa.rsa_encrypt.pubkey_path_bt.BackColor = buttoncolor

        '// message_lb
        tools.rsa.rsa_encrypt.message_lb.ForeColor = textcolor
        tools.rsa.rsa_encrypt.message_lb.BackColor = bgcolor

        '// encryption_message_txt
        tools.rsa.rsa_encrypt.encryption_message_txt.ForeColor = inputtextcolor
        tools.rsa.rsa_encrypt.encryption_message_txt.BackColor = inputbackgroundcolor

        '// encryption_message_lb
        tools.rsa.rsa_encrypt.encryption_message_lb.ForeColor = textcolor
        tools.rsa.rsa_encrypt.encryption_message_lb.BackColor = bgcolor

        '// decryption_message_txt
        tools.rsa.rsa_encrypt.decryption_message_txt.ForeColor = inputtextcolor
        tools.rsa.rsa_encrypt.decryption_message_txt.BackColor = inputbackgroundcolor

        '// encryption_bt
        tools.rsa.rsa_encrypt.encryption_bt.ForeColor = textcolor
        tools.rsa.rsa_encrypt.encryption_bt.BackColor = buttoncolor

        '// bit_cb
        tools.rsa.rsa_encrypt.bit_cb.ForeColor = inputtextcolor
        tools.rsa.rsa_encrypt.bit_cb.BackColor = inputbackgroundcolor
    End Sub
    Private Sub del_report_color()
        '// form_head
        tools.safedelete.del_report.form_head.ForeColor = textcolor
        tools.safedelete.del_report.form_head.BackColor = formheadcolor

        '// exit_bt
        tools.safedelete.del_report.exit_bt.ForeColor = textcolor
        tools.safedelete.del_report.exit_bt.BackColor = formheadcolor

        '// wincrypttitle
        tools.safedelete.del_report.wincrypttitle.ForeColor = textcolor
        tools.safedelete.del_report.wincrypttitle.BackColor = formheadcolor

        '// wincrypt_icon
        tools.safedelete.del_report.wincrypt_icon.BackColor = formheadcolor

        '// del_report
        tools.safedelete.del_report.ForeColor = textcolor
        tools.safedelete.del_report.BackColor = bgcolor

        '// report_txt
        tools.safedelete.del_report.report_txt.ForeColor = inputtextcolor
        tools.safedelete.del_report.report_txt.BackColor = inputbackgroundcolor

        '// ok_bt
        tools.safedelete.del_report.ok_bt.ForeColor = textcolor
        tools.safedelete.del_report.ok_bt.BackColor = buttoncolor

        '// saveas_bt
        tools.safedelete.del_report.saveas_bt.ForeColor = textcolor
        tools.safedelete.del_report.saveas_bt.BackColor = buttoncolor
    End Sub
    Private Sub safedelete_color()
        '// form_head
        tools.safedelete.safedelete.form_head.ForeColor = textcolor
        tools.safedelete.safedelete.form_head.BackColor = formheadcolor

        '// exit_bt
        tools.safedelete.safedelete.exit_bt.ForeColor = textcolor
        tools.safedelete.safedelete.exit_bt.BackColor = formheadcolor

        '// minimize_bt
        tools.safedelete.safedelete.minimize_bt.ForeColor = textcolor
        tools.safedelete.safedelete.minimize_bt.BackColor = formheadcolor

        '// wincrypttitle
        tools.safedelete.safedelete.wincrypttitle.ForeColor = textcolor
        tools.safedelete.safedelete.wincrypttitle.BackColor = formheadcolor

        '// wincrypt_icon
        tools.safedelete.safedelete.wincrypt_icon.BackColor = formheadcolor

        '// safedelete
        tools.safedelete.safedelete.ForeColor = textcolor
        tools.safedelete.safedelete.BackColor = bgcolor

        '// filelb
        tools.safedelete.safedelete.filelb.ForeColor = textcolor
        tools.safedelete.safedelete.filelb.BackColor = bgcolor

        '// file_txt
        tools.safedelete.safedelete.file_txt.ForeColor = inputtextcolor
        tools.safedelete.safedelete.file_txt.BackColor = inputbackgroundcolor

        '// selectpathbt
        tools.safedelete.safedelete.selectpathbt.ForeColor = textcolor
        tools.safedelete.safedelete.selectpathbt.BackColor = buttoncolor

        '// overwritelb
        tools.safedelete.safedelete.overwritelb.ForeColor = textcolor
        tools.safedelete.safedelete.overwritelb.BackColor = bgcolor

        '// overwritecb
        tools.safedelete.safedelete.overwritecb.ForeColor = inputtextcolor
        tools.safedelete.safedelete.overwritecb.BackColor = inputbackgroundcolor

        '// fileaddbt
        tools.safedelete.safedelete.fileaddbt.ForeColor = textcolor
        tools.safedelete.safedelete.fileaddbt.BackColor = buttoncolor

        '// override_pb_lb
        tools.safedelete.safedelete.override_pb_lb.ForeColor = textcolor
        tools.safedelete.safedelete.override_pb_lb.BackColor = bgcolor

        '// statuslb
        tools.safedelete.safedelete.statuslb.ForeColor = textcolor
        tools.safedelete.safedelete.statuslb.BackColor = bgcolor

        '// deletfilelist
        tools.safedelete.safedelete.deletfilelist.ForeColor = inputtextcolor
        tools.safedelete.safedelete.deletfilelist.BackColor = inputbackgroundcolor

        '// report_bt
        tools.safedelete.safedelete.report_bt.ForeColor = textcolor
        tools.safedelete.safedelete.report_bt.BackColor = buttoncolor

        '// abort_bt
        tools.safedelete.safedelete.abort_bt.ForeColor = textcolor
        tools.safedelete.safedelete.abort_bt.BackColor = buttoncolor

        '// deletebt
        tools.safedelete.safedelete.deletebt.ForeColor = textcolor
        tools.safedelete.safedelete.deletebt.BackColor = buttoncolor

        '// cleanlb1
        tools.safedelete.safedelete.cleanlb1.BackColor = buttoncolor

        '// removeentrybt
        tools.safedelete.safedelete.removeentrybt.ForeColor = textcolor
        tools.safedelete.safedelete.removeentrybt.BackColor = buttoncolor
    End Sub
    Private Sub Textencrypt_color()
        '// form_head
        tools.text_encryption.Textencrypt.form_head.ForeColor = textcolor
        tools.text_encryption.Textencrypt.form_head.BackColor = formheadcolor

        '// exit_bt
        tools.text_encryption.Textencrypt.exit_bt.ForeColor = textcolor
        tools.text_encryption.Textencrypt.exit_bt.BackColor = formheadcolor

        '// minimize_bt
        tools.text_encryption.Textencrypt.minimize_bt.ForeColor = textcolor
        tools.text_encryption.Textencrypt.minimize_bt.BackColor = formheadcolor

        '// wincrypttitle
        tools.text_encryption.Textencrypt.wincrypttitle.ForeColor = textcolor
        tools.text_encryption.Textencrypt.wincrypttitle.BackColor = formheadcolor

        '// wincrypt_icon
        tools.text_encryption.Textencrypt.wincrypt_icon.BackColor = formheadcolor

        '// Textencrypt
        tools.text_encryption.Textencrypt.ForeColor = textcolor
        tools.text_encryption.Textencrypt.BackColor = bgcolor

        '// encrypt_lb
        tools.text_encryption.Textencrypt.encrypt_lb.ForeColor = textcolor
        tools.text_encryption.Textencrypt.encrypt_lb.BackColor = bgcolor

        '// TrackBar
        tools.text_encryption.Textencrypt.TrackBar.BackColor = bgcolor

        '// decrypt_lb
        tools.text_encryption.Textencrypt.decrypt_lb.ForeColor = textcolor
        tools.text_encryption.Textencrypt.decrypt_lb.BackColor = bgcolor

        '// arab_cb
        tools.text_encryption.Textencrypt.arab_cb.ForeColor = textcolor
        tools.text_encryption.Textencrypt.arab_cb.BackColor = bgcolor

        '// text_input
        tools.text_encryption.Textencrypt.text_input.ForeColor = inputtextcolor
        tools.text_encryption.Textencrypt.text_input.BackColor = inputbackgroundcolor

        '// arrow_1
        tools.text_encryption.Textencrypt.arrow_1.BackColor = bgcolor

        '// arrow_2
        tools.text_encryption.Textencrypt.arrow_2.BackColor = bgcolor

        '// arrow_3
        tools.text_encryption.Textencrypt.arrow_3.BackColor = bgcolor

        '// text_output
        tools.text_encryption.Textencrypt.text_output.ForeColor = inputtextcolor
        tools.text_encryption.Textencrypt.text_output.BackColor = inputbackgroundcolor

        '// password_lb
        tools.text_encryption.Textencrypt.password_lb.ForeColor = textcolor
        tools.text_encryption.Textencrypt.password_lb.BackColor = bgcolor

        '// password_txt
        tools.text_encryption.Textencrypt.password_txt.ForeColor = inputtextcolor
        tools.text_encryption.Textencrypt.password_txt.BackColor = inputbackgroundcolor

        '// generate_bt
        tools.text_encryption.Textencrypt.generate_bt.ForeColor = textcolor
        tools.text_encryption.Textencrypt.generate_bt.BackColor = buttoncolor

        '// decrypt_bt
        tools.text_encryption.Textencrypt.decrypt_bt.ForeColor = textcolor
        tools.text_encryption.Textencrypt.decrypt_bt.BackColor = buttoncolor

        '// encrypt_bt
        tools.text_encryption.Textencrypt.encrypt_bt.ForeColor = textcolor
        tools.text_encryption.Textencrypt.encrypt_bt.BackColor = buttoncolor

        tools.text_encryption.Textencrypt.algo_cb.ForeColor = inputtextcolor
        tools.text_encryption.Textencrypt.algo_cb.BackColor = inputbackgroundcolor
    End Sub

    Private Sub md5filehash()
        FileHash_frm.form_head.BackColor = formheadcolor
        FileHash_frm.wincrypttitle.BackColor = formheadcolor
        FileHash_frm.wincrypt_icon.BackColor = formheadcolor
        FileHash_frm.minimize_bt.BackColor = formheadcolor
        FileHash_frm.exit_bt.BackColor = formheadcolor
        FileHash_frm.exit_bt.ForeColor = textcolor
        FileHash_frm.minimize_bt.ForeColor = textcolor
        FileHash_frm.wincrypttitle.ForeColor = textcolor
        FileHash_frm.file_lb.ForeColor = textcolor
        FileHash_frm.md5_lb.ForeColor = textcolor
        FileHash_frm.open_bt.ForeColor = textcolor
        FileHash_frm.copy_bt.ForeColor = textcolor
        FileHash_frm.generate_bt.ForeColor = textcolor
        FileHash_frm.ForeColor = textcolor
        FileHash_frm.md5_lb.ForeColor = textcolor
        FileHash_frm.BackColor = bgcolor
        FileHash_frm.file_lb.BackColor = bgcolor
        FileHash_frm.file_txt.ForeColor = inputtextcolor
        FileHash_frm.file_txt.BackColor = inputbackgroundcolor
        FileHash_frm.md5_hash_txt.ForeColor = inputtextcolor
        FileHash_frm.md5_hash_txt.BackColor = inputbackgroundcolor
        FileHash_frm.copy_bt.BackColor = buttoncolor
        FileHash_frm.open_bt.BackColor = buttoncolor
        FileHash_frm.select_Hash_combo.ForeColor = inputtextcolor
        FileHash_frm.select_Hash_combo.BackColor = inputbackgroundcolor
        FileHash_frm.generate_bt.BackColor = buttoncolor
    End Sub
End Class
