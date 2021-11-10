using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public GameObject InventoryObject;
    public GameObject PauseMenuObject;
    public GameObject PlayerObject;
    public GameObject Cursor_Object;

    bool IsPaused = false;
    bool IsInv= false;
    bool Accessable = true;

    [SerializeField] KeyCode PauseKey;
    [SerializeField] KeyCode InventoryKey;

    [HideInInspector]
    public Player player;

    void Start(){
        player = PlayerObject.GetComponent<Player>();
    }

    void Update()
    {
        PauseCheck();
        OpenInventory();
        OpenPauseMenu();
    }

    void OpenInventory(){
        if (Input.GetKeyDown(InventoryKey)){
            if(Accessable){
                if (IsInv == true){ //Unpausing
                    IsInv = false;
                    InventoryObject.SetActive(false);
                    Cursor_Object.SetActive(true);
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                }
                else{ //Pausing
                        IsInv = true;
                        InventoryObject.SetActive(true);
                        Cursor_Object.SetActive(false);
                        Cursor.lockState = CursorLockMode.None;
                        Cursor.visible = true;
                }
            }
        }
    }

    void OpenPauseMenu(){
        if (Input.GetKeyDown(PauseKey)){
            if (IsPaused == true){ //Unpausing
                IsPaused = false;
                Accessable = true;
                PauseMenuObject.SetActive(false);
                Cursor_Object.SetActive(true);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                Time.timeScale = 1.0f;
            }

            else{ //Pausing
                Accessable = false;
                IsPaused = true;
                IsInv = false;
                InventoryObject.SetActive(false);
                PauseMenuObject.SetActive(true);
                Cursor_Object.SetActive(false);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Time.timeScale = 0.0f;
            }
        }
    }

    void PauseCheck(){
        if (IsPaused){
            player.currentMouseDelta.x = 0;
            player.currentMouseDelta.y = 0;
        }
        else{
            return;
        }
    }

    
}
