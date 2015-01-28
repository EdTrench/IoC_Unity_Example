Namespace Helper.Resources
    Public Class AnOtherResourceManager
        Inherits System.Resources.ResourceManager
        Implements IResourceManager

        Public Overrides Function GetString(name As String) As String Implements IResourceManager.GetString
            Return "A N other Email Resource Get String"
        End Function

    End Class
End Namespace