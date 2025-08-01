using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class uinterface : MonoBehaviour
{
    public GameObject pausemenu;
    public GameObject inventary;
    public GameObject healthplayer;
    public Slider s;
    public GameObject button;
    public GameObject button2;
    public AudioClip soundPthought;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void pausescene()
    {
        SceneManager.LoadScene(4);
    }

    public void attack()
    {
        GameObject g = GameObject.FindWithTag("Player");
        Animator anim=g.GetComponent<Animator>();
        anim.SetTrigger("attackui");
        Debug.Log("bouton clicked");


    }
    public void swordattack()
    {
        GameObject g = GameObject.FindWithTag("Player");
        Animator anim = g.GetComponent<Animator>();
        anim.SetTrigger("swordattack");
    }

    public void pauselevel2()
    {
        
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void resume()
    {

        pausemenu.SetActive(false);
        Time.timeScale = 1f;

    }
    public void playmenu()
    {
        SceneManager.LoadScene(0);
    }

    public void quit()
    {
        Application.Quit();
        Debug.Log("app has quit");
    }

    public void loadlevel2()
    {
        SceneManager.LoadScene(6);
    }

    public void inventaryy()
    {

        inventary.SetActive(true);
        Time.timeScale = 0f;
    }
    public void resume2()
    {

        inventary.SetActive(false);
        Time.timeScale = 1f;

    }

    public void healthmax()
    {
        s = healthplayer.GetComponent<Slider>();
        s.value = 100;
        button.SetActive(false);
        button.GetComponent<AudioSource>();
        audioSource.clip = soundPthought;
        audioSource.PlayOneShot(soundPthought);


    }
    public void healthmax2()
    {
        s = healthplayer.GetComponent<Slider>();
        s.value = 100;
        button2.SetActive(false);
         }


    public void level3()
    {
        SceneManager.LoadScene(9);
    }

   
}


