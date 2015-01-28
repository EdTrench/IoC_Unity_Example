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
        _container.RegisterType(Of Service.CentreNetwork.Email.ExternalModerator.ExternalModerator, Service.CentreNetwork.Email.ExternalModerator.WhenYouFancyIt)("WhenYouFancyIt")
        _container.RegisterType(Of Service.CentreNetwork.Email.ExternalModerator.ExternalModerator, Service.CentreNetwork.Email.ExternalModerator.OnRequest)("OnRequest")
        _container.RegisterType(Of Service.CentreNetwork.Email.ExternalModerator.ExternalModerator, Service.CentreNetwork.Email.ExternalModerator.OnlyWhenITellYou)("OnlyWhenITellYou")
        _container.RegisterType(Of Func(Of String, Service.CentreNetwork.Email.ExternalModerator.ExternalModerator))( _
            New InjectionFactory(Function(x) _
                                      New Func(Of String, Service.CentreNetwork.Email.ExternalModerator.ExternalModerator)(Function(name) x.Resolve(Of Service.CentreNetwork.Email.ExternalModerator.ExternalModerator)(name))))
    End Sub

End Class