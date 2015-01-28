Namespace Model.Network
    Public Class NetworkEntity
        Inherits ModelEntity(Of NetworkEntity)

        Public Overridable Property Code As String
        Public Overridable Property Description As String
        Public Overridable Property AsEnum As Helper.NetworkEnum
        Public Overridable Property ExternalModeratorEmail As String

    End Class
End Namespace
