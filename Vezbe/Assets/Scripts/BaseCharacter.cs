using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : MonoBehaviour, IDamageable
{   
    private int health;
    public int Health { get { return health; } }
    
    public void TakeDamage(int damage){
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    // gameObject je referenca na objekat na kojem je zakacena skripta
    public void Die(){
        Destroy(gameObject);
    }

    
}