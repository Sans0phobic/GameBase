using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] InputActionReference inputAction;
    private InputAction jumpAction;
    private InputAction moveAction;

    float h = 0;
    float v = 0;
    [SerializeField] float playerSpeed = 0;
    [SerializeField] float jumpForce = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        //This is the movement until I do Input Actions
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(h, 0, v);
        rb.AddForce(movement * playerSpeed);

        if (Input.GetKey(KeyCode.Space)) 
        {
            OnJump();
        }
    }

    void OnJump() //This is bad & inconsistent, fix it later
    {
        Vector3 jump = new Vector3(0, jumpForce, 0);
        rb.AddForce(jump);
    }
}
