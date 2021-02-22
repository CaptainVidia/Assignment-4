using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TriggerSpeedUpMajor : PlayerDecorator
{
    public PlayerTriggerZones playerTriggerZones;

    public TriggerSpeedUpMajor(PlayerTriggerZones playerTriggerZones)
    {
        this.playerTriggerZones = playerTriggerZones;
    }

    public override float speed
    {
        get
        {
            return playerTriggerZones.speed + 7;
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
            return playerTriggerZones.triggerZones += ", SpeedUpMajor";
        } set
        {
            playerTriggerZones.triggerZones = value;
        }
    }
    
}
