using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Fusion;

public class CharacterMovementHandler : NetworkBehaviour
{
    NetworkCharacterControllerPrototypeCustom netChaConCustom;


    private void Awake()
    {
        netChaConCustom = GetComponent<NetworkCharacterControllerPrototypeCustom>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void FixedUpdateNetwork()
    {
        if(GetInput(out NetworkInputData networkInputData))
        {
            // move
            Vector3 moveDirection = transform.forward * networkInputData.movementInput.y + transform.right * networkInputData.movementInput.x;
            moveDirection.Normalize();

            netChaConCustom.Move(moveDirection);



        }
    }
}
