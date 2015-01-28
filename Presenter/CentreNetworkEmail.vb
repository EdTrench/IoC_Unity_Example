Namespace Presenter
    Public Class CentreNetworkEmail

        Private _centreNetworkEmailView As View.ICentreNetworkEmailForm
        Private ReadOnly _externalModeratorEmailFactory As Func(Of String, Service.CentreNetwork.Email.ExternalModerator.ExternalModerator)

        '<Microsoft.Practices.Unity.InjectionConstructor()> _
        Public Sub New(externalModeratorEmailFactory As Func(Of String, Service.CentreNetwork.Email.ExternalModerator.ExternalModerator))
            _externalModeratorEmailFactory = externalModeratorEmailFactory
        End Sub
        
        Public Sub SetView(centreNetworkEmailView As View.ICentreNetworkEmailForm)
            _centreNetworkEmailView = centreNetworkEmailView
            AddHandler _centreNetworkEmailView.CreateEmailClicked, AddressOf CreateEmail
            PopulateNetworks()
        End Sub

        Public Sub CreateEmail()
            Dim centreNetwork = New Model.Centre.CentreNetworkEntity With {.Network = _centreNetworkEmailView.Network}
            Dim externalModeratorEmail = _externalModeratorEmailFactory(centreNetwork.Network.ExternalModeratorEmail)
            externalModeratorEmail.CentreNetwork = centreNetwork
            externalModeratorEmail.Create()
            _centreNetworkEmailView.SetDisplay(externalModeratorEmail.Create())
        End Sub

        Private Sub PopulateNetworks()
            _centreNetworkEmailView.Networks = New List(Of Model.Network.NetworkEntity)() From {New Model.Network.NetworkEntity() With {.Code = "A",
                                                                                                                                        .AsEnum = Helper.NetworkEnum.PersonalDevelopmentProgrammes,
                                                                                                                                        .Description = "Personal Development Programmes",
                                                                                                                                        .ExternalModeratorEmail = "OnRequest"},
                                                                                                New Model.Network.NetworkEntity() With {.Code = "P",
                                                                                                                                        .AsEnum = Helper.NetworkEnum.CoPEandAoPE,
                                                                                                                                        .Description = "CoPE and AoPE",
                                                                                                                                        .ExternalModeratorEmail = "OnlyWhenITellYou"},
                                                                                                New Model.Network.NetworkEntity() With {.Code = "Q",
                                                                                                                                        .AsEnum = Helper.NetworkEnum.LifeskillsChallenge,
                                                                                                                                        .Description = "Lifeskills Challenge",
                                                                                                                                        .ExternalModeratorEmail = "WhenYouFancyIt"},
                                                                                               New Model.Network.NetworkEntity() With {.Code = "R",
                                                                                                                                        .AsEnum = Helper.NetworkEnum.DiplomaInLifeSkills,
                                                                                                                                        .Description = "Diploma Life Skills",
                                                                                                                                        .ExternalModeratorEmail = "OnRequest"},
                                                                                                New Model.Network.NetworkEntity() With {.Code = "T",
                                                                                                                                        .AsEnum = Helper.NetworkEnum.Excelsis,
                                                                                                                                        .Description = "Excelsis",
                                                                                                                                        .ExternalModeratorEmail = "OnlyWhenITellYou"},
                                                                                                New Model.Network.NetworkEntity() With {.Code = "Z",
                                                                                                                                        .AsEnum = Helper.NetworkEnum.MODBAC,
                                                                                                                                        .Description = "MODBAC",
                                                                                                                                        .ExternalModeratorEmail = "OnlyWhenITellYou"}}
        End Sub

    End Class
End Namespace