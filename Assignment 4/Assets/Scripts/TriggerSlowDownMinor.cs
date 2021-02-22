/*George Tang
 * Assignment 4
 * TriggerSpeedUpMinor.cs
 * Speeds the player for a little amount. Display shows the player
 * enter a SlowDownMinorTrigger.
*/
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
            return playerTriggerZones.speed - 15;
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
            return playerTriggerZones.triggerZones = "SlowDownMinor Woah Slow Down! Watch Out for Meatballs!!";
        }
        set
        {
            playerTriggerZones.triggerZones = value;
        }
    }
}
