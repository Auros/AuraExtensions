using UnityEngine;

public static class ColorDeconstructExtensions
{
    public static void Deconstruct(this Color color, out float r, out float g, out float b)
    {
        r = color.r;
        g = color.g;
        b = color.b;
    }

    public static void Deconstruct(this Color color, out float r, out float g, out float b, out float a)
    {
        r = color.r;
        g = color.g;
        b = color.b;
        a = color.a;
    }
}