Namespace Helper.Email.Output
    Public MustInherit Class Output

        Protected _toAddress As String
        Protected _subject As String
        Protected _body As String
        Protected _action As ActionEnum
        Protected _ccAddress As String
        Protected _sendAs As String
        Protected _bcAddress As String

        Public Sub New(action As ActionEnum)
            _action = action
        End Sub

        Public WriteOnly Property ToAddress As String
            Set(value As String)
                _toAddress = value
            End Set
        End Property

        Public WriteOnly Property Subject As String
            Set(value As String)
                _subject = value
            End Set
        End Property

        Public WriteOnly Property Body As String
            Set(value As String)
                _body = value
            End Set
        End Property

        Public WriteOnly Property CcAddress As String
            Set(value As String)
                _ccAddress = value
            End Set
        End Property

        Public WriteOnly Property SendAs As String
            Set(value As String)
                _sendAs = value
            End Set
        End Property

        Public WriteOnly Property BcAddress As String
            Set(value As String)
                _bcAddress = value
            End Set
        End Property

        Public Overridable Sub Create()
            Console.WriteLine(String.Format("To Address : {0}", _toAddress))
            Console.WriteLine(String.Format("Cc Address : {0}", _ccAddress))
            Console.WriteLine(String.Format("Subject : {0}", _subject))
            Console.WriteLine(String.Format("Body : {0}", _body))
        End Sub

    End Class
End Namespace