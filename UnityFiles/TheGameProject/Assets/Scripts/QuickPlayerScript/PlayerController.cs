using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    /*
     * Playercontroller zorgt voor het behandelen van input
     * PlayerMotor zorgt ervoor dat de megegeven Behandelde input
     * ook daadwerkelijk wordt 'gedaan'
     */
    private PlayerMotor motor;

    // groundCollider zorgt voor detectie van Ground
    public Transform GroundCollider;
    // sta je op de grond ja/nee
    public bool grounded = false;

    public float playerSpeed = 100;

    public bool _jumpInput;

    void Start()
    {
        // verkrijg het motor script
        motor = GetComponent<PlayerMotor>();
    }

    void Update()
    {
        //check of de Jump-button wordt ingedrukt
        _jumpInput = Input.GetButton("Jump");
        
        // roep jump (stuff) aan
        jump(_jumpInput);
        // beweging 
        Move();
    }

    void jump(bool jumpInput)
    {
        // kijk of je op de grond staat of niet
        grounded = Physics2D.Linecast(transform.position, GroundCollider.position, 1 << LayerMask.NameToLayer("Ground"));
        //geef door of je op de grond staat ja of nee
        motor.GroundedOrNot(grounded);
        // roep jump in motor aan
        motor.Jump(jumpInput);
    }

    void Move()
    {
        float _speed = playerSpeed;
        motor.Move(_speed);
    }
}