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
        m_text = "(�뷧�Ҹ��� �鸰��.)";
        StartCoroutine(typing(map2AniText, m_text, m_speed));
    }

    void SwitchText()
    {
        if (num == 1)
        {
            m_text = "�ȳ�, ����̾�. ���� �����̴�?";
            StartCoroutine(typing(map2AniText, m_text, m_speed));
        }
        else if (num == 2)
        {
            m_text = "Ȳ�� ������ ã���� �Դٰ�?";
            StartCoroutine(typing(map2AniText, m_text, m_speed));
        }
        else if (num == 3)
        {
            m_text = "�׷� �ʷϿ��������� ���� �ǰڳ�.";
            StartCoroutine(typing(map2AniText, m_text, m_speed));
        }
        else if (num == 4)
        {
            m_text = "�ű⿡ �� ���� ģ���� �־�.";
            StartCoroutine(typing(map2AniText, m_text, m_speed));
        }
        else if (num == 5)
        {
            m_text = "�� ģ������ ����� ���� �༱���� �˷��� �ž�.";
            StartCoroutine(typing(map2AniText, m_text, m_speed));
        }
        else if (num == 6)
        {
            m_text = "���� ������ �Ǳ� �ٶ�.";
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
