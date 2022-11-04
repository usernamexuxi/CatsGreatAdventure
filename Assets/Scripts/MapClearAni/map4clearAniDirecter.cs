using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class map4clearAniDirecter : MonoBehaviour
{
    int num = 0;
    public Text map4AniText;
    public string m_text;
    public float m_speed = 0.09f;

    IEnumerator typing(Text typingText, string message, float speed)
    {
        for (int i = 0; i < message.Length; i++)
        {
            typingText.text = message.Substring(0, i + 1);
            yield return new WaitForSeconds(speed);
        }
    }

    void Start()
    {
        m_text = "(저기 검은 고양이가 보인다.)";
        StartCoroutine(typing(map4AniText, m_text, m_speed));
    }

    void SwitchText()
    {
        if (num == 1)
        {
            m_text = "황금 생선을 찾으려면 어디로 가야 하냐고?";
            StartCoroutine(typing(map4AniText, m_text, m_speed));
        }
        else if (num == 2)
        {
            m_text = "내가 그걸 왜 알려줘야 하는데.";
            StartCoroutine(typing(map4AniText, m_text, m_speed));
        }
        else if (num == 3)
        {
            m_text = ".........";
            StartCoroutine(typing(map4AniText, m_text, m_speed));
        }
        else if (num == 4)
        {
            m_text = "어디로 가야 하는 지는 네가 직접 알아보라고.";
            StartCoroutine(typing(map4AniText, m_text, m_speed));
        }
        else if (num == 5)
        {
            m_text = ".........";
            StartCoroutine(typing(map4AniText, m_text, m_speed));
        }
        else if (num == 6)
        {
            m_text = "그런 표정 짓지 마.";
            StartCoroutine(typing(map4AniText, m_text, m_speed));
        }
        else if (num == 7)
        {
            m_text = "귀찮으니까 알려줄게.";
            StartCoroutine(typing(map4AniText, m_text, m_speed));
        }
        else if (num == 8)
        {
            m_text = "황금성으로 가 봐.";
            StartCoroutine(typing(map4AniText, m_text, m_speed));
        }
        else
        {
            SceneManager.LoadScene("map5playScene");
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
