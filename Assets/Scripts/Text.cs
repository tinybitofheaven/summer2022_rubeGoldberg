using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    public KeyCode textButton; //change what button this is
    public GameObject text; //lowercase gameObject refers to itself

    // Start is called before the first frame update
    void Start()
    {
        //textButton = KeyCode.Space;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(textButton))
        {
            text.SetActive(false);
        }
        // if (Input.GetKeyUp(textButton))
        // {
        //     text.SetActive(true);
        // }
    }
}
