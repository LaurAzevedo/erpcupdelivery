Module GeneralController

    Public CloseSplashScreen As Boolean = False
    Public AppDataFolder As String = "C:\ProgramData\"

    'DATA_VALIDA
    Public tmp_data As String
    Public DATA_FINAL_PESQUISA As String = "N"

    Public Sub OPEN_MOUSE()
        Dim cur As Cursor = Cursors.WaitCursor
        Cursor.Current = cur
    End Sub

    Public Sub CLOSE_MOUSE()
        Dim cur As Cursor = Cursors.Default
        Cursor.Current = cur
    End Sub

    Public Function CHECK_INTERNET_CONNECTION()
        Try
            My.Computer.Network.Ping("www.google.com", 10)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub WAIT_A_TIME()
        System.Threading.Thread.Sleep(0.001)
        Application.DoEvents()
    End Sub

End Module
