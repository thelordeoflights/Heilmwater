using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Yarn;
using Yarn.Unity;

public class TriggerDialogues : MonoBehaviour
{
    public DialogueRunner dg;
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Protagnist")
        {
            dg.StartDialogue("Dialogues");
        }
    }
    // void OnColl(Collider other)
    // {
    // }// public UnityEvent OnTriggerExit;




}
