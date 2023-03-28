using UnityEngine;

public static class Vector3WithExtensions
{
    public static Vector3 WithX(this Vector3 vector, float x)
    {
        vector.x = x;
        return vector;
    }
    
    public static Vector3 WithY(this Vector3 vector, float y)
    {
        vector.y = y;
        return vector;
    }
    
    public static Vector3 WithZ(this Vector3 vector, float z)
    {
        vector.z = z;
        return vector;
    }
    
    public static Vector3Int WithX(this Vector3Int vector, int x)
    {
        vector.x = x;
        return vector;
    }

    public static Vector3Int WithY(this Vector3Int vector, int y)
    {
        vector.y = y;
        return vector;
    }
    
    public static Vector3Int WithZ(this Vector3Int vector, int z)
    {
        vector.z = z;
        return vector;
    }
}