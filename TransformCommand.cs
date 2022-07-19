using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformCommand : BaseCommand
{
    private Transform target;
    private Vector3 pos;
    private Vector3 rota;
    private Vector3 scale;

    public TransformCommand(Transform target, Vector3 pos, Vector3 rota, Vector3 scale)
    {
        this.target = target;
        this.pos = pos;
        this.rota = rota;
        this.scale = scale;
    }

    public override void ExecuteCommand()
    {
        base.ExecuteCommand();
    }

    public override void RevocationCommand()
    {
        target.transform.localPosition = pos;
        target.transform.localEulerAngles = rota;
        target.transform.localScale = scale;
    }
}