using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimation : MonoBehaviour
{
    //Rmb to link this to the XR controller SelectValue function in Unity(Can refer to Controller action map to see which button has what)
    [SerializeField] private InputActionReference gripReference;
    [SerializeField] private InputActionReference triggerReference;
    //Rmb to link this to the Animator of this Prefab assets
    //(drag the animator at the component tab to the script sub tab) in Unity
    [SerializeField] private Animator handAnimator;

    // Start is called before the first frame update
    void Start()
    {
        //Get the grip value from the controller
        float gripValue = gripReference.action.ReadValue<float>();
        Debug.Log(gripValue);

        //To perform animation of the grippping when there is grip value
        handAnimator.SetFloat("Grip", gripValue);

       // float triggerValue = triggerReference.action.ReadValue<float>();
       // Debug.Log(triggerValue);

        //handAnimator.SetFloat("Trigger", triggerValue);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
