using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootprojectile : MonoBehaviour
{
    public Rigidbody bulletrigidbody;
    
    void Start()
    {  //float speed = 35f;
       // bulletrigidbody.velocity = transform.forward*speed;
    }


    private void Awake()
    {
        bulletrigidbody = GetComponent<Rigidbody>();
    }



    private void OnTriggerEnter(Collider other)
    {
        //Destroy(gameObject);
        if (other.GetComponent<hittarget>() != null)
        {
            Debug.Log("target hit"); 
        }

    }
   

}
