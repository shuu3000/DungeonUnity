using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dungeonManager : MonoBehaviour
{
    //マップチップのプレハブ   
    [SerializeField]
    private GameObject _mapParts = null;
    
    //親オブジェクト
    [SerializeField]
    private Transform _parent = null;
    
    //マップチップスプライト
    [SerializeField]
    private List<Sprite> _mapChipSprites = new List<Sprite>();
    private List<List<List<int>>> _mapData = new List<List<List<int>>>()
   {
        new List<List<int>>

     {
        new List<int>(){1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,},
        new List<int>(){1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,},
        new List<int>(){1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,},
        new List<int>(){1,0,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,0,1,},
        new List<int>(){1,0,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,0,1,},
        new List<int>(){1,0,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,0,1,},
        new List<int>(){1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,},
        new List<int>(){1,0,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,0,1,},
        new List<int>(){1,0,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,0,1,},
        new List<int>(){1,0,1,1,1,1,1,1,1,2,1,1,1,1,1,1,1,1,0,1,},
        new List<int>(){1,0,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,0,1,},
        new List<int>(){1,0,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,0,1,},
        new List<int>(){1,0,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,0,1,},
        new List<int>(){1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,},
        new List<int>(){1,1,1,1,0,1,1,1,1,0,1,1,1,1,0,1,1,1,0,1,},
        new List<int>(){1,1,1,1,0,1,1,1,1,0,1,1,1,1,0,1,1,1,0,1,},
        new List<int>(){1,1,1,1,0,1,1,1,1,0,1,1,1,1,0,1,1,1,0,1,},
        new List<int>(){1,1,1,1,0,1,1,1,1,0,1,1,1,1,0,1,1,1,0,1,},
        new List<int>(){1,1,1,1,0,1,1,1,1,0,1,1,1,1,0,1,1,1,0,1,},
        new List<int>(){1,1,1,1,0,1,1,1,1,0,1,1,1,1,0,1,1,1,0,1,},

        }
    };
    void Start()
    {
        MapMake();
    }

    
    private void　MapMake ()
    {
        foreach (int y in System.Linq.Enumerable.Range(0,20))
        {
            foreach (int x in System.Linq.Enumerable.Range(0, 20))
            {
                //プレハブの実態をヒエラルキーに生成する
                GameObject gobj= Instantiate(_mapParts, _parent);
                //指示座標を設定する
                gobj.transform.localPosition = new Vector3(x*32-304, y*-32+304, 0);

                gobj.GetComponent<ChipView>().SetImage(_mapChipSprites[_mapData[0][y][x]]);
                //gobj.GetComponent<ChipView>().SetImage(_mapChipSprites[_mapDatalist[0,y,x]]);


            }
        }
    }
}
