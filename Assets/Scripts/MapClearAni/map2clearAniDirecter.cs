using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class map2clearAniDirecter : MonoBehaviour
{
    int num = 0;
    public Text map2AniText;
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
        m_text = "(노랫소리가 들린다.)";
        StartCoroutine(typing(map2AniText, m_text, m_speed));
    }

    void SwitchText()
    {
        if (num == 1)
        {
            m_text = "안녕, 고양이야. 여긴 웬일이니?";
            StartCoroutine(typing(map2AniText, m_text, m_speed));
        }
        else if (num == 2)
        {
            m_text = "황금 생선을 찾으러 왔다고?";
            StartCoroutine(typing(map2AniText, m_text, m_speed));
        }
        else if (num == 3)
        {
            m_text = "그럼 초록요정마을로 가야 되겠네.";
            StartCoroutine(typing(map2AniText, m_text, m_speed));
        }
        else if (num == 4)
        {
            m_text = "거기에 내 요정 친구가 있어.";
            StartCoroutine(typing(map2AniText, m_text, m_speed));
        }
        else if (num == 5)
        {
            m_text = "그 친구한테 물어보면 다음 행선지도 알려줄 거야.";
            StartCoroutine(typing(map2AniText, m_text, m_speed));
        }
        else if (num == 6)
        {
            m_text = "좋은 여행이 되길 바라.";
            StartCoroutine(typing(map2AniText, m_text, m_speed));
        }
        else
        {
            SceneManager.LoadScene("map3playScene");
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
