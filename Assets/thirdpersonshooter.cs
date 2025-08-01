using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using StarterAssets;
using UnityEngine.InputSystem;
public class thirdpersonshooter : MonoBehaviour
{
    // Start is called before the first frame update
    public CinemachineVirtualCamera aimvirtualcamera;
    public CinemachineVirtualCamera maincamera;
    [SerializeField] private float normalsensitivity;
    [SerializeField] private float aimsensitivity;
   

    public Vector3 mouseworldposition;
    private void Update()
    {  
       
    }

    public void aimcamera()
    {
        aimvirtualcamera.gameObject.SetActive(true);
       
       
        maincamera.gameObject.SetActive(false);
        
        
        


    }
    public void agrandircamera()
    {
        maincamera.gameObject.SetActive(true);
        aimvirtualcamera.gameObject.SetActive(false);
        
        
       
      

    }
}
