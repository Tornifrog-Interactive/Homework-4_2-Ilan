using UnityEngine;

public class Car : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rb;

    [SerializeField]
    Vector3 velocity;

    [SerializeField]
    float maxLifetime = 10.0f;

    void Update()
    {
        transform.position += velocity * Time.deltaTime;
    }

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _rb = GetComponent<Rigidbody2D>();
    }

    public void SetVelocity(Vector3 newVelocity)
    {
        this.velocity = newVelocity;

        Destroy(this.gameObject, this.maxLifetime);
    }
}
