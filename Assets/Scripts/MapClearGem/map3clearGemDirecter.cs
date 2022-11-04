using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class map3clearGemDirecter : MonoBehaviour
{
    public float time;
    int num = 0;

    void Update()
    {
        time += Time.deltaTime;
        num = (int)time;

        if (num > 0.4)
        {
            SceneManager.LoadScene("map3clearAniScene");
        }
    }
}
