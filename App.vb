Imports Microsoft.Practices.Unity
Imports System.Windows.Forms

Public NotInheritable Class App

    Private Shared _container As Microsoft.Practices.Unity.IUnityContainer

    <STAThread()> _
    Public Shared Sub Main()
        CreateContainerAndRegisterTypes()
        Application.Run(_container.Resolve(Of View.CentreNetworkEmailForm)())
    End Sub
    
    Private Shared Sub CreateContainerAndRegisterTypes()
        _container = New Microsoft.Practices.Unity.UnityContainer()
        _container.RegisterType(Of Helper.Resources.IResourceManager, Helper.Resources.IocUnityExampleResourceManager)()
        _container.RegisterType(Of Helper.Email.Output.Output, Helper.Email.Output.OutlookMessage)()
        _container.RegisterType(Of Service.CentreNetwork.Email.ExternalModerator.ExternalModerator, Service.CentreNetwork.Email.ExternalModerator.CopeAope)()
        _container.RegisterType(Of Service.CentreNetwork.Email.ExternalModerator.ExternalModerator, Service.CentreNetwork.Email.ExternalModerator.LifeskillsChallenge)()
        _container.RegisterType(Of Service.CentreNetwork.Email.ExternalModerator.ExternalModerator, Service.CentreNetwork.Email.ExternalModerator.PersonalDevelopmentProgrammes)()
    End Sub

End Class