using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{

    public Transform swingPoint;
    public float attackRange = .5f;
    public LayerMask enemyLayers;
    public int attackDamage = 5;

   
    void Start()
    {
   
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            SwingWeapon();
        }
        
    }

    void SwingWeapon()
    {
        Debug.Log("Swing Weapon");
       //detect enemies
       Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(swingPoint.position, attackRange,enemyLayers);

        //damage enemy
        foreach(Collider2D enemy in hitEnemies)
        {
         Debug.Log("Hit" + enemy.name);

           enemy.gameObject.GetComponent<Enemy>().TakeDamage(attackDamage);
        }

    }

    private void OnDrawGizmosSelected()
    {
        if (swingPoint == null)
            return;
        Gizmos.DrawWireSphere(swingPoint.position, attackRange);
    }






}



