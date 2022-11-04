using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class map1clearAniDirecter : MonoBehaviour
{
    int num = 0;
    public Text map1AniText;
    public string m_text;
    public float m_speed = 0.09f;

    IEnumerator typing(Text typingText, string message, float speed)
    {
        for (int i = 0; i < message.Length; i++)
        {
            typingText.text = message.Substring(0, i+1);
            yield return new WaitForSeconds(speed);
        }
    }

    void Start()
    {
        m_text = "황금 생선을 찾으러 여기 겨울섬까지 왔다고?";
        StartCoroutine(typing(map1AniText, m_text, m_speed));
    }

    void SwitchText()
    {
        if (num == 1)
        {
            m_text = "그럼 다음 행선지는 바다왕국이겠네.";
            StartCoroutine(typing(map1AniText, m_text, m_speed));
        }
        else if (num == 2)
        {
            m_text = "몰랐어?";
            StartCoroutine(typing(map1AniText, m_text, m_speed));
        }
        else if (num == 3)
        {
            m_text = "바다왕국은 아래 지역으로 내려가면 나올 거야.";
            StartCoroutine(typing(map1AniText, m_text, m_speed));
        }
        else if (num == 4)
        {
            m_text = "꼭 황금 생선을 찾길 바라.";
            StartCoroutine(typing(map1AniText, m_text, m_speed));
        }
        else
        {
            SceneManager.LoadScene("map2playScene");
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            num = num + 1;
            SwitchText();
        }

    }
}
