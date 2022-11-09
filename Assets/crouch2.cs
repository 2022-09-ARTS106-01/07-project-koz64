using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crouch2 : MonoBehaviour
{
    public CharacterController PlayerHeight;
    public float normalHeight, crouchHeight;
    public bool invent = false;

    void Update () {
        if(Input.GetKeyDown(KeyCode.LeftControl)){
            PlayerHeight.height = crouchHeight;
        }
        if(Input.GetKeyUp(KeyCode.LeftControl)&&!(invent)){
            PlayerHeight.height = normalHeight;
        }
    }   

    public void OnTriggerStay(Collider other){
        if (other.gameObject.CompareTag("Vent")){
            invent = true;
        }
    }

public void OnTriggerExit(Collider other){
        if (other.gameObject.CompareTag("Vent")){
            invent = false;
        }    
    }

}
