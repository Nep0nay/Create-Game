using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _Timer;

    private float _currentTime = 60f; // 60�ʺ��� ����

    void Update()
    {
        if (_currentTime > 0f)
        {
            _currentTime -= Time.deltaTime;
            if (_currentTime < 0f) _currentTime = 0f; // ���� ����

            _Timer.text = _currentTime.ToString("F2"); // �Ҽ� ��° �ڸ����� ǥ��
        }
    }
}
