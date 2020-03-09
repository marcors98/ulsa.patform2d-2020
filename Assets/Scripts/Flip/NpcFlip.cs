using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFlip : IFlip
{
    public bool FlipSprite(float x, SpriteRenderer spr)
    {
        return x > 0 ? false : true;
        //get => x > 0 ? false : true;
    }
}
