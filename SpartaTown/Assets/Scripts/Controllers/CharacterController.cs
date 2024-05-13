using System.Collections;
using System.Collections.Generic;
using Unity.Jobs;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] public GameObject[] Character;

    private void Awake()
    {
        EnableCharacter();
    }

    public void EnableCharacter()
    {
        Character[(int)GameManager.Instance.playerSO.job].SetActive(true);
    }
}
