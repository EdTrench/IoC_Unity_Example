Namespace Service.CentreNetwork.Email.ExternalModerator
    Public Class PersonalDevelopmentProgrammes
        Inherits ExternalModerator
        
        Sub New(resourceManager As Helper.Resources.IResourceManager,
                output As Helper.Email.Output.Output)
            MyBase.New(resourceManager, output)
        End Sub

        Protected Overrides Function GetSubject() As String
            Return "Specific Personal Development Programmes subject"
        End Function

    End Class
End Namespace