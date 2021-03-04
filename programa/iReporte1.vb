Public Class iReporte1

    Private Sub iReporte1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.ReportSource = My.Application.Info.DirectoryPath + "\..\..\i1Reporte.rpt"
        OpenFileDialog1.InitialDirectory = My.Application.Info.DirectoryPath + "\..\..\i1Reporte.rpt("")"
    End Sub
End Class