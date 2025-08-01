using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Camera cam;

    void Update()
    {
        // Obtenir la position de la souris dans l'écran
        Vector3 mouseScreenPosition = Input.mousePosition;

        // Convertir la position de la souris en coordonnées de monde
        Ray ray = cam.ScreenPointToRay(mouseScreenPosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero); // Plan horizontal
        float rayLength;

        if (groundPlane.Raycast(ray, out rayLength))
        {
            Vector3 pointToLook = ray.GetPoint(rayLength);

            // Calculer la direction de regard
            Vector3 lookDir = pointToLook - transform.position;
            lookDir.y = 0; // On veut juste tourner horizontalement

            // Calculer l'angle pour faire face à la position de la souris
            Quaternion newRotation = Quaternion.LookRotation(lookDir);

            // Appliquer la rotation au transform du joueur
            transform.rotation = newRotation;
        }
    }
}
