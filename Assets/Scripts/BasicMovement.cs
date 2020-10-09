using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float spinSpeed = 180.0f;
    public float motionMagnitude = 0.1f;

    public bool doSpin = false;
    public bool domotion = false;
    // Update is called once per frame
    void Update()
    {
        //rotate around up or Y axis
        if (doSpin)
        {
            gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
        }
        //move up and down over time
        if (domotion)
        {
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
        }
    }
}
