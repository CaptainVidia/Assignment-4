//pickup
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TriggerZone : MonoBehaviour
{
    public enum TriggerZoneType {SLOWDOWNMINOR, SPEEDUPMAJOR, SPEEDUPMINOR, SLOWDOWNMAJOR}
    public TriggerZoneType triggerZoneType;
    
}
