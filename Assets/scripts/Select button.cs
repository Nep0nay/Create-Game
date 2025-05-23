using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Selectbutton : UIBase
{
    private Button _button;

    void Start()
    {
        _button = GetComponentInChildren<Button>();

        if (_button != null)
        {
            _button.onClick.AddListener(GameManager.Instance.OnClickSelectButton);
        }
    }

    private void OnClickSelectButton()
    {
        Destroy(gameObject);
    }
}
