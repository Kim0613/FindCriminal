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
        //��� ��ҹ�ư �ݱ� �����ϱ� 
        for (int i = 0; i < cancleButton.Length; i++)
        {
            cancleButton[i].onClick.AddListener(Cancle);

        }

        nextScene.onClick.AddListener(Next);
    }

    //��ҹ�ư ������
    void Cancle()
    {
        //�Ͻ����� ����
        Time.timeScale = 1;
                    print("�Ͻ�����");
    }
    //���� ��ư ���� ��
    void Next()
    {
        //���� ���� ������ ��ȯ
        SceneManager.LoadScene(3);
        //�Ͻ����� ����
        Time.timeScale = 1;

        print("�� ��ȯ�Ϸ�");


    }
}
