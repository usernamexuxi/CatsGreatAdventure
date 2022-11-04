using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class map5clearAniDirecter : MonoBehaviour
{
    int num = 0;
    public Text map5AniText;
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
        m_text = "(황금 생선을 얻기 위해 지나온 과정이 떠오른다.)";
        StartCoroutine(typing(map5AniText, m_text, m_speed));
    }

    void SwitchText()
    {
        if (num == 1)
        {
            m_text = "겨울섬에서 만난 펭귄";
            StartCoroutine(typing(map5AniText, m_text, m_speed));
        }
        else if (num == 2)
        {
            m_text = "바다왕국에서 만난 인어공주";
            StartCoroutine(typing(map5AniText, m_text, m_speed));
        }
        else if (num == 3)
        {
            m_text = "초록요정마을에서 만난 요정";
            StartCoroutine(typing(map5AniText, m_text, m_speed));
        }
        else if (num == 4)
        {
            m_text = "꿈의 나라에서 만난 검은 고양이";
            StartCoroutine(typing(map5AniText, m_text, m_speed));
        }
        else if (num == 5)
        {
            m_text = "그리고 황금성......";
            StartCoroutine(typing(map5AniText, m_text, m_speed));
        }
        else if (num == 6)
        {
            m_text = "(복잡하고 미묘한 감정이 따뜻하게 차오른다.)";
            StartCoroutine(typing(map5AniText, m_text, m_speed));
        }
        else if (num == 7)
        {
            m_text = "나는 황금 생선만 얻은 것이 아니구나.";
            StartCoroutine(typing(map5AniText, m_text, m_speed));
        }
        else if (num == 8)
        {
            m_text = "이번엔 어떤 여정을 떠나볼까.";
            StartCoroutine(typing(map5AniText, m_text, m_speed));
        }
        else
        {
            SceneManager.LoadScene("endingScene");
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
