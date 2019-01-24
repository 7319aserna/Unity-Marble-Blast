using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSync : MonoBehaviour
{
    
    Transform tParent;
    public Vector3 offset;

    public float x;
    public float sensitivity;

	// Use this for initialization
	void Start ()
    {
        tParent = transform.parent.transform;
        transform.LookAt(transform.parent);

        x = transform.eulerAngles.x;
        sensitivity = 2;
	}
	
	// Update is called once per frame
	void Update ()
    {
        x += Input.GetAxis("Mouse X") * sensitivity;
        Quaternion rotation = Quaternion.Euler(0, x, 0);

        // make the camera follow the player's position while keeping its own rotation
        transform.position = new Vector3(-Mathf.Sin(x * Mathf.PI / 180) * offset.x + tParent.position.x, tParent.position.y + offset.y, -Mathf.Cos(x * Mathf.PI / 180) * offset.z + tParent.position.z);
        transform.rotation = rotation;
    }
}
