using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform target;

    public float cameraWidth;
    public float cameraHeight;

    public float smoothSpeed;
    public Vector3 offset;


    private void LateUpdate()
    {
        Vector3 targetPoint = Camera.main.ScreenToWorldPoint(target.position);
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;

        if (targetPoint.x <= screenWidth/2 - cameraWidth / 2 || targetPoint.z <= screenHeight/2 - cameraHeight/2)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }


    }


}

