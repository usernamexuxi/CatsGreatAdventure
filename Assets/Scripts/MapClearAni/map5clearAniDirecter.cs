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
        m_text = "(Ȳ�� ������ ��� ���� ������ ������ ��������.)";
        StartCoroutine(typing(map5AniText, m_text, m_speed));
    }

    void SwitchText()
    {
        if (num == 1)
        {
            m_text = "�ܿＶ���� ���� ���";
            StartCoroutine(typing(map5AniText, m_text, m_speed));
        }
        else if (num == 2)
        {
            m_text = "�ٴٿձ����� ���� �ξ����";
            StartCoroutine(typing(map5AniText, m_text, m_speed));
        }
        else if (num == 3)
        {
            m_text = "�ʷϿ����������� ���� ����";
            StartCoroutine(typing(map5AniText, m_text, m_speed));
        }
        else if (num == 4)
        {
            m_text = "���� ���󿡼� ���� ���� �����";
            StartCoroutine(typing(map5AniText, m_text, m_speed));
        }
        else if (num == 5)
        {
            m_text = "�׸��� Ȳ�ݼ�......";
            StartCoroutine(typing(map5AniText, m_text, m_speed));
        }
        else if (num == 6)
        {
            m_text = "(�����ϰ� �̹��� ������ �����ϰ� ��������.)";
            StartCoroutine(typing(map5AniText, m_text, m_speed));
        }
        else if (num == 7)
        {
            m_text = "���� Ȳ�� ������ ���� ���� �ƴϱ���.";
            StartCoroutine(typing(map5AniText, m_text, m_speed));
        }
        else if (num == 8)
        {
            m_text = "�̹��� � ������ ��������.";
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
