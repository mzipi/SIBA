Public Class Reporte3

    Private Sub Reporte3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer2.ReportSource = My.Application.Info.DirectoryPath + "\..\..\3Reporte.rpt"
        OpenFileDialog1.InitialDirectory = My.Application.Info.DirectoryPath + "\..\..\3Reporte.rpt("")"
    End Sub

    Private Sub CrystalReportViewer2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer2.Load

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub
End Class