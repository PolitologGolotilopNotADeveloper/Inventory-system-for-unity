using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Inventory inventory;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.TryGetComponent<Resourse>(out Resourse resourse)){
            inventory.AddItem(resourse.Take());
        }
    }
}
