using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showUI : MonoBehaviour {

    public GameObject uiObject;
    public GameObject uiObject1;
    public GameObject uiObject2;
    public GameObject uiObject3;
    public GameObject uiObject4;
    public void Start()
    {
        uiObject.SetActive(false);
        uiObject1.SetActive(false);
        uiObject2.SetActive(false);
        uiObject3.SetActive(false);
        uiObject4.SetActive(false);
    }
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            StartCoroutine("WaitForSec");
        }
    }

    void OnTriggerExit(Collider other)
    {
        Destroy(uiObject);
        Destroy(uiObject1);
        Destroy(uiObject2);
        Destroy(uiObject3);
        Destroy(uiObject4);
        Destroy(gameObject);
    }
    IEnumerator WaitForSec()
    {
        uiObject.SetActive(true);
        yield return new WaitForSeconds(5);
        uiObject.SetActive(false);
        uiObject1.SetActive(true);
        yield return new WaitForSeconds(5);
        uiObject1.SetActive(false);
        uiObject2.SetActive(true);
        yield return new WaitForSeconds(5);
        uiObject2.SetActive(false);
        uiObject3.SetActive(true);
        yield return new WaitForSeconds(5);
        uiObject3.SetActive(false);
        uiObject4.SetActive(true);
    }
}
