using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingDirector : MonoBehaviour
{
    public float time;
    int num = 0;
    public float speed = 5.0f;

    void Update()
    {
        transform.Translate(0, speed, 0);

        time += Time.deltaTime;
        num = (int)time;

        if (num > 15)
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
