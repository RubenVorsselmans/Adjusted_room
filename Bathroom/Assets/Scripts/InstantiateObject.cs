using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InstantiateObject : MonoBehaviour
{
    public GameObject toilet;
    public GameObject douche;
    public void instantiateToilet()
    {
        GameObject _toilet = Instantiate(toilet, new Vector3(0f, 0.5f, 0f), Quaternion.identity);
        GameObject place = GameObject.Find("MovableObjects");
        _toilet.transform.parent = place.transform;
        Rigidbody body = _toilet.gameObject.AddComponent<Rigidbody>();
        body.useGravity = false;
        body.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        //_collider = transform.GetChild(i).gameObject.AddComponent(typeof(BoxCollider)) as BoxCollider;
        XRGrabInteractable grab = _toilet.gameObject.AddComponent<XRGrabInteractable>();
        grab.movementType = XRBaseInteractable.MovementType.VelocityTracking;
    }
    public void instantiateDouche()
    {
        GameObject _douche = Instantiate(douche, new Vector3(0f, 0.8f, 0f), Quaternion.identity);
        GameObject place = GameObject.Find("MovableObjects");
        _douche.transform.parent = place.transform;
        Rigidbody body = _douche.gameObject.GetComponent<Rigidbody>();
        //body.isKinematic = true;
        body.useGravity = false;
        body.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        //_collider = transform.GetChild(i).gameObject.AddComponent(typeof(BoxCollider)) as BoxCollider;
        XRGrabInteractable grab = _douche.gameObject.AddComponent<XRGrabInteractable>();
        grab.movementType = XRBaseInteractable.MovementType.VelocityTracking;
    }
}
