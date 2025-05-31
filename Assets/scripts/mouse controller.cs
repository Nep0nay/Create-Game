using UnityEngine;
using UnityEngine.UI;

public class mousecontroller : MonoBehaviour
{

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
            }
        }
    }
}
