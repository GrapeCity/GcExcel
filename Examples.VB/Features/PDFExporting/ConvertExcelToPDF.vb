﻿Imports System.IO

Namespace Features.PDFExporting
    Public Class ConvertExcelToPDF
        Inherits ExampleBase
        Public Overrides Sub Execute(workbook As Excel.Workbook)
            Dim fileStream As Stream = GetResourceStream("Employee absence schedule.xlsx")
            workbook.Open(fileStream)
        End Sub
        Public Overrides ReadOnly Property SavePdf As Boolean
            Get
                Return True
            End Get
        End Property
        Public Overrides ReadOnly Property ShowViewer As Boolean
            Get
                Return False
            End Get
        End Property
        Public Overrides ReadOnly Property TemplateName As String
            Get
                Return "Employee absence schedule.xlsx"
            End Get
        End Property
        Public Overrides ReadOnly Property UsedResources As String()
            Get
                Return New String() {"xlsx\Employee absence schedule.xlsx"}
            End Get
        End Property
    End Class
End Namespace