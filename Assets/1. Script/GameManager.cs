using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Button[] cancleButton;
    public Button nextScene;

    private void Awake()
    {
        //모든 취소버튼 닫기 실행하기 
        for (int i = 0; i < cancleButton.Length; i++)
        {
            cancleButton[i].onClick.AddListener(Cancle);

        }

        nextScene.onClick.AddListener(Next);
    }

    //취소버튼 누를시
    void Cancle()
    {
        //일시정지 해제
        Time.timeScale = 1;
                    print("일시정지");
    }
    //입장 버튼 누를 시
    void Next()
    {
        //범행 현장 씬으로 전환
        SceneManager.LoadScene(3);
        //일시정지 해제
        Time.timeScale = 1;

        print("씬 전환완료");


    }
}
