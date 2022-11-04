using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 씬 전환 시 반드시 포함.

public class PrologueDirector : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            SceneManager.LoadScene("StartScene");
        }
    }
}
