
Module Memory
    Public ClientHandle As Int32 = 0
    Public Const PROCESS_VM_READ = &H10
    Public Const PROCESS_VM_WRITE = (&H20)
    Public Const PROCESS_VM_OPERATION = (&H8)
    Public Const PROCESS_QUERY_INFORMATION = (&H400)
    Public Const PROCESS_READ_WRITE_QUERY = PROCESS_VM_READ + PROCESS_VM_WRITE + PROCESS_VM_OPERATION + PROCESS_QUERY_INFORMATION
    Public Const PROCESS_ALL_ACCESS = &H1F0FFF
    Public Declare Function GetWindowThreadProcessId Lib "user32" (ByVal hwnd As IntPtr, _
                          ByRef lpdwProcessId As Integer) As Integer
    Public Declare Function ReadProcessMemory Lib "kernel32" (ByVal hProcess As IntPtr, ByVal lpBaseAddress As Int32, ByRef lpBuffer As Int32, ByVal nSize As Int32, ByVal lpNumberOfBytesWritten As Int32) As Long
    Public Declare Function ReadProcessMemory Lib "kernel32" (ByVal hProcess As IntPtr, ByVal lpBaseAddress As Int32, ByRef lpBuffer As Byte(), ByVal nSize As Int32, ByVal lpNumberOfBytesWritten As Int32) As Long
    Public Declare Function WriteProcessMemory Lib "kernel32" (ByVal hProcess As IntPtr, ByVal lpBaseAddress As Int32, ByVal lpBuffer() As Byte, ByVal nSize As Int32, ByVal lpNumberOfBytesWritten As Int32) As Long
    Public Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    Public Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal parentHandle As IntPtr, _
                  ByVal childAfter As IntPtr, _
                  ByVal lclassName As String, _
                  ByVal windowTitle As String) As IntPtr
    Public Declare Function OpenProcess Lib "kernel32.dll" (ByVal dwDesiredAccess As UInteger, ByVal bInheritHandle As Integer, ByVal dwProcessId As UInteger) As IntPtr
    Public Declare Function CloseHandle Lib "kernel32.dll" (ByVal hHandle As IntPtr) As Boolean
    Public Function Tibia_Hwnd() As Int32
        If ClientHandle > 0 Then
            Dim i As Int32
            GetWindowThreadProcessId(ClientHandle, i)
            Return i
        Else
            Dim i As Int32
            GetWindowThreadProcessId(FindWindow("tibiaclient", vbNullString), i)
            Return i
        End If
    End Function

    Function ReadInt(ByVal address As Int32) As Int32
        Dim i As Int32 = Nothing
        ReadMemory(address, i, 4)
        Return i
    End Function
    Sub WriteInt(ByVal address As Int32, ByVal val As Int32)
        WriteMemory(address, val, 4)
    End Sub

    Public Function ReadString(ByVal Address As Long, ByVal CharCount As Int32, ByVal Hwnd As Int32) As String
        Dim ret As Byte() = Nothing
        Dim vBuffer As Long
        Dim processHandle As IntPtr = OpenProcess(PROCESS_VM_READ, 0, Hwnd)
        Dim tStr(CharCount) As Char
        Dim retStr As String = ""
        For i As Int32 = 0 To CharCount
            ReadProcessMemory(processHandle, Address + i, vBuffer, 1, 0)
            ret = BitConverter.GetBytes(vBuffer)
            tStr(i) = System.Text.Encoding.ASCII.GetString(ret) : retStr += tStr(i)
        Next
        Return retStr
        CloseHandle(processHandle)
    End Function

