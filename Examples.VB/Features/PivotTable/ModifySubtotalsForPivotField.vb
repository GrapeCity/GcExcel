﻿Namespace Features.PivotTable
    Public Class ModifySubtotalsForPivotField
        Inherits ExampleBase
        Public Overrides Sub Execute(workbook As Excel.Workbook)
            Dim sourceData As Object(,) = {
                {"Order ID", "Product", "Category", "Amount", "Date", "Country"},
                {1, "Carrots", "Vegetables", 4270, #1/6/2018#, "United States"},
                {2, "Broccoli", "Vegetables", 8239, #1/7/2018#, "United Kingdom"},
                {3, "Banana", "Fruit", 617, #1/8/2018#, "United States"},
                {4, "Banana", "Fruit", 8384, #1/10/2018#, "Canada"},
                {5, "Beans", "Vegetables", 2626, #1/10/2018#, "Germany"},
                {6, "Orange", "Fruit", 3610, #1/11/2018#, "United States"},
                {7, "Broccoli", "Vegetables", 9062, #1/11/2018#, "Australia"},
                {8, "Banana", "Fruit", 6906, #1/16/2018#, "New Zealand"},
                {9, "Apple", "Fruit", 2417, #1/16/2018#, "France"},
                {10, "Apple", "Fruit", 7431, #1/16/2018#, "Canada"},
                {11, "Banana", "Fruit", 8250, #1/16/2018#, "Germany"},
                {12, "Broccoli", "Vegetables", 7012, #1/18/2018#, "United States"},
                {13, "Carrots", "Vegetables", 1903, #1/20/2018#, "Germany"},
                {14, "Broccoli", "Vegetables", 2824, #1/22/2018#, "Canada"},
                {15, "Apple", "Fruit", 6946, #1/24/2018#, "France"}
            }

            Dim worksheet As IWorksheet = workbook.Worksheets(0)

            worksheet.Range("A1:F16").Value = sourceData
            Dim pivotcache = workbook.PivotCaches.Create(worksheet.Range("A1:F16"))
            Dim pivottable = worksheet.PivotTables.Add(pivotcache, worksheet.Range!I2, "pivottable1")
            worksheet.Range("D2:D16").NumberFormat = "$#,##0.00"
            worksheet.Range("J4:J17, J9:J33").NumberFormat = "$#,##0.00"

            Dim field_Category = pivottable.PivotFields(2)
            field_Category.Orientation = PivotFieldOrientation.RowField

            Dim field_Product = pivottable.PivotFields(1)
            field_Product.Orientation = PivotFieldOrientation.RowField

            Dim field_Amount = pivottable.PivotFields(3)
            field_Amount.Orientation = PivotFieldOrientation.DataField

            'modify subtotals for pivot field.
            field_Category.Subtotals = SubtotalType.Sum Or SubtotalType.Count Or SubtotalType.Average Or SubtotalType.Max Or SubtotalType.Min Or SubtotalType.CountNums Or SubtotalType.StdDev Or SubtotalType.StdDevP Or SubtotalType.Var Or SubtotalType.VarP
            worksheet.Range("E:E").ColumnWidth = 12
            worksheet.Range("I:J").ColumnWidth = 20
        End Sub
        Public Overrides ReadOnly Property ShowViewer As Boolean
            Get
                Return False
            End Get
        End Property
        Public Overrides ReadOnly Property ShowScreenshot As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
