using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{
    [SerializeField] Transform playerCamera = null;
    [SerializeField][Range(0.0f, 5.0f)] float mouseSensitivity = 3.5f;
    [SerializeField][Range(0.0f, 0.5f)] float moveSmoothTime = 0.3f;
    [SerializeField][Range(0.0f, 0.5f)] float mouseSmoothTime = 0.03f;    
<<<<<<< HEAD
    [SerializeField] float gravity = 13.0f;
=======
    [SerializeField] float gravity = -13.0f;
>>>>>>> parent of cf5acea (Commented ButtonHandler and Player)
    public float JumpStrength;
    [SerializeField] bool lockCursor = true;
    [SerializeField] KeyCode JumpKey;

    float cameraPitch = 0.0f;
    float velocityY = 0.0f;
    float Speed;
    CharacterController controller = null;
    Vector2 currentDir = Vector2.zero;
    Vector2 currentDirVelocity = Vector2.zero;
    public Vector2 currentMouseDelta = Vector2.zero;
    Vector2 currentMouseDeltaVelocity = Vector2.zero;

    public GameObject StatsObject;

    [HideInInspector]
    public Stats stat;

    void Start()
    {
        stat = StatsObject.GetComponent<Stats>();

        Speed = stat.Agility;
        Speed = Mathf.Clamp(Speed, 5.0f, 150.0f);
        JumpStrength = Mathf.Clamp(JumpStrength, 5, 50);
        JumpStrength = ((stat.Agility/500)+(stat.Strength/100));


        controller = GetComponent<CharacterController>();
        if(lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    void Update()
    {
        UpdateMouseLook();
        UpdateMovement();
    }

    void UpdateMouseLook()
    {
        Vector2 targetMouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        currentMouseDelta = Vector2.SmoothDamp(currentMouseDelta, targetMouseDelta, ref currentMouseDeltaVelocity, mouseSmoothTime);
        cameraPitch -= currentMouseDelta.y * mouseSensitivity;
        cameraPitch = Mathf.Clamp(cameraPitch, -90.0f, 90.0f);
        playerCamera.localEulerAngles = Vector3.right * cameraPitch;
        transform.Rotate(Vector3.up * currentMouseDelta.x * mouseSensitivity);
    }

    void UpdateMovement()
    {
        
        Speed = (stat.Agility/500);
        Speed = Mathf.Clamp(Speed, 5, 150);
        
        JumpStrength = ((stat.Agility/500)+(stat.Strength/100));
        JumpStrength = Mathf.Clamp(JumpStrength, 5, 50);


        Vector2 targetDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        targetDir.Normalize();
        currentDir = Vector2.SmoothDamp(currentDir, targetDir, ref currentDirVelocity, moveSmoothTime);
        if(controller.isGrounded && velocityY<0){
            velocityY = 0.0f;
        }
        velocityY += gravity * Time.deltaTime;
        Vector3 velocity = (transform.forward * currentDir.y + transform.right * currentDir.x) * Speed + Vector3.up * velocityY;
        controller.Move(velocity * Time.deltaTime);
        if(Input.GetKeyDown(JumpKey)&&controller.isGrounded){
            velocityY += JumpStrength;
        }
    }
}