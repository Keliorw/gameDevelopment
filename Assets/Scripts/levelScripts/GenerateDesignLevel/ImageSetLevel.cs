using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageSetLevel : MonoBehaviour
{
    [SerializeField] private GameObject ObjectDesignLocation;
    public Sprite[] ImageList = new Sprite[10];

    //Для кеширования
    private Dictionary<string, Transform> ListChild = new Dictionary<string, Transform>();

    void Start(){
        Transform[] AllChild = this.ObjectDesignLocation.GetComponentsInChildren<Transform>();
        foreach (var Child in AllChild){
            this.ListChild.Add(Child.name, Child);
            SpriteRenderer Image = Child.GetComponent<SpriteRenderer>();
            switch(Child.name){
                case "backGroundLevel":
                    Image.sprite = this.ImageList[0];
                    break;
                case "BarracksPlayer":
                    Image.sprite = this.ImageList[1];
                    break;
                case "GoldMinePlayer":
                    Image.sprite = this.ImageList[2];
                    break;
                default:
                    break;
            }
        }
        Debug.Log(ListChild);
    }
}
