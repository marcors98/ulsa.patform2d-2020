using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcFlip : IFlip
{
    public bool FlipSprite(float x, SpriteRenderer spr)
    {
        return x > 0 ? false : true;
    }
}
