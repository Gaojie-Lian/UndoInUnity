using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Transform Camera;

    void Start()
    {
        TransformCommand cmd = new TransformCommand(Camera, Camera.localPosition,
            Camera.localEulerAngles, Camera.localScale);
        CommandManager.Instance.AddCommand(cmd);
        Debug.Log("Initialize Position");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            TransformCommand cmd = new TransformCommand(Camera, Camera.localPosition,
            Camera.localEulerAngles, Camera.localScale);
            CommandManager.Instance.AddCommand(cmd);
            Debug.Log("Set Position");
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            CommandManager.Instance.RemoveCommand();

            Debug.Log("Undo");
        }
    }
}