using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawOnSee : MonoBehaviour
{
    public GameObject eyeInteractor;
    public GameObject objectToSpawn;

    private void Start()
    {
    }

    private void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(eyeInteractor.transform.position, Vector3.forward);

        if(Physics.Raycast(eyeInteractor.transform.position, eyeInteractor.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity)) //Physics.Raycast(ray,out hit)
        {
            objectToSpawn.transform.position = hit.point;
            //Instantiate(objectToSpawn, hit.point, new Quaternion(0,0,0,0));
        }
    }


}
