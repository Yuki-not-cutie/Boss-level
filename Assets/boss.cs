using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boss : MonoBehaviour
{
    public Slider slider;
    public GameObject end;
    
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }
    void Update()
    {
        if (slider.value < 1)
        {
            end.SetActive(true);
            slider.value = 3;

            Time.timeScale = 0f;
            Debug.Log(Time.timeScale);
        }
    }
   
}
