﻿Namespace SpreadSheetsViewer
    Public Class AgingReport
        Inherits ExampleBase

        Public Overrides Sub Execute(workbook As Workbook)
            'Load template file
            Dim fileStream = GetResourceStream("AgingReport.xlsx")
            workbook.Open(fileStream)
        End Sub

        Public Overrides ReadOnly Property TemplateName As String
            Get
                Return "AgingReport.xlsx"
            End Get
        End Property

        Public Overrides ReadOnly Property HasTemplate As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides ReadOnly Property IsViewReadOnly As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overrides ReadOnly Property ShowCode As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overrides ReadOnly Property CanDownloadZip As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overrides ReadOnly Property UsedResources As String()
            Get
                Return New String() {"xlsx\AgingReport.xlsx"}
            End Get
        End Property
    End Class

End Namespace
