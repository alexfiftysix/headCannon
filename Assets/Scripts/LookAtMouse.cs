using Unity.VisualScripting;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    private Camera _camera;
    
    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        var screenPosition = Input.mousePosition;
        var ray = _camera.ScreenPointToRay(screenPosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            var worldPos = hit.point;
            worldPos.y = transform.position.y;
            transform.LookAt(worldPos, Vector3.up);
        }
    }
}
