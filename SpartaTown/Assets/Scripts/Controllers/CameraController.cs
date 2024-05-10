using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject character;

    private float posX = 0f;
    private float posY = 0f;
    private float posZ = 0f;

    private Vector3 cameraPos;

    private void FixedUpdate()
    {
        cameraPos = new Vector3 (character.transform.position.x + posX, character.transform.position.y + posY, transform.position.z);
        transform.position = cameraPos;
    }
}