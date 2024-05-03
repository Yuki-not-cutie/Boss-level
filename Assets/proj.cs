using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class proj : MonoBehaviour
{
    public Animator anim;
    public bool animasset;
    public float range;
    public Transform attackPos;
    public LayerMask pplayer;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            
                animasset = true;
                anim.Play("exxpanding");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            animasset = false;
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        Collider2D[] killzone = Physics2D.OverlapCircleAll(attackPos.position, range, pplayer);
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, range);
    }
}
