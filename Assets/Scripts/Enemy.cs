using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float startSpeed =10f;

    public float speed;

    public float startHealth =100;
    private float health;

    public int worth =50;

    private bool isDead = false;


    void Start()
    {
        speed = startSpeed;
        health = startHealth;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        //change healthbar
        /*
        if(health<=0 && !isDead)
        {
            Die();
        }
        */
    }

    public void Slow(float p)
    {
        speed = startSpeed*(1-p);
    }

    void Die()
    {
        isDead=true;
        //give player money
        
        Destroy(gameObject);
    }


}
