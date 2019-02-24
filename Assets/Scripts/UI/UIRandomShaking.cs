using UnityEngine;
using System.Collections;

[RequireComponent(typeof(RectTransform))]
public class UIRandomShaking : MonoBehaviour
{

    
    public float[] leftUpPoint = new float[2] { -5, 5 };
    public float[] rightDownPoint = new float[2] { 5, -5 };

    private RectTransform rectTransform;
    private Vector2 newPosition;
    
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        //Debug.Log(rectTransform.anchoredPosition);
    }
    
    void Update()
    {
        newPosition = new Vector2(
            Random.Range(leftUpPoint[0], rightDownPoint[0]),
            Random.Range(leftUpPoint[1], rightDownPoint[1]));
        rectTransform.anchoredPosition = newPosition;

    }
}
