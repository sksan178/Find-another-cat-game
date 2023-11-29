using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintButton : MonoBehaviour
{
    private List<int> usedIndices = new List<int>();
    public new SpriteRenderer[] renderer = new SpriteRenderer[20];

    void Start()
    {
        // 초기화 코드를 여기에 추가할 수 있습니다.
    }

    void Update()
    {
        // 필요한 경우 추가적인 로직을 작성하세요
    }

    public void hintOnClick()
    {
        int rand;
        SpriteRenderer selectedRenderer;

        do
        {
            rand = GetUniqueRandomIndex();
            selectedRenderer = renderer[rand];

            if (selectedRenderer.color == Color.green)
            {
                // 녹색이면 계속해서 다른 랜덤 인덱스 얻기
                Debug.Log("Skipped because color is green. Trying again.");
            }
        } while (selectedRenderer.color == Color.green);

        // 녹색이 아니면 색 변경
        selectedRenderer.color = Color.blue;
    }


    // 중복 없이 랜덤한 인덱스를 얻는 함수
    private int GetUniqueRandomIndex()
    {
        int rand;
        do
        {
            rand = Random.Range(0, renderer.Length);
        } while (usedIndices.Contains(rand));

        usedIndices.Add(rand);
        if (usedIndices.Count == renderer.Length)
        {
            // 모든 인덱스를 사용했다면 초기화
            usedIndices.Clear();
        }

        return rand;
    }
}
