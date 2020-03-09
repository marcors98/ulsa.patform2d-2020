using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlip : IFlip
{
    public bool FlipSprite(float x, SpriteRenderer spr)
    {
        return x < 0 ? true : x > 0 ? false : spr.flipX;
    }
}
