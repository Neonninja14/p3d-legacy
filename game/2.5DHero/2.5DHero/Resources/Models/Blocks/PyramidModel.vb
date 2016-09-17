﻿Public Class PyramidModel

    Inherits BaseModel

    Public Sub New()
        vertexData.Clear()

        vertexData.Add(New VertexPositionNormalTexture(New Vector3(0, 0.5, 0), New Vector3(-1, 0, 0), New Vector2(0.5, 0.0))) 'e
        vertexData.Add(New VertexPositionNormalTexture(New Vector3(-0.5, -0.5, 0.5), New Vector3(-1, 0, 0), New Vector2(1.0, 1.0))) 'h
        vertexData.Add(New VertexPositionNormalTexture(New Vector3(-0.5, -0.5, -0.5), New Vector3(-1, 0, 0), New Vector2(0.0, 1.0))) 'a

        vertexData.Add(New VertexPositionNormalTexture(New Vector3(-0.5, -0.5, 0.5), New Vector3(0, 0, 1), New Vector2(0.0, 1.0))) 'h
        vertexData.Add(New VertexPositionNormalTexture(New Vector3(0, 0.5, 0), New Vector3(0, 0, 1), New Vector2(0.5, 0.0))) 'e
        vertexData.Add(New VertexPositionNormalTexture(New Vector3(0.5, -0.5, 0.5), New Vector3(0, 0, 1), New Vector2(1.0, 1.0))) 'c

        vertexData.Add(New VertexPositionNormalTexture(New Vector3(0.5, -0.5, -0.5), New Vector3(1, 0, 0), New Vector2(0.0, 1.0))) 'b
        vertexData.Add(New VertexPositionNormalTexture(New Vector3(0.5, -0.5, 0.5), New Vector3(1, 0, 0), New Vector2(1.0, 1.0))) 'c
        vertexData.Add(New VertexPositionNormalTexture(New Vector3(0, 0.5, 0), New Vector3(1, 0, 0), New Vector2(0.5, 0.0))) 'e

        vertexData.Add(New VertexPositionNormalTexture(New Vector3(0, 0.5, 0), New Vector3(0, 0, -1), New Vector2(0.5, 0.0))) 'e
        vertexData.Add(New VertexPositionNormalTexture(New Vector3(-0.5, -0.5, -0.5), New Vector3(0, 0, -1), New Vector2(1.0, 1.0))) 'a
        vertexData.Add(New VertexPositionNormalTexture(New Vector3(0.5, -0.5, -0.5), New Vector3(0, 0, -1), New Vector2(0.0, 1.0))) 'b

        Me.ID = 15

        Setup()
    End Sub

End Class