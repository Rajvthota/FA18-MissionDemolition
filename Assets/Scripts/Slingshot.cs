using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour {
    public GameObject launchPoint;

    private void Awake()
    {
        Transform launchPointTrans = transform.Find("LaunchPoint");

        launchPoint = launchPointTrans.gameObject;

        
    }

    private void OnMouseEnter()
    {
        print("Slingshot:OnMouseEnter()");
    }

    private void OnMouseExit()
    {
        {
            print("Slingshot:OnMouseExist()");
        }
    }
}
