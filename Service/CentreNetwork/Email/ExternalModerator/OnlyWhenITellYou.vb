﻿Namespace Service.CentreNetwork.Email.ExternalModerator
    Public Class OnlyWhenITellYou
        Inherits ExternalModerator

        '<Microsoft.Practices.Unity.InjectionConstructor()>
        Sub New(resourceManager As Helper.Resources.IResourceManager,
                output As Helper.Email.Output.Output)
            MyBase.New(resourceManager, output)
        End Sub

        Protected Overrides Function GetSubject() As String
            Return "Specific Only When I Tell You subject"
        End Function

    End Class
End Namespace