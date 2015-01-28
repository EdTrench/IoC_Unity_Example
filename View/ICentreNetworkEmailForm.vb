Namespace View
    Public Interface ICentreNetworkEmailForm
        WriteOnly Property Networks As IEnumerable(Of Model.Network.NetworkEntity)
        ReadOnly Property Network() As Model.Network.NetworkEntity
        Event CreateEmailClicked()
        Sub SetDisplay(value As String)
    End Interface
End Namespace