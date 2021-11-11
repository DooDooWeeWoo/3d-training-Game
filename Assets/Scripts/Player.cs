using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{
    //reference varaibles
    //[SerializeField] allows the variable to be used within the unity inspector without having to make it a public variable
    [SerializeField] Transform playerCamera = null;
    [SerializeField][Range(0.0f, 5.0f)] float mouseSensitivity = 3.5f;
    [SerializeField][Range(0.0f, 0.5f)] float moveSmoothTime = 0.3f; //movement speed smoothing
    [SerializeField][Range(0.0f, 0.5f)] float mouseSmoothTime = 0.03f; //mouse cursor look smoothing
    [SerializeField] float gravity = -13.0f; //gravity of the world
    public float JumpStrength; //the strength the player jumps at
    [SerializeField] bool lockCursor = true; //bool for locking the cursor
    [SerializeField] KeyCode JumpKey; //the keycode for the jump key


    float cameraPitch = 0.0f; //the pitch of the camera of the player
    float velocityY = 0.0f; //the vertical speed which the player moves at
    float Speed; //The horizontal speed which the player moves at
    CharacterController controller = null; //creating a new character controller
    Vector2 currentDir = Vector2.zero; //creating a vector on the x,y axis which grabs the players direction of travel
    Vector2 currentDirVelocity = Vector2.zero; //creating a vector which grabs teh current velocity in the direction the player is moving
    public Vector2 currentMouseDelta = Vector2.zero; //creating a vector which grabs the currently direction of travel of the cursor between two frames
    Vector2 currentMouseDeltaVelocity = Vector2.zero; //creating a vector which grabs the speed of the cursors velocity

    public GameObject StatsObject; //creating the gameobject which the Stats script will be connected to

    [HideInInspector]
    public Stats stat; //creating a script which can be referenced and allowing for the access of variables from the script

    void Start()
    {
        stat = StatsObject.GetComponent<Stats>(); //accessing the component script from the gameobject which the script is attatched to

        


        controller = GetComponent<CharacterController>(); //setting the character controller component as an abbreviation
        if(lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    void Update()
    {
        //referenced scripts
        UpdateMouseLook();
        UpdateMovement();
    }

    void UpdateMouseLook()
    {
        //Creating the mouse look function
        Vector2 targetMouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")); //getting the raw input of the mouse
        currentMouseDelta = Vector2.SmoothDamp(currentMouseDelta, targetMouseDelta, ref currentMouseDeltaVelocity, mouseSmoothTime); //smoothing out the CurrentMouseDelta to the TargetMouseDelta
        cameraPitch -= currentMouseDelta.y * mouseSensitivity; //changing the pitch of the camera by the Smoothed vertical mouse delta
        cameraPitch = Mathf.Clamp(cameraPitch, -90.0f, 90.0f); //Clamping the pitch of the camera between -90 form the horizon to +90 from the horizon
        playerCamera.localEulerAngles = Vector3.right * cameraPitch; //setting the rotation of the camera to the horizontal 
        transform.Rotate(Vector3.up * currentMouseDelta.x * mouseSensitivity); //rotate the camera by the horizontal mouse delta and multiply by the sensitivity
    }

    void UpdateMovement()
    {
        
        Speed = stat.Agility/500; //setting the speed of the player to the agility stats from the Stats script 
        Speed = Mathf.Clamp(Speed, 5.0f, 150.0f); //Clamping the speed to only allow a range between 5-150
        JumpStrength = ((stat.Agility/500)+(stat.Strength/100)); //setting the jumpstrength to the agility and strength from the Stats script
        JumpStrength = Mathf.Clamp(JumpStrength, 5, 50); //Clamping the jumpstrength to only allow a range between 5-50


        Vector2 targetDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); //grabbing the X keyboard input and the Y keyboard input
        targetDir.Normalize(); //keeps a vectors direction, but set the speed magnitude to 1
        currentDir = Vector2.SmoothDamp(currentDir, targetDir, ref currentDirVelocity, moveSmoothTime); //dampen the move speed
        if(controller.isGrounded && velocityY<0){ //check if the vertical velocity is less than zero, if it is less than zero, make it zero
            velocityY = 0.0f;
        }
        velocityY += gravity * Time.deltaTime; //creating a gravity effect by increasing the vertical velocity by the gravity of -9.81 overtime
        Vector3 velocity = (transform.forward * currentDir.y + transform.right * currentDir.x) * Speed + Vector3.up * velocityY; //transforming the 3 vectors by the horizontal inputs and the vertical inputs from the keyboard. X, Y, Z
        controller.Move(velocity * Time.deltaTime); //moving the player by the velocity vector above
        if(Input.GetKeyDown(JumpKey)&&controller.isGrounded){ //check if the player is touching the ground and if the jump button has been pressed
            velocityY += JumpStrength; //increase the vertical velocity by the jump strength
        }
    }
}