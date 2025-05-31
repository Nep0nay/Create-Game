using UnityEngine;

public class MoveSphere : mousecontroller
{
    public Vector3 targetPosition;   // 도착할 목표 위치
    public float moveSpeed = 5f;     // 이동 속도 (유니티 유닛/초)
    public float stopDistance = 0.01f; // 멈추는 거리 허용 오차
  
    private bool isMoving = true;    // 이동 상태 확인용

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

        // 현재 위치와 목표 위치 사이 거리 계산
        float distance = Vector3.Distance(transform.position, targetPosition);
        
        // 목표 위치에 도달하면 이동 중지
        if (distance <= stopDistance)
        {
            transform.position = targetPosition; // 위치 정확히 맞춤
            isMoving = false;
            return;
        }

        // 일정 속도로 목표 위치로 이동
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

    }
}
