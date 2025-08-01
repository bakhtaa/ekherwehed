using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class spherecollision : MonoBehaviour
{

    public GameObject health;
    public Slider s;
    public static bool test = false;



    // Start is called before the first frame update
    void Start()
    {
        s = health.GetComponent<Slider>();

    }

    // Update is called once per frame
    void Update()
    {
        if (s.value == 0)
        {
            test = true;
            //Time.timeScale = 0f;
           // SceneManager.LoadScene(2);
        }
    }

    /*void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           
          
            s.value = s.value - 10;
          }

 }*/

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {


            s.value = s.value - 10;
        }

    }
}

