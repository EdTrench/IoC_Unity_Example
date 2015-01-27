Namespace Model.Centre
    Public Class CentreNetworkEntity
        Inherits ModelEntity(Of CentreNetworkEntity)

        Public Overridable Property Centre As CentreEntity
        Public Overridable Property Network As Network.NetworkEntity
        Public Overridable Property RegistrationDate As Nullable(Of Date)

    End Class

End Namespace