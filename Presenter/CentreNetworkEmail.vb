Namespace Presenter
    Public Class CentreNetworkEmail

        Private _centreNetworkEmailView As View.ICentreNetworkEmailForm
        Private ReadOnly _externalModeratorEmail As Service.CentreNetwork.Email.ExternalModerator.ExternalModerator

        <Microsoft.Practices.Unity.InjectionConstructor()>
        Public Sub New(externalModeratorEmail As Service.CentreNetwork.Email.ExternalModerator.ExternalModerator)
            _externalModeratorEmail = externalModeratorEmail
        End Sub
        
        Public Sub SetView(centreNetworkEmailView As View.ICentreNetworkEmailForm)
            _centreNetworkEmailView = centreNetworkEmailView
            AddHandler _centreNetworkEmailView.CreateEmailClicked, AddressOf CreateEmail
            PopulateNetworks()
        End Sub

        Public Sub CreateEmail()

            Dim centreNetwork = New Model.Centre.CentreNetworkEntity With {.Network = _centreNetworkEmailView.Network}

            _externalModeratorEmail.CentreNetwork = centreNetwork
            _externalModeratorEmail.Create()
        End Sub

        Private Sub PopulateNetworks()
            _centreNetworkEmailView.Networks = New List(Of Model.Network.NetworkEntity)() From {New Model.Network.NetworkEntity() With {.Code = "A",
                                                                                                                                        .AsEnum = Helper.NetworkEnum.PersonalDevelopmentProgrammes,
                                                                                                                                        .Description = "Personal Development Programmes"},
                                                                                                New Model.Network.NetworkEntity() With {.Code = "P",
                                                                                                                                        .AsEnum = Helper.NetworkEnum.CoPEandAoPE,
                                                                                                                                        .Description = "CoPE and AoPE"},
                                                                                                New Model.Network.NetworkEntity() With {.Code = "Q",
                                                                                                                                        .AsEnum = Helper.NetworkEnum.LifeskillsChallenge,
                                                                                                                                        .Description = "Lifeskills Challenge"}}

        End Sub

    End Class
End Namespace