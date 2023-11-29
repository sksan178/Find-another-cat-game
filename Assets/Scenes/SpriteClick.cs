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
    public new SpriteRenderer renderer; // SpriteRenderer를 저장할 변수
    private bool isClick = true;

    void Start()
    {
        count = 1;
        total = 20;
        // 스크립트가 붙어 있는 게임 오브젝트의 SpriteRenderer를 가져오기
        renderer = GetComponent<SpriteRenderer>();
        //Main 씬에서 버튼 안에 있는 "Count" Text 오브젝트를 가져오기
        CatCount = GameObject.Find("Count").GetComponent<Text>();
    }

    void Update()
    {
        
    }

    void OnMouseDown()
    {
        // 클릭 시 색상을 초록색으로 변경
        if (renderer != null)
        {
            if (isClick)
            {
                renderer.color = Color.green;
                total -= count;

                CatCount.text = "남은 고양이 : " + total.ToString();

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
