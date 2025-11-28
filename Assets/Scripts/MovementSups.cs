using UnityEngine;

public class MovementSups : MonoBehaviour
{
    public float moveDistance = 2f;
    public float speed = 2f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float offset = Mathf.PingPong(Time.time * speed, moveDistance);
        transform.position = Vector3.Lerp(startPos, startPos + Vector3.up * moveDistance, offset / moveDistance);
    }
}
