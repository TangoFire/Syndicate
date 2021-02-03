using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletSpeed = 100f;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = ObjectPooling.sharedInstance.GetPooledObject();
        if (bullet != null)
        {
            bullet.transform.position = new Vector3(firePoint.position.x, firePoint.position.y);
            bullet.transform.rotation = firePoint.transform.rotation;
           
            bullet.SetActive(true);




            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletSpeed, ForceMode2D.Impulse);
        }
    }
}
