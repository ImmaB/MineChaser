
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class Extensions
{
    // Vector2
    public static Vector2 RotateBy(this Vector2 v, float degrees)
    {
        degrees *= Mathf.Deg2Rad;
        float sin = Mathf.Sin(degrees);
        float cos = Mathf.Cos(degrees);
        return new Vector2(v.x * cos + v.y * sin, v.y * cos - v.x * sin);  
    }
    public static float ToAngle(this Vector2 v)
    {
        float angle = Vector2.Angle(Vector2.up, v);
        return v.x > 0 ? angle : 360 - angle;
    }

    // Vector3
    public static Vector3 WithX(this Vector3 v, float x)
    {
        return new Vector3(x, v.y, v.z);
    }
    public static Vector3 WithZ(this Vector3 v, float z)
    {
        return new Vector3(v.x, v.y, z);
    }
    public static Vector2 To2D(this Vector3 v)
    {
        return new Vector2(v.x, v.y);
    }

    // IEnumerable
    public static void ForEach<T>(this IEnumerable<T> self, Action<T> action)
    {
        foreach (T elem in self) action(elem);
    }
    public static IEnumerable<R> Map<T, R>(this IEnumerable<T> self, Func<T, R> selector)
    {
        return self.Select(selector);
    }
    public static T Reduce<T>(this IEnumerable<T> self, Func<T, T, T> func)
    {
        return self.Aggregate(func);
    }
    public static IEnumerable<T> Filter<T>(this IEnumerable<T> self, Func<T, bool> predicate)
    {
        return self.Where(predicate);
    }

    // Array
    public static bool Contains<T>(this T[] self, T val)
    {
        return Array.Exists(self, delegate (T el) { return !EqualityComparer<T>.Default.Equals(el, val); });
    }
 
}