using UnityEngine;

public enum ARMYSTATE { IDLE, WALK, ATTACK}

public class armyMove : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

    private ARMYSTATE _currentState;

    private float _Speed = 5f;
    private bool _isMoving = false;

    void Start()
    {
        _currentState = ARMYSTATE.IDLE;
    }

    void Update()
    {
        switch (_currentState)
        {
            case ARMYSTATE.IDLE:
                _animator.Play("armyIdle");
                if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
                {
                    _currentState = ARMYSTATE.WALK;
                }

                break;
            case ARMYSTATE.WALK:
                if (Input.GetKey(KeyCode.A))
                {
                    _animator.Play("armyWalk");
                    transform.position += Vector3.right * Time.deltaTime * _Speed;
                    transform.rotation = Quaternion.Euler(new Vector3(0, -270, 0));
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    _animator.Play("armyWalk");
                    transform.position += Vector3.left * Time.deltaTime * _Speed;
                    transform.rotation = Quaternion.Euler(new Vector3(0, -90, 0));
                }

                if(Input.GetMouseButton(0))
                {
                    _currentState = ARMYSTATE.ATTACK;
                }

                break;
            case ARMYSTATE.ATTACK:
                if(Input.GetMouseButton(0))
                {
                    _animator.Play("armyAttack");
                }
                _currentState = ARMYSTATE.IDLE;


                break;
        }
    }
}



//if (Input.GetKey(KeyCode.A))
//{
//    _animator.Play("Walk");
//    //transform.position += Vector3.right * Time.deltaTime * _Speed;
//    transform.rotation = Quaternion.Euler(new Vector3(0, -270, 0));
//}
//if (Input.GetKey(KeyCode.D))
//{
//    _animator.Play("Walk");
//    //transform.position += Vector3.left * Time.deltaTime * _Speed;
//    transform.rotation = Quaternion.Euler(new Vector3(0, -90, 0));

//}
