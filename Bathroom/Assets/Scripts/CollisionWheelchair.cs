using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionWheelchair : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Floor")
        {
            OVRInput.SetControllerVibration(0.5f, 0.8f, OVRInput.Controller.LTouch);
            OVRInput.SetControllerVibration(0.5f, 0.8f, OVRInput.Controller.RTouch);
        }

    }
}
