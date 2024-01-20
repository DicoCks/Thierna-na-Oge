using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;

    private bool isInteractable = false;
    
#region Unity Action

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("InteractableObject"))
        {
            isInteractable = true;
        }
          
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("InteractableObject"))
        {
            isInteractable = true;
        }
    }

#endregion

    private void Interact()
    {
        if (isInteractable)
        {
            // 대화 띄우기
            Debug.Log("대화 시스템");
        }
    }
    

    private void SetMovementActive(bool isActive)
    {
        _playerMovement.enabled = isActive;
    }
}
