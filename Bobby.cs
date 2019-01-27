using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bobby : MonoBehaviour {

    RaycastHit hit;
	
	// Update is called once per frame
	void Update () {
        Debug.DrawRay(transform.position,-transform.up * 0.8f,Color.red);
		if(Physics.Raycast(transform.position,-transform.up,out hit))
        {
            if(hit.collider.tag == "platform")
            {
                gameObject.transform.parent = hit.collider.transform;
            }else
            {
                gameObject.transform.parent = null;
                transform.localScale = Vector3.one;
            }
        }
	}
}
