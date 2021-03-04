Imports System.Data.Odbc

Public Class login
    Dim TEXTBOX6 As TextBox



    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.BackgroundImageChanged, Label4.ForeColorChanged

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub SIBA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblbienvenido.Visible = False

        txtperfil.Visible = False
        txtnomusuario.Visible = False
        txtperfili.Visible = False

        txtusername.Visible = False
        txtusuario.Text = ""
        txtpass.Text = ""
        GroupBox1.Visible = False
        GroupBox5.Visible = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If (txtusuario.Text <> "" And txtpass.Text <> "") Then

            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim lector As Odbc.OdbcDataReader

            cx.ConnectionString = "FileDsn=C:\techplus.dsn;UID=techplus;PWD=1234"
            cx.Open()

            cm.CommandText = "SELECT nombre_apellido,perfil_usuario from usuarios where nombre_usuario ='" + txtusuario.Text + "' and contrasenia='" + txtpass.Text + "'"
            cm.Connection = cx
            lector = cm.ExecuteReader()
            If lector.HasRows Then
                txtperfil.Text = lector.GetString(1)
                txtnomusuario.Text = lector.GetString(0)
                MsgBox("Usuario  " + txtnomusuario.Text)
                MsgBox("Perfil " + txtperfil.Text)

                cx.Close()
            Else
                MsgBox("Error, Usuario y/o contraseña incorrecta")
                cx.Close()
            End If


        End If

        If (txtpass.Text = "" Or txtusuario.Text = "") Then
            MsgBox("Debe ingresar usuario y/o contraseña para loguearse")

        End If

        Dim usuario As String
        usuario = txtperfil.Text


        If (txtperfil.Text <> "") Then
            Select Case usuario
                Case "Administrativo"
                    Dim cx As New Odbc.OdbcConnection
                    Dim cm As New Odbc.OdbcCommand


                    cx.ConnectionString = "FileDSN=c:\itechplus_adm.dsn;UID=techplus_adm;pwd=1234"
                    cx.Open()

                    menupadm.lblnombreu.Text = txtnomusuario.Text
                    menupadm.lbltipou.Text = txtperfil.Text
                    menupadm.Show()
                    Me.Hide()

                Case "Alumno"
                    Dim cx As New Odbc.OdbcConnection
                    Dim cm As New Odbc.OdbcCommand


                    cx.ConnectionString = "FileDSN=c:\itechplus_alu.dsn;UID=techplus_alu;pwd=1234"
                    cx.Open()

                    menupalum.lbltipou.Text = txtperfil.Text
                    menupalum.lblnombreu.Text = txtnomusuario.Text

                    menupalum.Show()
                    Me.Close()
                Case "Director"
                    Dim cx As New Odbc.OdbcConnection
                    Dim cm As New Odbc.OdbcCommand

                    cx.ConnectionString = "FileDSN=c:\itechplus_dir.dsn;UID=techplus_dir;pwd=1234"
                    cx.Open()
                    menupdir.lblnombreu.Text = txtnomusuario.Text
                    menupdir.lbltipou.Text = txtperfil.Text
                    menupdir.Show()

                    Me.Close()
                Case "Docente"
                    Dim cx As New Odbc.OdbcConnection
                    Dim cm As New Odbc.OdbcCommand

                    cx.ConnectionString = "FileDSN=c:\itechplus_doc.dsn;UID=techplus_doc;pwd=1234"
                    cx.Open()


                    menupdoc.lblnombreu.Text = txtusuario.Text
                    conshordoc.lbltipou.Text = txtperfil.Text
                    conshordoc.lbltipou.Text = txtperfil.Text

                    menupdoc.Show()
                    Me.Close()

                Case "Encargado Informático"
                    Dim cx As New Odbc.OdbcConnection
                    Dim cm As New Odbc.OdbcCommand

                    cx.ConnectionString = "FileDSN=c:\itechplus_enc.dsn;UID=techplus_enc;pwd=1234"
                    cx.Open()
                    menurepei.lblnombreu.Text = txtnomusuario.Text

                    menurepei.Show()
                    Me.Close()

                    
                Case "Secretario Escolar"
                    Dim cx As New Odbc.OdbcConnection
                    Dim cm As New Odbc.OdbcCommand

                    cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                    cx.Open()
                    menupse.lblnombreu.Text = txtnomusuario.Text
                    menupse.lbltipou.Text = txtperfil.Text
                    conshordoc.lbltipou.Text = txtperfil.Text


                    menupse.Show()
                    Me.Close()

                    
            End Select
        End If


        



    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        GroupBox2.Visible = False
        GroupBox1.Visible = True
        GroupBox1.SetBounds(100, 60, 258, 256)
        Label1.Visible = False
        GroupBox4.Visible = False
        GroupBox3.SetBounds(12, 60, 75, 95)
        lblsiba.Visible = False
        Label2.Visible = False
        lblbienvenido.Visible = True
        lblbienvenido.Text = "BIENVENIDO"
        lblbienvenido.SetBounds(157, 9, 232, 39)


    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        GroupBox5.Visible = True
        GroupBox5.SetBounds(100, 60, 258, 256)
        GroupBox3.Visible = False
        GroupBox2.Visible = False
        GroupBox4.SetBounds(12, 60, 77, 95)
        Label2.Visible = False
        Label1.Visible = False
        lblbienvenido.Text = "WELCOME:"
        lblbienvenido.Visible = True
        lblbienvenido.SetBounds(157, 9, 232, 39)
        lblsiba.Visible = False

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (txtuser.Text <> "" And txtpw.Text <> "") Then

            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim lector As Odbc.OdbcDataReader

            cx.ConnectionString = "FileDsn=C:\techplus.dsn;UID=techplus;PWD=1234"
            cx.Open()

            cm.CommandText = "SELECT nombre_apellido,perfil_usuario from usuarios where nombre_usuario ='" + txtuser.Text + "' and contrasenia='" + txtpw.Text + "'"
            cm.Connection = cx
            lector = cm.ExecuteReader()
            If lector.HasRows Then
                txtperfili.Text = lector.GetString(1)
                txtusername.Text = lector.GetString(0)

                cx.Close()
            Else
                MsgBox("Error, Invalid user and/or password")
                cx.Close()
            End If


        End If

        If (txtpw.Text = "" Or txtuser.Text = "") Then
            MsgBox("Must enter a username and password for login")

        End If

        Dim usuario As String
        usuario = txtperfili.Text


        If (txtperfili.Text <> "") Then
            Select Case usuario
                Case "Administrativo"
                    Dim cx As New Odbc.OdbcConnection
                    Dim cm As New Odbc.OdbcCommand


                    cx.ConnectionString = "FileDSN=c:\itechplus_adm.dsn;UID=techplus_adm;pwd=1234"
                    cx.Open()
                    imenupadm.lblnombreu.Text = txtusuario.Text
                    imenupadm.Show()
                    Me.Hide()


                Case ("Alumno")
                    Dim cx As New Odbc.OdbcConnection
                    Dim cm As New Odbc.OdbcCommand


                    cx.ConnectionString = "FileDSN=c:\itechplus_alu.dsn;UID=techplus_alu;pwd=1234"
                    cx.Open()

                    imenupalum.lbltipou.Text = txtperfil.Text
                    imenupalum.lblnombreu.Text = txtusuario.Text
                    imenupalum.Show()
                    Me.Close()
                    
                Case "Director"
                    Dim cx As New Odbc.OdbcConnection
                    Dim cm As New Odbc.OdbcCommand

                    cx.ConnectionString = "FileDSN=c:\itechplus_dir.dsn;UID=techplus_dir;pwd=1234"
                    cx.Open()
                    imenupdir.lblnombreu.Text = txtusuario.Text
                    imenupdir.Show()

                    Me.Close()
                Case "Docente"
                    Dim cx As New Odbc.OdbcConnection
                    Dim cm As New Odbc.OdbcCommand

                    cx.ConnectionString = "FileDSN=c:\itechplus_doc.dsn;UID=techplus_doc;pwd=1234"
                    cx.Open()


                    imenupdoc.lblnombreu.Text = txtusuario.Text
                    iconshordoc.lbltipou.Text = txtperfil.Text
                    iconshordoc.lbltipou.Text = txtperfil.Text

                    imenupdoc.Show()
                    Me.Close()

                Case "Encargado Informático"
                    Dim cx As New Odbc.OdbcConnection
                    Dim cm As New Odbc.OdbcCommand

                    cx.ConnectionString = "FileDSN=c:\itechplus_enc.dsn;UID=techplus_enc;pwd=1234"
                    cx.Open()
                    imenurepei.lblnombreu.Text = txtusername.Text
                    imenurepei.Show()
                    Me.Close()



                Case "Secretario Escolar"
                    Dim cx As New Odbc.OdbcConnection
                    Dim cm As New Odbc.OdbcCommand

                    cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                    cx.Open()

                    imenupse.lbltipou.Text = "Secretary School"
                    imenupse.lblnombreu.Text = txtusername.Text
                    iconshordoc.lbltipou.Text = txtperfil.Text

                    imenupse.Show()
                    Me.Close()

                    
            End Select
        End If




    End Sub

    Private Sub txtusuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusuario.TextChanged

    End Sub

    Private Sub txtpass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpass.TextChanged

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub txtpw_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpw.TextChanged

    End Sub
End Class
