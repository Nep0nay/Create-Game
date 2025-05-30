using UnityEngine;
using UnityEngine.UI;

public class armyHealthbar : UIBase
{
    [SerializeField]
    private Image _armyhp;

    private int _maxhp = 100;
    private int _currenthp = 100;
    void Start()
    {
        _armyhp.fillAmount = 1;
    }

    void Update()
    {
        OnArmyHP();
    }

    public void OnArmyHP()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _currenthp -= 15;
            float remainHP = (float)_currenthp / (float)_maxhp;
            _armyhp.fillAmount = remainHP;

            if(remainHP <= 0)
            {

            }
        }

        
    }
}
