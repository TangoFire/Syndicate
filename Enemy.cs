using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHealth = 25;

    public void TakeDamage(int damageAmount)
    {
        enemyHealth -= damageAmount;
        Debug.Log(enemyHealth);
        
        if (damageAmount > enemyHealth)
        {
            EnemyDeath();
        }
    }

    public void EnemyDeath()
    {
        Destroy(gameObject);
        Debug.Log("Enemy Dies");
    }
}
