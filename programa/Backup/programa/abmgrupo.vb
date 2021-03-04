Public Class abmGrupo

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalta.Click
        accion = acciones.ingresar
        altagrupo.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click
        If dgvgrupos.SelectedRows.Count = 0 Then
            MsgBox("Primero debe seleccionar un grupo")
        Else
            accion = acciones.modificar
            With ungrupo

            End With

            altagrupo.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaja.Click
        If dgvgrupos.SelectedRows.Count = 0 Then
            MsgBox("Primero debe seleccionar un grupo")
        Else
            accion = acciones.eliminar
            altagrupo.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        abmcarreras.Show()
        Me.Hide()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                login.cmbnomu.SelectedIndex = 0
                login.cmbpass.SelectedIndex = 0
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub abmGrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New Data.DataSet

        cx.ConnectionString = "FileDsn=C:\sibapro.dsn;UID=developer;PWD=developer"
        cx.Open()
        cm.Connection = cx
        cm.CommandText = "SELECT * FROM grupos"
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "grupos")
        dgvgrupos.DataSource = ds.Tables("grupos")
    End Sub
End Class