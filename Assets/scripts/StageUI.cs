using UnityEngine;
using UnityEngine.UI;

public class StageUI : UIBase
{
    private Button _button;
    void Start()
    {
        _button = GetComponentInChildren<Button>();

        if (_button != null)
        {
            _button.onClick.AddListener(GameManager.Instance.OnFirstStageButton);
        }
    }

    private void OnFirstStageButton()
    {
        Destroy(gameObject);

    }
}
