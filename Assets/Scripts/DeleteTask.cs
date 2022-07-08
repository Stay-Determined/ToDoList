using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteTask : MonoBehaviour
{
    public GameObject task;
    public void deleteTask()
    {
        if(task.activeSelf == true)
        {   
            Destroy(task);
        }
    }
}
