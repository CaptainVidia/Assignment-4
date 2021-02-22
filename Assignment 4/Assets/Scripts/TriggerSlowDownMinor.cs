using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TriggerSlowDownMinor : PlayerDecorator
{
    public PlayerTriggerZones playerTriggerZones;

    public TriggerSlowDownMinor(PlayerTriggerZones playerTriggerZones)
    {
        this.playerTriggerZones = playerTriggerZones;
    }

    public override float speed
    {
        get
        {
            return playerTriggerZones.speed - 5;
        }
        set
        {
            playerTriggerZones.speed = value;
        }
    }

    public override string triggerZones
    {
        get
        {
            return playerTriggerZones.triggerZones += ", SlowDownMinor";
        }
        set
        {
            playerTriggerZones.triggerZones = value;
        }
    }
}
