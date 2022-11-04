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
        PrologueText.text = "안녕하세요. 냥이 뉴스입니다.";
    }

    void Update()
    {
        time += Time.deltaTime;
        num = (int)time;

        switch (num)
        {
            case 3:
                {
                    PrologueText.text = "요새 화제인 황금 생선에 관한 소식입니다.";
                    break;
                }
            case 6:
                {
                    PrologueText.text = "황금 생선은 희귀한……";
                    break;
                }
            case 9:
                {
                    PrologueText.text = "네 가지의 보석이 황금성의 열쇠……";
                    break;
                }
            case 12:
                {
                    PrologueText.text = "그리고 그 끝에 황금 생선……";
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