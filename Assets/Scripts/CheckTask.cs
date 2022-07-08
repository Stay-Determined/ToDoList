using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//add
public class CheckTask : MonoBehaviour
{
    public Button deleteButton;
    
    public void clickCheck()
    {
        if(deleteButton.interactable == true)
        {
            deleteButton.interactable = false;

        }
        else if(deleteButton.interactable == false)
        {
            deleteButton.interactable = true;

        }
    } 
}
