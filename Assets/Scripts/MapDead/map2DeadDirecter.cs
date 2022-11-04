using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class map2DeadDirecter : MonoBehaviour
{
    void Start()
    {

    }

    public void map2Btn()
    {
        SceneManager.LoadScene("map2playScene");
    }
}
