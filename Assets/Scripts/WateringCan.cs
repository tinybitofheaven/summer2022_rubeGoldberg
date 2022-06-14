using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WateringCan : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (GameObject.FindGameObjectWithTag("finalCamera") != null)
        {
            GameObject.FindGameObjectWithTag("cameraTarget").tag = "Untagged";
            GameObject.FindGameObjectWithTag("finalCamera").tag = "cameraTarget";
        }
        // other.gameObject.tag = "cameraTarget";
    }
}
