using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    //creating GameObjects for the script to use
    public GameObject InventoryObject;
    public GameObject PauseMenuObject;
    public GameObject PlayerObject;
    public GameObject Cursor_Object;

    //Creating bools to allow for pausing/Unpausing and determining states
    bool IsPaused = false;
    bool IsInv= false;
    bool Accessable = true;

    //SerializeField allows for a variable to show in the Unity inspector without having to set it as public
    //Keycodes allow for the selection of keys from the keyboard
    [SerializeField] KeyCode PauseKey;
    [SerializeField] KeyCode InventoryKey;

    //HideInInspector does the opposite of Serialize Field
    [HideInInspector]
    public Player player; //creating a script which can be referenced and allowing for the access of variables from the script

    void Start(){
        player = PlayerObject.GetComponent<Player>(); //accessing the component script from the gameobject which the script is attatched to
    }

    void Update()
    {
        //referencing functions
        PauseCheck();
        OpenInventory();
        OpenPauseMenu();
    }

    void OpenInventory(){
        if (Input.GetKeyDown(InventoryKey)){ //Accessing the inventory through the inventory button
            if(Accessable){ //check if the inventory is accessable
                if (IsInv == true){ //Unpause if the inventory is already open
                    IsInv = false; //set the inventory as closed
                    InventoryObject.SetActive(false); //disable the inventory screen
                    Cursor_Object.SetActive(true); //re-enable the Custom cursor
                    Cursor.lockState = CursorLockMode.Locked; //lock the cursor
                    Cursor.visible = false; //turn the cursor invisible
                }
                else{ //if the inventory is already closed, open it
                        IsInv = true; //set the inventory as open
                        InventoryObject.SetActive(true); //enable the inventory screen
                        Cursor_Object.SetActive(false); //Disable the custom cursor
                        Cursor.lockState = CursorLockMode.None; //unlock the cursor
                        Cursor.visible = true; //make the cursor visible
                }
            }
        }
    }

    void OpenPauseMenu(){
        if (Input.GetKeyDown(PauseKey)){ //accesing the pause menu using the pasue button
            if (IsPaused == true){ //Unpause if already paused
                IsPaused = false; //set pasued as false
                Accessable = true; //set accessable as true
                PauseMenuObject.SetActive(false); //disable pause menu screen
                Cursor_Object.SetActive(true); //enable the custom cursor
                Cursor.lockState = CursorLockMode.Locked; //lock the cursor
                Cursor.visible = false; //set the cursor invisible
                Time.timeScale = 1.0f; //run unity time scale as 1:1
            }

            else{ //Pause if Unpaused
                Accessable = false; //set accessable as false
                IsPaused = true; //set paused as true
                IsInv = false; //set the inventory as closed
                InventoryObject.SetActive(false); //disable the inventory screen is it is open
                PauseMenuObject.SetActive(true); //enable the pause menu screen
                Cursor_Object.SetActive(false); //disable  the custom cursor
                Cursor.lockState = CursorLockMode.None; //unlock the cursor
                Cursor.visible = true; //set the cursor as visible
                Time.timeScale = 0.0f; //set the unity timescale to 0:1, effectivly stopping everything in the game.
            }
        }
    }

    void PauseCheck(){
        if (IsPaused){ //if the game is paused
            player.currentMouseDelta.x = 0; //set the mouse input to zero so that youcan turn around in the pause menu
            player.currentMouseDelta.y = 0;
        }
        else{
            return;
        }
    }

    
}
