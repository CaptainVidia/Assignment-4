/*George Tang
 * Assignment 4
 * Player.cs
 * Controls the player movement, Calls OnTriggerEnter, AddPlayerDecorator, updatesText
 * A press R for reset has been implemented
*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

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
            case TriggerZone.TriggerZoneType.SLOWDOWNMAJOR:
                playerTriggerZones = new TriggerSlowDownMajor(playerTriggerZones);
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

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void Move()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * playerTriggerZones.speed);
    }
    
}
