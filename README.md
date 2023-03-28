# AuraExtensions
Provides useful extensions for common Unity structs like `UnityEngine.Vector3` and `UnityEngine.Color`.

This includes `.With[X|Y|Z|W|R|G|B](...)`, `.Only[X|Y|Z|W](...)` and [Deconstruct](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/functional/deconstruct) methods for Unity versions that support C# 9.

## Installation

### OpenUPM

*Coming Soon*

### Git URL

```
https://github.com/Auros/AuraExtensions.git?path=/Assets/AuraExtensions
```

## Examples

```cs
// Vector2, Vector3, Vector4
Vector2 vector2 = Vector2.zero;

vector2 = vector2.WithX(5f);
vector2 = vector2.WithY(-5f);

// C# 9 Deconstruct
var (v2x, v2y) = vector2;

// Vector3, Vector4
Vector3 vector3 = Vector3.zero;

vector3 = vector3.WithZ(1.54f);

vector3 = vector3.OnlyX();

// C# 9 Deconstruct
var (v3x, v3y, v3z) = vector3;

// Vector4
Vector4 vector4 = Vector4.zero;

vector4 = vector4.WithW(-0.04f);

// C# 9 Deconstruct
var (v4x, v4y, v4z) = vector4;
```

```cs
Color color = Color.red;

color = color.WithG(1f);

// C# 9 Deconstruct
var (r, g, b) = color;
```

## Compatibility

This library should be compatible with every Unity version that supports at least C# 3.0 (basically all of them).
The minimum supported version is set to Unity 2018.4.
`Deconstruct` support will only work on Unity 2021.2+ (C# 9).
