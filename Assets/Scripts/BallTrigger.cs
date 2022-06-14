using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ball")
        {
            GameObject.FindGameObjectWithTag("cameraTarget").tag = "Untagged";
            other.gameObject.tag = "cameraTarget";
        }
    }
}
