using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    Animator anim;
    int runHash = Animator.StringToHash("Run");
    int runStateHash = Animator.StringToHash("Base Layer.Run");


    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", move);

        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
        if (Input.GetKeyDown(KeyCode.A) && stateInfo.nameHash== runStateHash)
        {
            anim.SetTrigger(runHash);
        }
    }
}
