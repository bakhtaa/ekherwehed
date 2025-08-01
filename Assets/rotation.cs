using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    private Vector3 mouseWorldPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseScreenPosition = Input.mousePosition;

        // Convertir la position de la souris en coordonnées de monde
        mouseScreenPosition.z = Camera.main.transform.position.y; // Utiliser la hauteur de la caméra
        mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);

        // Tourner le personnage vers la position de la souris
        Vector3 lookDirection = mouseWorldPosition - transform.position;
        lookDirection.y = 0f; // Assurez-vous que le personnage ne regarde pas vers le haut ou vers le bas
        transform.rotation = Quaternion.LookRotation(lookDirection.normalized, Vector3.up);

    }
}
