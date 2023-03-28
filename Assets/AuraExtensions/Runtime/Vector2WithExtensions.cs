using UnityEngine;

public static class Vector2WithExtensions
{
    public static Vector2 WithX(this Vector2 vector, float x)
    {
        vector.x = x;
        return vector;
    }
    
    public static Vector2 WithY(this Vector2 vector, float y)
    {
        vector.y = y;
        return vector;
    }

    public static Vector2Int WithX(this Vector2Int vector, int x)
    {
        vector.x = x;
        return vector;
    }

    public static Vector2Int WithY(this Vector2Int vector, int y)
    {
        vector.y = y;
        return vector;
    }
}