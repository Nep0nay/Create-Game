using UnityEngine;

public class MoveSphere : mousecontroller
{
    public Vector3 targetPosition;   // ������ ��ǥ ��ġ
    public float moveSpeed = 5f;     // �̵� �ӵ� (����Ƽ ����/��)
    public float stopDistance = 0.01f; // ���ߴ� �Ÿ� ��� ����
  
    private bool isMoving = true;    // �̵� ���� Ȯ�ο�

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo, float.MaxValue, 1 << 7))
            {
                Debug.Log("is Hit Plane: " + hitInfo.point);
            }
            targetPosition = hitInfo.point;
        }

        if (!isMoving) return;

        // ���� ��ġ�� ��ǥ ��ġ ���� �Ÿ� ���
        float distance = Vector3.Distance(transform.position, targetPosition);
        
        // ��ǥ ��ġ�� �����ϸ� �̵� ����
        if (distance <= stopDistance)
        {
            transform.position = targetPosition; // ��ġ ��Ȯ�� ����
            isMoving = false;
            return;
        }

        // ���� �ӵ��� ��ǥ ��ġ�� �̵�
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

    }
}
