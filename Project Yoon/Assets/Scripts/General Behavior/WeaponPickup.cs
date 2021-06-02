using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : MonoBehaviour
{

    public Transform player;

    public Item itemToAdd;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Character").transform;
    }

    public void OnWeaponPickup()
    {
        if (Vector3.SqrMagnitude(player.position - transform.position) < 5)
        {
            Inventory.inventoryInstance.add(itemToAdd);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
