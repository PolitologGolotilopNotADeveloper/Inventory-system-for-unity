using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] private GameObject cellPref;
    [SerializeField] private Transform InventoryPanel;
    [SerializeField] private int size = 20;

    private List<InventoryCell> cells = new List<InventoryCell>();
    private int itemsInside = 0;

    private void Start() {
        AddCellsToInventory();
    }

    public void AddItem(Resourse resourse){
        if(itemsInside<size){
            foreach(InventoryCell cell in cells){
                if(cell.storedItem is not null){
                    if(cell.storedItem.name==resourse.name && cell.storedItem.count<cell.storedItem.maxCount){
                        Resourse resourseInside = cell.storedItem;
                        if(resourseInside.count+resourse.count<=resourseInside.maxCount){
                            resourseInside.count+=resourse.count;
                        }
                        else{
                            resourse.count=resourseInside.count+resourse.count-resourse.maxCount;
                            resourseInside.count=resourseInside.maxCount;
                            if(resourse.count>0){
                                AddItem(resourse);
                            }
                        }
                        cell.Put(resourseInside);
                        break;
                    }
                }
                else{
                    cell.Put(resourse);
                    break;
                    }
                }
                itemsInside+=1;
            }
        }

    private void AddCellsToInventory(){
        for(int i = 0; i<size; i++){
            GameObject temp = Instantiate(cellPref, new Vector2(0,0), Quaternion.identity);
            temp.transform.SetParent(InventoryPanel, false);
            cells.Add(temp.GetComponent<InventoryCell>());
        }
    }
}
