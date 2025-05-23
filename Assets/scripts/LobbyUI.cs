using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class LobbyUI : UIBase
{
    private Button _button;

    void Start()
    {
        _button = GetComponentInChildren<Button>();

        if (_button != null)
        {
            _button.onClick.AddListener(GameManager.Instance.OnClickStartButton);
        }
    }

    private void OnClickStartButton()
    {
        Destroy(gameObject);

    }

}
