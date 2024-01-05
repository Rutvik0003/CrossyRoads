using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Vector3 v3 = new Vector3 (3.5f,0,0);
    public Vector3 Lr = new Vector3(0, 0, 1);
    public Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = transform.position - v3;
            cam.transform .position = cam.transform .position - v3;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = transform.position + v3;
            cam.transform.position = cam.transform.position + v3;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = transform.position - Lr;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = transform.position + Lr;
        }
    }

}
