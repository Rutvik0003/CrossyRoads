using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Cars : MonoBehaviour
{

    public float Speed;
    // Update is called once per frame
    void Update()
    {
      transform .Translate (0,0,Speed*Time.deltaTime);
    }
}
