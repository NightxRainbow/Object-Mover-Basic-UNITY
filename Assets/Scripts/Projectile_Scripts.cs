using UnityEngine;

public class Projectile_Scripts : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 playerPosition;

    [SerializeField] float OTWspeed = 2.0f;
    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        OtwPlayer();
        DestroyWhenReached();
    }

    private void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }

    private void OtwPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, OTWspeed * Time.deltaTime);
    }
}
