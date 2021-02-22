//player decorator
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class PlayerDecorator : PlayerTriggerZones
{
    public override abstract float speed { get; set; }
    public override abstract string triggerZones { get; set; }
}
