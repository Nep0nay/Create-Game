using UnityEngine;

public enum STATE { IDLE, MOVE, ATTACK}

public class enemy : MonoBehaviour
{
    private Transform _target;
    private STATE _currentState;


    void Start()
    {
        _currentState = STATE.IDLE;
    }

    public void SetTarget(Transform target)
    { 
        Vector3 pos = target.transform.position;
        target.transform.position += Vector3.left;
        _target = target; 
    }

    void Update()
    {
        if (_target == null)
            return;

        switch(_currentState)
        {
            case STATE.IDLE:
                //여기서 거리체크 하면된다.
                var dis = Vector3.Distance(transform.position, _target.transform.position);
                Debug.Log(dis);

                break;
            case STATE.MOVE:
                break;
            case STATE.ATTACK:
                break;
        }
    }
}
