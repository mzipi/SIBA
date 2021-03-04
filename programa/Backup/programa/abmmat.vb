Public Class abmMateria

    Private Sub Form31_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If (ltvmatcar.SelectedItems.Count = 0) Then
            MsgBox("Debe seleccionar una materia y luego presionar Modificar")
        End If

        If (ltvmatcar.SelectedItems.Count > 0) Then
            If (modMateria.txtcod.Text = "Mat 3") Then
                modMateria.txtnombre.Text = "Matemáticas"
                modMateria.txtnomcar.Text = "EMT INFORMÁTICA"
                modMateria.Show()
                Me.Hide()

            ElseIf (modMateria.txtcod.Text = "Prog3") Then
                modMateria.txtnombre.Text = "Programación"
                modMateria.txtnomcar.Text = "EMT INFORMÁTICA"
                modMateria.Show()
                Me.Hide()

            Else
                modMateria.Show()
                Me.Hide()
            End If
        End If



        


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        bajamat.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        altaMateria.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        asignhoramat.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        abmcarreras.Show()
        Me.Hide()
    End Sub

    Private Sub ltvmatcar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltvmatcar.SelectedIndexChanged
        If ltvmatcar.SelectedItems.Count > 0 Then modMateria.txtcod.Text = ltvmatcar.SelectedItems.Item(0).Text
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes

                login.cmbnomu.SelectedIndex = 0
                login.cmbpass.SelectedIndex = 0
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No

                Me.Show()
        End Select
    End Sub
End Class