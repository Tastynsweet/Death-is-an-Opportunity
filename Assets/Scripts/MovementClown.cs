using UnityEngine;

public class MovementClown : MonoBehaviour
{
    public float riseSpeed = 2f;
    public float bounceSpeed = 2f;
    public float bounceHeight = 0.5f;
    public float maxY = 0f;

    private Vector3 startPos;
    private bool reachedTop = false;
    private float bounceStartTime;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (!reachedTop)
        {
            transform.position += Vector3.up * riseSpeed * Time.deltaTime;

            if (transform.position.y >= maxY)
            {
                transform.position = new Vector3(transform.position.x, maxY, transform.position.z);
                reachedTop = true;
                bounceStartTime = Time.time;
            }
        }
        else
        {
            float offset = Mathf.Sin((Time.time - bounceStartTime) * bounceSpeed) * bounceHeight;
            transform.position = new Vector3(transform.position.x, maxY - offset, transform.position.z);
        }



    }
}
