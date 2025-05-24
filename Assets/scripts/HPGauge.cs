using UnityEngine;

public class HPGauge : MonoBehaviour
{
    [SerializeField]
    private Transform _target;

    void Update()
    {
        Vector2 uiPosition = Camera.main.WorldToScreenPoint(_target.position);

        (transform as RectTransform).position = uiPosition + Vector2.up * 110;

    }
}
