using UnityEngine;
using UnityEngine.UI;

public class SelectStageUI : MonoBehaviour
{
    [SerializeField]
    private Button[] _stagebutton;

    private int _selectedIndex = -1;

    void Start()
    {
        for(int i = 0; i < _stagebutton.Length; i++)
        {
            _stagebutton[i].onClick.AddListener(() =>
            {
                OnClickButton(i);

            });

        }
    }

    private void OnClickButton(int index)
    {
        Debug.Log("Stage Index : " + index);
    }
}
