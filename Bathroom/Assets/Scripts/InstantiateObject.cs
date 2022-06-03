using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InstantiateObject : MonoBehaviour
{
    public GameObject toilet;
    public GameObject shower;
    public GameObject toiletBar1;
    public GameObject toiletBar2;
    public GameObject mirror;
    public GameObject sink;
    public GameObject cabinet;
    public GameObject bed;
    public GameObject oven;
    public GameObject microwave;
    public GameObject fridge;
    public GameObject washingMachine;
    public GameObject bin;
    public GameObject spawn;
    private bool isShown = false;
    private float posX;
    private float posZ;
    public void instantiateToilet()
    {
        instantiate(toilet);
    }
    public void instantiateShower()
    {
        instantiate(shower);
    }
    public void instantiateToiletbar1()
    {
        instantiate(toiletBar1);
    }
    public void instantiateToiletbar2()
    {
        instantiate(toiletBar2);
    }
    public void instantiateMirror()
    {
        instantiate(mirror);
    }
    public void instantiateSink()
    {
        instantiate(sink);
    }
    public void instantiateMicrowave()
    {
        instantiate(microwave);
    }
    public void instantiateFridge()
    {
        instantiate(fridge);
    }
    public void instantiateOven()
    {
        instantiate(oven);
    }
    public void instantiateCabinet()
    {
        instantiate(cabinet);
    }
    public void instantiateWashingmachine()
    {
        instantiate(washingMachine);
    }
    public void instantiateBed()
    {
        instantiate(bed);
    }
    public void showBin()
    {
        if (!isShown)
        {
            bin.transform.position = new Vector3 (posX,0,posZ);
            bin.SetActive(true);
            isShown = true;
        }

        else
        {
            isShown = false;
            bin.SetActive(false);
        }
    }
    private void Update()
    {
        posX = spawn.transform.position.x;
        posZ = spawn.transform.position.z;
    }
    private void instantiate(GameObject moveObject)
    {
        GameObject _object = Instantiate(moveObject, new Vector3(posX, 0f, posZ), Quaternion.identity);
        GameObject place = GameObject.Find("MovableObjects");
        _object.transform.parent = place.transform;
        Rigidbody body = _object.gameObject.AddComponent<Rigidbody>();
        body.useGravity = false;
        body.isKinematic = true;
        body.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        //_collider = transform.GetChild(i).gameObject.AddComponent(typeof(BoxCollider)) as BoxCollider;
        XRGrabInteractable grab = _object.gameObject.AddComponent<XRGrabInteractable>();
        grab.movementType = XRBaseInteractable.MovementType.VelocityTracking;
    }
}
