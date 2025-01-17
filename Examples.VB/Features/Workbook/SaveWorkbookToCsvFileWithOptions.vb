﻿Namespace Features.Workbook
    Public Class SaveWorkbookToCsvFileWithOptions
        Inherits ExampleBase
        Public Overrides Sub Execute(workbook As Excel.Workbook)
            Dim data As Object(,) = {
                {"Name", "City", "Birthday", "Sex", "Weight", "Height"},
                {"Bob", "NewYork", #6/8/1968#, "male", 80, 180},
                {"Betty", "NewYork", #7/3/1972#, "female", 72, 168},
                {"Gary", "NewYork", #3/2/1964#, "male", 71, 179},
                {"Hunk", "Washington", #8/8/1972#, "male", 80, 171},
                {"Cherry", "Washington", #2/2/1986#, "female", 58, 161},
                {"Eva", "Washington", #2/5/1993#, "female", 71, 180}
            }

            'Set data.
            Dim sheet As IWorksheet = workbook.Worksheets(0)
            sheet.Range("A1:F7").Value = data
            sheet.Tables.Add(sheet.Range("A1:F7"), True)

            'Save csv options
            Dim options As New CsvSaveOptions With {
                .ColumnSeparator = "-"
            }

            'Change the path to real export path when save.
            workbook.Save(IO.Path.Combine(CurrentDirectory, "dest.csv"), options)
        End Sub
        Public Overrides ReadOnly Property CanDownload As Boolean
            Get
                Return False
            End Get
        End Property
        Public Overrides ReadOnly Property ShowViewer As Boolean
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace
