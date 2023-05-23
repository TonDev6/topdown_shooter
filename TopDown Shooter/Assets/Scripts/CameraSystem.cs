using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    public Transform playerSprite;
    public Vector2 maxLim;
    public Vector2 minLim;

    private void LateUpdate() 
    {
        if (playerSprite != null)
        {
            Vector3 newPosition = new Vector3(
                Mathf.Clamp(playerSprite.position.x, minLim.x, maxLim.x),
                Mathf.Clamp(playerSprite.position.y, minLim.y, maxLim.y),
                transform.position.z
            );

            transform.position = newPosition;
        }
    }
}
