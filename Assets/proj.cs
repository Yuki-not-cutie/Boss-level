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
    public GameObject PauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Debug.Log(Time.timeScale);
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
                StartCoroutine(damage());
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            animasset = false;
        }
    }
    private IEnumerator damage()
    {
        yield return new WaitForSeconds(1);
        Collider2D[] killzone = Physics2D.OverlapCircleAll(attackPos.position, range, pplayer);
        for (int i = 0;i < killzone.Length; i++)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
            Debug.Log(Time.timeScale);

        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, range);
    }
}
