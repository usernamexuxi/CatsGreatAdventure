using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class getItem : MonoBehaviour
{
    Rigidbody2D rigid2D;
    public float time;
    public float walkForce = 10;
    public float booster = 15;
    public float jumpForce;

    int num = 0;

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        time += Time.deltaTime;
        num = (int)time;
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "map1item")
        {
            Destroy(col.gameObject);
            // �÷��� �ӵ� ����
            this.rigid2D.AddForce(Vector2.right * walkForce, ForceMode2D.Impulse);
        }

        else if (col.gameObject.tag == "map3item")
        {
            Destroy(col.gameObject);
            // �ν���=���ư���
            this.rigid2D.AddForce(Vector2.right * booster, ForceMode2D.Impulse);
        }
        else if (col.gameObject.tag == "map4item")
        {
            //��������
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }
    }
}
