using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitFunction : MonoBehaviour {
    Scene nextLevel;

	// Use this for initialization
	void Start ()
    {
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Rigidbody>().useGravity = false;
            other.GetComponent<BallController>().enabled = false;
            GetComponent<ExitMovement>().enabled = true;
        }
    }
}
