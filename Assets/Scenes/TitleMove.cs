using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TitleMove : MonoBehaviour
{
    RectTransform pos;
    Vector2 Position = new Vector2 (0, 171);    //�̵��� ��ġ
    private float moveSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        pos = GetComponent<RectTransform>();
        pos.anchoredPosition = new Vector2(0, 550);     //�ʱ� ��ġ
    }

    // Update is called once per frame
    void Update()
    {
        pos.anchoredPosition = Vector2.Lerp(pos.anchoredPosition, Position, Time.deltaTime * moveSpeed);
    }
}
