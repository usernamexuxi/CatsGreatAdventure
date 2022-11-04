using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dead : MonoBehaviour
{
    GameObject life1;
    GameObject life2;
    GameObject life3;
    Animator animator;

    public int i = 2;
    public int x = 0;

    // Start is called before the first frame update
    void Start()
    {
        life1 = GameObject.Find("life1");
        life2 = GameObject.Find("life2");
        life3 = GameObject.Find("life3");
    }

    void Update()
    {
        Vector2 view = Camera.main.WorldToScreenPoint(transform.position);
        if (view.y < -50)
        {
            if (SceneManager.GetActiveScene().buildIndex == 3)
                SceneManager.LoadScene("map1deadScene");
            else if (SceneManager.GetActiveScene().buildIndex == 7)
                SceneManager.LoadScene("map2deadScene");
            else if (SceneManager.GetActiveScene().buildIndex == 11)
                SceneManager.LoadScene("map3deadScene");
            else if (SceneManager.GetActiveScene().buildIndex == 15)
                SceneManager.LoadScene("map4deadScene");
            else if (SceneManager.GetActiveScene().buildIndex == 19)
                SceneManager.LoadScene("map5deadScene");
        }
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "thorn")
        {
            if (x == 0)
            {
                if (i == 2)
                {
                    Destroy(life1);
                    Destroy(other.gameObject);
                    i--;

                }
                else if (i == 1)
                {
                    Destroy(life2);
                    i--;
                    Destroy(other.gameObject);
                }

                else
                {
                    if (SceneManager.GetActiveScene().buildIndex == 3)
                        SceneManager.LoadScene("map1deadScene");
                    else if (SceneManager.GetActiveScene().buildIndex == 7)
                        SceneManager.LoadScene("map2deadScene");
                    else if (SceneManager.GetActiveScene().buildIndex == 11)
                        SceneManager.LoadScene("map3deadScene");
                    else if (SceneManager.GetActiveScene().buildIndex == 15)
                        SceneManager.LoadScene("map4deadScene");
                    else if (SceneManager.GetActiveScene().buildIndex == 19)
                        SceneManager.LoadScene("map5deadScene");
                }
            }
        }
    }
}