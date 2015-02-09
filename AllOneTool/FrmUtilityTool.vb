Imports CommonDB
Imports System.IO
Imports PublicUtility

Public Class FrmUtilityTool
    Dim db As DBSql
    Dim languageVB As String = ".vb"
    Dim languageCSharp As String = ".cs"
    Dim PublicTable As String = "PublicTable"
    Dim PublicStoreProcesdure As String = "PublicSP"

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim browser As New FolderBrowserDialog()
        browser.ShowDialog()
        txtPath.Text = browser.SelectedPath
    End Sub

    Private Sub bttConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttConnect.Click
        tvwDB.Nodes.Clear()

        db = New DBSql(GetString())
        If Not db.CheckConnection Then Exit Sub
        MsgBox("Successfully")

        Dim tb As DataTable
        tb = db.GetAllTableName()
        tvwDB.Nodes.Add(txtDatabase.Text)

        For Each row As DataRow In tb.Rows
            tvwDB.Nodes(0).Nodes.Add(row(0))
        Next

        tvwDB.ExpandAll()
        tvwDB.Sort()
    End Sub

    Function GetString() As String
        Dim connect As String = ""
        connect = String.Format("Server={0};Database={1};User id={2};Password={3};Connection timeout=0", txtServer.Text, txtDatabase.Text, txtUserId.Text, txtPassword.Text)

        Return connect
    End Function

    Private Sub tvwDB_AfterCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvwDB.AfterCheck

        For Each note As TreeNode In e.Node.Nodes
            note.Checked = e.Node.Checked
        Next

    End Sub

    Private Sub bttGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttGenerate.Click
        If ckoCSharp.Checked Then
            If ckoTableClass.Checked Then
                GenerateCSharp()
            End If
            If ckoTableName.Checked Then
                GenerateTableNameCSharp()
            End If
            If ckoStore.Checked Then
                GenerateStoreProcedureCSharp()
            End If
        End If
        If ckoVB.Checked Then
            If ckoTableClass.Checked Then
                GenerateVB()
            End If
            If ckoTableName.Checked Then
                GenerateTableNameVB()
            End If
            If ckoStore.Checked Then
                GenerateStoreProcedureVB()
            End If
        End If

        MessageBox.Show("Successfully", "Generate code")

    End Sub
    Sub GenerateTableNameVB()
        Dim f As New StreamWriter(txtPath.Text & "\" & PublicTable & languageVB)
        f.WriteLine(" Public class " & PublicTable)
        For Each note As TreeNode In tvwDB.Nodes(0).Nodes
            f.WriteLine("     Public Shared Table_" & note.Text & " as String= """ & note.Text & """ ")
            Application.DoEvents()
        Next
        f.WriteLine(" End class ")
        f.Flush()
        f.Close()
    End Sub
    Sub GenerateTableNameCSharp()

        Dim f As New StreamWriter(txtPath.Text & "\" & PublicTable & languageCSharp)
        f.WriteLine("using System; ")
        f.WriteLine(" public class " & PublicTable)
        f.WriteLine(" { ")
        For Each note As TreeNode In tvwDB.Nodes(0).Nodes
            f.WriteLine("     public string Table_" & note.Text & "= """ & note.Text & """ ;")
            Application.DoEvents()
        Next
        f.WriteLine(" } ")
        f.Flush()
        f.Close()
    End Sub
    Sub GenerateStoreProcedureVB()
        Dim tb As DataTable = db.GetAllStoreProcedures()
        Dim f As New StreamWriter(txtPath.Text & "\" & PublicStoreProcesdure & languageVB)
        f.WriteLine(" Public class " & PublicStoreProcesdure)
        For Each row As DataRow In tb.Rows
            f.WriteLine("     Public Shared " & row("name") & " as String= """ & row("name") & """ ")
            Application.DoEvents()
        Next
        f.WriteLine(" End class ")
        f.Flush()
        f.Close()
    End Sub
    Sub GenerateStoreProcedureCSharp()
        Dim tb As DataTable = db.GetAllStoreProcedures()
        Dim f As New StreamWriter(txtPath.Text & "\" & PublicStoreProcesdure & languageCSharp)
        f.WriteLine("using System; ")
        f.WriteLine(" public class " & PublicStoreProcesdure)
        f.WriteLine(" { ")
        For Each row As DataRow In tb.Rows
            f.WriteLine("     public string " & row("name") & "= """ & row("name") & """ ;")
            Application.DoEvents()
        Next
        f.WriteLine(" } ")
        f.Flush()
        f.Close()
    End Sub
    Sub GenerateVB()
        Dim tbColumn As DataTable
        Dim tbKeys As DataTable
        For Each note As TreeNode In tvwDB.Nodes(0).Nodes
            Application.DoEvents()
            If note.Checked Then
                Dim f As New StreamWriter(txtPath.Text & "\" & note.Text & ".vb")
                f.WriteLine()
                f.WriteLine(" Public Class " & note.Text)
                tbColumn = db.GetAllColumn(note.Text)
                tbKeys = db.GetKeysOfTable(note.Text)
                For Each rowColum As DataRow In tbColumn.Rows
                    Application.DoEvents()
                    Dim key As Boolean = False
                    For Each rowKey As DataRow In tbKeys.Rows
                        If rowColum("column_name") = rowKey("column_name") Then
                            key = True
                            Exit For
                        End If
                    Next
                    If key Then
                        f.WriteLine("     Public " & rowColum("column_name") & "_K As " & GetTypeColumnVB(rowColum("datatype")))
                    Else
                        f.WriteLine("     Public " & rowColum("column_name") & " As " & GetTypeColumnVB(rowColum("datatype")))
                    End If
                Next
                f.WriteLine(" End  Class")
                f.Flush()
                f.Close()
            End If
        Next



    End Sub
    Sub GenerateCSharp()
        Dim tbColumn As DataTable
        Dim tbKeys As DataTable
        For Each note As TreeNode In tvwDB.Nodes(0).Nodes
            Application.DoEvents()
            If note.Checked Then
                Dim f As New StreamWriter(txtPath.Text & "\" & note.Text & ".cs")
                f.WriteLine("using System; ")
                f.WriteLine(" public class " & note.Text)
                f.WriteLine(" {")
                tbColumn = db.GetAllColumn(note.Text)
                tbKeys = db.GetKeysOfTable(note.Text)
                For Each rowColum As DataRow In tbColumn.Rows
                    Application.DoEvents()
                    Dim key As Boolean = False
                    For Each rowKey As DataRow In tbKeys.Rows
                        If rowColum("column_name") = rowKey("column_name") Then
                            key = True
                            Exit For
                        End If
                    Next
                    If key Then
                        f.WriteLine("     public " & GetTypeColumnCSharp(rowColum("datatype")) & " " & rowColum("column_name") & "_K ; ")
                    Else
                        f.WriteLine("     public " & GetTypeColumnCSharp(rowColum("datatype")) & " " & rowColum("column_name") & " ; ")
                    End If
                Next
                f.WriteLine(" }")
                f.Flush()
                f.Close()
            End If
        Next


    End Sub

    Function GetTypeColumnVB(ByVal sqlType As String)
        Select Case sqlType
            Case "char", "nchar", "varchar", "nvarchar", "text", "ntext"
                Return " String "
            Case "datetime", "smalldatetime"
                Return " DateTime "
            Case "bit"
                Return " Boolean "
            Case "int", "smallint", "tinyint"
                Return " Integer "
            Case "decimal", "float", "double"
                Return " Decimal "
            Case "binary", "varbinary", "image"
                Return " byte()"
        End Select
        Return ""
    End Function
    Function GetTypeColumnCSharp(ByVal sqlType As String)
        Select Case sqlType
            Case "char", "nchar", "varchar", "nvarchar", "text", "ntext"
                Return " string "
            Case "datetime", "smalldatetime"
                Return " DateTime "
            Case "bit"
                Return " bool "
            Case "int"
                Return " int "
            Case "decimal", "float", "double"
                Return " decimal "
            Case "binary", "image"
                Return " byte[]"
        End Select
        Return ""
    End Function

    Private Sub bttEncryption_Click(sender As System.Object, e As System.EventArgs) Handles bttEncryption.Click
        txtResult.Text = PublicFunction.EncryptPassword(txtInput.Text)
    End Sub

    Private Sub bttDecryption_Click(sender As System.Object, e As System.EventArgs) Handles bttDecryption.Click
        txtResult.Text = PublicFunction.DecryptPassword(txtInput.Text)
    End Sub
End Class
