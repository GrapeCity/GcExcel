﻿Namespace Features.PDFExporting.ExportChart
    Public Class DisplayUnitLabelPdf
        Inherits ExampleBase
        Public Overrides Sub Execute(workbook As Excel.Workbook)
            Dim worksheet As IWorksheet = workbook.Worksheets(0)

            Dim shape As IShape = worksheet.Shapes.AddChart(ChartType.ColumnClustered, 20, 200, 360, 230)

            worksheet.Range("A1:D6").Value = New Object(,) {
                {Nothing, "S1", "S2", "S3"},
                {"Item1", 10, 25, 25},
                {"Item2", -51, -36, 27},
                {"Item3", 52, -85, -30},
                {"Item4", 22, 65, 65},
                {"Item5", 23, 69, 69}
            }

            shape.Chart.SeriesCollection.Add(worksheet.Range("A1:D6"), RowCol.Columns, True, True)

            With shape.Chart.Axes.Item(AxisType.Value)
                .DisplayUnit = DisplayUnit.Custom
                .DisplayUnitCustom = 100
                .HasDisplayUnitLabel = True
            End With
        End Sub
    End Class
End Namespace
