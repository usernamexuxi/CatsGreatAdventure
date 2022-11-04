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
        m_text = "(���� ���� ����̰� ���δ�.)";
        StartCoroutine(typing(map4AniText, m_text, m_speed));
    }

    void SwitchText()
    {
        if (num == 1)
        {
            m_text = "Ȳ�� ������ ã������ ���� ���� �ϳİ�?";
            StartCoroutine(typing(map4AniText, m_text, m_speed));
        }
        else if (num == 2)
        {
            m_text = "���� �װ� �� �˷���� �ϴµ�.";
            StartCoroutine(typing(map4AniText, m_text, m_speed));
        }
        else if (num == 3)
        {
            m_text = ".........";
            StartCoroutine(typing(map4AniText, m_text, m_speed));
        }
        else if (num == 4)
        {
            m_text = "���� ���� �ϴ� ���� �װ� ���� �˾ƺ����.";
            StartCoroutine(typing(map4AniText, m_text, m_speed));
        }
        else if (num == 5)
        {
            m_text = ".........";
            StartCoroutine(typing(map4AniText, m_text, m_speed));
        }
        else if (num == 6)
        {
            m_text = "�׷� ǥ�� ���� ��.";
            StartCoroutine(typing(map4AniText, m_text, m_speed));
        }
        else if (num == 7)
        {
            m_text = "�������ϱ� �˷��ٰ�.";
            StartCoroutine(typing(map4AniText, m_text, m_speed));
        }
        else if (num == 8)
        {
            m_text = "Ȳ�ݼ����� �� ��.";
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
