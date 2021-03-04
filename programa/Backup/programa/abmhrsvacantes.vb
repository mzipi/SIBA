Public Class abmhrsvacantes

    Private Sub btnbaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaja.Click
        bajahrsvacantes.Show()
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

    Private Sub btnalta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalta.Click
        altahrsvacantes.Show()
        Me.Hide()

    End Sub

    Private Sub btnmod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click
        MsgBox("Debe realizar doble click sobre un docente para modificar")
    End Sub

    Private Sub ltvhrsvac_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles ltvhrsvac.ItemSelectionChanged
        itmLV = e.ItemIndex
    End Sub
    Dim itmLV As Integer

    Private Sub ltvhrsvac_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ltvhrsvac.MouseDoubleClick
        Debug.WriteLine(itmLV.ToString & " " & ltvhrsvac.Items(itmLV).Text)
        Select Case itmLV
            Case 0
                modhrsvac.txtci.Text = 12345678
                modhrsvac.cmbestfunc.SelectedIndex = 5
                modhrsvac.Show()
                Me.Hide()

            Case 1
                modhrsvac.txtci.Text = 23456789
                modhrsvac.cmbestfunc.SelectedIndex = 2
                modhrsvac.Show()
                Me.Hide()
        End Select
    End Sub

    Private Sub ltvhrsvac_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltvhrsvac.SelectedIndexChanged
        If ltvhrsvac.SelectedItems.Count > 0 Then modhrsvac.txtnombredoc.Text = ltvhrsvac.SelectedItems.Item(0).Text
    End Sub

    Private Sub btnatras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        menupadm.Show()
        Me.Hide()

    End Sub
End Class