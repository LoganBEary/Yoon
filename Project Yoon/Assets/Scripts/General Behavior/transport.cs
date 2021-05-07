using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transport : MonoBehaviour
{
    public string scene;
    public PauseManager pmanager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            pmanager.gotoScene(scene);
        }
    }
}
