using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button[] cancleButton;

    private void Awake()
    {
        for (int i = 0; i < cancleButton.Length; i++)
        {
            cancleButton[i].onClick.AddListener(Cancle);

        }
    }

    //취소버튼 누를시
    void Cancle()
    {
        //일시정지 해제
        Time.timeScale = 1;
                    print("일시정지");
    }
}
