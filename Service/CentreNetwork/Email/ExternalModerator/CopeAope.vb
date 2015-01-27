Namespace Service.CentreNetwork.Email.ExternalModerator
    Public Class CopeAope
        Inherits ExternalModerator
        
        Sub New(resourceManager As Helper.Resources.IResourceManager,
                output As Helper.Email.Output.Output)
            MyBase.New(resourceManager, output)
        End Sub

    End Class
End Namespace