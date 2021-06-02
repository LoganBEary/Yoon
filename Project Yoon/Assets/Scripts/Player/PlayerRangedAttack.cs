using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRangedAttack : MonoBehaviour
{
    public Rigidbody rb;

    public float lifetime;
    public float counter = 0;

    public float damage;

    // Update is called once per frame
    private void Update()
    {
        if (counter >= lifetime)
        {
            Destroy(gameObject);
        }
        counter += Time.deltaTime;
    }

    void FixedUpdate()
    {
        rb.velocity = transform.forward * 5;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("enemy");
            other.gameObject.GetComponent<EnemyController>().takeDamage(damage);
            Destroy(gameObject);
        }
        else if (other.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }
    }
}
