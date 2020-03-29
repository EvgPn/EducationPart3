using UnityEngine;
using System;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/ScriptableObjectClass", order = 1)]
public class ScriptableObjectClass : ScriptableObject
{
    public string AppName;
    public string AppVersion;
    public List<Player> Players;
}

[Serializable]
public class Player
{
    public string Name;
    public Color color;
}
