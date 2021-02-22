//player powerups
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerTriggerZones
{
    [field: SerializeField] public virtual float speed { set; get; } = 40f;
    [field: SerializeField] public virtual string triggerZones { set; get; } = "";
}
