Imports System.Security.Cryptography
Imports System.IO
Imports System.Runtime.Serialization.Formatters
Imports System.Xml.Serialization
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Data
Imports System.Reflection
Imports System.Data.OleDb
Imports System.Net
Imports System.Data.Odbc
Imports PublicUtility
Imports System.Data.OracleClient
Imports System.Data.Common
Imports System.Globalization
Imports System.Runtime.InteropServices
Imports WeifenLuo.WinFormsUI.Docking
Imports System.ComponentModel
Imports Microsoft.Office.Interop

''' <summary>
''' Stored many common functions useful
''' Author: Truong Minh Tam
''' Date: Junly-2011
''' </summary>
''' <remarks></remarks>
''' 

Public Class PublicFunction

#Region "Variable"
    Public Shared pathfile As String = "C:\Programs_NDV\ERPNDV\Bat\Approved.bat"
    Const contentApproved As String = "[{0}] đã gởi yêu cầu xác nhận đến bạn (Approved request).  "
    Const contentReject As String = "[{0}] đã từ chối xác nhận yêu cầu (Rejected request). "


    'Private lang As New MultiLanguage
    Private Shared _folderLog As String = Application.StartupPath + "\Log\"
    Private Shared _fileLog As String = Application.StartupPath + "\Log\" & DateTime.Now.ToString("dd-MMM-yyyy") & ".txt"
    Private Shared _line As String = "================================================================================================="
#End Region

#Region "Enum "
    Public Enum HangHoa
        SanPham = 0
        NguyenLieu = 1
    End Enum
    Public Enum GiaBan
        GiaBanSi = 0
        GiaBanLe = 1
    End Enum

    Public Enum enumMessage
        Question = 0
        Warning = 1
        [Error] = 2
    End Enum
    Public Enum enumTimeType
        ThaoTacChinh = 1
        GioCongCoDinh = 2
        GioCongLangPhi = 3
    End Enum
    Public Enum enumTimeCondition
        ALL = 0
        BienDong = 1
        CoDinh = 2
    End Enum
    ''' <summary>
    ''' ddmmyyyy
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum enumDateFormat
        ddmmyyyy = 0
        mmddyyyy = 1
    End Enum

    Public Enum FormState
        AddNew = 0
        Edit = 1
        Delete = 2
        Confirm = 3
    End Enum

    Public Enum Status
        Wait
        Complete
    End Enum
    Public Enum Submit
        Confirm
        Reject
    End Enum
    Public Enum ConfirmSE
        Create
        Submit
        Ringi1
        Ringi2
        Ringi3
        Ringi4
        Ringi5
        Refer1
        Refer2
        Refer3
        Refer4
        Refer5
        Notify
        Approved
    End Enum
    Public Enum ConfirmOT
        Requester
        TeamLeader
        LineLeader
        GroupLeader
        Manager
        DManager
        GManager
        FManager
        HR
    End Enum

    Public Enum FrmName
        FrmConfirmOT = 0
    End Enum
#End Region

#Region "Fpics"

    'Public Function CheckExistPdCode(ByVal pdCode As String) As Boolean
    '    Dim db = New DBSql(PublicConst.EnumServers.NDV_SQL_Fpics)
    '    Dim sql As String = String.Format("select top 1 * from {0} where ProductCode='{1}'",
    '                                    PublicTable_FPICS.Table_m_Product, pdCode)
    '    Dim tbPdCode As DataTable = db.FillDataTable(sql)
    '    If tbPdCode.Rows.Count > 0 Then
    '        Return True
    '    End If
    '    db.CloseConnect()
    '    Return False
    'End Function

    'Public Function CheckExistPdCodeProcessResult(ByVal pdCode As String) As Boolean
    '    Dim db = New DBSql(PublicConst.EnumServers.NDV_SQL_Fpics)
    '    Dim sql As String = String.Format("select top 1 * from {0} where ProductCode='{1}'",
    '                                    PublicTable_FPICS.Table_m_Product, pdCode)
    '    Dim tbPdCode As DataTable = db.FillDataTable(sql)
    '    If tbPdCode.Rows.Count > 0 Then
    '        Return True
    '    End If
    '    db.CloseConnect()
    '    Return False
    'End Function

    Shared Function GetStandardLotSize(ByVal pdCode As String, ByVal revision As String) As Integer
        Dim sql As String = String.Format(" SELECT StandardLotSize " +
                                          " FROM [m_Product] " +
                                          " where productcode='{0}' and revisioncode='{1}'",
                                          pdCode, revision)
        Dim db As New DBSql(PublicConst.EnumServers.NDV_SQL_Fpics)
        Dim o As Object = db.ExecuteScalar(sql)
        db.CloseConnect()
        If o Is DBNull.Value Then
            Return 0
        Else
            Return Convert.ToInt32(o)
        End If
    End Function

#End Region

#Region "Update default data"
    Shared Sub SettingDefaultData()
        If PublicConst.Language = PublicConst.EnumLanguage.English Then
            PublicConst.Message_Question_Getdata = "Do you want to get data ?"
            PublicConst.Message_Question_Save = "Do you want to save data ?"
            PublicConst.Message_Question_Update = "Do you want to update data ?"
            PublicConst.Message_Question_Delete = "Do you want to delete data ?"
            PublicConst.Message_Question_Insert = "Do you want to insert ?"
            PublicConst.Message_Question_Import = "Do you want to import ?"
            PublicConst.Message_Question_Export = "Do you want to export ?"
            PublicConst.Message_Question_Print = "Do you want to print ?"
            PublicConst.Message_Question_Sync = "Do you want to Sync data ?"
            PublicConst.Message_Question_Exit = "Do you want to exit ?"
            PublicConst.Message_Question_Back = "Do you want to back ?"
            PublicConst.Message_Question_Lock = "Do you want to lock ?"
            PublicConst.Message_Question_UnLock = "Do you want to unlock ?"
            PublicConst.Message_Question_Backup = "Do you want to backup ?"
            PublicConst.Message_Question_Restore = "Do you want to restore ?"
            PublicConst.Message_Question_Confirm = "Do you want to confirm ?"
            PublicConst.Message_Question_UnConfirm = "Do you want to unconfirm ?"
            PublicConst.Message_Question_Run = "Do you want to run?"


            PublicConst.Message_Caption_Getdata = "GetData"
            PublicConst.Message_Caption_Save = "Save"
            PublicConst.Message_Caption_Update = "Update"
            PublicConst.Message_Caption_Delete = "Delete"
            PublicConst.Message_Caption_Insert = "Insert"
            PublicConst.Message_Caption_Import = "Import"
            PublicConst.Message_Caption_Export = "Export"
            PublicConst.Message_Caption_Print = "Print"
            PublicConst.Message_Caption_Sync = "Sync"
            PublicConst.Message_Caption_Exit = "Exit"
            PublicConst.Message_Caption_Back = "Back"
            PublicConst.Message_Caption_Lock = "Lock"
            PublicConst.Message_Caption_UnLock = "Unlock"
            PublicConst.Message_Caption_Backup = "Backup"
            PublicConst.Message_Caption_Restore = "Restore"
            PublicConst.Message_Caption_Confirm = "Confirm"
            PublicConst.Message_Caption_UnConfirm = "Unconfirm"
            PublicConst.Message_Caption_Run = "Run"
            PublicConst.Message_Caption_Condition = "Condition"
            PublicConst.Message_Caption_Error = "Error"
            PublicConst.Message_Caption_Help = "Help"
            PublicConst.Message_Caption_Info = "Information"
            PublicConst.Message_Caption_Warning = "Warning"

            PublicConst.Message_Successfully = "Success"
            PublicConst.Message_Warning_NotNull = " is not null."
            PublicConst.Message_Warning_ExistData = " Data is exist."
        End If
        If PublicConst.Language = PublicConst.EnumLanguage.Japan Then
            PublicConst.Message_Question_Getdata = "Do you want to get data ?"
            PublicConst.Message_Question_Save = "Do you want to save data ?"
            PublicConst.Message_Question_Update = "Do you want to update data ?"
            PublicConst.Message_Question_Delete = "Do you want to delete data ?"
            PublicConst.Message_Question_Insert = "Do you want to insert ?"
            PublicConst.Message_Question_Import = "Do you want to import ?"
            PublicConst.Message_Question_Export = "Do you want to export ?"
            PublicConst.Message_Question_Print = "Do you want to print ?"
            PublicConst.Message_Question_Sync = "Do you want to Sync data ?"
            PublicConst.Message_Question_Exit = "Do you want to exit ?"
            PublicConst.Message_Question_Back = "Do you want to back ?"
            PublicConst.Message_Question_Lock = "Do you want to lock ?"
            PublicConst.Message_Question_UnLock = "Do you want to unlock ?"
            PublicConst.Message_Question_Backup = "Do you want to backup ?"
            PublicConst.Message_Question_Restore = "Do you want to restore ?"
            PublicConst.Message_Question_Confirm = "Do you want to confirm ?"
            PublicConst.Message_Question_UnConfirm = "Do you want to unconfirm ?"
            PublicConst.Message_Question_Run = "Do you want to run?"


            PublicConst.Message_Caption_Getdata = "GetData"
            PublicConst.Message_Caption_Save = "Save"
            PublicConst.Message_Caption_Update = "Update"
            PublicConst.Message_Caption_Delete = "Delete"
            PublicConst.Message_Caption_Insert = "Insert"
            PublicConst.Message_Caption_Import = "Import"
            PublicConst.Message_Caption_Export = "Export"
            PublicConst.Message_Caption_Print = "Print"
            PublicConst.Message_Caption_Sync = "Sync"
            PublicConst.Message_Caption_Exit = "Exit"
            PublicConst.Message_Caption_Back = "Back"
            PublicConst.Message_Caption_Lock = "Lock"
            PublicConst.Message_Caption_UnLock = "Unlock"
            PublicConst.Message_Caption_Backup = "Backup"
            PublicConst.Message_Caption_Restore = "Restore"
            PublicConst.Message_Caption_Confirm = "Confirm"
            PublicConst.Message_Caption_UnConfirm = "Unconfirm"
            PublicConst.Message_Caption_Run = "Run"
            PublicConst.Message_Caption_Condition = "Condition"
            PublicConst.Message_Caption_Error = "Error"
            PublicConst.Message_Caption_Help = "Help"
            PublicConst.Message_Caption_Info = "Information"
            PublicConst.Message_Caption_Warning = "Warning"

            PublicConst.Message_Successfully = "Success"
            PublicConst.Message_Warning_NotNull = " is not null."
            PublicConst.Message_Warning_ExistData = " Data is exist."
        End If
        If PublicConst.Language = PublicConst.EnumLanguage.China Then
            PublicConst.Message_Question_Getdata = "Do you want to get data ?"
            PublicConst.Message_Question_Save = "Do you want to save data ?"
            PublicConst.Message_Question_Update = "Do you want to update data ?"
            PublicConst.Message_Question_Delete = "Do you want to delete data ?"
            PublicConst.Message_Question_Insert = "Do you want to insert ?"
            PublicConst.Message_Question_Import = "Do you want to import ?"
            PublicConst.Message_Question_Export = "Do you want to export ?"
            PublicConst.Message_Question_Print = "Do you want to print ?"
            PublicConst.Message_Question_Sync = "Do you want to Sync data ?"
            PublicConst.Message_Question_Exit = "Do you want to exit ?"
            PublicConst.Message_Question_Back = "Do you want to back ?"
            PublicConst.Message_Question_Lock = "Do you want to lock ?"
            PublicConst.Message_Question_UnLock = "Do you want to unlock ?"
            PublicConst.Message_Question_Backup = "Do you want to backup ?"
            PublicConst.Message_Question_Restore = "Do you want to restore ?"
            PublicConst.Message_Question_Confirm = "Do you want to confirm ?"
            PublicConst.Message_Question_UnConfirm = "Do you want to unconfirm ?"
            PublicConst.Message_Question_Run = "Do you want to run?"


            PublicConst.Message_Caption_Getdata = "GetData"
            PublicConst.Message_Caption_Save = "Save"
            PublicConst.Message_Caption_Update = "Update"
            PublicConst.Message_Caption_Delete = "Delete"
            PublicConst.Message_Caption_Insert = "Insert"
            PublicConst.Message_Caption_Import = "Import"
            PublicConst.Message_Caption_Export = "Export"
            PublicConst.Message_Caption_Print = "Print"
            PublicConst.Message_Caption_Sync = "Sync"
            PublicConst.Message_Caption_Exit = "Exit"
            PublicConst.Message_Caption_Back = "Back"
            PublicConst.Message_Caption_Lock = "Lock"
            PublicConst.Message_Caption_UnLock = "Unlock"
            PublicConst.Message_Caption_Backup = "Backup"
            PublicConst.Message_Caption_Restore = "Restore"
            PublicConst.Message_Caption_Confirm = "Confirm"
            PublicConst.Message_Caption_UnConfirm = "Unconfirm"
            PublicConst.Message_Caption_Run = "Run"
            PublicConst.Message_Caption_Condition = "Condition"
            PublicConst.Message_Caption_Error = "Error"
            PublicConst.Message_Caption_Help = "Help"
            PublicConst.Message_Caption_Info = "Information"
            PublicConst.Message_Caption_Warning = "Warning"

            PublicConst.Message_Successfully = "Success"
            PublicConst.Message_Warning_NotNull = " is not null."
            PublicConst.Message_Warning_ExistData = " Data is exist."
        End If
        If PublicConst.Language = PublicConst.EnumLanguage.VietNam Then
            PublicConst.Message_Question_Getdata = "Do you want to get data ?"
            PublicConst.Message_Question_Save = "Do you want to save data ?"
            PublicConst.Message_Question_Update = "Do you want to update data ?"
            PublicConst.Message_Question_Delete = "Do you want to delete data ?"
            PublicConst.Message_Question_Insert = "Do you want to insert ?"
            PublicConst.Message_Question_Import = "Do you want to import ?"
            PublicConst.Message_Question_Export = "Do you want to export ?"
            PublicConst.Message_Question_Print = "Do you want to print ?"
            PublicConst.Message_Question_Sync = "Do you want to Sync data ?"
            PublicConst.Message_Question_Exit = "Do you want to exit ?"
            PublicConst.Message_Question_Back = "Do you want to back ?"
            PublicConst.Message_Question_Lock = "Do you want to lock ?"
            PublicConst.Message_Question_UnLock = "Do you want to unlock ?"
            PublicConst.Message_Question_Backup = "Do you want to backup ?"
            PublicConst.Message_Question_Restore = "Do you want to restore ?"
            PublicConst.Message_Question_Confirm = "Do you want to confirm ?"
            PublicConst.Message_Question_UnConfirm = "Do you want to unconfirm ?"
            PublicConst.Message_Question_Run = "Do you want to run?"


            PublicConst.Message_Caption_Getdata = "GetData"
            PublicConst.Message_Caption_Save = "Save"
            PublicConst.Message_Caption_Update = "Update"
            PublicConst.Message_Caption_Delete = "Delete"
            PublicConst.Message_Caption_Insert = "Insert"
            PublicConst.Message_Caption_Import = "Import"
            PublicConst.Message_Caption_Export = "Export"
            PublicConst.Message_Caption_Print = "Print"
            PublicConst.Message_Caption_Sync = "Sync"
            PublicConst.Message_Caption_Exit = "Exit"
            PublicConst.Message_Caption_Back = "Back"
            PublicConst.Message_Caption_Lock = "Lock"
            PublicConst.Message_Caption_UnLock = "Unlock"
            PublicConst.Message_Caption_Backup = "Backup"
            PublicConst.Message_Caption_Restore = "Restore"
            PublicConst.Message_Caption_Confirm = "Confirm"
            PublicConst.Message_Caption_UnConfirm = "Unconfirm"
            PublicConst.Message_Caption_Run = "Run"
            PublicConst.Message_Caption_Condition = "Condition"
            PublicConst.Message_Caption_Error = "Error"
            PublicConst.Message_Caption_Help = "Help"
            PublicConst.Message_Caption_Info = "Information"
            PublicConst.Message_Caption_Warning = "Warning"

            PublicConst.Message_Successfully = "Success"
            PublicConst.Message_Warning_NotNull = " is not null."
            PublicConst.Message_Warning_ExistData = " Data is exist."
        End If
    End Sub
#End Region

#Region "Show New Form"

    Public Shared Sub ShowNewForm(ByVal frm As DockContent, Optional ByVal translate As Boolean = True)
        'Check ChildForm exist already.
        For Each Child As DockContent In PublicConst.DockPanel.Contents
            If Child.Tag = frm.Tag Then
                Child.Close()
                Exit For
            End If
        Next
        frm.Show(PublicConst.DockPanel)
        'Set language
        'If translate Then
        '    lang.ShowLanguage(frm, frm.Tag)
        'End If
    End Sub

    Public Shared Function GetFormExisted(ByVal sFormName As String) As DockContent
        For Each Child As DockContent In PublicConst.DockPanel.Contents
            If Child.Name = sFormName Then
                Return Child
            End If
        Next
        Return Nothing
    End Function

#End Region

#Region " Variable API 32bit"
    Private Declare Function GetSystemDefaultLCID Lib "kernel32" () As Integer
    Private Const LOCALE_SSHORTDATE As Short = &H1FS ' short date format string
    Private Declare Function GetLocaleInfo Lib "kernel32" Alias "GetLocaleInfoA" (ByVal Locale As Integer, ByVal LCType As Integer,
                                                                                  ByVal lpLCData As String, ByVal cchData As Integer) As Integer

#End Region

#Region "API function"
    Public Shared Function GetDateShortLocal() As String
        Dim sReturn As String = ""
        Dim r As Integer
        Dim LCID As Integer
        LCID = GetSystemDefaultLCID()
        r = GetLocaleInfo(LCID, LOCALE_SSHORTDATE, sReturn, Len(sReturn))
        If r Then
            sReturn = Space(r)
            r = GetLocaleInfo(LCID, LOCALE_SSHORTDATE, sReturn, Len(sReturn))
            sReturn = Left(sReturn, r - 1)
        End If
        Return sReturn
    End Function
#End Region

#Region "Encryption Password MD5"
    Public Shared Function EncryptPassword(ByVal Password As String) As String
        'Encrypt the Password       
        Dim sEncryptedPassword As String = ""
        Dim sEncryptKey As String = "P@SSW@RD@09"        'Should be minimum 8 characters       
        Try
            sEncryptedPassword = EncryptDecryptClass.EncryptPasswordMD5(Password, sEncryptKey)
        Catch ex As Exception
            Return sEncryptedPassword
        End Try
        Return sEncryptedPassword
    End Function
    Public Shared Function DecryptPassword(ByVal Password As String) As String
        'Encrypt the Password       
        Dim sDecryptedPassword As String = ""
        Dim sEncryptKey As String = "P@SSW@RD@09" 'Should be minimum 8 characters      
        Try
            sDecryptedPassword = EncryptDecryptClass.DecryptPasswordMD5(Password, sEncryptKey)
        Catch ex As Exception
            Return sDecryptedPassword
        End Try
        Return sDecryptedPassword
    End Function
#End Region

#Region "Serialize, Deserialize"
    Public Shared Sub BinarySerialize(ByVal filename As String, ByVal obj As Object)
        Dim fileStreamObject As FileStream
        fileStreamObject = New FileStream(filename, FileMode.Create)
        Dim binaryFormatter As New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        binaryFormatter.Serialize(fileStreamObject, obj)
        fileStreamObject.Close()
    End Sub
    Public Shared Function BinaryDeserialize(ByVal filename As String) As Object
        Dim fileStreamObject As New FileStream(filename, FileMode.Open)
        Dim binaryFormatter As New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        Dim obj As Object = binaryFormatter.Deserialize(fileStreamObject)
        fileStreamObject.Close()
        Return obj
    End Function
    Public Shared Sub SoapSerialize(ByVal filename As String, ByVal obj As Object)
        Dim fileStreamObject As FileStream
        fileStreamObject = New FileStream(filename, FileMode.Create)
        Dim binaryFormatter As New Runtime.Serialization.Formatters.Soap.SoapFormatter()
        binaryFormatter.Serialize(fileStreamObject, obj)
        fileStreamObject.Close()
    End Sub
    Public Shared Function SoapDeserialize(ByVal filename As String) As Object
        Dim fileStreamObject As New FileStream(filename, FileMode.Open)
        Dim binaryFormatter As New Runtime.Serialization.Formatters.Soap.SoapFormatter()
        Dim obj As Object = binaryFormatter.Deserialize(fileStreamObject)
        fileStreamObject.Close()
        Return obj
    End Function
    Public Shared Sub XMLSerialize(ByVal filename As String, ByVal obj As Object)
        Dim fileStreamObject As FileStream
        fileStreamObject = New FileStream(filename, FileMode.Create)
        Dim binaryFormatter As New XmlSerializer(obj.GetType)
        binaryFormatter.Serialize(fileStreamObject, obj)
        fileStreamObject.Close()
    End Sub
    Public Shared Function XMLDeserialize(ByVal filename As String, ByVal obj As Object) As Object
        Dim fileStreamObject As New FileStream(filename, FileMode.Open)
        Dim binaryFormatter As New XmlSerializer(obj.GetType)
        Dim o As Object = binaryFormatter.Deserialize(fileStreamObject)
        fileStreamObject.Close()
        Return o
    End Function


#End Region

#Region "File and Folder "
    Private Sub DirectoryCopy(sourceDirName As String, destDirName As String, copySubDirs As Boolean)

        '// Get the subdirectories for the specified directory.
        Dim dir As DirectoryInfo = New DirectoryInfo(sourceDirName)
        Dim dirs() As DirectoryInfo = dir.GetDirectories()

        If Not dir.Exists() Then
            Throw New DirectoryNotFoundException(
                "Source directory does not exist or could not be found: " &
                 sourceDirName)
        End If

        '// If the destination directory doesn't exist, create it. 
        If (Not Directory.Exists(destDirName)) Then
            Directory.CreateDirectory(destDirName)
        End If

        ' // Get the files in the directory and copy them to the new location.
        Dim files() As FileInfo = dir.GetFiles()
        For Each file As FileInfo In files
            Dim temppath As String = Path.Combine(destDirName, file.Name)
            file.CopyTo(temppath, True)
        Next

        '// If copying subdirectories, copy them and their contents to new location. 
        If copySubDirs Then
            For Each subdir As DirectoryInfo In dirs
                Dim temppath As String = Path.Combine(destDirName, subdir.Name)
                DirectoryCopy(subdir.FullName, temppath, copySubDirs)
            Next
        End If
    End Sub
    Shared Function ConvertFileToArrayByte(ByVal filename As String) As Byte()
        Dim fs As New FileStream(filename, FileMode.Open, FileAccess.Read)
        Dim ImageData(fs.Length) As Byte
        fs.Read(ImageData, 0, System.Convert.ToInt32(fs.Length))
        fs.Close()
        Return ImageData
    End Function

    Shared Sub ConvertArrayByteToFile(ByVal fileName As String, ByVal Buffer() As Byte)
        If File.Exists(fileName) Then
            File.Delete(fileName)
        End If
        Dim fs = New FileStream(fileName, FileMode.Create)
        fs.Write(Buffer, 0, Buffer.Length)
        fs.Close()
    End Sub

    Shared Function GetImageFromArrayByte(ByVal Arraybyte As Byte()) As Image
        Dim ms As New MemoryStream(Arraybyte)
        Dim returnImage As Image = Image.FromStream(ms)
        Return returnImage
    End Function
    Shared Function ImageToByteArray(ByVal imageIn As Image) As Byte()
        Dim ms As New MemoryStream()
        imageIn.Save(ms, Imaging.ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function
    Shared Function LoadFile() As String
        Dim ofdialog As New OpenFileDialog
        If ofdialog.ShowDialog = DialogResult.OK Then
            If File.Exists(ofdialog.FileName) Then
                Return ofdialog.FileName
            End If
        End If
        Return ""
    End Function

    ''' <summary>
    ''' Vo Thanh Son IT
    ''' Copy file from folder to folder
    ''' </summary>
    ''' <param name="SourceFileName"></param>
    ''' <param name="DestFileName"></param>
    ''' <param name="Override"></param>
    ''' <remarks></remarks>
    Public Shared Sub UpLoadFile(ByVal SourceFileName As String, ByVal DestFileName As String, ByVal Override As Boolean)
        Try
            If (File.Exists(SourceFileName)) Then
                If (File.Exists(DestFileName)) Then
                    File.SetAttributes(DestFileName, FileAttributes.Archive)
                End If
                File.Copy(SourceFileName, DestFileName, Override)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Son IT
    ''' Open any file with current program
    ''' </summary>
    ''' <param name="sFileName"></param>
    ''' <remarks></remarks>
    Public Shared Sub OpenFile(ByVal sFileName As String)
        Dim process As System.Diagnostics.ProcessStartInfo
        Try
            If (sFileName <> String.Empty) Then
                If (Not File.Exists(sFileName)) Then
                    MessageBox.Show("File: " + sFileName + "not exist on server", "File")
                    Return
                Else
                    process = New System.Diagnostics.ProcessStartInfo(sFileName)
                    process.Verb = "open"
                    Dim sprocess = New System.Diagnostics.Process()
                    sprocess.StartInfo = process
                    sprocess.Start()
                End If
            Else
                MessageBox.Show("File not exist", "File")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "Add char, string "

    'Sub SendMail(person As String, sendto As Object,
    '             ccto As Object, submit As Submit, Title As String,
    '             comment As String, ByVal tag As String, ID As String, ByVal RQDate As DateTime)
    '    CreateFileConfirm(ID, tag)

    '    '//Khởi tạo Lotus
    '    Dim notesSession As New NotesSession()
    '    Dim notesDataBase As NotesDatabase = Nothing
    '    Dim notesDocument As NotesDocument = Nothing

    '    '//Đăng nhập tự động với password = 12345
    '    notesSession.Initialize()
    '    'notesSession.InitializeUsingNotesUserName("tam_truongminh","minhtam");
    '    Dim server As String = notesSession.GetEnvironmentString("MailServer", True)
    '    Dim mailfile As String = notesSession.GetEnvironmentString("MailFile", True)
    '    Dim username As String = notesSession.GetEnvironmentString("User", True)

    '    notesDataBase = notesSession.GetDatabase(server, mailfile)

    '    If Not notesDataBase.IsOpen Then
    '        notesDataBase.Open()
    '    End If
    '    notesDocument = notesDataBase.CreateDocument()

    '    notesDocument.ReplaceItemValue("Form", "Memo")
    '    notesDocument.ReplaceItemValue("SendTo", "")
    '    notesDocument.ReplaceItemValue("CopyTo", "")
    '    notesDocument.ReplaceItemValue("Subject", String.Format("({0}) {1} {2}",
    '                                        CurrentUser.Section, Title, RQDate.ToString("dd-MMM-yyyy")))

    '    ' //Khởi tạo richtext
    '    Dim strSpace As String = ""
    '    Dim richTextItem As NotesRichTextItem = notesDocument.CreateRichTextItem("Body")
    '    richTextItem.AppendText(" Dear Mr/Ms,")
    '    richTextItem.AddNewLine()
    '    richTextItem.AddNewLine()
    '    If submit = PublicFunction.Submit.Confirm Then
    '        richTextItem.AppendText(String.Format(contentApproved, person))
    '    Else
    '        richTextItem.AppendText(String.Format(contentReject, person))
    '    End If
    '    richTextItem.AddNewLine()
    '    richTextItem.AddNewLine()
    '    richTextItem.AppendText("Ghi chú (Comment): " + comment)
    '    richTextItem.AddNewLine()
    '    richTextItem.AddNewLine()
    '    richTextItem.AppendText("Mở file bên dưới để xem chi tiết (Please open file show detail).")
    '    richTextItem.AddNewLine()
    '    richTextItem.AddNewLine()
    '    richTextItem.EmbedObject(EMBED_TYPE.EMBED_ATTACHMENT, Nothing, pathfile, Nothing)


    '    notesDocument.ReplaceItemValue("SendTo", sendto)
    '    notesDocument.ReplaceItemValue("CopyTo", ccto)
    '    Dim oItemValue As Object = notesDocument.GetItemValue("SendTo")

    '    notesDocument.Send(False, oItemValue)

    '    richTextItem = Nothing
    '    notesDocument = Nothing
    '    notesDataBase = Nothing
    '    notesSession = Nothing

    'End Sub

    Shared Sub CreateFileConfirm(ByVal ID As String, ByVal tag As String)
        Dim line1 As String = "@echo off"
        Dim line2 As String = String.Format("start C:\Programs_NDV\ERPNDV\ERPNDV.exe {0},{1}", tag, ID)
        Dim line3 As String = "exit"
        File.Delete(pathfile)
        WriteLineEnd(pathfile, line1)
        WriteLineEnd(pathfile, String.Format(line2, ID.Trim()))
        WriteLineEnd(pathfile, line3)
    End Sub

    Public Shared Function AddLeft(ByVal charAdd As String, ByVal Value As String, ByVal length As Integer) As String
        Return Value.PadLeft(length, charAdd)
    End Function

    Public Shared Function AddRight(ByVal charAdd As String, ByVal Value As String, ByVal length As Integer) As String
        Return Value.PadRight(length, charAdd)
    End Function
    ''' <summary>
    ''' Return '01,'02','03'
    ''' </summary>
    ''' <param name="table"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetCodeString(ByVal table As DataTable) As String
        Dim strCode As String = ""
        If table Is Nothing Then Return strCode
        If table.Rows.Count > 0 Then
            For Each row As DataRow In table.Rows
                strCode += "'" & row(0) & "',"
            Next
            If strCode.Length > 0 Then
                strCode = strCode.Substring(0, strCode.Length - 1)
            End If
            Return strCode
        Else
            Return strCode
        End If
    End Function
    ''' <summary>
    ''' Return 01,02,03
    ''' </summary>
    ''' <param name="lst"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetCodeString(ByVal lst As List(Of String)) As String
        Dim strCode As String = ""
        If lst.Count = 0 Then Return strCode
        For Each item As String In lst
            strCode += item & ","
        Next
        If strCode.Length > 0 Then
            strCode = strCode.Substring(0, strCode.Length - 1)
        End If
        Return strCode
    End Function
    Public Shared Function Left(ByVal str As String, ByVal length As Integer)
        Return Microsoft.VisualBasic.Left(str, length)
    End Function

    Public Shared Function Right(ByVal str As String, ByVal length As Integer)
        Return Microsoft.VisualBasic.Right(str, length)
    End Function

#End Region

#Region "Drawing"
    Shared Sub FillControl(ByVal X As Integer, ByVal Y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim rectange As New System.Drawing.Rectangle(X, Y, width, height)
        Dim rectangeDraw As New System.Drawing.Rectangle(X, Y, width - 1, height - 1)
        Dim brush As New LinearGradientBrush(rectange, Color.White, Color.YellowGreen, LinearGradientMode.Horizontal)
        Dim pen As New Pen(PublicConst.Color_Boder, 0)
        e.Graphics.FillRectangle(brush, rectange)
        e.Graphics.DrawRectangle(pen, rectangeDraw)
    End Sub
    Shared Sub FillForm(ByVal X As Integer, ByVal Y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim rectange As New System.Drawing.Rectangle(X, Y, width, height)
        Dim rectangeDraw As New System.Drawing.Rectangle(X, Y, width - 2, height - 2)
        Dim brush As New LinearGradientBrush(rectange, Color.White, Color.YellowGreen, LinearGradientMode.Vertical)
        Dim pen As New Pen(PublicConst.Color_Boder, 1)
        e.Graphics.FillRectangle(brush, rectange)
        e.Graphics.DrawRectangle(pen, rectangeDraw)
    End Sub
    Shared Sub FillControl(ByVal X As Integer, ByVal Y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal color1 As Color, ByVal color2 As Color, ByVal lineMode As LinearGradientMode, ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim rectange As New System.Drawing.Rectangle(X, Y, width, height)
        Dim rectangeDraw As New System.Drawing.Rectangle(X, Y, width - 1, height - 1)
        Dim brush As New LinearGradientBrush(rectange, color1, color2, lineMode)
        Dim pen As New Pen(PublicConst.Color_Boder, 0)
        e.Graphics.FillRectangle(brush, rectange)
        e.Graphics.DrawRectangle(pen, rectangeDraw)
    End Sub
#End Region

#Region "Set color"
    Public Shared Sub SetColorEnter(ByVal textBox As System.Windows.Forms.ToolStripComboBox)
        textBox.BackColor = PublicConst.Color_Entry_Text
        textBox.SelectAll()
    End Sub
    Shared Sub SetColorLeave(ByVal textBox As System.Windows.Forms.ToolStripComboBox)
        textBox.BackColor = PublicConst.Color_Leave_Text
    End Sub
    Public Shared Sub SetColorEnter(ByVal textBox As System.Windows.Forms.ToolStripTextBox)
        textBox.BackColor = PublicConst.Color_Entry_Text
        textBox.SelectAll()
    End Sub
    Shared Sub SetColorLeave(ByVal textBox As System.Windows.Forms.ToolStripTextBox)
        textBox.BackColor = PublicConst.Color_Leave_Text
    End Sub
    Public Shared Sub SetColorEnter(ByVal textBox As System.Windows.Forms.TextBox)
        textBox.BackColor = PublicConst.Color_Entry_Text
        textBox.SelectAll()
    End Sub
    Shared Sub SetColorLeave(ByVal textBox As System.Windows.Forms.TextBox)
        textBox.BackColor = PublicConst.Color_Leave_Text
    End Sub
    Public Shared Sub SetColorEnter(ByVal combo As ComboBox)
        combo.BackColor = PublicConst.Color_Entry_Text
        combo.SelectAll()
    End Sub
    Shared Sub SetColorLeave(ByVal combo As ComboBox)
        combo.BackColor = PublicConst.Color_Leave_Text
    End Sub
    Public Shared Sub SetColorEnter(ByVal maskBox As MaskedTextBox)
        maskBox.BackColor = PublicConst.Color_Entry_Text
        maskBox.Focus()
        maskBox.SelectAll()
    End Sub
    Shared Sub SetColorLeave(ByVal maskBox As MaskedTextBox)
        maskBox.BackColor = PublicConst.Color_Leave_Text
    End Sub

    Shared Function GetColor(ByVal index As Integer) As Color
        Select Case index
            Case 0
                Return Color.Red
            Case 1
                Return Color.Blue
            Case 2
                Return Color.Yellow
            Case 3
                Return Color.Orange
            Case 4
                Return Color.Orchid
            Case 5
                Return Color.Pink
            Case 6
                Return Color.GreenYellow
            Case 7
                Return Color.LightBlue
            Case 8
                Return Color.LightGreen
            Case 9
                Return Color.LightPink
            Case 10
                Return Color.LightPink
        End Select

    End Function
#End Region

#Region "Show message"
    Shared Function ShowQuestion(Optional ByVal info As String = "") As DialogResult
        Return MessageBox.Show(info, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    End Function
    Shared Function ShowQuestionGetData(Optional ByVal info As String = "") As DialogResult

        Return MessageBox.Show(String.Format(PublicConst.Message_Question_Getdata, info),
                               PublicConst.Message_Caption_Getdata,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question)


    End Function
    Shared Function ShowQuestionGetDataAgain(Optional ByVal info As String = "") As DialogResult

        Return MessageBox.Show(String.Format(PublicConst.Message_Question_GetdataAgain, info),
                               PublicConst.Message_Caption_Getdata,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question)


    End Function
    Shared Function ShowQuestionSave(Optional ByVal info As String = "") As DialogResult
        Return MessageBox.Show(String.Format(PublicConst.Message_Question_Save, info),
                               PublicConst.Message_Caption_Save, MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

    End Function
    Shared Function ShowQuestionDelete(Optional ByVal info As String = "") As DialogResult
        Return MessageBox.Show(String.Format(PublicConst.Message_Question_Delete, info),
                               PublicConst.Message_Caption_Delete, MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
    End Function
    Shared Function ShowQuestionUpdate(Optional ByVal info As String = "") As DialogResult
        Return MessageBox.Show(String.Format(PublicConst.Message_Question_Update, info),
                               PublicConst.Message_Caption_Update,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    End Function
    Shared Function ShowQuestionInsert(Optional ByVal info As String = "") As DialogResult
        Return MessageBox.Show(String.Format(PublicConst.Message_Question_Insert, 0),
                               PublicConst.Message_Caption_Insert,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1)
    End Function
    Shared Function ShowQuestionImport(Optional ByVal info As String = "") As DialogResult
        Return MessageBox.Show(String.Format(PublicConst.Message_Question_Import, info),
                               PublicConst.Message_Caption_Import,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1)
    End Function
    Shared Function ShowQuestionExport(Optional ByVal info As String = "") As DialogResult
        Return MessageBox.Show(String.Format(PublicConst.Message_Question_Export, info),
                               PublicConst.Message_Caption_Export,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1)
    End Function
    Shared Function ShowQuestionPrint(Optional ByVal info As String = "") As DialogResult
        Return MessageBox.Show(String.Format(PublicConst.Message_Question_Print, info),
                               PublicConst.Message_Caption_Print,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1)
    End Function
    Shared Function ShowQuestionExit(Optional ByVal info As String = "") As DialogResult
        Return MessageBox.Show(String.Format(PublicConst.Message_Question_Exit, info),
                               PublicConst.Message_Caption_Exit,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1)
    End Function
    Shared Function ShowQuestionLock(Optional ByVal info As String = "") As DialogResult
        Return MessageBox.Show(String.Format(PublicConst.Message_Question_Lock, info),
                               PublicConst.Message_Caption_Lock,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1)
    End Function
    Shared Function ShowQuestionUnLock(Optional ByVal info As String = "") As DialogResult
        Return MessageBox.Show(String.Format(PublicConst.Message_Question_UnLock, info),
                               PublicConst.Message_Caption_Confirm,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1)
    End Function
    Shared Function ShowQuestionConfirm(Optional ByVal info As String = "") As DialogResult
        Return MessageBox.Show(String.Format(PublicConst.Message_Question_Confirm, info),
                               PublicConst.Message_Caption_Confirm,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1)
    End Function
    Shared Function ShowQuestionUnConfirm(Optional ByVal info As String = "") As DialogResult
        Return MessageBox.Show(String.Format(PublicConst.Message_Question_UnConfirm, info),
                               PublicConst.Message_Caption_Confirm,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1)
    End Function
    Shared Function ShowQuestionBackup(Optional ByVal info As String = "") As DialogResult
        Return MessageBox.Show(String.Format(PublicConst.Message_Question_Backup, info),
                               PublicConst.Message_Caption_Confirm,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1)
    End Function
    Shared Function ShowQuestionRestore(Optional ByVal info As String = "") As DialogResult
        Return MessageBox.Show(String.Format(PublicConst.Message_Question_Restore, info),
                               PublicConst.Message_Caption_Confirm,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1)
    End Function
    Shared Function ShowQuestionRun(Optional ByVal info As String = "") As DialogResult

        Return MessageBox.Show(String.Format(PublicConst.Message_Question_Run, info),
                               PublicConst.Message_Caption_Run,
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1)

    End Function
    Shared Function ShowQuestionRunAgain(Optional ByVal info As String = "") As DialogResult

        Return MessageBox.Show(String.Format(PublicConst.Message_Question_RunAgain, info),
                               PublicConst.Message_Caption_Run,
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1)

    End Function
    Shared Function ShowQuestionBack(Optional ByVal info As String = "") As DialogResult
        Return MessageBox.Show(String.Format(PublicConst.Message_Question_Back, info),
                               PublicConst.Message_Caption_Back,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1)
    End Function
    'Warning mesage==============================================================================================================
    Shared Sub ShowWarning(ByVal infor As String)
        MessageBox.Show(infor, PublicConst.Message_Caption_Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    Shared Sub ShowWarningNotNull(ByVal columName As String)
        MessageBox.Show(String.Format(PublicConst.Message_Warning_NotNull, columName), PublicConst.Message_Caption_Warning,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    Shared Sub ShowWarningNotEmpty(ByVal columName As String)
        MessageBox.Show(String.Format(PublicConst.Message_Warning_NotEmpty, columName), PublicConst.Message_Caption_Warning,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    Shared Sub ShowWarningLength(ByVal columName As String, ByVal length As Integer)
        MessageBox.Show(String.Format(PublicConst.Message_Warning_Length, columName, length), PublicConst.Message_Caption_Warning,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    Shared Sub ShowWarningLocked(Optional ByVal infor As String = "Data")
        MessageBox.Show(String.Format(PublicConst.Message_Warning_Locked, infor), PublicConst.Message_Caption_Warning,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    Shared Sub ShowWarningNotConfirm(ByVal infor As String)
        MessageBox.Show(String.Format(PublicConst.Message_Warning_NotConfirm, infor), PublicConst.Message_Caption_Warning,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    Shared Sub ShowWarningLockedBefore(ByVal infor As String)
        MessageBox.Show(String.Format(PublicConst.Message_Warning_LockedBefore, infor), PublicConst.Message_Caption_Warning,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    Shared Sub ShowWarningExistData(ByVal infor As String)
        MessageBox.Show(String.Format(PublicConst.Message_Warning_ExistData, infor), PublicConst.Message_Caption_Warning,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    Shared Sub ShowWarningNotModify(ByVal infor As String)
        MessageBox.Show(String.Format(PublicConst.Message_Warning_CanNotModify, infor), PublicConst.Message_Caption_Warning,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    Shared Sub ShowWarningMustDigit(ByVal infor As String)
        MessageBox.Show(String.Format(PublicConst.Message_Warning_MustDigit, infor), PublicConst.Message_Caption_Warning,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    Shared Sub ShowWarningMustString(ByVal infor As String)
        MessageBox.Show(String.Format(PublicConst.Message_Warning_MustChar, infor), PublicConst.Message_Caption_Warning,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    Shared Sub ShowWarningNotCorrect(ByVal infor As String)
        MessageBox.Show(String.Format(PublicConst.Message_Warning_NotCorrect, infor), PublicConst.Message_Caption_Warning,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    Shared Sub ShowWarningABMustDiff(ByVal infor As String)
        MessageBox.Show(String.Format(PublicConst.Message_Warning_MustDiff, infor), PublicConst.Message_Caption_Warning,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    Shared Sub ShowWarningMustSame(ByVal infor As String)
        MessageBox.Show(String.Format(PublicConst.Message_Warning_MustDiff, infor), PublicConst.Message_Caption_Warning,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    'Success mesage==============================================================================================================
    Shared Sub ShowSuccess()
        MessageBox.Show(PublicConst.Message_Successfully, PublicConst.Message_Caption_Info,
                        MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub
    Shared Sub ShowSuccess(ByVal rowNumber As Integer)
        MessageBox.Show(String.Format(PublicConst.Message_Successfully_Rows, rowNumber), PublicConst.Message_Caption_Info,
                        MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub
    'Error mesage==============================================================================================================
    Shared Sub ShowError(ByVal ex As Exception, ByVal functionName As String, ByVal formOrClassName As String)
        MessageBox.Show(ex.Message, PublicConst.Message_Caption_Error, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Write log file
        If Not Directory.Exists(_folderLog) Then
            Directory.CreateDirectory(_folderLog)
        End If
        WriteLineEnd(_fileLog, _line)
        WriteLineEnd(_fileLog, "DateTime:" & DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss"))
        WriteLineEnd(_fileLog, "UserID:" & CurrentUser.UserID & "-" & CurrentUser.FullName)
        WriteLineEnd(_fileLog, "PC:" & Environment.MachineName & "-" & Environment.UserName)
        WriteLineEnd(_fileLog, "ClassOrForm:" & formOrClassName)
        WriteLineEnd(_fileLog, "FunctionName:" & functionName)
        WriteLineEnd(_fileLog, "Error:" & ex.Message)
    End Sub

    Shared Sub ShowError(ByVal ex As Exception, ByVal functionName As String, ByVal formOrClassName As String, ByVal msg As String)
        MessageBox.Show(ex.Message & msg, PublicConst.Message_Caption_Error, MessageBoxButtons.OK, MessageBoxIcon.Error)
        If Not Directory.Exists(_folderLog) Then
            Directory.CreateDirectory(_folderLog)
        End If
        WriteLineEnd(_fileLog, _line)
        WriteLineEnd(_fileLog, "DateTime:" & DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss"))
        WriteLineEnd(_fileLog, "UserID:" & CurrentUser.UserID & "-" & CurrentUser.FullName)
        WriteLineEnd(_fileLog, "PC:" & Environment.MachineName & "-" & Environment.UserName)
        WriteLineEnd(_fileLog, "ClassOrForm:" & formOrClassName)
        WriteLineEnd(_fileLog, "FunctionName:" & functionName)
        WriteLineEnd(_fileLog, "Error:" & ex.Message)
    End Sub
#End Region

#Region "Create ID"
    ''' <summary>
    ''' Increase index 
    ''' Example: 001-->002
    ''' </summary>
    ''' <param name="index"></param>
    ''' <param name="lenght"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function IncreaseIndex(ByVal index As String, ByVal lenght As Integer) As String
        If index.Length > 0 Then
            Dim value As Integer = CInt(index)
            value += 1
            Return AddLeft("0", value, lenght)
        End If
        Return AddLeft("0", 1, lenght)
    End Function
#End Region

#Region "Import , Export EXCEL "
    Shared Sub ExportWithFormat(ByVal grid As DataGridView)
        Try
            Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

            Dim app As New Excel.Application
            Dim workBook As Excel.Workbook
            Dim workSheet As Excel.Worksheet
            Dim workRange As Excel.Range
            workBook = app.Workbooks.Add(Type.Missing)
            workSheet = CType(workBook.Sheets(1), Excel.Worksheet)
            workSheet.Name = "Sheet1"
            app.Visible = True
            'Header
            For col As Integer = 0 To grid.ColumnCount - 1
                workSheet.Cells(1, col + 1) = grid.Columns(col).HeaderText
            Next
            'Write data
            For row As Integer = 0 To grid.Rows.Count - 1
                For col As Integer = 0 To grid.ColumnCount - 1
                    If grid.Rows(row).Cells(col).ValueType.Name = "String" Then
                        workSheet.Cells(row + 2, col + 1) = "'" + grid.Rows(row).Cells(col).Value
                    Else
                        workSheet.Cells(row + 2, col + 1) = grid.Rows(row).Cells(col).Value
                    End If

                    If grid.Rows(row).Cells(col).Style.BackColor.Name <> "0" Then
                        workRange = workSheet.Range(workSheet.Cells(row + 2, col + 1), workSheet.Cells(row + 2, col + 1))
                        workRange.Interior.Color = ColorTranslator.ToWin32(grid.Rows(row).Cells(col).Style.BackColor)
                    End If
                Next

            Next
            app.DefaultSaveFormat = Excel.XlFileFormat.xlWorkbookDefault
            GC.Collect()
            GC.WaitForPendingFinalizers()
            Marshal.FinalReleaseComObject(workSheet)
            Marshal.FinalReleaseComObject(workBook)
            Marshal.FinalReleaseComObject(app)

            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' Vo Thanh Son IT
    ''' </summary>
    ''' <param name="grid"></param>
    ''' <param name="bWithoutInvisibleColumns"></param>
    ''' <remarks></remarks>
    Public Shared Sub ExportEXCEL(ByVal grid As DataGridView, ByVal bWithoutInvisibleColumns As Boolean)
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

        If grid.RowCount = 0 Then Exit Sub


        Dim myExcel As Excel.Application = New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wSheet As Excel.Worksheet
        wbook = myExcel.Application.Workbooks.Add(True)
        wbook.Sheets.Add(Type.Missing, myExcel.Application.Worksheets(myExcel.Application.Worksheets.Count), 1, Excel.XlSheetType.xlWorksheet)
        wSheet = myExcel.Application.Worksheets(1)
        wSheet.Activate()
        myExcel.Visible = True

        Dim i, j As Integer
        Dim rows As Integer = grid.Rows.Count
        Dim cols As Integer = grid.Columns.Count
        Dim DataArray(rows - 1, cols - 1) As Object

        For i = 0 To rows - 1
            Dim iCol As Int16 = 0
            For j = 0 To cols - 1
                If bWithoutInvisibleColumns And (Not grid.Columns(j).Visible Or grid.Columns(j).DataPropertyName = "") Then
                    Continue For
                End If
                If grid.Rows(i).Cells(j).Value Is System.DBNull.Value Or grid.Rows(i).Cells(j).Value Is Nothing Then
                Else
                    If grid.Rows(i).Cells(j).Value.GetType().Name = "String" Then
                        DataArray(i, iCol) = "'" & grid.Rows(i).Cells(j).Value.ToString()
                    Else
                        DataArray(i, iCol) = grid.Rows(i).Cells(j).Value
                    End If
                End If
                iCol = iCol + 1
            Next
        Next

        Dim iColHeader As Int16 = 0
        For j = 0 To cols - 1
            If bWithoutInvisibleColumns And (Not grid.Columns(j).Visible Or grid.Columns(j).DataPropertyName = "") Then
                Continue For
            End If
            wSheet.Cells(1, iColHeader + 1) = "'" + grid.Columns(j).HeaderText
            iColHeader = iColHeader + 1
        Next

        If DataArray IsNot Nothing Then
            wSheet.Range("A2").Resize(rows, cols).Value = DataArray
        End If

        Try
            myExcel.DefaultSaveFormat = Excel.XlFileFormat.xlWorkbookDefault
            ''myExcel.DisplayAlerts = False
            ' myExcel.Columns.AutoFit()
            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
        Catch ex As Exception
        End Try

    End Sub

    Shared Sub ExportEXCEL(ByVal grid As DataGridView)

        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

        If grid.RowCount = 0 Then Exit Sub

        Dim myExcel As Excel.Application = New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wSheet As Excel.Worksheet
        wbook = myExcel.Application.Workbooks.Add(True)
        wbook.Sheets.Add(Type.Missing, myExcel.Application.Worksheets(myExcel.Application.Worksheets.Count), 1, Excel.XlSheetType.xlWorksheet)
        wSheet = myExcel.Application.Worksheets(1)
        wSheet.Activate()
        myExcel.Visible = True


        Dim i, j As Integer
        Dim rows As Integer = grid.Rows.Count
        Dim cols As Integer = grid.Columns.Count
        Dim DataArray(rows - 1, cols - 1) As Object

        For i = 0 To rows - 1
            For j = 0 To cols - 1
                If grid.Rows(i).Cells(j).Value Is System.DBNull.Value Then Continue For

                If String.IsNullOrEmpty(grid.Rows(i).Cells(j).Value) Then
                Else
                    If grid.Rows(i).Cells(j).Value.GetType.Name = "String" Then
                        DataArray(i, j) = "'" & grid.Rows(i).Cells(j).Value.ToString()
                    Else
                        DataArray(i, j) = grid.Rows(i).Cells(j).Value
                    End If
                End If
            Next
        Next

        For j = 0 To cols - 1
            wSheet.Cells(1, j + 1) = "'" + grid.Columns(j).HeaderText
        Next
        If DataArray IsNot Nothing Then
            wSheet.Range("A2").Resize(rows, cols).Value = DataArray
        End If

        Try
            myExcel.DefaultSaveFormat = Excel.XlFileFormat.xlWorkbookDefault
            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
        Catch ex As Exception
        End Try

    End Sub

    Shared Sub ExportEXCEL(ByVal grid As DataGridView, ByVal sheetName As String, ByVal fileName As String)
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

        If grid.DataSource Is Nothing Then Exit Sub
        If grid.RowCount = 0 Then Exit Sub


        Dim myExcel As Excel.Application = New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wSheet As Excel.Worksheet
        wbook = myExcel.Application.Workbooks.Add(True)
        wbook.Sheets.Add(Type.Missing, myExcel.Application.Worksheets(myExcel.Application.Worksheets.Count), 1, Excel.XlSheetType.xlWorksheet)
        wSheet = myExcel.Application.Worksheets(1)
        wSheet.Activate()
        If sheetName <> "" Then
            wSheet.Name = sheetName
        End If
        myExcel.Visible = True

        Dim i, j As Integer
        Dim rows As Integer = grid.Rows.Count
        Dim cols As Integer = grid.Columns.Count
        Dim DataArray(rows - 1, cols - 1) As Object

        For i = 0 To rows - 1
            For j = 0 To cols - 1
                If grid.Rows(i).Cells(j).Value Is System.DBNull.Value Then Continue For
                If String.IsNullOrEmpty(grid.Rows(i).Cells(j).Value) Then
                Else
                    If grid.Rows(i).Cells(j).Value.GetType().Name = "String" Then
                        DataArray(i, j) = "'" & grid.Rows(i).Cells(j).Value.ToString()
                    Else
                        DataArray(i, j) = grid.Rows(i).Cells(j).Value
                    End If

                End If
            Next
        Next

        For j = 0 To cols - 1
            wSheet.Cells(1, j + 1) = "'" + grid.Columns(j).HeaderText
        Next
        If DataArray IsNot Nothing Then
            wSheet.Range("A2").Resize(rows, cols).Value = DataArray
        End If

        Try

            ''myExcel.DisplayAlerts = False
            ' myExcel.Columns.AutoFit()
            If fileName = "" Then
                myExcel.DefaultSaveFormat = Excel.XlFileFormat.xlWorkbookDefault

            Else
                Dim dialogsave As New SaveFileDialog
                dialogsave.FileName = fileName
                dialogsave.Filter = "Excel 2007|*.xlsx"
                If dialogsave.ShowDialog = DialogResult.OK Then
                    wbook.SaveAs(dialogsave.FileName, Type.Missing, Type.Missing, Type.Missing,
                                    Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlShared, Type.Missing,
                                    Type.Missing, Type.Missing, Type.Missing, Type.Missing)
                End If
            End If

            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
        Catch ex As Exception
        End Try

    End Sub

    Shared Sub ExportEXCEL(ByVal grids() As DataGridView)
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

        Dim myExcel As Excel.Application = New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wSheet As Excel.Worksheet
        wbook = myExcel.Application.Workbooks.Add(True)
        myExcel.Visible = True


        For Each grid As DataGridView In grids
            If grid Is Nothing Then Continue For
            If grid.Rows.Count = 0 Then Continue For

            wbook.Sheets.Add(Type.Missing, myExcel.Application.Worksheets(myExcel.Application.Worksheets.Count), 1, Excel.XlSheetType.xlWorksheet)
            wSheet = myExcel.Application.Worksheets(myExcel.Application.Worksheets.Count - 1)
            wSheet.Activate()

            Dim i, j As Integer
            Dim rows As Integer = grid.Rows.Count
            Dim cols As Integer = grid.Columns.Count
            Dim DataArray(rows - 1, cols - 1) As Object

            For i = 0 To rows - 1
                For j = 0 To cols - 1
                    If grid.Rows(i).Cells(j).Value Is System.DBNull.Value Then Continue For
                    If String.IsNullOrEmpty(grid.Rows(i).Cells(j).Value) Then
                    Else
                        If IsDate(grid.Rows(i).Cells(j).Value) Or IsNumeric(grid.Rows(i).Cells(j).Value) Then
                            DataArray(i, j) = grid.Rows(i).Cells(j).Value
                        Else
                            DataArray(i, j) = "'" + grid.Rows(i).Cells(j).Value.ToString()
                        End If
                    End If
                Next
            Next


            For j = 0 To cols - 1
                wSheet.Cells(1, j + 1) = "'" + grid.Columns(j).HeaderText
            Next

            If DataArray IsNot Nothing Then
                wSheet.Range("A2").Resize(rows, cols).Value = DataArray
            End If

        Next
        Try
            myExcel.DefaultSaveFormat = Excel.XlFileFormat.xlWorkbookDefault
            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
        Catch ex As Exception
        End Try
    End Sub

    Shared Sub ExportEXCEL(ByVal grids() As DataGridView, ByVal fileName As String)
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

        Dim myExcel As Excel.Application = New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wSheet As Excel.Worksheet
        wbook = myExcel.Application.Workbooks.Add(True)
        myExcel.Visible = True


        For Each grid As DataGridView In grids
            If grid Is Nothing Then Continue For
            If grid.Rows.Count = 0 Then Continue For

            wbook.Sheets.Add(Type.Missing, myExcel.Application.Worksheets(myExcel.Application.Worksheets.Count), 1, Excel.XlSheetType.xlWorksheet)
            wSheet = myExcel.Application.Worksheets(myExcel.Application.Worksheets.Count - 1)
            wSheet.Activate()
            Dim i, j As Integer
            Dim rows As Integer = grid.Rows.Count
            Dim cols As Integer = grid.Columns.Count
            Dim DataArray(rows - 1, cols - 1) As Object

            For i = 0 To rows - 1
                For j = 0 To cols - 1
                    If grid.Rows(i).Cells(j) Is System.DBNull.Value Then Continue For
                    If String.IsNullOrEmpty(grid.Rows(i).Cells(j).Value) Then
                    Else
                        If grid.Rows(i).Cells(j).GetType().Name = "String" Then
                            DataArray(i, j) = "'" + grid.Rows(i).Cells(j).Value.ToString()
                        Else
                            DataArray(i, j) = grid.Rows(i).Cells(j).Value
                        End If
                    End If
                Next
            Next


            For j = 0 To cols - 1
                wSheet.Cells(1, j + 1) = "'" + grid.Columns(j).HeaderText
            Next

            If DataArray IsNot Nothing Then
                wSheet.Range("A2").Resize(rows, cols).Value = DataArray
            End If

        Next
        Try
            myExcel.DefaultSaveFormat = Excel.XlFileFormat.xlWorkbookDefault
            ''myExcel.DisplayAlerts = False
            'myExcel.Columns.AutoFit()
            If fileName = "" Then
                myExcel.DefaultSaveFormat = Excel.XlFileFormat.xlWorkbookDefault

            Else
                Dim dialogsave As New SaveFileDialog
                dialogsave.FileName = fileName
                dialogsave.Filter = "Excel 2007|*.xlsx"
                If dialogsave.ShowDialog = DialogResult.OK Then
                    wbook.SaveAs(dialogsave.FileName, Type.Missing, Type.Missing, Type.Missing,
                                    Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlShared, Type.Missing,
                                    Type.Missing, Type.Missing, Type.Missing, Type.Missing)
                End If
            End If

            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
        Catch ex As Exception
        End Try
    End Sub

    Shared Sub ExportEXCEL(ByVal dt As System.Data.DataTable)
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

        If dt Is Nothing Then Return
        If dt.Rows.Count = 0 Then Return

        Dim i, j As Integer
        Dim rows As Integer = dt.Rows.Count
        Dim cols As Integer = dt.Columns.Count
        Dim DataArray(rows - 1, cols - 1) As Object
        Dim myExcel As Excel.Application = New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wSheet As Excel.Worksheet
        wbook = myExcel.Application.Workbooks.Add(True)
        wbook.Sheets.Add(Type.Missing, myExcel.Application.Worksheets(myExcel.Application.Worksheets.Count), 1, Excel.XlSheetType.xlWorksheet)
        wSheet = myExcel.Application.Worksheets(1)
        wSheet.Activate()
        myExcel.Visible = True

        For i = 0 To rows - 1
            For j = 0 To cols - 1
                If dt.Rows(i).Item(j) Is System.DBNull.Value Then Continue For
                If String.IsNullOrEmpty(dt.Rows(i).Item(j)) Then
                Else
                    If dt.Rows(i).Item(j).GetType().Name = "String" Then
                        DataArray(i, j) = "'" + dt.Rows(i).Item(j).ToString()
                    Else
                        DataArray(i, j) = dt.Rows(i).Item(j)
                    End If
                End If
            Next
        Next


        For j = 0 To cols - 1
            myExcel.Cells(1, j + 1) = "'" + dt.Columns(j).Caption
        Next

        If DataArray IsNot Nothing Then
            myExcel.Range("A2").Resize(rows, cols).Value = DataArray
        End If

        Try

            myExcel.DefaultSaveFormat = Excel.XlFileFormat.xlWorkbookDefault

            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
        Catch ex As Exception
        End Try


    End Sub

    Shared Sub ExportEXCEL(ByVal dt As System.Data.DataTable, ByVal sheetName As String, ByVal fileName As String)
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

        If dt Is Nothing Then Return
        If dt.Rows.Count = 0 Then Return

        Dim i, j As Integer
        Dim rows As Integer = dt.Rows.Count
        Dim cols As Integer = dt.Columns.Count
        Dim DataArray(rows - 1, cols - 1) As Object
        Dim myExcel As Excel.Application = New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wSheet As Excel.Worksheet
        wbook = myExcel.Application.Workbooks.Add(True)
        wbook.Sheets.Add(Type.Missing, myExcel.Application.Worksheets(myExcel.Application.Worksheets.Count), 1, Excel.XlSheetType.xlWorksheet)
        wSheet = myExcel.Application.Worksheets(1)
        wSheet.Activate()
        If sheetName <> "" Then
            wSheet.Name = sheetName
        End If
        myExcel.Visible = True

        For i = 0 To rows - 1
            For j = 0 To cols - 1
                If dt.Rows(i).Item(j) Is System.DBNull.Value Then Continue For
                If String.IsNullOrEmpty(dt.Rows(i).Item(j)) Then
                Else
                    If dt.Rows(i).Item(j).GetType().Name = "String" Then
                        DataArray(i, j) = "'" + dt.Rows(i).Item(j).ToString()
                    Else
                        DataArray(i, j) = dt.Rows(i).Item(j)
                    End If
                End If
            Next
        Next


        For j = 0 To cols - 1
            myExcel.Cells(1, j + 1) = "'" + dt.Columns(j).Caption
        Next

        If DataArray IsNot Nothing Then
            myExcel.Range("A2").Resize(rows, cols).Value = DataArray
        End If

        Try

            myExcel.DefaultSaveFormat = Excel.XlFileFormat.xlWorkbookDefault

            If fileName = "" Then
                myExcel.DefaultSaveFormat = Excel.XlFileFormat.xlWorkbookDefault

            Else
                Dim dialogsave As New SaveFileDialog
                dialogsave.FileName = fileName
                dialogsave.Filter = "Excel 2007|*.xlsx"
                If dialogsave.ShowDialog = DialogResult.OK Then
                    wbook.SaveAs(dialogsave.FileName, Type.Missing, Type.Missing, Type.Missing,
                                    Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlShared, Type.Missing,
                                    Type.Missing, Type.Missing, Type.Missing, Type.Missing)
                End If
            End If


            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
        Catch ex As Exception
        End Try


    End Sub

    Shared Sub ExportEXCEL(ByVal table() As DataTable)
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

        Dim myExcel As Excel.Application = New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wSheet As Excel.Worksheet
        wbook = myExcel.Application.Workbooks.Add(True)
        myExcel.Visible = True


        For Each dt As DataTable In table
            If dt Is Nothing Then Continue For
            If dt.Rows.Count = 0 Then Continue For

            wbook.Sheets.Add(Type.Missing, myExcel.Application.Worksheets(myExcel.Application.Worksheets.Count), 1, Excel.XlSheetType.xlWorksheet)
            wSheet = myExcel.Application.Worksheets(myExcel.Application.Worksheets.Count - 1)
            wSheet.Activate()

            Dim i, j As Integer
            Dim rows As Integer = dt.Rows.Count
            Dim cols As Integer = dt.Columns.Count
            Dim DataArray(rows - 1, cols - 1) As Object

            For i = 0 To rows - 1
                For j = 0 To cols - 1
                    If dt.Rows(i).Item(j) Is System.DBNull.Value Then Continue For
                    If String.IsNullOrEmpty(dt.Rows(i).Item(j).ToString) Then
                    Else
                        If dt.Rows(i).Item(j).GetType().Name = "String" Then
                            DataArray(i, j) = "'" + dt.Rows(i).Item(j).ToString()
                        Else
                            DataArray(i, j) = dt.Rows(i).Item(j)
                        End If
                    End If
                Next
            Next


            For j = 0 To cols - 1
                wSheet.Cells(1, j + 1) = "'" + dt.Columns(j).Caption
            Next

            If DataArray IsNot Nothing Then
                wSheet.Range("A2").Resize(rows, cols).Value = DataArray
            End If

        Next
        Try
            myExcel.DefaultSaveFormat = Excel.XlFileFormat.xlWorkbookDefault

            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
        Catch ex As Exception
        End Try
    End Sub

    Shared Sub ExportEXCEL(ByVal dt As System.Data.DataTable, ByVal filename As String)
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

        If dt Is Nothing Then Return
        If dt.Rows.Count = 0 Then Return

        Dim i, j As Integer
        Dim rows As Integer = dt.Rows.Count
        Dim cols As Integer = dt.Columns.Count
        Dim DataArray(rows - 1, cols - 1) As Object
        Dim myExcel As Excel.Application = New Excel.Application
        Dim wSheet As Excel.Worksheet
        Dim wbook As Excel.Workbook

        For i = 0 To rows - 1
            For j = 0 To cols - 1
                If dt.Rows(i).Item(j) Is System.DBNull.Value Then Continue For
                If String.IsNullOrEmpty(dt.Rows(i).Item(j).ToString) Then
                Else
                    If dt.Rows(i).Item(j).GetType().Name = "String" Then
                        DataArray(i, j) = "'" + dt.Rows(i).Item(j).ToString()
                    Else
                        DataArray(i, j) = dt.Rows(i).Item(j)
                    End If
                End If
            Next
        Next
        wbook = myExcel.Application.Workbooks.Add(True)
        myExcel.Visible = True
        wSheet = myExcel.Application.Worksheets(1)
        wSheet.Name = filename
        wSheet.Activate()


        For j = 0 To cols - 1
            myExcel.Cells(1, j + 1) = "'" + dt.Columns(j).Caption
        Next

        If DataArray IsNot Nothing Then
            wSheet.Range("A2").Resize(rows, cols).Value = DataArray
        End If

        Try
            myExcel.DefaultSaveFormat = Excel.XlFileFormat.xlWorkbookDefault
            ''myExcel.DisplayAlerts = False
            If filename = "" Then
                myExcel.DefaultSaveFormat = Excel.XlFileFormat.xlWorkbookDefault

            Else
                Dim dialogsave As New SaveFileDialog
                dialogsave.FileName = filename
                dialogsave.Filter = "Excel 2007|*.xlsx"
                If dialogsave.ShowDialog = DialogResult.OK Then
                    wbook.SaveAs(dialogsave.FileName, Type.Missing, Type.Missing, Type.Missing,
                                    Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlShared, Type.Missing,
                                    Type.Missing, Type.Missing, Type.Missing, Type.Missing)
                End If
            End If

            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
        Catch ex As Exception
        End Try


    End Sub

    Shared Sub ExportEXCEL(ByVal table() As DataTable, ByVal fileName As String)
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

        Dim myExcel As Excel.Application = New Excel.Application
        Dim wbook As Excel.Workbook
        Dim wSheet As Excel.Worksheet
        wbook = myExcel.Application.Workbooks.Add(True)
        myExcel.Visible = True


        For Each dt As DataTable In table
            If dt Is Nothing Then Continue For
            If dt.Rows.Count = 0 Then Continue For

            wbook.Sheets.Add(Type.Missing, myExcel.Application.Worksheets(myExcel.Application.Worksheets.Count), 1, Excel.XlSheetType.xlWorksheet)
            wSheet = myExcel.Application.Worksheets(myExcel.Application.Worksheets.Count - 1)
            wSheet.Activate()
            Dim i, j As Integer
            Dim rows As Integer = dt.Rows.Count
            Dim cols As Integer = dt.Columns.Count
            Dim DataArray(rows - 1, cols - 1) As Object

            For i = 0 To rows - 1
                For j = 0 To cols - 1
                    If dt.Rows(i).Item(j) Is System.DBNull.Value Then Continue For
                    If String.IsNullOrEmpty(dt.Rows(i).Item(j).ToString) Then
                    Else
                        If dt.Rows(i).Item(j).GetType().Name = "String" Then
                            DataArray(i, j) = "'" + dt.Rows(i).Item(j).ToString()
                        Else
                            DataArray(i, j) = dt.Rows(i).Item(j)
                        End If
                    End If
                Next
            Next


            For j = 0 To cols - 1
                wSheet.Cells(1, j + 1) = "'" + dt.Columns(j).Caption
            Next

            If DataArray IsNot Nothing Then
                wSheet.Range("A2").Resize(rows, cols).Value = DataArray
            End If

        Next
        Try
            myExcel.DefaultSaveFormat = Excel.XlFileFormat.xlWorkbookDefault

            If fileName = "" Then
                myExcel.DefaultSaveFormat = Excel.XlFileFormat.xlWorkbookDefault

            Else
                Dim dialogsave As New SaveFileDialog
                dialogsave.FileName = fileName
                dialogsave.Filter = "Excel 2007|*.xlsx"
                If dialogsave.ShowDialog = DialogResult.OK Then
                    wbook.SaveAs(dialogsave.FileName, Type.Missing, Type.Missing, Type.Missing,
                                    Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlShared, Type.Missing,
                                    Type.Missing, Type.Missing, Type.Missing, Type.Missing)
                End If
            End If

            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
        Catch ex As Exception
        End Try
    End Sub

    Shared Function ImportEXCEL(ByVal isHeader As Boolean) As System.Data.DataTable
        Try
            Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

            Dim connectionString As String = ""
            Dim table As New DataTable
            Dim header As String = "No"
            If isHeader Then header = "Yes"

            Dim openFile As New OpenFileDialog()
            openFile.Filter = "All file(*.*)|*.*|Excel 2003(*.xls)|*.xls|Excel 2007(*.xlsx)|*.xlsx"
            If openFile.ShowDialog() = DialogResult.OK Then
                Dim file As String = openFile.FileName
                If file.Contains(".xlsx") Then
                    'read a 2007 file  
                    connectionString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                        file + ";Extended Properties='Excel 12.0 Xml;HDR={0};IMEX=1' ;", header)
                Else
                    'read a 97-2003 file  
                    connectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                        file + ";Extended Properties='Excel 8.0;HDR={0};IMEX=1';", header)
                End If
                Dim connection = New System.Data.OleDb.OleDbConnection(connectionString)
                connection.Open()
                Dim dt As DataTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
                If dt IsNot Nothing Then
                    Dim command = New System.Data.OleDb.OleDbDataAdapter(String.Format("select * from [{0}] ", dt.Rows(0).Item("TABLE_NAME")), connection)

                    command.TableMappings.Add("Table", "Table")

                    command.Fill(table)
                    command.Dispose()
                    dt.Dispose()
                End If

                connection.Close()

            End If

            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
            Return table

        Catch ex As Exception
            Return New DataTable
        End Try
    End Function

    Shared Function ImportEXCEL(ByVal SheetName As String) As System.Data.DataTable
        Try
            Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

            Dim connectionString As String = ""
            Dim table As New DataTable
            Dim header As String = "No"
            Dim isHeader As Boolean = True
            If isHeader Then header = "Yes"

            Dim openFile As New OpenFileDialog()
            openFile.Filter = "All file(*.*)|*.*|Excel 2003(*.xls)|*.xls|Excel 2007(*.xlsx)|*.xlsx"
            If openFile.ShowDialog() = DialogResult.OK Then
                Dim file As String = openFile.FileName
                If file.Contains(".xlsx") Then
                    'read a 2007 file  
                    connectionString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                        file + ";Extended Properties='Excel 12.0 Xml;HDR={0};IMEX=1' ;", header)
                Else
                    'read a 97-2003 file  
                    connectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                        file + ";Extended Properties='Excel 8.0;HDR={0};IMEX=1';", header)
                End If
                Dim connection = New System.Data.OleDb.OleDbConnection(connectionString)
                connection.Open()
                Dim dt As DataTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
                If dt IsNot Nothing Then
                    Dim command = New System.Data.OleDb.OleDbDataAdapter(String.Format("select * from [{0}$] ", SheetName), connection)

                    command.TableMappings.Add("Table", "Table")

                    command.Fill(table)
                    command.Dispose()
                    dt.Dispose()
                End If

                connection.Close()

            End If

            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
            Return table

        Catch ex As Exception
            Return New DataTable
        End Try
    End Function

    Shared Function ImportEXCEL(ByVal sheetname As String, ByVal fileName As String) As System.Data.DataTable
        Try
            Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

            Dim connectionString As String = ""
            Dim table As New DataTable
            Dim header As String = "Yes"

            If Not System.IO.File.Exists(fileName) Or sheetname = "" Then Return New DataTable

            Dim file As String = fileName
            If file.Contains(".xlsx") Then
                'read a 2007 file  
                connectionString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                    file + ";Extended Properties='Excel 12.0 Xml;HDR={0};IMEX=1' ;", header)
            Else
                'read a 97-2003 file  
                connectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                    file + ";Extended Properties='Excel 8.0;HDR={0};IMEX=1';", header)
            End If
            Dim connection = New System.Data.OleDb.OleDbConnection(connectionString)
            connection.Open()
            Dim dt As DataTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)

            If dt IsNot Nothing Then
                Dim command = New System.Data.OleDb.OleDbDataAdapter(String.Format("select * from [{0}$] ", sheetname), connection)

                command.TableMappings.Add("Table", "Table")

                command.Fill(table)
                command.Dispose()
                dt.Dispose()
            End If

            connection.Close()
            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI

            Return table

        Catch ex As Exception
            Return New DataTable
        End Try
    End Function

    Shared Function ImportEXCEL(ByVal isHeader As Boolean, ByRef fileName As String) As System.Data.DataTable
        Try
            Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

            Dim connectionString As String = ""
            Dim table As New DataTable
            Dim header As String = "No"
            If isHeader Then header = "Yes"

            ' If Not System.IO.File.Exists(fileName) Then Return New DataTable

            Dim openFile As New OpenFileDialog()
            openFile.Filter = "All file(*.*)|*.*|Excel 2003(*.xls)|*.xls|Excel 2007(*.xlsx)|*.xlsx"
            If openFile.ShowDialog() = DialogResult.OK Then
                fileName = openFile.FileName
                If fileName.Contains(".xlsx") Then
                    'read a 2007 file  
                    connectionString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                        fileName + ";Extended Properties='Excel 12.0 Xml;HDR={0};IMEX=1' ;", header)
                Else
                    'read a 97-2003 file  
                    connectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                        fileName + ";Extended Properties='Excel 8.0;HDR={0};IMEX=1';", header)
                End If
                Dim connection = New System.Data.OleDb.OleDbConnection(connectionString)
                connection.Open()
                Dim dt As DataTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)

                If dt IsNot Nothing Then
                    Dim command = New System.Data.OleDb.OleDbDataAdapter(String.Format("select * from [{0}] ", dt.Rows(0).Item("TABLE_NAME")), connection)

                    command.TableMappings.Add("Table", "Table")

                    command.Fill(table)
                    command.Dispose()
                    dt.Dispose()
                End If

                connection.Close()
            End If
            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
            Return table

        Catch ex As Exception
            Return New DataTable
        End Try
    End Function
    ''' <summary>
    ''' Son IT
    ''' </summary>
    ''' <param name="arrSheetName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function ImportEXCEL(ByVal arrSheetName() As String) As System.Data.DataSet
        Try
            Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

            Dim connectionString As String = ""
            Dim dataset As New DataSet
            Dim header As String = "No"
            Dim isHeader As Boolean = True
            If isHeader Then header = "Yes"

            Dim openFile As New OpenFileDialog()
            openFile.Filter = "All file(*.*)|*.*|Excel 2003(*.xls)|*.xls|Excel 2007(*.xlsx)|*.xlsx"
            If openFile.ShowDialog() = DialogResult.OK Then
                Dim file As String = openFile.FileName
                If file.Contains(".xlsx") Then
                    'read a 2007 file  
                    connectionString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                        file + ";Extended Properties='Excel 12.0 Xml;HDR={0};IMEX=1' ;", header)
                Else
                    'read a 97-2003 file  
                    connectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                        file + ";Extended Properties='Excel 8.0;HDR={0};IMEX=1';", header)
                End If

                Dim connection = New System.Data.OleDb.OleDbConnection(connectionString)
                connection.Open()

                Dim dt As DataTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)

                If dt IsNot Nothing Then
                    For Each sheet As String In arrSheetName
                        Try
                            Dim command = New System.Data.OleDb.OleDbDataAdapter(String.Format("select * from [{0}$] ", sheet), connection)
                            command.TableMappings.Add("Table", "Table")
                            command.Fill(dataset, sheet)
                            command.Dispose()
                        Catch ex As Exception
                        End Try
                    Next
                    dt.Dispose()
                End If

                connection.Close()
                System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
            End If
            Return dataset

        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Import , Export file txt, csv "

    Shared Function ImportCSV(ByVal isHeader As Boolean) As DataTable
        Dim openfile As New OpenFileDialog()
        openfile.Filter = "All file(*.*)|*.*|CSV file(*.csv)|*.csv|Text file(*.txt)|*.txt "
        If openfile.ShowDialog() = DialogResult.OK Then
            Try
                Dim fileTemp As String = "C:\\temp" + DateTime.Now.ToString("ddMMyyyy") + ".txt"
                Dim writer As StreamWriter = File.CreateText(fileTemp)
                writer.Close()
                File.Copy(openfile.FileName, fileTemp, True)
                If Not isHeader Then
                    WriteLineFirst(fileTemp, "")
                End If
                Dim connect As String = "Driver={Microsoft Text Driver (*.txt; *.csv)};Dbq=C:\\;Extensions=asc,csv,tab,txt;"
                Dim cons As OdbcConnection = New OdbcConnection(connect)
                cons.Open()
                Dim dapter As OdbcDataAdapter = New OdbcDataAdapter(String.Format("select * from {0} ",
                                                                                 Path.GetFileName(fileTemp)), cons)
                Dim tb As DataTable = New DataTable()
                dapter.Fill(tb)
                File.Delete(fileTemp)
                Return tb
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error csv")
            End Try
        End If
        Return New DataTable()
    End Function
    Shared Function ExportCSV(ByVal table As DataTable, ByVal isHeader As Boolean)
        Dim openfile As New SaveFileDialog()
        openfile.Filter = "All file(*.*)|*.*|CSV file(*.csv)|*.csv|Text file(*.txt)|*.txt "
        Dim writer As StreamWriter = Nothing
        If openfile.ShowDialog() = DialogResult.OK Then
            Try
                Dim line As String = ""
                writer = File.CreateText(openfile.FileName)
                If isHeader Then
                    For Each column As DataColumn In table.Columns
                        line += column.ColumnName + vbTab + ","
                    Next
                    line = line.Substring(0, line.Length - 1)
                    writer.WriteLine(line)
                End If
                For Each row As DataRow In table.Rows
                    line = ""
                    For colum As Integer = 0 To table.Columns.Count - 1
                        If IsNumeric(row.Item(colum)) Then
                            line += row.Item(colum).ToString() + vbTab + ","
                        Else
                            line += """" + row.Item(colum).ToString() + """" + vbTab + ","
                        End If
                    Next
                    line = line.Substring(0, line.Length - 1)
                    writer.WriteLine(line)
                Next
                writer.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error csv")
                If writer IsNot Nothing Then writer.Close()
            End Try
        End If
        Return New DataTable()
    End Function
    Shared Function ExportCSV(ByVal grid As DataGridView, ByVal isHeader As Boolean)
        Dim openfile As New SaveFileDialog()
        openfile.Filter = "All file(*.*)|*.*|CSV file(*.csv)|*.csv|Text file(*.txt)|*.txt "
        Dim writer As StreamWriter = Nothing
        If openfile.ShowDialog() = DialogResult.OK Then
            Try
                Dim line As String = ""
                writer = File.CreateText(openfile.FileName)
                If isHeader Then
                    For Each column As DataGridViewColumn In grid.Columns
                        line += column.HeaderText + vbTab + ","
                    Next
                    line = line.Substring(0, line.Length - 1)
                    writer.WriteLine(line)
                End If
                For Each row As DataGridViewRow In grid.Rows
                    If Not row.IsNewRow Then
                        line = ""
                        For colum As Integer = 0 To grid.Columns.Count - 1
                            If IsNumeric(row.Cells(colum).Value) Then
                                line += row.Cells(colum).Value.ToString() + vbTab + ","
                            Else
                                line += """" + row.Cells(colum).Value.ToString() + """" + vbTab + ","
                            End If
                        Next
                        line = line.Substring(0, line.Length - 1)
                        writer.WriteLine(line)
                    End If
                Next
                writer.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error csv")
                If writer IsNot Nothing Then writer.Close()
            End Try
        End If
        Return New DataTable()
    End Function

    Public Shared Sub WriteLineFirst(filename As String, line As String)

        Dim tempfile As String = Path.GetTempFileName()
        Dim writer As StreamWriter = New StreamWriter(tempfile)
        Dim reader As StreamReader = New StreamReader(filename)
        writer.WriteLine(line)
        While (Not reader.EndOfStream)
            writer.WriteLine(reader.ReadLine())
        End While
        writer.Close()
        reader.Close()
        File.Copy(tempfile, filename, True)
    End Sub
    Public Shared Sub WriteLineEnd(filename As String, line As String)
        Dim writer As StreamWriter = New StreamWriter(filename, True)
        writer.WriteLine(line)
        writer.Close()
    End Sub

#End Region

#Region "Date and Time "
    Shared Function GetThisMonth(ByVal today As DateTime) As String
        If today.Day <= 20 Then
            Return today.ToString("MMyyyy")
        Else
            Return today.AddMonths(1).ToString("MMyyyy")
        End If
    End Function
    Shared Function FirstDayOfMonth(ByVal today As DateTime) As DateTime
        Dim NextMonth As DateTime = today.AddMonths(1)
        Dim PreviouMonth As DateTime = today.AddMonths(-1)
        If today.Day <= 20 Then
            Return New DateTime(PreviouMonth.Year, PreviouMonth.Month, 21)
        Else
            Return New DateTime(today.Year, today.Month, 21)
        End If
    End Function
    Shared Function LastDayOfMonth(ByVal today As DateTime) As DateTime
        Dim NextMonth As DateTime = today.AddMonths(1)
        Dim PreviouMonth As DateTime = today.AddMonths(-1)
        If today.Day <= 20 Then
            Return New DateTime(today.Year, today.Month, 20)
        Else
            Return New DateTime(NextMonth.Year, NextMonth.Month, 20)
        End If
    End Function
    Shared Function FirstDayOfWeek(ByVal today As DateTime) As DateTime
        While (today.DayOfWeek <> DayOfWeek.Monday)
            today = today.AddDays(-1)
        End While
        Return New DateTime(today.Year, today.Month, today.Day)
    End Function
    Shared Function LastDayOfWeek(ByVal today As DateTime) As DateTime
        While (today.DayOfWeek <> DayOfWeek.Sunday)
            today = today.AddDays(+1)
        End While
        Return New DateTime(today.Year, today.Month, today.Day)
    End Function

    Shared Function GetWeekNumberOfYear(ByVal value As DateTime) As Integer
        Return CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(value, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)
    End Function

    Shared Function GetEndDayOfMonth(ByVal datetime As DateTime) As DateTime
        Select Case datetime.Month
            Case 1, 3, 5, 7, 8, 10, 12
                Return New DateTime(datetime.Year, datetime.Month, 31, 23, 59, 59)
            Case 2
                If datetime.Year Mod 4 = 0 Then
                    Return New DateTime(datetime.Year, datetime.Month, 29, 23, 59, 59)
                Else
                    Return New DateTime(datetime.Year, datetime.Month, 28, 23, 59, 59)
                End If
            Case 2, 4, 6, 9, 11
                Return New DateTime(datetime.Year, datetime.Month, 30, 23, 59, 59)
        End Select

        Return datetime
    End Function

    Shared Function GetStartDayOfMonth(ByVal datetime As DateTime) As DateTime
        Return New DateTime(datetime.Year, datetime.Month, 1, 0, 0, 0)
    End Function
    ''' <summary>
    ''' Return datetime with time is 0,0,0
    ''' </summary>
    ''' <param name="dateValue"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    Shared Function GetStartDate(ByVal dateValue As DateTime) As DateTime
        Return New DateTime(dateValue.Year, dateValue.Month, dateValue.Day, 0, 0, 0)
    End Function
    ''' <summary>
    ''' Return datetime with time is 0,0,0
    ''' </summary>
    ''' <param name="PickerValue"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function GetStartDate(ByVal PickerValue As DateTimePicker) As DateTime
        Return New DateTime(PickerValue.Value.Year, PickerValue.Value.Month, PickerValue.Value.Day, 0, 0, 0)
    End Function
    ''' <summary>
    ''' Return datetime with time is 23,59,59
    ''' </summary>
    ''' <param name="dateValue"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function GetEndDate(ByVal dateValue As DateTime) As DateTime
        Return New DateTime(dateValue.Year, dateValue.Month, dateValue.Day, 23, 59, 59)
    End Function
    ''' <summary>
    '''Return datetime with time is 23,59,59 
    ''' </summary>
    ''' <param name="PickerValue"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function GetEndDate(ByVal PickerValue As DateTimePicker) As DateTime
        Return New DateTime(PickerValue.Value.Year, PickerValue.Value.Month, PickerValue.Value.Day, 23, 59, 59)
    End Function
    ''' <summary>
    ''' Return datetime with time of value
    ''' </summary>
    ''' <param name="dateValue"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function GetDateTime(ByVal dateValue As DateTime) As DateTime
        Return New DateTime(dateValue.Year, dateValue.Month, dateValue.Day, dateValue.Hour, dateValue.Minute, dateValue.Second)
    End Function
    ''' <summary>
    ''' Return datetime with time of pickerdatetime
    ''' </summary>
    ''' <param name="PickerValue"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function GetDateTime(ByVal PickerValue As DateTimePicker) As DateTime
        Return New DateTime(PickerValue.Value.Year, PickerValue.Value.Month, PickerValue.Value.Day, PickerValue.Value.Hour, PickerValue.Value.Minute, PickerValue.Value.Second)
    End Function
    ''' <summary>
    ''' Return datetime with time of para(Hour),0,0
    ''' </summary>
    ''' <param name="dateValue"></param>
    ''' <param name="hour"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function GetDateTime(ByVal dateValue As DateTime, ByVal hour As Integer) As DateTime
        Return New DateTime(dateValue.Year, dateValue.Month, dateValue.Day, hour, 0, 0)
    End Function
    Shared Function GetDateTime(ByVal dateValue As DateTime, ByVal hour As Integer, ByVal minute As Integer, ByVal second As Integer) As DateTime
        Return New DateTime(dateValue.Year, dateValue.Month, dateValue.Day, hour, minute, second)
    End Function
    Shared Function GetDatetime(ByVal strDate As String, ByVal format As enumDateFormat) As DateTime

        If format = enumDateFormat.ddmmyyyy Then
            Return New DateTime(Microsoft.VisualBasic.Right(strDate, 4), Microsoft.VisualBasic.Mid(strDate, 4, 2), Microsoft.VisualBasic.Left(strDate, 2))
        End If
        If format = enumDateFormat.mmddyyyy Then
            Return New DateTime(Microsoft.VisualBasic.Right(strDate, 4), Microsoft.VisualBasic.Left(strDate, 2), Microsoft.VisualBasic.Mid(strDate, 4, 2))
        End If

        Return DateTime.Now
    End Function
    ''' <summary>
    ''' Return datetime with time of para(Hour),0,0
    ''' </summary>
    ''' <param name="PickerValue"></param>
    ''' <param name="hour"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function GetDateTime(ByVal PickerValue As DateTimePicker, ByVal hour As Integer) As DateTime
        Return New DateTime(PickerValue.Value.Year, PickerValue.Value.Month, PickerValue.Value.Day, hour, 0, 0)
    End Function
    ''' <summary>
    ''' Return JAN,FER,MAR,APR,MAY,JUN,JUL,AUG,SEP,OCT,NOV,DEC
    ''' </summary>
    ''' <param name="month"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function GetNameOfMonth(ByVal month As Integer) As String
        If month <= 0 Or month > 12 Then
            Return ""
        End If

        Dim dateOfMonth As DateTime = New DateTime(DateTime.Now.Year, month, 1)
        Return UCase(dateOfMonth.ToString("MMM"))
    End Function
    ''' <summary>
    '''  Return value Q12012 
    ''' </summary>
    ''' <param name="datetime"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function GetQuater(ByVal datetime As DateTime) As String
        Dim quater As String = ""
        Dim year As String = datetime.Year
        Dim month As Integer = datetime.Month
        If month <= 3 Then
            quater = "Q1" & year
        End If
        If month >= 4 And month <= 6 Then
            quater = "Q2" & year
        End If
        If month >= 7 And month <= 9 Then
            quater = "Q3" & year
        End If
        If month >= 10 Then
            quater = "Q4" & year
        End If
        Return quater

    End Function
    ''' <summary>
    ''' Return value Q12012
    ''' </summary>
    ''' <param name="datetime"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function GetQuaterByFinancial(ByVal datetime As DateTime) As String
        Dim quater As String = ""

        Dim year As String = datetime.Year
        Dim month As Integer = datetime.Month
        If month <= 3 Then
            quater = "Q4" & (year - 1)
        End If
        If month >= 4 And month <= 6 Then
            quater = "Q1" & year
        End If
        If month >= 7 And month <= 9 Then
            quater = "Q2" & year
        End If
        If month >= 10 Then
            quater = "Q3" & year
        End If
        Return quater

    End Function
    ''' <summary>
    ''' Return 2014Q1 (month 04-->09) or 2014Q3 (month 10-->03)
    ''' </summary>
    ''' <param name="datetime"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function GetQuaterByFinancialBOM(ByVal datetime As DateTime) As String
        Dim quater As String = ""

        Dim year As String = datetime.Year
        Dim month As Integer = datetime.Month
        If month <= 3 Then
            quater = (year - 1) & "Q3"
        End If
        If month >= 4 And month <= 6 Then
            quater = year & "Q1"
        End If
        If month >= 7 And month <= 9 Then
            quater = year & "Q1"
        End If
        If month >= 10 Then
            quater = year & "Q3"
        End If
        Return quater

    End Function
    ''' <summary>
    ''' Return value 2012Q3
    ''' </summary>
    ''' <param name="datetime"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function GetQuater2(ByVal datetime As DateTime) As String
        Dim quater As String = ""
        Dim year As String = datetime.Year
        Dim month As Integer = datetime.Month
        If month <= 3 Then
            quater = year & "Q1"
        End If
        If month >= 4 And month <= 6 Then
            quater = year & "Q2"
        End If
        If month >= 7 And month <= 9 Then
            quater = year & "Q3"
        End If
        If month >= 10 Then
            quater = year & "Q4"
        End If
        Return quater

    End Function
    Shared Function GetMonthOfQuater(ByVal datetime As DateTime) As String
        Dim quater As String = ""
        Dim year As String = datetime.Year
        Dim month As Integer = datetime.Month
        If month <= 3 Then
            quater = year + "03"
        End If
        If month >= 4 And month <= 6 Then
            quater = year + "06"
        End If
        If month >= 7 And month <= 9 Then
            quater = year + "09"
        End If
        If month >= 10 Then
            quater = year + "12"
        End If
        Return quater
    End Function


#End Region

#Region "Validate"
    Shared Function IsNumber(ByVal textbox As TextBox) As Boolean
        If Not IsNumeric(textbox.Text) Then
            textbox.Text = ""
            textbox.Focus()
            Return False
        End If

        Return True
    End Function
#End Region

#Region "Format Grid"
    ''' <summary>
    ''' Set index first column of datagridview
    ''' </summary>
    ''' <param name="grid"></param>
    ''' <remarks></remarks>
    Shared Sub SetIndexGrid(ByVal grid As DataGridView)
        For index As Integer = 0 To grid.RowCount - 1
            grid.Item(0, index).Value = index + 1
        Next
    End Sub
    ''' <summary>
    ''' Up currentrow of datagridview
    ''' </summary>
    ''' <param name="grid"></param>
    ''' <remarks></remarks>
    Shared Sub GridViewUpRow(ByVal grid As DataGridView)
        If grid.CurrentRow IsNot Nothing Then
            Dim gridTemp As DataGridView = grid

            Dim totalRows As Integer = gridTemp.Rows.Count
            Dim idx As Integer = gridTemp.SelectedRows(0).Index
            If idx = 0 Then
                Return
            End If
            '   dim col As Integer = grid.SelectedCells[0].OwningColumn.Index;
            Dim rows As DataGridViewRowCollection = gridTemp.Rows
            Dim row As DataGridViewRow = rows(idx)
            rows.Remove(row)
            rows.Insert(idx - 1, row)
            gridTemp.ClearSelection()
            gridTemp.Rows(idx - 1).Selected = True

        End If
    End Sub
    ''' <summary>
    ''' Dow currentrow of datagridview
    ''' </summary>
    ''' <param name="grid"></param>
    ''' <remarks></remarks>
    Shared Sub GridViewDown(ByVal grid As DataGridView)
        If grid.CurrentRow IsNot Nothing Then
            Dim gridTemp As DataGridView = grid

            Dim totalRows As Integer = gridTemp.Rows.Count
            Dim idx As Integer = gridTemp.SelectedRows(0).Index
            If idx = gridTemp.RowCount - 1 Then
                Return
            End If
            '   dim col As Integer = grid.SelectedCells[0].OwningColumn.Index;
            Dim rows As DataGridViewRowCollection = gridTemp.Rows
            Dim row As DataGridViewRow = rows(idx)
            rows.Remove(row)
            rows.Insert(idx + 1, row)
            gridTemp.ClearSelection()
            ' grid.Rows[idx - 1].Cells[col].Selected = true;
            gridTemp.Rows(idx + 1).Selected = True
            gridTemp.CurrentCell = gridTemp.CurrentRow.Cells(0)
        End If

    End Sub

