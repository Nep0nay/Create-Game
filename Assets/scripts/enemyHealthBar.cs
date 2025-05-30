using UnityEngine;
using UnityEngine.UI;

public class enemyHealthBar : UIManager
{
    [SerializeField]
    private Image _enemyhp;

    private int _maxhp = 100;
    private int _currenthp = 100;
    void Start()
    {
        _enemyhp.fillAmount = 1;
    }

    void Update()
    {
        OnEnemyHP();
    }

    public void OnEnemyHP()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _currenthp -= 15;
            float remainHP = (float)_currenthp / (float)_maxhp;
            _enemyhp.fillAmount = remainHP;
        }
    }
}
