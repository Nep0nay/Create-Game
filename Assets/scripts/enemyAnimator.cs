using Unity.VisualScripting;
using UnityEngine;

public class enemyAnimator : UIBase
{
    [SerializeField]
    private Animator _animator;

    [SerializeField]
    private GameObject _target;
    
    private float _Speed = 5f;
    private bool _isMoving = false;
    private bool _isPlaying = false;

    void Start()
    {
        _animator.Play("Idle");
    }

    void Update()
    {
        var aniState = _animator.GetCurrentAnimatorStateInfo(0);

        if(aniState.normalizedTime >= 1)
        {
            _isPlaying = false;
        }

        float distance = Vector3.Distance(_target.transform.position, transform.position);

        if(distance <= 5f)
        {
            _isMoving = true;
            _animator.Play("Walk");


        }
        else if(distance >= 5f)
        {
            _animator.Play("Idle");
            _isMoving = true; 
        }

    }
}
