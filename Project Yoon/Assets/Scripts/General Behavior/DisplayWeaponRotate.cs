using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayWeaponRotate : MonoBehaviour
{
    private float rotateSpeed = 20f;

    public Vector3 axis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = axis * rotateSpeed * Time.deltaTime;
        transform.Rotate(rotation);
    }
}