#Region "Memory reading/Writing"

    'Write Memory
    Public Sub WriteMemory(ByVal Address As Integer, ByVal Value As Integer, ByVal Size As Integer)
        Try
            Dim TibiaReadWrite As Integer
            Dim PID As Integer = Tibia_Hwnd()
            TibiaReadWrite = OpenProcess(PROCESS_READ_WRITE_QUERY, False, PID)

            Dim bytArray() As Byte
            bytArray = BitConverter.GetBytes(Value)
            WriteProcessMemory(TibiaReadWrite, Address, bytArray, Size, 0)

            CloseHandle(TibiaReadWrite)
        Catch Ex As Exception
            'ShowError(Ex)
        End Try
    End Sub
    Public Sub WriteMemory(ByVal Address As Integer, ByVal Value() As Byte)
        Try
            Dim TibiaReadWrite As Integer
            Dim PID As Integer = Tibia_Hwnd()
            TibiaReadWrite = OpenProcess(PROCESS_READ_WRITE_QUERY, False, PID)

            WriteProcessMemory(TibiaReadWrite, Address, Value, Value.Length, 0)

            CloseHandle(TibiaReadWrite)
        Catch Ex As Exception
            'ShowError(Ex)
        End Try
    End Sub
    Public Sub WriteMemory(ByVal Address As Integer, ByVal Value() As Byte, ByVal Offset As Integer, ByVal Length As Integer)
        Try
            Dim Count1 As Integer
            For Count1 = 0 To Length - 1
                WriteMemory(Address + Count1, Value(Count1 + Offset), 1)
            Next
        Catch Ex As Exception
            'ShowError(Ex)
        End Try
    End Sub
    Public Sub WriteMemory(ByVal Address As Integer, ByVal Value As String)
        Try
            Dim Length As Integer = Value.Length
            For I As Integer = 0 To Length - 1
                WriteMemory(Address + I, Asc(Value.Chars(I)), 1)
            Next
            WriteMemory(Address + Length, 0, 1)
        Catch Ex As Exception
            'ShowError(Ex)
        End Try
    End Sub
    Public Sub WriteMemory(ByVal Address As Integer, ByVal Value As Double)
        Try
            Dim Buffer(0 To 7) As Byte
            Buffer = BitConverter.GetBytes(Value)
            For I As Integer = 0 To 7
                WriteMemory(Address + I, CInt(Buffer(I)), 1)
            Next
        Catch Ex As Exception
            'ShowError(Ex)
        End Try
    End Sub
    'Read Memory
    Public Sub ReadMemory(ByVal Address As Integer, ByRef Value As Double)
        Try
            Dim Buffer(7) As Byte
            Dim Temp As Integer
            For I As Integer = 0 To 7
                ReadMemory(Address + I, Temp, 1)
                Buffer(I) = CByte(Temp)
            Next
            Value = BitConverter.ToDouble(Buffer, 0)
        Catch Ex As Exception
            'ShowError(Ex)
        End Try
    End Sub
    Public Sub ReadMemory(ByVal Address As Integer, ByRef Value As Integer, ByVal Size As Integer)
        Try
            Dim mValue As Integer

            Dim TibiaReadWrite As Integer
            Dim PID As Integer = Tibia_Hwnd()
            TibiaReadWrite = OpenProcess(PROCESS_READ_WRITE_QUERY, False, PID)

            ReadProcessMemory(TibiaReadWrite, Address, mValue, Size, 0)
            Value = mValue

            CloseHandle(TibiaReadWrite)
        Catch Ex As Exception
            'ShowError(Ex)
        End Try
    End Sub
    Public Sub ReadMemory(ByVal Address As Integer, ByRef Value() As Byte, ByVal Length As Integer)
        Try
            Dim bytArray() As Byte
            Dim Count1 As Integer
            Dim tempInteger As Integer
            ReDim bytArray(Length - 1)
            For Count1 = 0 To Length - 1
                ReadMemory(Address + Count1, tempInteger, 1)
                bytArray(Count1) = CByte(tempInteger)
            Next
            Value = bytArray
        Catch Ex As Exception
            'ShowError(Ex)
        End Try
    End Sub
    Public Sub ReadMemory(ByVal Address As Integer, ByRef Value As String)
        Try
            Dim intChar As Integer
            Dim Count1 As Integer
            Dim strTemp As String
            strTemp = String.Empty
            Count1 = 0
            Do
                ReadMemory(Address + Count1, intChar, 1)
                If intChar <> 0 Then strTemp = strTemp & Chr(intChar)
                Count1 += 1
            Loop Until intChar = 0
            Value = strTemp
        Catch Ex As Exception
            'ShowError(Ex)
        End Try
    End Sub
    Public Sub ReadMemory(ByVal Address As Integer, ByRef Value As String, ByVal Length As Integer)
        Try
            Dim intChar As Integer
            Dim Count1 As Integer
            Dim strTemp As String
            strTemp = String.Empty
            For Count1 = 0 To Length - 1
                ReadMemory(Address + Count1, intChar, 1)
                strTemp = strTemp & Chr(intChar)
            Next
            Value = strTemp
        Catch Ex As Exception
            'ShowError(Ex)
        End Try
    End Sub
#End Region
End Module
