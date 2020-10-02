using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Varibles
    public Transform direction;
    public Rigidbody RB;
    public float moveSpeed = 4000, terminalVelo = 4, gravityScale = 11, airControl = 0.05f, groundControl = 0.6f;
    public bool isGrounded = true;

    private Vector2 playerInput;
    private Vector3 velocity;
    private Quaternion oldDir;
    private float gravityForce, moveForce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        setDir();
        getInput();
        movement();
        groundCheck();
        gravity();
    }

    private void getInput()
    {
        Vector2 newPlayerInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        playerInput = Vector2.Lerp(playerInput, newPlayerInput, moveForce);
    }

    private void setDir()
    {
        oldDir = Quaternion.Lerp(oldDir, transform.rotation, 0.05f);
        direction.rotation = oldDir;
    }

    private void movement()
    {
        Vector3 FMovement = direction.forward * playerInput.y * Time.deltaTime;
        Vector3 RMovement = direction.right * playerInput.x * Time.deltaTime;

        velocity = (FMovement + RMovement) * moveSpeed;
        RB.AddForce(velocity);
        RB.velocity = Vector3.ClampMagnitude(RB.velocity, terminalVelo);
    }

    private void groundCheck()
    {
        Collider[] colls = Physics.OverlapSphere(transform.position, 0.05f);

        isGrounded = colls[0] != null && colls[0].gameObject != gameObject;

        if (isGrounded)
        {
            moveForce = groundControl;
        }
        else
        {
            moveForce = airControl;
        }
    }

    private void gravity()
    {
        if (!isGrounded)
        {
            gravityForce += gravityScale * Time.deltaTime;

            Vector3 gravVelo = Vector3.down * gravityForce;

            RB.AddForce(gravVelo);
        }

        if (isGrounded)
        {
            gravityForce = 0;
        }
    }
}
