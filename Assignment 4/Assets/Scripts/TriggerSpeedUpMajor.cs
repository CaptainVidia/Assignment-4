/*George Tang
 * Assignment 4
 * TriggerSpeedUpMajor.cs
 * Speeds the player for a big amount. Display shows the player
 * enter a SpeedUpMajorTrigger.
*/
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
            return playerTriggerZones.speed + 110;
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
            return playerTriggerZones.triggerZones = "SpeedUpMajor - RACE ON!!";
        } set
        {
            playerTriggerZones.triggerZones = value;
        }
    }
    
}
