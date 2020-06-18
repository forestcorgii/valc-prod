﻿Imports System.IO
'Public Batch As New BatchInfo
Public Class BatchInfos
    Inherits List(Of BatchInfo)

    Public Overloads Function Find(tripNumber As String) As BatchInfo
        Return (From res In Me Where res.TripNo = tripNumber Select res).FirstOrDefault
    End Function

End Class
Public Class BatchInfo
    Implements ICloneable

    Public TripNo As String = ""
    Public ClientEmailDateTime As String = ""
    Public ClientEmail As String = ""
    Public DDCSentEmailDateTime As String = ""
    Public BillCount As String = ""
    Public Folder As String = ""
    Public Synergized As String = ""
    Public Remarks As String = ""
    Public Type As String = ""

    <Xml.Serialization.XmlIgnore> Public BatchRow As DataGridViewRow
    <Xml.Serialization.XmlIgnore> Public ReadOnly Property Filename As String
        Get
            Dim f As String = Directory.GetFiles(DateFolder & "\BATCH\", "*" & TripNo & ".XML").FirstOrDefault
            If f Is Nothing Then f = Directory.GetFiles(DateFolder & "\BATCH\", "*" & TripNo & "_*.xml").FirstOrDefault

            If f IsNot Nothing Then
                Return Path.GetFileNameWithoutExtension(f)
            End If
            Return ""
        End Get
    End Property
    <Xml.Serialization.XmlIgnore> Public ReadOnly Property BatchFileInfo As FileInfo
        Get
            Return New FileInfo(DateFolder & "\BATCH\" & Filename & ".XML")
        End Get
    End Property
    <Xml.Serialization.XmlIgnore> Public DateFolder As String
    <Xml.Serialization.XmlIgnore> Public ReadOnly Property ForEntry As Integer
        Get
            Dim filecount As Integer = 0
            If DateFolder <> "" Then
                Dim _processed As String = DateFolder & "\PROCESSED"
                If Directory.Exists(_processed) Then
                    filecount = BillCount - (Query.Count + Billed.Count + Reject.Count + Ongoing.Count)
                End If
            End If
            If filecount < 0 Then Return 0
            Return filecount
        End Get
    End Property

    <Xml.Serialization.XmlIgnore> Public ReadOnly Property Query As List(Of String)
        Get
            Dim files As New List(Of String)
            If DateFolder <> "" Then
                Dim _query As String = DateFolder & "\PROCESSED\QUERY"
                If Directory.Exists(_query) Then
                    files.AddRange(Directory.GetFiles(_query, "*_" & TripNo & "_*.xml"))
                End If
            End If
            Return files
        End Get
    End Property

    <Xml.Serialization.XmlIgnore> Public ReadOnly Property Billed As List(Of String)
        Get
            Dim files As New List(Of String)
            If DateFolder <> "" Then
                Dim _finished As String = DateFolder & "\PROCESSED\FINISH"
                If Directory.Exists(_finished) Then
                    files.AddRange(Directory.GetFiles(_finished, "*_" & TripNo & "_*.xml"))
                End If
            End If
            Return files
        End Get
    End Property

    <Xml.Serialization.XmlIgnore> Public ReadOnly Property Reject As List(Of String)
        Get
            Dim files As New List(Of String)
            If DateFolder <> "" Then
                Dim _reject As String = DateFolder & "\PROCESSED\REJECT"
                If Directory.Exists(_reject) Then
                    files.AddRange(Directory.GetFiles(_reject, "*_" & TripNo & "_*.xml"))
                End If
            End If
            Return files
        End Get
    End Property

    <Xml.Serialization.XmlIgnore> Public ReadOnly Property Ongoing As List(Of String)
        Get
            Dim files As New List(Of String)
            If DateFolder <> "" Then
                Dim _ongoing As String = DateFolder & "\ONGOING"
                If Directory.Exists(_ongoing) Then
                    files.AddRange(Directory.GetFiles(_ongoing, "*_" & TripNo & "_*.xml"))
                End If
            End If
            Return files
        End Get
    End Property

    <Xml.Serialization.XmlIgnore> Public ReadOnly Property TA As String
        Get
            Dim tm As TimeSpan = (Time - Date.Parse(ClientEmailDateTime))
            If tm.Minutes > 0 Then
                Return String.Format("{0:00}:{1:00}", tm.Minutes, tm.Seconds)
            End If
            Return "###"
        End Get
    End Property

    <Xml.Serialization.XmlIgnore> Public ReadOnly Property Time As Date
        Get
            Dim _time As String = DateFolder & "\TIME"
            If Directory.Exists(_time) Then
                Dim times As String() = Directory.GetFiles(_time)
                If times.Length > 0 Then
                    TimeUnresponsiveElapse(Path.GetFileNameWithoutExtension(times(0)).Replace("#", ":"))
                    Return Date.Parse(Path.GetFileNameWithoutExtension(times(0)).Replace("#", ":"))
                End If
            End If
            Return Nothing
        End Get
    End Property

    <Xml.Serialization.XmlIgnore> Private _modifiedDate As Date
    Public Function Modified() As Boolean
        'Dim BatchFileInfo As New FileInfo(DateFolder & "\BATCH\" & Filename & ".XML")
        If BatchFileInfo.Exists Then
            If Not BatchFileInfo.LastWriteTime = _modifiedDate Then
                _modifiedDate = BatchFileInfo.LastWriteTime
                Return True
            End If
        End If
        Return False
    End Function

    Private savedDate_timefile As Date
    Private savedDate_system As Date
    Private Function TimeUnresponsiveElapse(_time As Date) As TimeSpan
        If savedDate_timefile.ToString("HHmmss") = _time.ToString("HHmmss") Then
            Return (Now - savedDate_system)
        Else
            savedDate_system = Now
            savedDate_timefile = _time
            Return New TimeSpan(0, 0, 0)
        End If
    End Function

    Public Function CheckTimeManagerActivity(_elapseInSeconds As Integer) As Boolean
        If TimeUnresponsiveElapse(Time).TotalSeconds > _elapseInSeconds Then
            MsgBox("Time Manager is Unresponsive", MsgBoxStyle.Critical)
            Return False
        End If
        Return True
    End Function

    Private Sub changeRowColor(_acolor As Color, _bcolor As Color)
        BatchRow.DefaultCellStyle.BackColor = _bcolor
        BatchRow.DefaultCellStyle.ForeColor = _acolor
        '  BatchRow.DefaultCellStyle.SelectionBackColor = _acolor
        '    BatchRow.DefaultCellStyle.SelectionForeColor = _bcolor
    End Sub

    Public Sub RefreshRow()
        If TA = "###" Then Exit Sub
        If CInt(TA.Substring(0, 2)) >= 30 Then
            changeRowColor(Color.Maroon, Color.White)
        ElseIf CInt(TA.Substring(0, 2)) >= 25 Then
            changeRowColor(Color.Orange, Color.White)
        ElseIf CInt(TA.Substring(0, 2)) >= 20 Then
            changeRowColor(Color.Green, Color.White)
        ElseIf CInt(TA.Substring(0, 2)) >= 15 Then
            changeRowColor(Color.Blue, Color.White)
        End If
        Application.DoEvents()
        BatchRow.SetValues(Filename, TripNo, TA, BillCount, ForEntry, Query.Count, Billed.Count, Reject.Count, Ongoing.Count, ClientEmailDateTime, ClientEmail, Remarks)
    End Sub

    Public Overrides Function ToString() As String
        Return TripNo
    End Function


    Public Function Clone() As Object Implements ICloneable.Clone
        Return Me.MemberwiseClone()
    End Function
End Class

Public Class BOLInfos
    Inherits List(Of BOLInfo)
    Implements ICloneable

    Public Shared Function collectProNumbers(username As String, dateFolder As String, status As BOLInfo.BOLStatus) As BOLInfo()
        Dim fld As String = ""
        Select Case status
            Case BOLInfo.BOLStatus.ONGOING
                fld = "\ONGOING"
            Case BOLInfo.BOLStatus.QUERY
                fld = "\PROCESSED\QUERY"
            Case BOLInfo.BOLStatus.ANSWERED
                fld = "\PROCESSED\QUERY\ANSWERED"
            Case BOLInfo.BOLStatus.FINISH
                fld = "\PROCESSED\FINISH"
        End Select

        Try
            Dim pros As String() = Directory.GetFiles(dateFolder & fld, "*" & username & ".XML")
            Return (From res In pros Select DirectCast(XmlSerialization.ReadFromFile(res, New BOLInfo), BOLInfo)).ToArray
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
        Return Nothing
    End Function

    Public Overloads Function Find(proNo As String, FBNo As String) As BOLInfo
        Return (From res In Me Where res.FBNo = FBNo And res.ProNo = proNo Select res).FirstOrDefault
    End Function
    Public Overloads Function Find(bol As BOLInfo) As BOLInfo
        Return (From res In Me Where res.FBNo = bol.FBNo And res.ProNo = bol.ProNo And res.Status = bol.Status Select res).FirstOrDefault
    End Function

    Public Function Clone() As Object Implements ICloneable.Clone
        Return Me.MemberwiseClone
    End Function
End Class

'Public Class BOLInfo
'    Public Batch As New BatchInfo
'    Public Entry As New List(Of TimeInfo)
'    Public Query As New List(Of QueryInfo)
'    Public ProNo As String = ""
'    Public FBNo As String = ""
'    Public QueryToVALC As New List(Of QueryInfo)
'    Public Username As String = ""
'    Public Fullname As String = ""
'    Public Status As String = "" 'Billed,Reject,Query,Answered,Query_Billed
'    Public SkippedReason As String = ""
'    Public Remarks As String = ""
'End Class
Public Class BOLInfo
    Implements ICloneable

    Public Batch As New BatchInfo
    Public Entry As New List(Of TimeInfo)
    Public Query As New List(Of QueryInfo)
    Public ProNo As String = ""
    Public FBNo As String = ""
    Public QueryToVALC As New List(Of QueryInfo)
    Public Username As String = ""
    Public Fullname As String = ""
    Public Status As String = "" 'Billed,Reject,Query,Answered,Query_Billed
    Public SkippedReason As String = ""
    Public Remarks As String = ""

    <Xml.Serialization.XmlIgnore> Public ReadOnly Property Filename As String
        Get
            Return String.Format("{0}_{1}_{2}_{3}", Batch.Filename, ProNo, FBNo, Username)
        End Get
    End Property

    Public Sub Write(status As String)
        Dim fld As String = ""
        Select Case status
            Case "ONGOING" 'BOLStatus.ONGOING
                fld = "\ONGOING"
            Case "QUERY" 'BOLStatus.QUERY
                fld = "\PROCESSED\QUERY"
            Case "SKIPPED" 'BOLStatus.SKIPPED
                fld = "\PROCESSED\Skipped"
            Case "BILLED", "BILLED QUERY" 'BOLStatus.FINISH
                fld = "\PROCESSED\FINISH"
        End Select

        'XmlSerialization.WriteToFile(String.Format("{0}\{1}\{2}_{3}_{4}_{5}.XML", Batch.DateFolder, fld, Batch.Filename, ProNo, FBNo, Username), Me)
        XmlSerialization.WriteToFile(String.Format("{0}\{1}\{2}.XML", Batch.DateFolder, fld, Filename), Me)
    End Sub

    Public Sub Delete(status As String)
        Dim fld As String = ""
        Select Case status
            Case "ONGOING" 'BOLStatus.ONGOING
                fld = "\ONGOING"
            Case "QUERY" 'BOLStatus.QUERY
                fld = "\PROCESSED\QUERY"
            Case "SKIPPED" 'BOLStatus.SKIPPED
                fld = "\PROCESSED\Skipped"
            Case "BILLED", "BILLED QUERY" 'BOLStatus.FINISH
                fld = "\PROCESSED\FINISH"
            Case "ANSWERED" 'BOLStatus.ANSWERED
                fld = "\PROCESSED\QUERY\ANSWERED"
        End Select

        'File.Delete(String.Format("{0}\{1}\{2}.XML", Batch.DateFolder, fld, Batch.Filename, ProNo, FBNo, Username))
        File.Delete(String.Format("{0}\{1}\{2}.XML", Batch.DateFolder, fld, Filename))
    End Sub

    Public Enum BOLStatus
        ONGOING = 0
        QUERY = 1
        FINISH = 2
        ANSWERED = 3
        SKIPPED = 4

    End Enum

    <Xml.Serialization.XmlIgnore> Public ProductionRow As DataGridViewRow
    Public Sub RefreshProductionRow()
        Dim foundBOL As String() = Directory.GetFiles(Batch.DateFolder, String.Format("*{0}_{1}_{2}_{3}.XML", Batch.TripNo, ProNo, FBNo, Username), SearchOption.AllDirectories)
        If foundBOL.Length > 0 Then
            Dim tempBOL As BOLInfo = XmlSerialization.ReadFromFile(foundBOL(0), New BOLInfo)
            With tempBOL
                Status = .Status
                Entry = .Entry
                Query = .Query
            End With
            ProductionRow.SetValues(Batch.ClientEmailDateTime, Batch.Folder, Batch.TripNo, ProNo, FBNo, Remarks, Status, Entry(Entry.Count - 1).Start, Entry(Entry.Count - 1).Endd)
        End If
    End Sub

    Public Function Clone() As Object Implements ICloneable.Clone
        Return Me.MemberwiseClone()
    End Function
End Class



Public Class TimeInfo
    Public Start As String = ""
    Public Endd As String = ""
    Public Status As String = ""
    Public ReadOnly Property TimeElapsed As String
        Get
            Dim tm As TimeSpan = (Date.Parse(Endd) - Date.Parse(Start))
            Return String.Format("{0}:{1}", tm.Minutes, tm.Seconds)
        End Get
    End Property
End Class

Public Class QueryInfo
    Public Start As String = ""
    Public Endd As String = ""
    Public QuerySentToClient As String = ""
    Public AnswerReceivedFromClient As String = ""
    Public BillerQuery As String = ""
    Public QueryAnswer As String = ""
    Public ShipperName As String = ""
    Public ConsigneeName As String = ""
End Class
'Public Class QueryInfo
'    Public Start As String = ""
'    Public Endd As String = ""
'    Public BillerQuery As String = ""
'    Public QueryAnswer As String = ""
'    Public ShipperName As String = ""
'    Public ConsigneeName As String = ""
'End Class
Public Class clsUserInfo
    Public Fullname As String
    Public Username As String
    Public Rater As Boolean
End Class

Public Class clsConf
    Public ProductionPath As String = ""
    Public BackupPath As String = ""
    Public SwitchWindow As Boolean = False
End Class