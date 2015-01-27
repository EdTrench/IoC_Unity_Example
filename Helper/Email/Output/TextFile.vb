Namespace Helper.Email.Output
    Public Class TextFile
        Inherits Output

        Public Sub New(action As ActionEnum)
            MyBase.New(action)
        End Sub

        Public Overloads Overrides Sub Create()
            Console.WriteLine("*** Text File Created ***")
            MyBase.Create()
        End Sub

    End Class
End Namespace