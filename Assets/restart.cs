using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
   public void StartGame() {
        SceneManager.LoadScene("main");
        Time.timeScale = 1f;
    }
}
