using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : Powerup
{

    public override void applyPowerup(BallController player)
    {
        player.currentForce *= boost;
        player.currentMaxSpeed *= boost;
        gameController.startTimer("speed");
    }
}
