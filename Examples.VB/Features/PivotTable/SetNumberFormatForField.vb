﻿Namespace Features.PivotTable
    Public Class SetNumberFormatForField
        Inherits ExampleBase

        Public Overrides Sub Execute(workbook As Excel.Workbook)
            Dim sourceData(,) As Object = {
                {"Order ID", "Product", "Category", "Amount", "Date", "Country"},
                {1, "Carrots", "Vegetables", 4270, #2018-1-6#, "United States"},
                {2, "Broccoli", "Vegetables", 8239, #2018-1-7#, "United Kingdom"},
                {3, "Banana", "Fruit", 617, #2018-1-8#, "United States"},
                {4, "Banana", "Fruit", 8384, #2018-1-10#, "Canada"},
                {5, "Beans", "Vegetables", 2626, #2018-1-10#, "Germany"},
                {6, "Orange", "Fruit", 3610, #2018-1-11#, "United States"},
                {7, "Broccoli", "Vegetables", 9062, #2018-1-11#, "Australia"},
                {8, "Banana", "Fruit", 6906, #2018-1-16#, "New Zealand"},
                {9, "Apple", "Fruit", 2417, #2018-1-16#, "France"},
                {10, "Apple", "Fruit", 7431, #2018-1-16#, "Canada"},
                {11, "Banana", "Fruit", 8250, #2018-1-16#, "Germany"},
                {12, "Broccoli", "Vegetables", 7012, #2018-1-18#, "United States"},
                {13, "Carrots", "Vegetables", 1903, #2018-1-20#, "Germany"},
                {14, "Broccoli", "Vegetables", 2824, #2018-1-22#, "Canada"},
                {15, "Apple", "Fruit", 6946, #2018-1-24#, "France"}
            }

            Dim worksheet As IWorksheet = workbook.Worksheets(0)
            worksheet.Range("H1:M16").Value = sourceData
            worksheet.Range("H:M").ColumnWidth = 15
            Dim pivotcache = workbook.PivotCaches.Create(worksheet.Range("H1:M16"))
            Dim pivottable = worksheet.PivotTables.Add(pivotcache, worksheet.Range!A1, "pivottable1")
            worksheet.Range("K2:K16").NumberFormat = "$#,##0.00"

            'config pivot table's fields
            Dim field_Category = pivottable.PivotFields("Category")
            field_Category.Orientation = PivotFieldOrientation.ColumnField

            Dim field_Product = pivottable.PivotFields("Product")
            field_Product.Orientation = PivotFieldOrientation.RowField

            Dim field_Amount = pivottable.PivotFields("Amount")
            field_Amount.Orientation = PivotFieldOrientation.DataField

            Dim field_Country = pivottable.PivotFields("Country")
            field_Country.Orientation = PivotFieldOrientation.PageField

            ' Set number format for amount field
            field_Amount.NumberFormat = "$#,##0.00"

            worksheet.Range("A:D").Columns.AutoFit()
        End Sub

        Public Overrides ReadOnly Property ShowViewer As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
