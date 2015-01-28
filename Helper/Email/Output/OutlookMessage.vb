Namespace Helper.Email.Output
    Public Class OutlookMessage
        Inherits Output

        Public Overloads Overrides Function Create() As String
            Return String.Format("{0}{1}{2}",
                                 "*** Outlook Message Created ***",
                                 Environment.NewLine,
                                 MyBase.Create())
        End Function

    End Class
End Namespace