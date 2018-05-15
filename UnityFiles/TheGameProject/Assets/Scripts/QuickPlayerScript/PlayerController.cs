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
}