Namespace Helper.Email.Output
    Public Class OutlookMessage
        Inherits Output

        Public Sub New(action As ActionEnum)
            MyBase.New(action)
        End Sub

        Public Overloads Overrides Sub Create()
            Console.WriteLine("*** Outlook Message Created ***")
            MyBase.Create()
        End Sub

    End Class
End Namespace