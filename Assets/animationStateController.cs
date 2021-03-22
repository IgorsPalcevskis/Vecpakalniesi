using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int isRunningHash;
    int isWalkingBackHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        isWalkingBackHash = Animator.StringToHash("isWalkingBack");
    //    Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalkingBack = animator.GetBool(isWalkingBackHash);
        bool forwardPress = Input.GetKey("w");
        bool runPress = Input.GetKey("left shift");
        bool walkBackPress = Input.GetKey("s");
        // if player presses w key
        if (!isWalking && forwardPress)
        {
            // then set the isWalking boolean to true
            animator.SetBool(isWalkingHash, true);
        }
        // if player releases w key
        if (isWalking && !forwardPress)
        {
            // then set the isWalking boolean to false
            animator.SetBool(isWalkingHash, false);
        }
        // if player is walking and pressing left shift
        if (forwardPress && runPress)
        {
            // then set the isRunning boolean to true
            animator.SetBool(isRunningHash, true);
        }
        // if player stops running and walking
        if (!forwardPress || !runPress)
        {
            // then set the isRunning boolean to false
            animator.SetBool(isRunningHash, false);
        }
        // player presses s key
        if (!isWalkingBack && walkBackPress)
        {
            // then set the isWalking boolean to true
            animator.SetBool(isWalkingBackHash, true);
        }
        // player releases s key
        if (isWalkingBack && !walkBackPress)
        {
            // then set the isWalking boolean to true
            animator.SetBool(isWalkingBackHash, false);
        }
    }
}
