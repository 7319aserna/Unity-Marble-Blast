using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBumpers : MonoBehaviour {
    [SerializeField]
    Vector3 bumperOffset;
    float bumperTimerChange = 0.0f;

    // Use this for initialization
    void Start()
    {
        transform.position = bumperOffset;
    }
	// Update is called once per frame
	void Update () {
        bumperTimerChange += Time.deltaTime;
        transform.position = new Vector3(bumperOffset.x, Random.Range(-25.0f, 25.0f), bumperOffset.z);
    }
}