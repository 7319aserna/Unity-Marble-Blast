using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    int[] baseTime = new int[] { 5, 10 };
    [SerializeField]
    float[] timer = new float[] { 5, 10 };

    bool[] timerGo = new bool[] { false, false };

    int gemCount;
    int totalGemCount;

    BallController player;

	// Use this for initialization
	void Start ()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        player = FindObjectOfType<BallController>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        for (int i = 0; i < 2; ++i)
        {
            if (timerGo[i])
            {
                timer[i] -= Time.deltaTime;
            }
            if (timer[i] < 0)
            {
                timer[i] = baseTime[i];
                timerGo[i] = false;
                if (i == 0)
                {
                    player.currentForce = player.baseForce;
                    player.currentMaxSpeed = player.baseMaxSpeed;
                }
                else
                {
                    player.transform.localScale = new Vector3(10,10,10);
                }
            }
        }
	}

    public void startTimer(string trait)
    {
        if (trait == "speed")
        {
            timerGo[0] = true;
        }
        if (trait == "size")
        {
            timerGo[1] = true;
        }
    }
}
