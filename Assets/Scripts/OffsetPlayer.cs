using UnityEngine;

public class OffsetPlayer : MonoBehaviour
{
    public GameObject player;
    [Range(0, 0.1f)] public float lerp;
    
    private Vector3 _offset;
    
    // Start is called before the first frame update
    void Start()
    {
        _offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var targetPosition = player.transform.position + _offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, lerp); ;
    }
}
