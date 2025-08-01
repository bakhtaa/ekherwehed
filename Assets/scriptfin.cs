using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scriptfin : MonoBehaviour
{
    public GameObject sadnessbar;
    public Slider sadnessslider;
    public AudioClip audiogagner;
    // Start is called before the first frame update
    void Start()
    {
        sadnessslider = sadnessbar.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sadnessslider.value == 3)
        {

            lastsound();

        }
    }
    public void lastsound()
    {
        Invoke("scenesuivante", 3f);

    }
    public void lastsoundwin()
    {
        AudioSource audiosource = GetComponent<AudioSource>();
        audiosource.clip = audiogagner;
        audiosource.Play();
        // Invoke("scenesuivante", 5f);
    }
    public void scenesuivante()
    {

        SceneManager.LoadScene(3);

    }
    
}
