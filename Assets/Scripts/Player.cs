using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rb;

    [SerializeField]
    float speed = 10f;

    [SerializeField]
    InputAction moveHorizontal = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveVertical = new InputAction(type: InputActionType.Button);

    [SerializeField]
    string triggeringTag;

    [SerializeField]
    Text youWon;

    [SerializeField]
    Text gameOver;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        youWon.gameObject.SetActive(false);
        gameOver.gameObject.SetActive(false);
    }

    void OnEnable()
    {
        moveHorizontal.Enable();
        moveVertical.Enable();
    }

    void OnDisable()
    {
        moveHorizontal.Disable();
        moveVertical.Disable();
    }

    void Update()
    {
        float horizontal = moveHorizontal.ReadValue<float>();
        float vertical = moveVertical.ReadValue<float>();
        Vector3 movementVector = new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime;
        transform.position += movementVector;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Car")
        {
            _rb.velocity = Vector3.zero;
            this.gameObject.SetActive(false);
            gameOver.gameObject.SetActive(true);
        }
        if (collision.gameObject.tag == "Finish")
        {
            youWon.gameObject.SetActive(true);
            enabled = false;
        }
    }
}
