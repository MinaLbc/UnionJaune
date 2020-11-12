using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform target;

    public float cameraWidth;
    public float cameraHeight;

    public float smoothSpeed;
    public Vector3 offset;
    public float cameraOffset;


    private void LateUpdate()
    {
        Vector3 targetPoint = Camera.main.WorldToScreenPoint(target.position);
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;

        float c_width = screenWidth * cameraWidth;
        float c_height = screenHeight * cameraHeight;
        float c_offset = screenHeight * cameraOffset;

        if (targetPoint.x >= screenWidth/2 - c_width / 2 && targetPoint.x <= screenWidth / 2 + c_width / 2 && targetPoint.y >= screenHeight/2 - c_offset - c_height / 2 && targetPoint.y <= screenHeight / 2 - c_offset  + c_height / 2)
        {

        }
        else
        {
            Debug.Log(c_width);
            Debug.Log(targetPoint);
            Debug.Log(screenWidth);
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }


    }


}

