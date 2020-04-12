using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float Horizontal { get; private set; }
    public float Vertical { get; private set; }
    public bool Jumping { get; private set; }

    public event Action OnJump;
<<<<<<< HEAD:Assets/PlayerInput.cs

   // public event Action ChangeForeground;
=======
>>>>>>> feed50c46aab1d5e9b9e3a2ef16b4dcb8a35ddfb:Assets/Scripts/Character/PlayerInput.cs

    private void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        Jumping = Input.GetKey(KeyCode.Space);

        if(Jumping && OnJump != null)
        {
            OnJump();
        }

       // if (Input.GetKeyDown(KeyCode.E))
       // {
       //     ChangeForeground();
       // }
        
    }
}
