using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windObject : MonoBehaviour {
    public bool inWindZone;
    public GameObject windZone;

    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}

    void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag == "windArea")
        {
            windZone = coll.gameObject;
            inWindZone = true;
        }
    }

    void OnTriggerExit(Collider coll)
    {
        if(coll.gameObject.tag == "windArea")
        {
            inWindZone = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate () {
        if (inWindZone)
        {
            rb.AddForce(windZone.GetComponent<windArea>().direction * windZone.GetComponent<windArea>().strength);
        }
	}
}
