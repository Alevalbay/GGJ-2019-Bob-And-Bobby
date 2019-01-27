using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public Vector3 openPos;
    public Transform doorObj;

    bool opendoor;

    private void Update()
    {
        if(opendoor)
        {
            doorObj.localPosition = Vector3.Lerp(doorObj.localPosition, openPos,3 * Time.deltaTime);
            if(transform.position == openPos)
            {
                opendoor = false;
            }
        }
    }

    void OnTriggerStay (Collider col)
    {
        if (col.tag == "Player")
        {
            opendoor = true;
        }
    }
}
