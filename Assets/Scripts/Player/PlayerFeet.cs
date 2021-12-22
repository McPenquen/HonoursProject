using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFeet : MonoBehaviour
{
    // Reference to the player
    [SerializeField] private Player player = null;
    // Is touching ground or an object
    private bool isGrounded = false;

    private void OnCollisionEnter(Collision col)
    {
        // If the player touches the environment let the player know they are can jump
        if (col.gameObject.layer == 15 && !isGrounded)
        {
            isGrounded = true;
            player.SetCanJump(isGrounded);
        }
    }

    private void OnCollisionExit(Collision col)
    {
        // If the player stop touching the environment let the player know they are can't jump
        if (col.gameObject.layer == 15 && isGrounded )
        {
            isGrounded = false;
            player.SetCanJump(isGrounded);
        }
    }
}
