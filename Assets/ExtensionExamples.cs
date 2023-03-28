using UnityEngine;

public class ExtensionExamples : MonoBehaviour
{
    private void Start()
    {
        // Vector3 WithX
        Vector3 vector3 = new(5f, 1f, 3f);
        var newVector3 = vector3.WithX(vector3.x + 5f);
        Debug.Log(newVector3);
        
        // Vector3 Deconstruct
        var (x, y, z) = newVector3;
        Debug.Log($"X: {x}, Y: {y}, Z: {z}");
        
        // RGBA WithG
        Color color = new(0.32f, 0.564f, 0.815f, 0.95f);
        var newColor = color.WithG(0f);
        Debug.Log(newColor);
        
        // RGB Deconstruct
        var (r, g, b) = newColor;
        Debug.Log($"R: {r}, G: {g}, B: {b}");
    }
}
