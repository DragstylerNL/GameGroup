using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMotor : MonoBehaviour
{
    // spring snelheid
    [Range(1, 20)]
    public float jumpVelocity;
    // val multiplier
    public float fallMultiplier = 2.5f;
    // lage sprong multiplier
    public float lowJumpMultiplier = 2f;
    // sta je op de grond ja/nee
    private bool grounded = false;
    // player speed
    public float speed = 3f;
    // timer zodat je niet 2 keer in 1 sec kan springen
    private float jumpTimer;
    // is 'spring' ingedrukt ja/nee
    private bool isJumpPressed;
    // spring is weer losgelaten
    private bool noJumpInput = true;

    // rigidbody rb
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void GroundedOrNot(bool onGround)
    {
        grounded = onGround;
    }

    public void Jump(bool jumpInput)
    {
        // private variabel aanpassen
        isJumpPressed = jumpInput;
        // is jump ingedrukt & staan we op de grond & is de jumptimer weer klein genoeg
        if (isJumpPressed && grounded && noJumpInput &&jumpTimer < 0.1)
        {
            noJumpInput = false;
            // spring
            rb.velocity = Vector2.up * jumpVelocity;
            // set de timer op .2 zotat je niet in dezelfde frame weer kan springen.
            jumpTimer = 0.2f;
        }
        if (!isJumpPressed && grounded)
            noJumpInput = true;
    }

    public void Move(float _speed)
    {
        speed = _speed;
    }

    void Update()
    {

        rb.velocity = new Vector2(speed, 0f);

        // de 2de jump per frame timer verkleinen wanner hoger dan 0
        if (jumpTimer > 0)
        {
            jumpTimer -= Time.deltaTime;
        }

        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
    }


}
