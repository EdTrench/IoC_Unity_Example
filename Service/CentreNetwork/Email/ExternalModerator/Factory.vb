Namespace Service.CentreNetwork.Email.ExternalModerator
    Public NotInheritable Class Factory
        Implements IFactory
        
        'How can i get Unity to do this for me?
        'The CreateContainerAndRegisterTypes() in App.vb
        'registers the 3 concrete classes

        Public Function Create(centreNetwork As Model.Centre.CentreNetworkEntity) As ExternalModerator Implements IFactory.Create

            Select Case centreNetwork.Network.AsEnum
                Case Helper.NetworkEnum.CoPEandAoPE
                    'Return New Service.CentreNetwork.Email.ExternalModerator.CopeAope
                Case Helper.NetworkEnum.PersonalDevelopmentProgrammes
                    'Return New Service.CentreNetwork.Email.ExternalModerator.LifeskillsChallenge
                Case Helper.NetworkEnum.LifeskillsChallenge
                    'Return New Service.CentreNetwork.Email.ExternalModerator.LifeskillsChallenge
            End Select
            Throw New NotImplementedException
        End Function

    End Class
End Namespace