using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintButton : MonoBehaviour
{
    private List<int> usedIndices = new List<int>();
    public new SpriteRenderer[] renderer = new SpriteRenderer[20];

    void Start()
    {
        // �ʱ�ȭ �ڵ带 ���⿡ �߰��� �� �ֽ��ϴ�.
    }

    void Update()
    {
        // �ʿ��� ��� �߰����� ������ �ۼ��ϼ���
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
                // ����̸� ����ؼ� �ٸ� ���� �ε��� ���
                Debug.Log("Skipped because color is green. Trying again.");
            }
        } while (selectedRenderer.color == Color.green);

        // ����� �ƴϸ� �� ����
        selectedRenderer.color = Color.blue;
    }


    // �ߺ� ���� ������ �ε����� ��� �Լ�
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
            // ��� �ε����� ����ߴٸ� �ʱ�ȭ
            usedIndices.Clear();
        }

        return rand;
    }
}
