using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Trambolin : MonoBehaviour {

    public int power = 10;

    void OnTriggerEnter (Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<FirstPersonController>().m_JumpSpeed += power;
            col.gameObject.GetComponent<FirstPersonController>().m_Jump = true;
        }    
    }

    void OnTriggerExit (Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<FirstPersonController>().m_JumpSpeed -= power;
        }
    }

}
