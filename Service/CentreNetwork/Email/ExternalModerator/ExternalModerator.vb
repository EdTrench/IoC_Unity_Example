Namespace Service.CentreNetwork.Email.ExternalModerator
    Public MustInherit Class ExternalModerator
        Inherits Email

        <Microsoft.Practices.Unity.InjectionConstructor()>
        Sub New(resourceManager As Helper.Resources.IResourceManager,
                output As Helper.Email.Output.Output)
            MyBase.New(resourceManager, output)
        End Sub

        Protected MustOverride Function GetSubject() As String

        Public Overrides Sub Create()

            Dim networkDescription = "{No Network Description}"
            If Not _centreNetwork.Network Is Nothing Then
                If Not String.IsNullOrEmpty(_centreNetwork.Network.Description) Then networkDescription = _centreNetwork.Network.Description
            End If

            Dim centreNumber = "{No Centre Number}"
            Dim centreName = "{No Centre Name}"
            If Not _centreNetwork.Centre Is Nothing Then
                If Not String.IsNullOrEmpty(_centreNetwork.Centre.Number) Then centreNumber = _centreNetwork.Centre.Number
                If Not String.IsNullOrEmpty(_centreNetwork.Centre.Name) Then centreName = _centreNetwork.Centre.Name
            End If
            _output.Body = String.Format(_resourceManager.GetString(Me.GetType().Name))
            _output.Subject = GetSubject()
            _output.Action = Helper.Email.Output.Output.ActionEnum.Show
            _output.ToAddress = "test@test.com"
            _output.Create()
        End Sub

    End Class
End Namespace