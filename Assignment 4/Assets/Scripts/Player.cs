//player
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public PlayerTriggerZones playerTriggerZones;
    public DisplayText displayText;


    private void Start()
    {
        UpdateDisplayText();
    }
    private void Awake()
    {
        playerTriggerZones = new PlayerTriggerZones();
    }

    private void OnTriggerEnter(Collider other)
    {
        TriggerZone triggerZone = other.gameObject.GetComponent<TriggerZone>();
        if (triggerZone != null)
        {
            AddPlayerDecorator(triggerZone);
        }
    }

    private void AddPlayerDecorator(TriggerZone triggerZone)
    {
        switch (triggerZone.triggerZoneType)
        {
            case TriggerZone.TriggerZoneType.SPEEDUPMAJOR:
                playerTriggerZones = new TriggerSpeedUpMajor(playerTriggerZones);
                break;
            case TriggerZone.TriggerZoneType.SPEEDUPMINOR:
                playerTriggerZones = new TriggerSpeedUpMinor(playerTriggerZones);
                break;
            case TriggerZone.TriggerZoneType.SLOWDOWNMINOR:
                playerTriggerZones = new TriggerSlowDownMinor(playerTriggerZones);
                break;
            default:
                break;
        }
        UpdateDisplayText();
    }

    public void UpdateDisplayText()
    {
        displayText.Display(playerTriggerZones);
    }
    private float horizontalInput;
    private float verticalInput;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * playerTriggerZones.speed);
    }

}
