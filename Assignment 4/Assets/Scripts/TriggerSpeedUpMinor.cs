/*George Tang
 * Assignment 4
 * TriggerSpeedUpMinor.cs
 * Speeds the player for a little amount. Display shows the player
 * enter a SpeedUpMinorTrigger.
*/
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
            return playerTriggerZones.speed + 10;
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
            return playerTriggerZones.triggerZones = "SpeedUpMinor! Let's Build that Speed!!";
        }
        set
        {
            playerTriggerZones.triggerZones = value;
        }
    }
}
