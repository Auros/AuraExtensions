using UnityEngine;

public static class Vector2OnlyExtensions
{
    public static Vector2 OnlyX(this Vector2 vector)
    {
        vector.y = 0;
        return vector;
    }
    
    public static Vector2 OnlyY(this Vector2 vector)
    {
        vector.x = 0;
        return vector;
    }

    public static Vector2Int OnlyX(this Vector2Int vector)
    {
        vector.y = 0;
        return vector;
    }

    public static Vector2Int OnlyY(this Vector2Int vector)
    {
        vector.x = 0;
        return vector;
    }
}