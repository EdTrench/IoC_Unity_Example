Namespace Helper.Email.Output
    Public Class OutlookMessage
        Inherits Output

        Public Overloads Overrides Sub Create()
            Console.WriteLine("*** Outlook Message Created ***")
            MyBase.Create()
        End Sub

    End Class
End Namespace