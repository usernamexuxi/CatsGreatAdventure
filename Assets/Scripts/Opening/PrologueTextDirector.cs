using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PrologueTextDirector : MonoBehaviour
{
    public float time;
    public Text PrologueText;
    int num = 0;

    // Start is called before the first frame update
    void Start()
    {
        PrologueText.text = "�ȳ��ϼ���. ���� �����Դϴ�.";
    }

    void Update()
    {
        time += Time.deltaTime;
        num = (int)time;

        switch (num)
        {
            case 3:
                {
                    PrologueText.text = "��� ȭ���� Ȳ�� ������ ���� �ҽ��Դϴ�.";
                    break;
                }
            case 6:
                {
                    PrologueText.text = "Ȳ�� ������ ����ѡ���";
                    break;
                }
            case 9:
                {
                    PrologueText.text = "�� ������ ������ Ȳ�ݼ��� ���衦��";
                    break;
                }
            case 12:
                {
                    PrologueText.text = "�׸��� �� ���� Ȳ�� ��������";
                    break;
                }
            case 14:
                {
                    PrologueText.text = "";
                    break;
                }
            case 15:
                {
                    SceneManager.LoadScene("StartScene");
                    break;
                }
        }
    }
}