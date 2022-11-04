using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map2item : MonoBehaviour
{
    public Animator ani;

    // Start is called before the first frame update
    void Start()
    {
        ani.SetBool("getShell", false);
    }
    void OnInvoke()
    {
        ani.SetBool("getShell", false);
        GameObject.Find("player").GetComponent<dead>().x = 0;
    }
    void test()
    {
        GameObject.Find("player").GetComponent<dead>().x = 1;
    }
    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "map2item")
        {
            ani.SetBool("getShell", true);
            Destroy(col.gameObject);
            test();
            Invoke("OnInvoke", 3.0f);
        }
    }

}
