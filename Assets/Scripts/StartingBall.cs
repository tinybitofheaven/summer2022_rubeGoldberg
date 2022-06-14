using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingBall : MonoBehaviour
{
    public Rigidbody2D ball;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ball.gravityScale = 1;
        }
    }
}
