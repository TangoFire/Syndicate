using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bullet;
    public int bulletDamage = 5;
    public LayerMask enemyLayers;

    // public GameObject hitEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
       
        Debug.Log("Hit");
       
        if (collision.collider.gameObject.layer == 8)
        {
            Debug.Log("Hit Enemy");
            collision.gameObject.GetComponent<Enemy>().TakeDamage(bulletDamage);
        }
        else if (collision.collider.gameObject.layer != 8)
            {
            Debug.Log("Hit Else");
                Debug.Log(collision.collider.gameObject.layer.ToString());
            }
       
        gameObject.SetActive(false);

    }
   
    
    
    


}
