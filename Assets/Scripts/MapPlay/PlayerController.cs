using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{ 
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 530.0f;
    float walkForce = 20.0f;
    float maxWalkSpeed = 3.0f;
    SpriteRenderer rend;


    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && this.rigid2D.velocity.y == 0)
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        this.animator.speed = speedx / 2.0f;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rend.flipX = false;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rend.flipX = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("gem"))
        {
            if (SceneManager.GetActiveScene().name == "map1playScene")
                SceneManager.LoadScene("map1clearGemScene");
            else if (SceneManager.GetActiveScene().name == "map2playScene")
                SceneManager.LoadScene("map2clearGemScene");
            else if (SceneManager.GetActiveScene().name == "map3playScene")
                SceneManager.LoadScene("map3clearGemScene");
            else if (SceneManager.GetActiveScene().name == "map4playScene")
                SceneManager.LoadScene("map4clearGemScene");
            else if (SceneManager.GetActiveScene().name == "map5playScene")
                SceneManager.LoadScene("map5clearGemScene");
        }
    }
}