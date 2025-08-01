using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class colereslider : MonoBehaviour
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
        if (s.value==3)
        {
            Invoke("lastsound", 3f);
          
        }
    }
    public void lastsound()
    {
        SceneManager.LoadScene(8);
        Time.timeScale = 0f;

    }
}
