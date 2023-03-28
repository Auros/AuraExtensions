using UnityEngine;

public static class Vector3DeconstructExtensions
{
    public static void Deconstruct(this Vector3 vector, out float x, out float y, out float z)
    {
        x = vector.x;
        y = vector.y;
        z = vector.z;
    }
    
    public static void Deconstruct(this Vector3Int vector, out int x, out int y, out int z)
    {
        x = vector.x;
        y = vector.y;
        z = vector.z;
    }
}