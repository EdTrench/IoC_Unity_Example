Namespace View
    Public Interface ICentreNetworkEmailForm
        WriteOnly Property Networks As IEnumerable(Of Model.Network.NetworkEntity)
        Event CreateEmailClicked()
        ReadOnly Property Network() As Model.Network.NetworkEntity
    End Interface
End Namespace