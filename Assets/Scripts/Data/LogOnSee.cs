using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LogOnSee
{
    public Vector3 GetLeftEyeFixationPoint(GameObject leftEyeInteractor)
    {
        RaycastHit leftHit;
        Ray leftRay = new Ray(leftEyeInteractor.GetComponent<Transform>().transform.position, Vector3.forward);
        Debug.DrawRay(leftEyeInteractor.transform.position, Vector3.forward * 5, Color.red);
        Debug.Log("Poistion de l'interactor = " + leftEyeInteractor.transform.position);
        if (Physics.Raycast(leftEyeInteractor.transform.position, leftEyeInteractor.transform.TransformDirection(Vector3.forward),out leftHit,Mathf.Infinity))//leftRay, out leftHit, Mathf.Infinity
        {
            Debug.Log("Touche ");
            return leftHit.point;
        }
        return Vector3.zero;
    }


    public Vector3 GetRightEyeFixationPoint(GameObject rightEyeInteractor)
    {
        RaycastHit rightHit;
        Ray rightRay = new Ray(rightEyeInteractor.transform.position, Vector3.forward);

        if (Physics.Raycast(rightRay, out rightHit, Mathf.Infinity))
        {
            return rightHit.point;
        }

        return Vector3.zero;
    }

}
