using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteItem : MonoBehaviour
{
    private bool isShown = false;
    public GameObject bin;
    public void showBin()
    {
        if (!isShown)
        {
            bin.SetActive(true);
            isShown = true;
        }
        else
        {
            bin.SetActive(false);
            isShown = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.other.gameObject);
    }
}
