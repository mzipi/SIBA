Public Class modDocente
    Public Sub New()
        InitializeComponent()

        Dim toolTip As New ToolTip
        toolTip.SetToolTip(txtci, "Debe ingresar solo números sin puntos ni guión. Ej.1234567 ")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        txtnombre.Clear()
        txtci.Clear()
        txtant.Clear()
        txtformac.Clear()
        txttel.Clear()
        cmbgrado.SelectedIndex = 0
        cmbestfun.SelectedIndex = 0

        abmdocentes.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click

        Dim sql As String = ""
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand

        If (txtnombre.Text = "") Then
            MsgBox("Debe ingresar un nombre de docente")
        End If
        If (txtci.Text = "") Then
            MsgBox("Debe ingresar la cédula de identidad")
        End If
        If (txttel.Text = "") Then
            MsgBox("Debe ingresar un número de teléfono")

        End If

        If (cmbgrado.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar el grado del docente")

        End If

        If (cmbestfun.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar estado funcional del docente")

        End If

        If (txtnombre.Text <> "" And txtci.Text <> "" And txttel.Text <> "" And cmbestfun.SelectedIndex <> 0 And cmbgrado.SelectedIndex <> 0) Then
            Sql = "UPDATE docentes SET "
            sql += "ci = " + txtci.Text + ","
            Sql += "nombre_completo='" + txtnombre.Text + "',"
            sql += "grado='" + cmbgrado.SelectedItem + "',"
            Sql += "antiguedad=" + txtant.Text + ","
            Sql += "form_acad='" + txtformac.Text + "',"
            Sql += "tel=" + txttel.Text + ","
            Sql += "estado_funcional='" + cmbestfun.SelectedItem + "',"
            Sql += "vac_desde='" + txtvac_desde.Text + " ',"
            sql += "vac_hasta='" + txtvac_hasta.Text + "'"
            sql += "where ci = " + undocente.ci.ToString
            MsgBox("Docente modificado exitosamente")
            cx.ConnectionString = "FileDsn=c:\sibapro.dsn;UID=developer;PWD=developer"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = sql
            cm.ExecuteNonQuery()
            abmdocentes.Show()
            Me.Close()
        
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                txtnombre.Clear()
                txtci.Clear()
                txtant.Clear()
                txtformac.Clear()
                txttel.Clear()
                cmbgrado.SelectedIndex = 0
                cmbestfun.SelectedIndex = 0
                login.cmbpass.SelectedIndex = 0
                login.cmbnomu.SelectedIndex = 0

                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub txtant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtant.KeyPress

        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtant_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtant.TextChanged

    End Sub

    Private Sub txttel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttel.KeyPress

        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txttel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttel.TextChanged

    End Sub

    Private Sub modDocente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With undocente
            txtci.Text = .ci
            txtnombre.Text = .nombre_completo
            cmbgrado.SelectedItem = .grado
            txtant.Text = .antiguedad
            txtformac.Text = .form_acad
            txttel.Text = .tel
            cmbestfun.SelectedItem = .estado_funcional

        End With
    End Sub

    Private Sub txtci_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtci.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If

    End Sub

    Private Sub txtci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtci.TextChanged

    End Sub

    Private Sub gbxdoc_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbxdoc.Enter

    End Sub

    Private Sub cmbgrado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbgrado.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmbgrado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbgrado.SelectedIndexChanged

    End Sub

    Private Sub cmbestfun_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbestfun.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If

    End Sub

    Private Sub cmbestfun_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbestfun.SelectedIndexChanged

    End Sub

    Private Sub txtvac_desde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvac_desde.TextChanged

    End Sub
End Class
