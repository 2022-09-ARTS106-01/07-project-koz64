using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchScript : MonoBehaviour
{
    CharacterController playerCol;
    float originalHeight;
    public float reducedHeight;
    Vector3 originalCamHeight=new Vector3 (0f,0.8f,0f);
    Vector3 crouchcamheight=Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        playerCol = GetComponent<CharacterController>();
        originalHeight = playerCol.height;
    }

    // Update is called once per frame
    void Update()
    {
        //Crouch
        if (Input.GetKeyDown(KeyCode.LeftControl))
        Crouch();
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        GoUp();
    }

    //Method to reduce height;
    void Crouch()
    {
        playerCol.height = reducedHeight;
        Camera.main.transform.position=crouchcamheight;
    }

    //Method to reset height;
    void GoUp()
    {
        playerCol.height = originalHeight;
        Camera.main.transform.position=originalCamHeight;
    }
}
