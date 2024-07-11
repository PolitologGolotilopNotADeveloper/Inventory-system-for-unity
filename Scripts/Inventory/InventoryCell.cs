using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryCell : MonoBehaviour
{
    public Resourse storedItem;
    private Image cellImage;
    private Text itemCount;

    private void Awake() {
        cellImage = transform.Find("ItemIcon").gameObject.GetComponent<Image>();
        itemCount = transform.Find("ItemCount").gameObject.GetComponent<Text>();
    }

    public void Put(Resourse resourse){
        storedItem = resourse;
        cellImage.sprite = resourse.sprite;
        itemCount.text = resourse.count.ToString();
    }
}
