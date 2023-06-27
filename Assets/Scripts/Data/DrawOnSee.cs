using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawOnSee : MonoBehaviour
{
    public GameObject eyeInteractor;
    public GameObject objectToSpawn;


    private void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(eyeInteractor.transform.position, Vector3.forward);

        // On trace un rayon à partir de l'oeil et on voit s'il rentre en collision ou non avec une entité
        if(Physics.Raycast(eyeInteractor.transform.position, eyeInteractor.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            objectToSpawn.transform.position = hit.point;
            /* Decommenter cette ligne si l'on veut faire spawn un objet a cet endroit
             * ATTENTION :
             * Puisque le code est effectue a chaque update et que l'on ne detruit pas les objets,
             * il faut veiller a ne pas laisser tourner le code trop longtemps pour ne pas saturer la RAM.
             * De plus, cela n'a pas grand interêt puisque les objets se supperposent. Aucune interpretation n'est reellement possible
             * de cette manière
             */
            //Instantiate(objectToSpawn, hit.point, new Quaternion(0,0,0,0));
        }
    }


}
