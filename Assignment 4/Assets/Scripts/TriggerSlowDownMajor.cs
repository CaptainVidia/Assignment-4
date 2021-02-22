/*George Tang
 * Assignment 4
 * TriggerSlowDownMajor.cs
 * Speeds the player for a little amount. Display shows the player
 * enter a SpeedUpMinorTrigger.
*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TriggerSlowDownMajor : PlayerDecorator
{
    public PlayerTriggerZones playerTriggerZones;

    public TriggerSlowDownMajor(PlayerTriggerZones playerTriggerZones)
    {
        this.playerTriggerZones = playerTriggerZones;
    }

    public override float speed
    {
        get
        {
            return playerTriggerZones.speed = 0;
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
            return playerTriggerZones.triggerZones = "SlowDownMajor! Race Complete!! You Win!!";
        }
        set
        {
            playerTriggerZones.triggerZones = value;
        }
    }
}
