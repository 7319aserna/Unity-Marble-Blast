using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour {

    int[] baseTime = new int[] { 5, 10 };
    [SerializeField]
    float[] timer = new float[] { 5, 10 };

    bool[] timerGo = new bool[] { false, false };

    public int gemCount = 0;
    public int totalGemCount;

    public TextMeshProUGUI gems;
    public TextMeshProUGUI exitAppeared;
    public GameObject exit;

    BallController player;

	// Use this for initialization
	void Start ()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        player = FindObjectOfType<BallController>();

        gems.text = "Gems: " + gemCount.ToString();

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
                    player.transform.localScale = new Vector3(5,5,5);
                }
            }
        }
        gems.text = "Gems: " + gemCount.ToString() + "/" + totalGemCount.ToString();
        if (gemCount >= totalGemCount)
        {
            exit.SetActive(true);
            exitAppeared.text = "The exit has appeared!";
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
