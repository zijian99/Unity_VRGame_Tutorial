using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDummy : MonoBehaviour
{
    [SerializeField] private Animator dummyAnimator;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Weapon"))
        {
            Debug.Log("I've been hit");
            dummyAnimator.SetTrigger("Death");
            GetComponent<BoxCollider>().enabled = false;
        }
    }

    public void ActivateDummy()
    {
        dummyAnimator.SetTrigger("Activate");
    }
}
