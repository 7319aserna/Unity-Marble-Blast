using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSync : MonoBehaviour
{
    
    Transform tParent;
    public Vector3 offset;

	// Use this for initialization
	void Start ()
    {
        tParent = transform.parent.transform;
	}
	
	// Update is called once per frame
	void Update ()
    {
        // make the camera follow the player's position while keeping its own rotation
        transform.position = new Vector3(tParent.position.x + offset.x, tParent.position.y + offset.y, tParent.position.z + offset.z);
        transform.rotation = Quaternion.Euler(Vector3.zero);
        transform.LookAt(transform.parent);
    }
}
