using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class positivethought : MonoBehaviour
{
    public  AudioClip soundPthought;
    public  AudioSource audioSource;
    public GameObject health;
    public Slider s;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        s = health.GetComponent<Slider>();
        s.value = 0.5f;
       
    }

    // Update is called once per frame
    void Update()
    {
      

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Jouer le son
            audioSource.clip = soundPthought;
            audioSource.PlayOneShot(soundPthought);
            Destroy(gameObject, soundPthought.length);
            s.value = s.value + 10;
           





}
    }


    
}
