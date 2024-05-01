using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeranim : MonoBehaviour
{
    public static bool Moving = false;
public GameObject Playercharachter;
  
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.W))
        {
            Moving = true;
        }
            else
            {
                Moving = false;
            }
            
        
       
                    
    }
}
