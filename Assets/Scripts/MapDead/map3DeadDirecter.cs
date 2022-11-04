using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class map3DeadDirecter : MonoBehaviour
{
    void Start()
    {

    }

    public void map3Btn()
    {
        SceneManager.LoadScene("map3playScene");
    }
}
