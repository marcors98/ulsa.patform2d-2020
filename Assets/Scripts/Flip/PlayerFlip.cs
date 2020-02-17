using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platform2DUtils.GameplaySystem;

public class PlayerFlip : IFlip
{
    public bool FlipSprite(float x, SpriteRenderer spr)
    {
        return x < 0f ? true : x > 0f ? false : spr.flipX;
    }
}
