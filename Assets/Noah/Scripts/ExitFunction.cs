using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ExitFunction : MonoBehaviour {
    Scene nextLevel;
    public Transform mCam;
    public TextMeshProUGUI youWinText;

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
            youWinText.text = "You Win!";
            StartCoroutine(WaitForSec());
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Main Menu");
    }
}
