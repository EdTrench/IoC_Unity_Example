Namespace Helper.Resources
    Public Class IocUnityExampleResourceManager
        Inherits System.Resources.ResourceManager
        Implements IResourceManager

        '<Microsoft.Practices.Unity.InjectionConstructor()>
        Public Sub New()
            MyBase.New("IoC_Unity_Example.EmailContent",
                       Reflection.Assembly.GetExecutingAssembly())
        End Sub

        Public Overrides Function GetString(name As String) As String Implements IResourceManager.GetString
            Return MyBase.GetString(name)
        End Function

    End Class
End Namespace