using UnityEngine;
using UnityEngine.UI;

public class mousecontroller : MonoBehaviour
{
    private DestinationMove _selectAgent;

    private float _Speed = 3f;
    void Start()
    {
        
    }

    void Update()
    {
        MouseControll();
    }

    public void MouseControll()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //int layer = LayerMash.NameToLayer("Agent");

            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo, float.MaxValue, 1 << 6))
            {
                Debug.Log("is Hit Plane: " + hitInfo.collider.gameObject.name);

                _selectAgent = hitInfo.collider.gameObject.GetComponent<DestinationMove>();
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //int layer = LayerMash.NameToLayer("Agent");

            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo, float.MaxValue, 1 << 7))
            {
                Debug.Log("is Hit Plane: " + hitInfo.collider.gameObject.name);

                if(_selectAgent != null)
                    _selectAgent.SetDestination(hitInfo.point);
            }
        }
    }
}
