using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EllenController : MonoBehaviour
{
    [SerializeField] private Animator _ellenAnimator;

    private void Update()
    {
        float horizontalMove = Input.GetAxisRaw("Horizontal");

        if(horizontalMove != 0)
        {
            _ellenAnimator.SetBool("isRunning", true);
        }
        else
        {
            _ellenAnimator.SetBool("isRunning", false);
        }
    }
}
