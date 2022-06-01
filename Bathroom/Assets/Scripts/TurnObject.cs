using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnObject : MonoBehaviour
{
    public void Turn()
    {
        this.gameObject.transform.RotateAround(this.gameObject.transform.position, Vector3.up,90);
    }
}
