using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class mainMenu : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PlayGame()
    {
        SceneManager.LoadScene(1);

    }


    public void quit()
    {
        Application.Quit();
        Debug.Log("app has quit");
    }

    public void volume()
    {
        SceneManager.LoadScene(5);
    }

  
}
