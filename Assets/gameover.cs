using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public GameObject player;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {

        
        
    }

    // Update is called once per frame
    void Update()
    {  
    if(player.transform.position.y< -121f)
        {
            Time.timeScale = 0f;
            SceneManager.LoadScene(2);
 }
        
    }
}
