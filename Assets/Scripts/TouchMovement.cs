using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TouchMovement : MonoBehaviour
{
    // Transform based player movement using joystick with swipes on the right side of the screen controlling camara view direction
    public GameObject player;
    public float speed;
    public Joystick move_joystick;
    public float rotate_speed;
    public Joystick rotate_joystick;

    // Update is called once per frame
    void Update()
    {
        float theta =  -player.transform.rotation.eulerAngles.y / 360f * 2 * Mathf.PI;
        float xprime = move_joystick.Horizontal * Mathf.Cos(theta) - move_joystick.Vertical * Mathf.Sin(theta); // Joystick x position corrected for current rotation
        float yprime = move_joystick.Vertical * Mathf.Cos(theta) + move_joystick.Horizontal * Mathf.Sin(theta); // Joystick y position corrected for current rotation
        Vector2 direction = new Vector2(xprime, yprime);
        Vector2 velocity = direction * speed * Time.deltaTime;
        player.transform.position += new Vector3(velocity[0], 0, velocity[1]);
        float rotate_amount = rotate_joystick.Horizontal * rotate_speed * Time.deltaTime;
        player.transform.RotateAround(player.transform.position, new Vector3(0, 1, 0), rotate_amount);
    }
}
