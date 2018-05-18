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
    private float speed;
    // timer zodat je niet 2 keer in 1 sec kan springen
    private float jumpTimer;
    // is 'spring' ingedrukt ja/nee
    private bool isJumpPressed;

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
        if (isJumpPressed && grounded && jumpTimer < 0.1)
        {
            // spring
            rb.velocity += Vector2.up * jumpVelocity;
            // set de timer op .2 zotat je niet in dezelfde frame weer kan springen.
            jumpTimer = 0.2f;
        }
    }

    public void Move(float _speed)
    {
        speed = _speed;
    }

    void Update()
    {
        // de 2de jump per frame timer verkleinen wanner hoger dan 0
        if (jumpTimer > 0)
        {
            jumpTimer -= Time.deltaTime;
        }
    }


}
