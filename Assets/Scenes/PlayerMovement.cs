using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 1f;
    private float x, y;

    public GameObject mySprites;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get input
        x = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        y = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        
        transform.Translate(x, y, 0f);

        if (x != 0 || y != 0)
        {
            float angle = Mathf.Atan2(y, x) * Mathf.Rad2Deg;
            mySprites.transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
}
