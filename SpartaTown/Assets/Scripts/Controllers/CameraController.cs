using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Camera camera;
    private float posX = 0f;
    private float posY = 0f;

    private Vector3 cameraPos;
    private CharacterController characterController;

    private void Awake()
    {
        camera = Camera.main;
        characterController = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        GameObject playerObj = characterController.Character[(int)GameManager.Instance.playerSO.job];
        cameraPos = new Vector3 (playerObj.transform.position.x + posX, playerObj.transform.position.y + posY, camera.transform.position.z);
        camera.transform.position = cameraPos;
    }
}