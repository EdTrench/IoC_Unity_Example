Namespace Helper.Email.Output
    Public MustInherit Class Output

        Protected _toAddress As String
        Protected _subject As String
        Protected _body As String
        'Protected _action As ActionEnum
        Protected _ccAddress As String
        Protected _sendAs As String
        Protected _bcAddress As String

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

        Public Overridable Function Create() As String
            Return String.Format("{0}{1}{2}{3}",
                                 String.Format("To Address : {0} {1}", _toAddress, Environment.NewLine),
                                 String.Format("Cc Address : {0} {1}", _ccAddress, Environment.NewLine),
                                 String.Format("Subject : {0} {1}", _subject, Environment.NewLine),
                                 String.Format("Body : {0} {1}", _body, Environment.NewLine))
        End Function

    End Class
End Namespace