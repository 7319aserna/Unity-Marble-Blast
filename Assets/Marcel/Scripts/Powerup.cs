using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour {

    public MeshRenderer mesh;
    public GameController gameController;
    public float boost;

    // Use this for initialization
    void Start()
    {
        mesh = gameObject.GetComponent<MeshRenderer>();
        gameController = FindObjectOfType<GameController>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    // apply powerup to player
    public virtual void applyPowerup(BallController player)
    {

    }

    // if player makes contact with powerup
    private void OnTriggerEnter(Collider other)
    {
        applyPowerup(other.gameObject.GetComponent<BallController>());
        gameObject.SetActive(false);
    }
}
