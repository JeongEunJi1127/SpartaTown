using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Camera camera;
    private float posX = 0f;
    private float posY = 0f;

    private Vector3 cameraPos;

    private void Awake()
    {
        camera = Camera.main;
    }

    private void FixedUpdate()
    {
        GameObject playerObj = GameManager.Instance.player.GetComponent<CharacterUI>().Character[(int)GameManager.Instance.playerSO.job];
        cameraPos = new Vector3 (playerObj.transform.position.x + posX, playerObj.transform.position.y + posY, camera.transform.position.z);
        camera.transform.position = cameraPos;
    }
}