using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public enum ENMEYSTATE { IDLE, WALK, ATTACK }

public class enemyAnimator : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

    [SerializeField]
    private Transform _target;
   
    private ENMEYSTATE _currentState;

    private float _Speed = 5f;

    void Start()
    {
        _currentState = ENMEYSTATE.IDLE;

    }

    public void TargetTransform(Transform target)
    {
        _target = target;
    }


    void Update()
    {
        if (_target == null)
            return;

        switch (_currentState)
        {
            case ENMEYSTATE.IDLE:
                _animator.Play("enemyIdle");
                var dis = Vector3.Distance(_target.transform.position, transform.position);

                if (dis <= 6f)
                {
                    _currentState = ENMEYSTATE.WALK;
                }

                break;
            case ENMEYSTATE.WALK:
                var dis1 = Vector3.Distance(_target.transform.position, transform.position);
                transform.position += Vector3.right * Time.deltaTime * _Speed;
                _animator.Play("enemyWalk");

                if(dis1 <= 1f)
                {
                    _currentState = ENMEYSTATE.ATTACK;
                }

                break;
            case ENMEYSTATE.ATTACK:
                _animator.Play("enemyAttack");

                break;
        }

    }
}
