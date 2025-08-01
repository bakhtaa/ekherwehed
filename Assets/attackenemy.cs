using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class attackenemy : MonoBehaviour
{
    public Transform targeta;
    public Transform targetb;
    public Transform targetc;
    public Transform targetd;
    private Animator anim;
    public int verif = 0;

    public float timer = 0f;
    public int ita = 0;
    bool test = true;
    public Vector3 target;
    public GameObject sphere;
    public GameObject arme;
    public GameObject empty;
    public GameObject p;
    public float distance;
    public AudioClip enemyaudio;
    public GameObject ennemihealth;
    public Slider slidehealth;
    // public float distance2;
    public GameObject door;



    [SerializeField]
    private float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        p = GameObject.FindWithTag("Player");
        targeta = GameObject.FindWithTag("A").transform;
        targetb = GameObject.FindWithTag("B").transform;
        targetc = GameObject.FindWithTag("C").transform;
        targetd = GameObject.FindWithTag("D").transform;
    }

    // Update is called once per frame

    void Update()
    {

        distance = Vector3.Distance(this.transform.position, p.transform.position);
        if (checkdeath())
        {
            anim.SetBool("attackennemy", false);
            anim.SetBool("walkennemy", false);
            anim.SetBool("dying", true);
        }
        else {
            if (distance <= 6f)
            {
                if (distance <= 0.75f)
                {
                    attack();

                }
                else
                {
                    follow();
                }
            }


            if (distance > 6f)

            {

                patroll();

            }
        }
        }
        /*else
        {

            anim.SetBool("attackennemy", false);
            anim.SetBool("walkennemy", false);
            anim.SetBool("dying", true);
        }*/

    


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "A")
        {
            verif = 1;
            timer = 0;

        }
        if (other.gameObject.tag == "B")
        {
            verif = 2;
            timer = 0;
        }
        if (other.gameObject.tag == "C")
        {
            verif = 3;
            timer = 0;

        }
        if (other.gameObject.tag == "D")
        {

            verif = 4;
            timer = 0;

        }
    }

    public void attackprojectile()
    {
        sphere = Instantiate(arme, empty.transform.position, Quaternion.identity);
        //sphere.transform.LookAt(p.transform);
        //sphere.GetComponent<Rigidbody>().AddForce(transform.forward * 2000f);
        target = new Vector3(p.transform.position.x, p.transform.position.y, p.transform.position.z);
        sphere.transform.position = Vector3.MoveTowards(sphere.transform.position, target, 1000 * Time.deltaTime);
        AudioSource audiosource = GetComponent<AudioSource>();
        audiosource.clip = enemyaudio;
        audiosource.Play();

    }


    public void patroll()
    {
        anim.SetBool("walkennemy", true);
        anim.SetBool("attackennemy", false);
        timer = Time.deltaTime + timer;
        if (verif == 0) //mezelet massaret hata collision 
        {
            transform.LookAt(targeta);
            transform.Translate(Vector3.forward * Time.deltaTime * 1f);
        }
        if (verif == 1) //saret awel collision (notre cube avec a)
        {
            //saret collision donc bech yebda yehsseb
            if (timer >= 1)
            {
                transform.LookAt(targetb);
                transform.Translate(Vector3.forward * Time.deltaTime * 1f);

            }
        }
        if (verif == 2) //sarett theni collision 
        {

            if (timer >= 1)
            {
                transform.LookAt(targetc);
                transform.Translate(Vector3.forward * Time.deltaTime * 1f);

            }
        }
        if (verif == 3) //saret theleth collision
        {

            if (timer >= 1)
            {
                transform.LookAt(targetd);
                transform.Translate(Vector3.forward * Time.deltaTime * 1f);

            }
        }
        if (verif == 4)
        {
            if (timer >= 1)
            {
                transform.LookAt(targeta);
                transform.Translate(Vector3.forward * Time.deltaTime * 1f);
            }
        }

    }

    public void attack()
    {

        anim.SetBool("walkennemy", false);
        anim.SetBool("attackennemy", true);
    }

    public void follow()
    {
        transform.LookAt(p.transform);
        transform.Translate(Vector3.forward * Time.deltaTime * 0.25f);
        anim.SetBool("walkennemy", true);
        anim.SetBool("attackennemy", false);
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


    public void dooropens()
    {
        door = GameObject.FindWithTag("door");
        Animator anim2= door.GetComponent<Animator>();
        anim2.SetTrigger("dooropen");

     }

    





}


