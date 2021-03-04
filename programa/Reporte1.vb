Public Class Reporte1

    Private Sub Reporte1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.ReportSource = My.Application.Info.DirectoryPath + "\..\..\1Reporte.rpt"
        OpenFileDialog1.InitialDirectory = My.Application.Info.DirectoryPath + "\..\..\1Reporte.rpt("")"
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub
End Class