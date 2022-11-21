using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    public float speed = 15;

    private GameObject _player;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        var toOther = (_player.transform.position - transform.position).normalized;
        transform.Translate(toOther * (speed * Time.deltaTime), Space.World);
    }
}
