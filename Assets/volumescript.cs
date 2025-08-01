using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class volumescript : MonoBehaviour


{

    public Slider volumeslider;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void back()
    {
        SceneManager.LoadScene(0);
    }

    public void changevolume()
    {
        AudioListener.volume = volumeslider.value;
    }
}
