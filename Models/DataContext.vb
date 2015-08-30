Imports System.Data.Metadata.Edm
Imports System.Reflection
Imports System.IO
Imports System.Xml
Imports System.Data.Mapping
Namespace Models
    Public Class DataContext
        Private Shared _DBEntities As dbServicioEntities

        Public Shared Property DBEntities() As dbServicioEntities
            Get
                If _DBEntities Is Nothing Then
                    _DBEntities = New dbServicioEntities()
                End If
                Return _DBEntities
            End Get
            Set(value As dbServicioEntities)
                _DBEntities = value
            End Set
        End Property
    End Class
End Namespace

