using TMPro;
using UnityEngine;

public class Timer : UIBase
{
    [SerializeField]
    private TextMeshProUGUI _Timer;

    private float _currentTime = 60f; // 60초부터 시작

    void Update()
    {
        if (_currentTime > 0f)
        {
            _currentTime -= Time.deltaTime;
            if (_currentTime < 0f) _currentTime = 0f; // 음수 방지

            _Timer.text = _currentTime.ToString("F2"); // 소수 둘째 자리까지 표시
        }
    }
}
