using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMovement : MonoBehaviour {

    public Transform player;
    public float forceMult;
    private Vector3 dir;
	
	// Update is called once per frame
	void Update () {
        dir = transform.position - player.position;
        player.GetComponent<Rigidbody>().AddForce(dir * forceMult);
	}
}
