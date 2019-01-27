using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : MonoBehaviour {

    public Transform hand;
    public Transform cam;
    RaycastHit hit;
    public bool active;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            active = !active;


        if(Physics.Raycast(cam.position,cam.forward,out hit,3f))
        {
            if (active && hit.collider.tag == "interactive")
            {
                Transform obj;
                obj = hit.collider.transform;
                obj.transform.parent = hand;
                obj.transform.localPosition = Vector3.zero;
                obj.GetComponent<Rigidbody>().isKinematic = true;
                Debug.Log("asdfdsf");
            }
        }

        if (!active && hand.childCount > 0)
        {
            hand.GetChild(0).gameObject.GetComponent<Rigidbody>().isKinematic = false;
            hand.GetChild(0).gameObject.transform.parent = null;           
        }
    }


    /*   RaycastHit hit;
       GameObject cam,obj;
       //Bobun Konumu
       public Transform bob;
       //Kamera Konumu
       public Transform bobCam;
       //Fırlatma İvmesi
       public float throwForce = 10;
       //??
       bool hasPlayer = false;
       //taşınan eşya Varmı??
       bool beingCarried = false;
       //??
       public int dmg;
       //eşyaya dokundumu
       private bool touched = false;

       private void Start()
       {

       }

       void Update () {
           //cisimle olan uzaklığı ölçer
           float dist = Vector3.Distance(gameObject.transform.position, bob.position);
               if(dist<=2.5f)
                   {
                       hasPlayer = true;
                   }
               else
                   {
                       hasPlayer = false;
                   }
           if (hasPlayer && Input.GetKeyDown("Use"))
           {
               GetComponent<Rigidbody>().isKinematic = true;
               transform.parent = bobCam;
               beingCarried = true;
           }
           if (beingCarried)
           {
               if (touched)
               {
                   GetComponent<Rigidbody>().isKinematic = false;
                   transform.parent = null;
                   beingCarried = false;
                   touched = false;
               }
               if (Input.GetMouseButton(0))
               {
                   GetComponent<Rigidbody>().isKinematic = false;
                   transform.parent = null;
                   beingCarried = false;
                   GetComponent<Rigidbody>().AddForce(bobCam.forward * throwForce);
               }
               else if (Input.GetMouseButton(0))
               {
                   GetComponent<Rigidbody>().isKinematic = false;
                   transform.parent = null;
                   beingCarried = false;
               }
           }

       }
       private void OnTriggerEnter()
       {
           touched = true;
       }   */
}
