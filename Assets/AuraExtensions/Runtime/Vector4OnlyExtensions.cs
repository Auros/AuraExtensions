using UnityEngine;

public static class Vector4OnlyExtensions
{
    public static Vector4 OnlyX(this Vector4 vector)
    {
        vector.y = 0;
        vector.z = 0;
        vector.w = 0;
        return vector;
    }
    
    public static Vector4 OnlyY(this Vector4 vector)
    {
        vector.x = 0;
        vector.z = 0;
        vector.w = 0;
        return vector;
    }
    
    public static Vector4 OnlyZ(this Vector4 vector)
    {
        vector.x = 0;
        vector.y = 0;
        vector.w = 0;
        return vector;
    }
    
    public static Vector4 OnlyW(this Vector4 vector)
    {
        vector.x = 0;
        vector.y = 0;
        vector.z = 0;
        return vector;
    }
}