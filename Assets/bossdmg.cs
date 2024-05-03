using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossdmg : MonoBehaviour
{
    public boss boss;
    public int maxHealth = 3;
    public int currentHealth;
    private bool insideTrigger;
    public GameObject crystal;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            insideTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            insideTrigger = false;
        }
    }
    void Start()
    {
        currentHealth = maxHealth;
        
    }
    void Update()
    {
        if (insideTrigger && Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(1);
            crystal.SetActive(false);
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        boss.SetHealth(currentHealth);
    }
    
}
