using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleDirector : MonoBehaviour
{
    void Start()
    {
        
    }

    public void StartBtn()
    {
        SceneManager.LoadScene("map1playScene");
    }
}
