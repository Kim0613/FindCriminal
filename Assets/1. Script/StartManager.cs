using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public Button startBtn;

    private void Awake()
    {
        startBtn.onClick.AddListener(StartBtn);
    }

    //시작 버튼 누를 시
    void StartBtn()
    {
        //로딩씬으로 전환
        SceneManager.LoadScene(1);
    }
}
