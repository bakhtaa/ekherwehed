using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class animscript : MonoBehaviour
{

    private Animator anim;
    public GameObject p;
    public float distance;
    public GameObject arme;
    public GameObject empty;
    public AudioClip enemyaudio;
    public GameObject sphere;
    public Vector3 target;
    public GameObject ennemihealth;
    public Slider slidehealth;
    public AudioClip gagner;
    public GameObject sadnessbar;
    public Slider sadnessslider;
    public AudioClip audiogagner;
    public static bool test = false;
    public GameObject angerhealth;
    public Slider angerslider;



    //bool test=false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        p = GameObject.FindWithTag("Player");
        slidehealth = ennemihealth.GetComponent<Slider>();
        sadnessslider = sadnessbar.GetComponent<Slider>();
       
        sadnessslider.value = 0;
        angerslider.value = 0;


    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(this.transform.position, p.transform.position);

        if (checkdeath()==false)
        {
            if (distance <= 50f)
            {
                if (distance <= 1f)
                {
                    attack();


                }
                else
                {
                    follow();

                }

            }
        }
        else
        {
            anim.SetBool("attack", false);
            anim.SetBool("walk", false);
            anim.SetBool("death", true);
        }

    }





    /*if (sadnessslider.value == 3)
    {

        lastsound();

    }*/






    public void attackprojectile()
    {
        sphere = Instantiate(arme, empty.transform.position, Quaternion.identity);
        //sphere.transform.LookAt(p.transform);
        //sphere.GetComponent<Rigidbody>().AddForce(transform.forward * 2000f);
        target = new Vector3(p.transform.position.x, p.transform.position.y + 1, p.transform.position.z);
        sphere.transform.position = Vector3.MoveTowards(sphere.transform.position, target, 1000 * Time.deltaTime);
        AudioSource audiosource = GetComponent<AudioSource>();
        audiosource.clip = enemyaudio;
        audiosource.Play();

    }


    public void gagnerfin()
    {
        AudioSource audiosource = GetComponent<AudioSource>();
        audiosource.clip = gagner;
        audiosource.Play();
        sadnessslider.value = sadnessslider.value + 1;
       

    }





    public void lastsound()
    {
        Invoke("lastsoundwin", 3f);

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

    void attack()
    {
        anim.SetBool("attack", true);
        anim.SetBool("walk", false);
    }
    void follow()
    {
        anim.SetBool("attack", false);
        anim.SetBool("walk", true);
        transform.LookAt(p.transform);
        transform.Translate(Vector3.forward * Time.deltaTime * 0.25f);
    }
    public bool checkdeath()
    {
        slidehealth = ennemihealth.GetComponent<Slider>();
        if (slidehealth.value == 0)
            return (true);
        else
        {
            return (false);
        }


    }


}
