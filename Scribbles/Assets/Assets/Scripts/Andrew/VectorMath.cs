using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VectorMath
{
    public static bool areAnyVectorComponentsGreater(Vector3 first, Vector3 second)
    {
        return ((first.x > second.x) || (first.y > second.y) || (first.z > second.z));
    }

    public static bool areAnyVectorComponentsLess(Vector3 first, Vector3 second)
    {
        return ((first.x < second.x) || (first.y < second.y) || (first.z < second.z));
    }
}
