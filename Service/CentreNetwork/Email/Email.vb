Namespace Service.CentreNetwork.Email
    Public MustInherit Class Email

        Protected _resourceManager As Helper.Resources.IResourceManager
        Protected _output As Helper.Email.Output.Output
        Protected _centreNetwork As Model.Centre.CentreNetworkEntity

        Public WriteOnly Property CentreNetwork() As Model.Centre.CentreNetworkEntity
            Set(value As Model.Centre.CentreNetworkEntity)
                _centreNetwork = value
            End Set
        End Property

        Sub New(resourceManager As Helper.Resources.IResourceManager,
                output As Helper.Email.Output.Output)
            _resourceManager = resourceManager
            _output = output
        End Sub

        Public MustOverride Function Create() As String

    End Class
End Namespace
