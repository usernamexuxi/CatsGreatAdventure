using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class map3clearAniDirecter : MonoBehaviour
{
    int num = 0;
    public Text map3AniText;
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
        m_text = "인어공주가 절 소개했다고요?";
        StartCoroutine(typing(map3AniText, m_text, m_speed));
    }

    void SwitchText()
    {
        if (num == 1)
        {
            m_text = "혹시 황금 생선을 찾는다는 고양이...?";
            StartCoroutine(typing(map3AniText, m_text, m_speed));
        }
        else if (num == 2)
        {
            m_text = "그럼 꿈의 나라로 가보세요.";
            StartCoroutine(typing(map3AniText, m_text, m_speed));
        }
        else if (num == 3)
        {
            m_text = "아참, 그곳은 잠들어야만 갈 수 있어요.";
            StartCoroutine(typing(map3AniText, m_text, m_speed));
        }
        else if (num == 4)
        {
            m_text = "필요하시다면, 제가 잠잘 곳을 마련해 드릴게요.";
            StartCoroutine(typing(map3AniText, m_text, m_speed));
        }
        else
        {
            SceneManager.LoadScene("map4playScene");
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
