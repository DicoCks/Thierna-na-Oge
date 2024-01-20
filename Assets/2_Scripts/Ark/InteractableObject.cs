using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    // NPC, 보스몹에 넣고 플레이어가 가까이 다가가면 상호작용할 수 있는 기능
    [SerializeField] private GameObject interactObject;

    public void SetInteractable(bool isInteractable)
    {
        interactObject.SetActive(isInteractable);
    }
}
