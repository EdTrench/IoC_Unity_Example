Namespace Service.CentreNetwork.Email.ExternalModerator
    Public MustInherit Class ExternalModerator
        Inherits Email

        Sub New(resourceManager As Helper.Resources.IResourceManager,
                output As Helper.Email.Output.Output)
            MyBase.New(resourceManager, output)
        End Sub

        Protected MustOverride Function GetSubject() As String

        Public Overrides Function Create() As String
            _output.Body = String.Format(_resourceManager.GetString(Me.GetType().Name))
            _output.Subject = String.Format("Network - {0} - {1}", GetNetworkDescription, GetSubject())
            _output.ToAddress = "ToTest@test.com"
            _output.CcAddress = "CcTest@test.com"
            Return _output.Create()
        End Function

        Private Function GetNetworkDescription() As String
            Dim networkDescription = "{No Network Description}"
            If Not _centreNetwork.Network Is Nothing Then
                If Not String.IsNullOrEmpty(_centreNetwork.Network.Description) Then networkDescription = _centreNetwork.Network.Description
            End If
            Return networkDescription
        End Function

    End Class
End Namespace