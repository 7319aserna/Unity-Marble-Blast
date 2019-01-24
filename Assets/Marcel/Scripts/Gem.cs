using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : Powerup
{
    public override void applyPowerup(BallController player)
    {
        gameController.gemCount++;
    }
}
