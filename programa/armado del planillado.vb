Public Class armado_del_planillado



    
    Private Sub armado_del_planillado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim turnos()() As String
        Dim i As Integer
        i = 0
        ReDim turnos(2)(6)
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New Data.DataSet
        cx.ConnectionString = "FileDsn=C:\FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx.Open()
        cm.Connection = cx
        cm.CommandText = "SELECT nombre_turno from turno "
        cm.CommandText = "SELECT inicio,fin,nombre_turno from horas,se_divide,turno where horas.id_horas=se_divide.id_horas and turno.id_turno=se_divide.id_turno"
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "turno")
        dgvplanillado.DataSource = ds.Tables("turno")
        dgvplanillado.Columns(0).DefaultCellStyle.Format = "hh:mm"

        txb.Text = dgvplanillado.Item(0, 0).Value.ToString
        While (i < 3)

            ' ltvplanillado.Items.Item(i) = txb.Text



            'turnos(i) = dgvplanillado.Item(0, i).Value.ToString
            MsgBox("Turno:" + turnos(i).ToString)
            'ltvplanillado.columns(i) = turnos.ToString(i)
            i = i + 1

        End While
    End Sub

    Private Sub dgvplanillado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvplanillado.CellContentClick

    End Sub

    Private Sub txb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txb.TextChanged

    End Sub
End Class