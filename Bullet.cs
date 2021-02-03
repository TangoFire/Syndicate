using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePoint;
    public int bulletDamage = 5;

    // public GameObject hitEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Debug.Log("Hit");
        if (collision.transform.tag == "Enemy")
        {
            
            collision.gameObject.GetComponent<Enemy>().TakeDamage(bulletDamage);
        }
        gameObject.SetActive(false);

    }

    
}
