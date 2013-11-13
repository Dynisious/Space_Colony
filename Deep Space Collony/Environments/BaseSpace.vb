Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public MustInherit Class BaseSpace
    Public Friendly As Galaxy.Allegence
    Public Graphic As galaxyTile

    Public MustOverride Sub Update()

    Public MustOverride Sub Clicked(e As MouseEventArgs)

End Class
