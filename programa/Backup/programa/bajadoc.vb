Public Class bajaDocente

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnelim.Click
        Dim sql As String = ""
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand

        sql = "DELETE FROM docentes WHERE CI = " + txtci.Text
        cx.ConnectionString = "FileDsn=c:\sibapro.dsn;UID=developer;PWD=developer"
        cx.Open()
        cm.Connection = cx
        cm.CommandText = sql
        cm.ExecuteNonQuery()
        abmdocentes.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        abmdocentes.Show()
        Me.Hide()

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltitulo.Click

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes

                login.cmbpass.SelectedIndex = 0
                login.cmbnomu.SelectedIndex = 0

                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub ltvdocentes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub bajaDocente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        With undocente
            txtci.Text = .ci
            txtnombre.Text = .nombre_completo
            cmbgrado.SelectedItem = .grado
            txtant.Text = .antiguedad
            txtformac.Text = .form_acad
            txttel.Text = .tel
            cmbestfun.SelectedItem = .estado_funcional

        End With
        txtci.Enabled = False
        txtnombre.Enabled = False
        cmbgrado.Enabled = False
        txtant.Enabled = False
        txtformac.Enabled = False
        txttel.Enabled = False
        cmbestfun.Enabled = False


    End Sub

    Private Sub cmbgrado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbgrado.SelectedIndexChanged

    End Sub
End Class