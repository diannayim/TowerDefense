using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/PathScriptableObject", order = 1)]
public class PathScriptableObject : ScriptableObject
{
    public string pathName;

    public Vector2[] pathPoints;
}