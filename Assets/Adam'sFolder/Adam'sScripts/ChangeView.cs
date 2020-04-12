using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeView : MonoBehaviour
{
    public SpriteRenderer opacity;
    public PlayerInput playerInput;
    [SerializeField] float Alpha = 0f;


    void Start()
    {
        playerInput.ChangeForeground += SetOpacity;
        opacity.color = new Color(opacity.color.r, opacity.color.g, opacity.color.b, Alpha);
    }

    private void SetOpacity()
    {
        if (opacity.color.a == 0)
        {
            Alpha = 1;
            opacity.color = new Color(opacity.color.r, opacity.color.g, opacity.color.b, Alpha);
        }
        else
        {
            Alpha = 0;
            opacity.color = new Color(opacity.color.r, opacity.color.g, opacity.color.b, Alpha);
        }
    }    
}
