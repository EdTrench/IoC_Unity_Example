Namespace Helper.Email.Output
    Public Class TextFile
        Inherits Output

        Public Overloads Overrides Function Create() As String
            Return String.Format("{0}{1}{2}",
                                 "*** Text File Created ***",
                                 Environment.NewLine,
                                 MyBase.Create())
        End Function

    End Class
End Namespace