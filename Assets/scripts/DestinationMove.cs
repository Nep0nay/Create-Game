using UnityEngine;

public class DestinationMove : MonoBehaviour
{
    private Vector3 Destination;

    private bool isMove = false;

    [SerializeField]
    private float Speed = 5f;
    void Start()
    {
        
    }

    public void SetDestination(Vector3 dest)
    {
        Destination = dest;
        isMove = true;
    }

    void Update()
    {
        if (isMove == false)
            return;

        Vector3 direct = Destination - transform.position;
        direct.Normalize(); //ũ�⸦ 1�� �������ش�

        transform.position += direct * Speed * Time.deltaTime;

        var remainDist = Vector3.Distance(transform.position, Destination);

        if(remainDist < 0.01f)
            isMove = false;

        

    }
}
