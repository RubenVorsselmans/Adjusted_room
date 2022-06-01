using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MoveObjects : MonoBehaviour
{
    Rigidbody body;
    XRGrabInteractable grab;
    int teller = 0;
    int objectCounter = 0;
    public GameObject menuScreen;
    
    // Start is called before the first frame update
    void Start()
    {
        /*
        foreach(GameObject child in transform)
        {
            body = child.AddComponent(typeof(Rigidbody)) as Rigidbody;
        }
        */
        for (int i = 0; i < transform.childCount; i++)
        {
            body = transform.GetChild(i).gameObject.AddComponent(typeof(Rigidbody)) as Rigidbody;
            body.useGravity = false;
            body.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
            //_collider = transform.GetChild(i).gameObject.AddComponent(typeof(BoxCollider)) as BoxCollider;
            grab = transform.GetChild(i).gameObject.AddComponent(typeof(XRGrabInteractable)) as XRGrabInteractable;
            grab.movementType = XRBaseInteractable.MovementType.VelocityTracking;
            //turn = transform.GetChild(i).gameObject.AddComponent(typeof(TurnObject)) as TurnObject;
        }
    }
    public void ChangeAxis()
    {
        if (teller <= 2)
            teller++;
        else
            teller = 0;
        if(teller == 1)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
                //Debug.Log(body);
                //Debug.Log(body.constraints);
            }
        }
        if (teller == 2)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
                //Debug.Log(body);
                //Debug.Log(body.constraints);
            }
        }
        if (teller == 3)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezeRotationZ;
                //Debug.Log(body);
                //Debug.Log(body.constraints);
            }
        }
        if (teller == 0)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
                //Debug.Log(body);
                //Debug.Log(body.constraints);
            }
        }
    }
    public void showUi()
    {
        menuScreen.gameObject.SetActive(true);
        Vector3 vHeadPos = Camera.main.transform.position;
        Vector3 vGazeDir = Camera.main.transform.forward;
        menuScreen.transform.position = (vHeadPos + vGazeDir * 1.0f) + new Vector3(0.0f, -.40f, 0.0f);
        Vector3 vRot = Camera.main.transform.eulerAngles; vRot.z = 0;
        menuScreen.transform.eulerAngles = vRot;
        Debug.Log("Test");
    }
    public void hideUi()
    {
        menuScreen.gameObject.SetActive(false);
    }
}
