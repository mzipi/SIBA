Imports System.Data.Odbc

Public Class abmdocentes

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalta.Click
        accion = acciones.ingresar
        altaDocente.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click
        If (dgvdoc.SelectedRows.Count = 0) Then
            MsgBox("Para modificar seleccione una fila de la lista y luego presione modificar")
        End If
        If (dgvdoc.SelectedRows.Count <> 0) Then
            accion = acciones.modificar
            With dgvdoc.SelectedRows.Item(0)
                undocente.ci = .Cells(0).Value
                undocente.nombre_completo = .Cells(1).Value
                undocente.grado = .Cells(2).Value
                undocente.antiguedad = .Cells(3).Value
                undocente.form_acad = .Cells(4).Value
                undocente.tel = .Cells(5).Value
                undocente.estado_funcional = .Cells(6).Value

            End With
            modDocente.Show()
            Me.Close()

        End If
        

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaja.Click
        If (dgvdoc.SelectedRows.Count = 0) Then
            MsgBox("Para eliminar seleccione una fila de la lista y luego presione eliminar")
        End If
        If (dgvdoc.SelectedRows.Count <> 0) Then
            accion = acciones.eliminar
            With dgvdoc.SelectedRows.Item(0)
                undocente.ci = .Cells(0).Value
                undocente.nombre_completo = .Cells(1).Value
                undocente.grado = .Cells(2).Value
                undocente.antiguedad = .Cells(3).Value
                undocente.form_acad = .Cells(4).Value
                undocente.tel = .Cells(5).Value
                undocente.estado_funcional = .Cells(6).Value

            End With
            bajaDocente.Show()
            Me.Close()

        End If
        
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnasigngrup.Click
        asignarGrupo.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        menupse.Show()
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

  

    Private Sub abmdocentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New Data.DataSet
        cx.ConnectionString = "FileDsn=C:\sibapro.dsn;UID=developer;PWD=developer"
        cx.Open()
        cm.Connection = cx
        cm.CommandText = "SELECT * FROM docentes"
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "docentes")
        dgvdoc.DataSource = ds.Tables("docentes")
    End Sub
End Class