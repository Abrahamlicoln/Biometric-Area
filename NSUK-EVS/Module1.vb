﻿Module Module1
    Public fptemplist As New List(Of DPFP.Template)
    Public listofnames As New List(Of String)
    Delegate Sub FunctionCall(ByVal param)
    Delegate Sub FunctionCall2(ByVal param, ByVal param)

    Public report1datatable As New DataTable
    Public report1source As New DataSet
    Public nameemodule As String
    Public date1 As String
    Public date2 As String
End Module
