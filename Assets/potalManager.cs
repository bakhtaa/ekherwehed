using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class potalManager : MonoBehaviour
{
    public Transform posB;
    public GameObject bulletempty;
    public GameObject sphere;
    public GameObject copy;
    public AudioClip sounddamage;
    public Vector3 target;
    public GameObject ennemi;
    public AudioClip dyingsound;
    public GameObject healthplayer;
    public Slider s;
   


    // Start is called before the first frame update
    void Start()
    {
        ennemi = GameObject.FindWithTag("ennemy");
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("portalA"))
        {
            CharacterController cc = GetComponent<CharacterController>();
            cc.enabled = false;
            transform.position = posB.position;
            transform.rotation = new Quaternion(transform.rotation.x, posB.rotation.y, transform.rotation.z, transform.rotation.w);
            s = healthplayer.GetComponent<Slider>();
            s.value = 100;
            cc.enabled = true;
        }
    }

    public void shoot()
    { 
        copy = Instantiate(sphere, bulletempty.transform.position, Quaternion.identity);
        copy.GetComponent<Rigidbody>().AddForce(transform.forward * 500f);
        //target = new Vector3(ennemi.transform.position.x, ennemi.transform.position.y + 1, ennemi.transform.position.z);
        //copy.transform.position = Vector3.MoveTowards(copy.transform.position, target, 500 * Time.deltaTime);
        AudioSource audiosource = GetComponent<AudioSource>();
        audiosource.clip = sounddamage;
        audiosource.Play();
        Destroy(copy, 2f);

    }
    public void dying()
    {
        AudioSource audiosource = GetComponent<AudioSource>();
        audiosource.clip = dyingsound;
        audiosource.Play();
    }
    public void movetogameover()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene(2);
    }



}
