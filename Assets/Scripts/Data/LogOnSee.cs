using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LogOnSee
{
    /* Les fonctions sont actuellement les meme.
     * Cependant elles ont ete duppliquees dans le cas
     * fortement probable ou il serait necessaire deffectuer
     * un code sur un oeil et pas sur l'autre
     */

    public Vector3 GetLeftEyeFixationPoint(GameObject leftEyeInteractor)
    {
        RaycastHit leftHit;
        Ray leftRay = new Ray(leftEyeInteractor.GetComponent<Transform>().transform.position, Vector3.forward);

        //On trace un rayon fictif et l'on voit s'il rentre en collision avec une entité
        if (Physics.Raycast(leftEyeInteractor.transform.position, leftEyeInteractor.transform.TransformDirection(Vector3.forward),out leftHit,Mathf.Infinity))
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
