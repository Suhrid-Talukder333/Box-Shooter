using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Horizontal" + Input.GetAxis("Horizontal"));
    }
}
