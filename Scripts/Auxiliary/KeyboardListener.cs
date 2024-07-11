using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class KeyboardListener : MonoBehaviour
{
    [SerializeField] private UIManager UIManager;
    [SerializeField] private Canvas InventoryCanvas;

    private void Update(){
        if(Input.GetKeyDown(KeyCode.E))
        {
            UIManager.SwitchActiveCanvas(InventoryCanvas);
        }
}
}
