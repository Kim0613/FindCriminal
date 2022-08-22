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

    //���� ��ư ���� ��
    void StartBtn()
    {
        //�ε������� ��ȯ
        SceneManager.LoadScene(1);
    }
}
