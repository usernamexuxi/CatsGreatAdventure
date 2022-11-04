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
        m_text = "Ȳ�� ������ ã���� ���� �ܿＶ���� �Դٰ�?";
        StartCoroutine(typing(map1AniText, m_text, m_speed));
    }

    void SwitchText()
    {
        if (num == 1)
        {
            m_text = "�׷� ���� �༱���� �ٴٿձ��̰ڳ�.";
            StartCoroutine(typing(map1AniText, m_text, m_speed));
        }
        else if (num == 2)
        {
            m_text = "������?";
            StartCoroutine(typing(map1AniText, m_text, m_speed));
        }
        else if (num == 3)
        {
            m_text = "�ٴٿձ��� �Ʒ� �������� �������� ���� �ž�.";
            StartCoroutine(typing(map1AniText, m_text, m_speed));
        }
        else if (num == 4)
        {
            m_text = "�� Ȳ�� ������ ã�� �ٶ�.";
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
