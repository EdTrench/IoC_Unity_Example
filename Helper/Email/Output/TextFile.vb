Namespace Helper.Email.Output
    Public Class TextFile
        Inherits Output

        Public Overloads Overrides Sub Create()
            Console.WriteLine("*** Text File Created ***")
            MyBase.Create()
        End Sub

    End Class
End Namespace