#End Region

#Region "Set Object to other, List <-->Datatable "
    Public Shared Sub SetObjectToOther(Of T1, T2)(ByRef objOld As T1, ByRef objNew As T2)
        Dim typeOld As Type
        Dim typeNew As Type
        typeOld = objOld.GetType()
        typeNew = objNew.GetType
        Dim fieldsOld() As FieldInfo = typeOld.GetFields()
        Dim fieldsNew() As FieldInfo = typeNew.GetFields()
        For Each fOld As FieldInfo In fieldsOld
            For Each fNew As FieldInfo In fieldsNew
                If fOld.Name = fNew.Name Then
                    fNew.SetValue(objNew, fOld.GetValue(objOld))
                    Exit For
                End If
            Next
        Next

    End Sub
    ''' <summary>
    ''' Vo Thanh Son 12-Nov-2012
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="obj"></param>
    ''' <param name="row"></param>
    ''' <remarks></remarks>
    Public Shared Sub SetObjValue(Of T)(ByRef obj As T, ByVal row As DataRow)
        Try
            obj = Activator.CreateInstance(Of T)()
            If row Is Nothing Then Exit Sub
            Dim type As Type
            type = obj.GetType()
            Dim fields() As FieldInfo = type.GetFields()
            For index As Integer = 0 To fields.Length - 1
                Try
                    Dim value As Object = row(fields(index).Name.Replace(PublicConst.Key, ""))
                    If value IsNot DBNull.Value Then
                        fields(index).SetValue(obj, value)
                    Else
                        fields(index).SetValue(obj, Nothing)
                    End If
                Catch ex As Exception
                End Try
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Function ConvertTo(Of T)(ByVal list As IList(Of T)) As DataTable
        Dim table As DataTable = CreateTable(Of T)()
        Dim entityType As Type = GetType(T)
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(entityType)
        For Each item As T In list
            Dim row As DataRow = table.NewRow()
            For Each prop As PropertyDescriptor In properties
                row(prop.Name) = prop.GetValue(item)
            Next
            table.Rows.Add(row)
        Next
        Return table
    End Function

    Public Shared Function ConvertTo(Of T)(ByVal rows As IList(Of DataRow)) As IList(Of T)
        Dim list As IList(Of T) = Nothing
        If rows IsNot Nothing Then
            list = New List(Of T)
            For Each row As DataRow In rows
                Dim item As T = CreateItem(Of T)(row)
                list.Add(item)
            Next
        End If
        Return list
    End Function

    Public Shared Function ConvertTo(Of T)(ByVal table As DataTable) As IList(Of T)
        If table Is Nothing Then Return Nothing
        Dim rows As List(Of DataRow) = New List(Of DataRow)()
        For Each row As DataRow In table.Rows
            rows.Add(row)
        Next
        Return ConvertTo(Of T)(rows)
    End Function

    Public Shared Function CreateItem(Of T)(ByVal row As DataRow) As T
        Dim obj As T
        If row IsNot Nothing Then
            obj = Activator.CreateInstance(Of T)()
            For Each column As DataColumn In row.Table.Columns
                Dim prop As PropertyInfo = obj.GetType().GetProperty(column.ColumnName)
                Try
                    Dim value As Object = row(column.ColumnName)
                    prop.SetValue(obj, value, Nothing)
                Catch
                    ' You can log something here
                    Throw
                End Try
            Next
        End If
        Return obj
    End Function

    Public Shared Function CreateTable(Of T)() As DataTable
        Dim entityType As Type = GetType(T)
        Dim table As New DataTable(entityType.Name)
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(entityType)
        For Each prop As PropertyDescriptor In properties
            table.Columns.Add(prop.Name, prop.PropertyType)
        Next
        Return table
    End Function

