Public Class consultademateria

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Reporte4_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CrystalReportViewer1.ReportSource = My.Application.Info.DirectoryPath + "\..\..\4Reporte.rpt"
        OpenFileDialog1.InitialDirectory = My.Application.Info.DirectoryPath + "\..\..\4Reporte.rpt("")"
    End Sub
End Class