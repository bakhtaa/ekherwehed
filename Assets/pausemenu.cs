using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void resume()
    {
        SceneManager.LoadScene(0);
    }

    public void playmenu()
    {
        SceneManager.LoadScene(1);
    }

    public void quit()
    {
        Application.Quit();
        Debug.Log("app has quit");
    }

    public void resume2()
    {
        SceneManager.LoadScene(6);
    }
   

}
