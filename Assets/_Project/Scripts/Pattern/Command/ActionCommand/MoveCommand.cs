using System;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class MoveCommand : ActionCommand
{
    public MoveCommand(IEntityTurn entityTurn) : base(entityTurn)
    {
    }

    public override async Task ExeciteAsync()
    {
        Debug.Log("Move");
    }

}