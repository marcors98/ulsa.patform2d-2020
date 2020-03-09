using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class GameData 
{
    [SerializeField]
    Player player;
    [SerializeField]
    Vector3 playerPos;

    public Player Player
    {
        get => player;
        set => player = value;
    }
    public Vector3 PlayerPos { get => playerPos; set => playerPos = value; }
}
