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

    //��ҹ�ư ������
    void Cancle()
    {
        //�Ͻ����� ����
        Time.timeScale = 1;
                    print("�Ͻ�����");
    }
}
