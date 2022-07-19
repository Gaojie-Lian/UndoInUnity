using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandManager : MonoBehaviour
{
    public static CommandManager Instance;
    private List<BaseCommand> CommandSet;

    private void Awake()
    {
        Instance = this;
    }

    public CommandManager()
    {
        CommandSet = new List<BaseCommand>();
    }

    public void AddCommand(BaseCommand baseCommand)
    {
        CommandSet.Add(baseCommand);
        baseCommand.ExecuteCommand();
    }

    public void RemoveCommand()
    {
        if (CommandSet.Count > 0)
        {
            BaseCommand baseCommand = CommandSet[CommandSet.Count - 1];
            CommandSet.Remove(baseCommand);
            baseCommand.RevocationCommand();
        }
    }
}