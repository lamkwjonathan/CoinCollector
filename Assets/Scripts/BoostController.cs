using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoostController : MonoBehaviour
{
    // Implements a temporary speed boost with a cooldown
    // Boost can only be reactivated after the cooldown
    public GameObject player;
    public Button boostButton;
    public int BoostSpeed;
    public float BoostDuration; 
    private bool isBoostActive = false;
    private float boostTimeLeft;
    public float BoostCooldown;
    private bool isBoostCooldown = false;
    private float boostCooldownLeft;
    private float originalSpeed;
    
    public void OnButtonPressed()
    {
        if (!isBoostCooldown)
        {
            if (!isBoostActive)
            {
                originalSpeed = player.GetComponent<TouchMovement>().speed;
                player.GetComponent<TouchMovement>().speed = BoostSpeed;
                boostTimeLeft = BoostDuration;
                boostCooldownLeft = BoostCooldown;
                isBoostActive = true;
                boostButton.interactable = false;
                //Debug.Log("BOOST STARTED");
            }
        }
    }

    void Update()
    {
        if (isBoostActive)
        {
            boostTimeLeft -= Time.deltaTime;
            if (boostTimeLeft < 0)
            {
                isBoostActive = false;
                isBoostCooldown = true;
                boostTimeLeft = BoostDuration;
                player.GetComponent<TouchMovement>().speed = originalSpeed;
                //Debug.Log("BOOST ENDED");
                //Debug.Log("BOOST COOLDOWN");
            }
        }

        if (isBoostCooldown)
        {
            boostCooldownLeft -= Time.deltaTime;
            if (boostCooldownLeft < 0)
            {
                isBoostCooldown = false;
                boostCooldownLeft = BoostCooldown;
                boostButton.interactable = true;
                //Debug.Log("BOOST COOLDOWN ENDED");
            }
        }
    }

}
