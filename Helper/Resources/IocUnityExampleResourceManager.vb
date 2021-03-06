﻿Namespace Helper.Resources
    Public Class IocUnityExampleResourceManager
        Inherits System.Resources.ResourceManager
        Implements IResourceManager

        '<Microsoft.Practices.Unity.InjectionConstructor()>
        Public Sub New()
            MyBase.New("IoC_Unity_Example.EmailContent",
                       Reflection.Assembly.GetExecutingAssembly())
        End Sub

        Public Overrides Function GetString(name As String) As String Implements IResourceManager.GetString
            Return String.Format("{0}{1}{2}",
                                 "IoC Unity Example Resource -->",
                                 Environment.NewLine,
                                 MyBase.GetString(name))
        End Function

    End Class
End Namespace