using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
  


  public void attack()
    {
        Animator anim = GetComponent<Animator>();
        anim.SetTrigger("attackui");
        Debug.Log("button clicked");
    }


}
