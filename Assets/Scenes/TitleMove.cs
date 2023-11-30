using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TitleMove : MonoBehaviour
{
    RectTransform pos;
    Vector2 Position = new Vector2 (0, 171);    //이동할 위치
    private float moveSpeed = 1.0f;    //이동속도 정의
    // Start is called before the first frame update
    void Start()
    {
        pos = GetComponent<RectTransform>();
        pos.anchoredPosition = new Vector2(0, 550);     //초기 위치
    }

    // Update is called once per frame
    void Update()
    {
        //지정된 위치, 지정된 시간동안 오브젝트를 이동한다.
        pos.anchoredPosition = Vector2.Lerp(pos.anchoredPosition, Position, Time.deltaTime * moveSpeed);
    }
}
