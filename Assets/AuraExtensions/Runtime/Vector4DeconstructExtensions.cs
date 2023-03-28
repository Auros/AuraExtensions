using UnityEngine;

public static class Vector4DeconstructExtensions
{
    public static void Deconstruct(this Vector4 vector, out float x, out float y, out float z, out float w)
    {
        x = vector.x;
        y = vector.y;
        z = vector.z;
        w = vector.w;
    }
}