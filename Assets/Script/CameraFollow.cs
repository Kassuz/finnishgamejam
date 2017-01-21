using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float upperLimitX, lowerLimitX;
    [SerializeField] private float upperLimitY, lowerLimitY;

    private void LateUpdate()
    {
        if (playerTransform != null)
            transform.position = CalculatePosition();
    }

    private Vector3 CalculatePosition()
    {
        float posx = Mathf.Clamp(playerTransform.position.x, lowerLimitX, upperLimitX);
        float posy = Mathf.Clamp(playerTransform.position.y, lowerLimitY, upperLimitY);
        Vector3 pos = new Vector3(posx, posy, -10);

        return pos;
    }
}
