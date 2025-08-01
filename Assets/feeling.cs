using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class feeling : MonoBehaviour
{
    // Start is called before the first frame update
   
        public AudioClip soundPthought;
        public AudioSource audioSource;
        public GameObject feelingslider;
        public Slider s;

        // Start is called before the first frame update
        void Start()
        {
            audioSource = GetComponent<AudioSource>();
            s = feelingslider.GetComponent<Slider>();
          

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
                Destroy(gameObject, 0.75f);
                s.value = s.value + 1;
             }
        }
    }

