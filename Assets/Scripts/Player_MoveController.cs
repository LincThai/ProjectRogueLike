using UnityEngine;
using UnityEngine.InputSystem;

public class Player_MoveController : MonoBehaviour
{
    /// <summary>
    /// Basic Movement for the player either 3D or 2D meaning we may include a jump.
    /// </summary>

    #region References
    // Reference Variable
    Player_Core statsScript;
    InputAction moveAction;
    CharacterController controller;

    #endregion

    #region Movement Variables

    public float moveSpeed;
    private Vector2 moveInput; 
    
    #endregion

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Connect to the Player_Core script and assign the movement speed.
        statsScript = GetComponent<Player_Core>();
        moveSpeed = statsScript.player_MoveSpeed;
        controller = GetComponent<CharacterController>();

        // subscribe to the input in your input actions asset
        moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        // assign the values read from the input system to a vector 2
        moveInput = moveAction.ReadValue<Vector2>();
        // Forward or Backward movement input is assigned to the y of the vactor 2
        float verticalInput = moveInput.y;
        // Left or Right torque/rotational input is assigned to the x of the vector 2
        float horizontalInput = moveInput.x;


    }
}
