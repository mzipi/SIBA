Public Class iReporte3

    Private Sub iReporte3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer2.ReportSource = My.Application.Info.DirectoryPath + "\..\..\i3Reporte.rpt"
        OpenFileDialog1.InitialDirectory = My.Application.Info.DirectoryPath + "\..\..\i3Reporte.rpt("")"
    End Sub
End Class