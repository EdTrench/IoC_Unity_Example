Namespace View
    Public Class CentreNetworkEmailForm
        Inherits Windows.Forms.Form
        Implements ICentreNetworkEmailForm


        Private _presenter As Presenter.CentreNetworkEmail

        <Microsoft.Practices.Unity.Dependency()>
        Public Property Presenter As Presenter.CentreNetworkEmail
            Get
                Return _presenter
            End Get
            Set(value As Presenter.CentreNetworkEmail)
                _presenter = value
                _presenter.SetView(Me)
            End Set
        End Property

        Public Event CreateEmailClicked() Implements ICentreNetworkEmailForm.CreateEmailClicked

        Private Sub butCreateEmail_Click(sender As Object, e As EventArgs) Handles butCreateEmail.Click
            RaiseEvent CreateEmailClicked()
        End Sub

        Public WriteOnly Property Networks As IEnumerable(Of Model.Network.NetworkEntity) Implements ICentreNetworkEmailForm.Networks
            Set(value As IEnumerable(Of Model.Network.NetworkEntity))
                cboNetwork.Items.AddRange(value.OrderBy(Function(x) x.Description) _
                                   .Select(Function(x) x) _
                                   .ToArray())
                cboNetwork.DisplayMember = "Description"
            End Set
        End Property

        Public ReadOnly Property Network As Model.Network.NetworkEntity Implements ICentreNetworkEmailForm.Network
            Get
                Return cboNetwork.SelectedItem
            End Get
        End Property

        Public Sub SetDisplay(value As String) Implements ICentreNetworkEmailForm.SetDisplay
            _lblDisplay.Text = value
        End Sub
    End Class

End Namespace