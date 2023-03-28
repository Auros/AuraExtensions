using UnityEngine;

public static class Vector3OnlyExtensions
{
    public static Vector3 OnlyX(this Vector3 vector)
    {
        vector.y = 0;
        vector.z = 0;
        return vector;
    }
    
    public static Vector3 OnlyY(this Vector3 vector)
    {
        vector.x = 0;
        vector.z = 0;
        return vector;
    }
    
    public static Vector3 OnlyZ(this Vector3 vector)
    {
        vector.x = 0;
        vector.y = 0;
        return vector;
    }

    public static Vector3Int OnlyX(this Vector3Int vector)
    {
        vector.y = 0;
        vector.z = 0;
        return vector;
    }

    public static Vector3Int OnlyY(this Vector3Int vector)
    {
        vector.x = 0;
        vector.z = 0;
        return vector;
    }
    
    public static Vector3Int OnlyZ(this Vector3Int vector)
    {
        vector.x = 0;
        vector.y = 0;
        return vector;
    }
}