#End Region

#Region "HOST"
    ''' <summary>
    ''' Get IP current of computer
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function GetIP() As String
        Dim strHostName As String = ""
        strHostName = System.Net.Dns.GetHostName()
        Dim ipEntry As IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)
        Dim addr() As IPAddress = ipEntry.AddressList
        Return addr(addr.Length - 1).ToString()
    End Function
    ''' <summary>
    ''' Get computername of this computer
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function GetHostName() As String
        Return Environ("COMPUTERNAME")
    End Function
    ''' <summary>
    ''' Get username current login this computer
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function GetUserName() As String
        Return Environ("USERNAME")
    End Function
#End Region

#Region "Para Sql, Odbc, Oledb, Oracel,..."
    ''' <summary>
    ''' Return with para name @StartDate,@EndDate
    ''' </summary>
    ''' <param name="startDate"></param>
    ''' <param name="endDate"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function GetSqlPara(ByVal startDate As DateTime, ByVal endDate As DateTime) As SqlClient.SqlParameter()
        Dim para(1) As SqlClient.SqlParameter
        para(0) = New SqlClient.SqlParameter("@StartDate", startDate)
        para(1) = New SqlClient.SqlParameter("@EndDate", endDate)
        Return para
    End Function
    ''' <summary>
    ''' Return with para name @StartDate,@EndDate
    ''' </summary>
    ''' <param name="startDate"></param>
    ''' <param name="endDate"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function GetOdbcPara(ByVal startDate As DateTime, ByVal endDate As DateTime) As OdbcParameter()
        Dim para(1) As OdbcParameter
        para(0) = New OdbcParameter("@StartDate", startDate)
        para(1) = New OdbcParameter("@EndDate", endDate)
        Return para
    End Function
    ''' <summary>
    ''' Return with para name @StartDate,@EndDate
    ''' </summary>
    ''' <param name="startDate"></param>
    ''' <param name="endDate"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function GetOracelPara(ByVal startDate As DateTime, ByVal endDate As DateTime) As OracleClient.OracleParameter()
        Dim para(1) As OracleParameter
        para(0) = New OracleParameter("@StartDate", startDate)
        para(1) = New OracleParameter("@EndDate", endDate)
        Return para
    End Function
    ''' <summary>
    ''' Return with para name @StartDate,@EndDate
    ''' </summary>
    ''' <param name="startDate"></param>
    ''' <param name="endDate"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function GetOledbPara(ByVal startDate As DateTime, ByVal endDate As DateTime) As OleDbParameter()
        Dim para(1) As OleDbParameter
        para(0) = New OleDbParameter("@StartDate", startDate)
        para(1) = New OleDbParameter("@EndDate", endDate)
        Return para
    End Function

#End Region

#Region "AS400"


#End Region

#Region "Math..."
    Public Shared Function RoundDown(ByVal number As Double, ByVal decimalPlaces As Integer) As Double
        Return Math.Floor(number * Math.Pow(10, decimalPlaces)) / Math.Pow(10, decimalPlaces)
    End Function

    Public Shared Function RoundUp(ByVal number As Double, ByVal decimalPlaces As Integer) As Double

        Return Math.Ceiling(number * Math.Pow(10, decimalPlaces)) / Math.Pow(10, decimalPlaces)
    End Function
#End Region

End Class

