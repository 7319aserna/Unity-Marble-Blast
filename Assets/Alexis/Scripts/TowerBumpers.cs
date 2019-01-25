using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBumpers : MonoBehaviour {
    [SerializeField]
    Vector3 bumperOffset;

    // Use this for initialization
    void Start()
    {
        transform.position = bumperOffset;
    }
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(bumperOffset.x, Random.Range(-25.0f, 25.0f), bumperOffset.z);
    }
}