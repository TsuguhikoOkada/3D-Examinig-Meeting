using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomPanel : MonoBehaviour
{
    [SerializeField, Header("ZoomPanel")] GameObject _panel;

    [SerializeField] Transform _objParent;

    GameObject zoomObj;

    void Start()
    {
        _panel.SetActive(false);
    }

    public void ShowPanel()
    {
        Item item = ItemBox.instance.GetSelectedItem();

        if (item != null)
        {
            Destroy(zoomObj);

            _panel.SetActive(true);

            // アイテムを表示させる
            GameObject zoomObjPrefab = ItemGenerater.instance.GetZoomItem(item._type);
            zoomObj = Instantiate(zoomObjPrefab, _objParent);
            
        }
      
    }

    public void ClosePanel()
    {
        _panel.SetActive(false);
        Destroy(zoomObj);
    }
}
