﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaMarbleBoost : Powerup
{

    public override void applyPowerup(BallController player)
    {
        player.transform.localScale *= boost;
        gameController.startTimer("size");
    }
}
