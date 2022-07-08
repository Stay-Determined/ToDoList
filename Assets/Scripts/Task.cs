using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task : MonoBehaviour
{
    public GameObject task;
    public int multiplier = 0;
    private string inputText;

    public void textInput(string taskName)
    {
        inputText = taskName;
        Debug.Log(inputText);
    }

    public void addTask()
    {
        Text taskText = transform.Find("TaskText").GetComponent<Text>();
        taskText.text = inputText;
        Debug.Log(inputText);

        Vector3 yAxis = new Vector3(transform.position.x, transform.position.y + multiplier, transform.position.z);
            GameObject newTask = Instantiate(task, yAxis, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
            if (newTask.activeSelf == false)
            {
                newTask.SetActive(true);
            }
            multiplier -= 50;
    }
}
