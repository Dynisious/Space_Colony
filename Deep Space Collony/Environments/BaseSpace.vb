Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public MustInherit Class BaseSpace
    Public Empty As Boolean
    Public Friendly As Galaxy.Allegence
    Public Highlighted As Boolean = False
    Public Graphic As galaxyTile

    Public MustOverride Sub Update()

    Public MustOverride Sub Clicked(e As MouseEventArgs)

End Class
