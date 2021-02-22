using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TriggerSpeedUpMinor : PlayerDecorator
{
    public PlayerTriggerZones playerTriggerZones;

    public TriggerSpeedUpMinor(PlayerTriggerZones playerTriggerZones)
    {
        this.playerTriggerZones = playerTriggerZones;
    }

    public override float speed
    {
        get
        {
            return playerTriggerZones.speed + 5;
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
            return playerTriggerZones.triggerZones += ", SpeedUpMinor";
        }
        set
        {
            playerTriggerZones.triggerZones = value;
        }
    }
}
