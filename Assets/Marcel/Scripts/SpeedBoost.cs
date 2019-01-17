using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : Powerup
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public override void applyPowerup(BallController player)
    {
        player.force *= boost;
        player.maxSpeed *= boost;
    }
}
