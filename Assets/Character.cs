using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] float Speed;

    public void MoveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)rb.position + direction * Speed * Time.fixedDeltaTime);
    }
}
