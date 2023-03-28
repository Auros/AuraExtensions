using UnityEngine;

public static class Vector2DeconstructExtensions
{
    public static void Deconstruct(this Vector2 vector, out float x, out float y)
    {
        x = vector.x;
        y = vector.y;
    }

    public static void Deconstruct(this Vector2Int vector, out int x, out int y)
    {
        x = vector.x;
        y = vector.y;
    }
}