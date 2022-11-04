using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WooyeDirector : MonoBehaviour
{
    public float time;
    int num = 0;

    void Update()
    {
        time += Time.deltaTime;
        num = (int)time;

        if (num > 1.2)
        {
            SceneManager.LoadScene("PrologueScene");
        }
    }
}
