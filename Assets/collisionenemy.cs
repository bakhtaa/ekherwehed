using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collisionenemy : MonoBehaviour
{
    public GameObject healthenemy1;
    public Slider se;
    
    public GameObject healthenemy2;
    public Slider s2;

    public GameObject healthenemy3;
    public Slider s3;
    public GameObject healthenemy4;
    public Slider s4;
    public GameObject healthenemy5;
    public Slider s5;
    // Start is called before the first frame update

    void Start()
    {
        se = healthenemy1.GetComponent<Slider>();
        s2 = healthenemy2.GetComponent<Slider>();
        s3 = healthenemy3.GetComponent<Slider>();
        s4 = healthenemy4.GetComponent<Slider>();
        s5 = healthenemy4.GetComponent<Slider>();
        //se.value = 0;
    }

    // Update is called once per frame
    void Update()
    { 

    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("ennemy1"))
        {
            se.value = se.value - 1;
            Destroy(gameObject, 1f);

        }
        if(other.gameObject.CompareTag("ennemy2"))
        {
            s2.value = s2.value - 1;
            Destroy(gameObject, 1f);
        }
        if (other.gameObject.CompareTag("ennemy3"))
        {
            s3.value = s3.value - 1;
            Destroy(gameObject, 1f);
        }
        if (other.gameObject.CompareTag("ennemy4"))
        {
            s4.value = s4.value - 1;
            Destroy(gameObject, 1f);
        }
        if (other.gameObject.CompareTag("ennemy5"))
        {
            s5.value = s5.value - 1;
            Destroy(gameObject, 1f);
        }

    }
}
