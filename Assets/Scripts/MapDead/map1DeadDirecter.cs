using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class map1DeadDirecter : MonoBehaviour
{
    void Start()
    {

    }

    public void map1Btn()
    {
        SceneManager.LoadScene("map1playScene");
    }
}
