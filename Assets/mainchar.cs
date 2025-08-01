using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainchar : MonoBehaviour
{
    public Transform posA;
    public Transform posB; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("portalA"))
        {
            CharacterController cc = GetComponent<CharacterController>();
            cc.enabled = false;
            transform.position = posB.position;
            transform.rotation = new Quaternion(transform.rotation.x, posB.rotation.y, transform.rotation.z, transform.rotation.w);
            cc.enabled = true;
        }

        if (other.CompareTag("portalB"))
        {
            CharacterController cc = GetComponent<CharacterController>();
            cc.enabled = false;
            transform.position = posA.position;
            transform.rotation = new Quaternion(transform.rotation.x, posA.rotation.y, transform.rotation.z, transform.rotation.w);
            cc.enabled = true;
        }
    }


}
