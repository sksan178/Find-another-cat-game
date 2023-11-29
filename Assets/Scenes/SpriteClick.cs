using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpriteClick : MonoBehaviour
{
    public Text CatCount;
    public static int count;
    public static int total;
    public new SpriteRenderer renderer; // SpriteRenderer�� ������ ����
    private bool isClick = true;

    void Start()
    {
        count = 1;
        total = 20;
        // ��ũ��Ʈ�� �پ� �ִ� ���� ������Ʈ�� SpriteRenderer�� ��������
        renderer = GetComponent<SpriteRenderer>();
        //Main ������ ��ư �ȿ� �ִ� "Count" Text ������Ʈ�� ��������
        CatCount = GameObject.Find("Count").GetComponent<Text>();
    }

    void Update()
    {
        
    }

    void OnMouseDown()
    {
        // Ŭ�� �� ������ �ʷϻ����� ����
        if (renderer != null)
        {
            if (isClick)
            {
                renderer.color = Color.green;
                total -= count;

                CatCount.text = "���� ����� : " + total.ToString();

                isClick = false;
            }

            if (total <= 0)
            {
                GameClear();
            }
        }
    }

    void GameClear()
    {
        SceneManager.LoadScene("Clear");
    }
}
