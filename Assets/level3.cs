using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class level3 : MonoBehaviour
{
   
  
    public GameObject feelingslider;
    public Slider s;
     
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        s = feelingslider.GetComponent<Slider>();
        if (s.value == 2)
        {
            Invoke("lastsound", 3f);

        }
    }
    public void lastsound()
    {
        SceneManager.LoadScene(10);
        Time.timeScale = 0f;

    }
}

