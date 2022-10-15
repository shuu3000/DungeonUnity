using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    [SerializeField]

    private GameObject _mapChip = null;

    // �}�b�v�`�b�v�z�u�G���A
    [SerializeField]

    private Transform _mapArea = null;

    [SerializeField]
    private List<Sprite> _mapSprites = new List<Sprite>();

    private List<MapChipView> _mapChipViews = new List<MapChipView>();
    private List<List<int>> _mapData = new List<List<int>>()
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
        new List<int>(){1,0,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,0,1,},
        new List<int>(){1,0,1,1,1,1,1,1,1,2,1,1,1,1,1,1,1,1,0,1,},
        new List<int>(){1,0,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,0,1,},
        new List<int>(){1,0,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,0,1,},
        new List<int>(){1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,},
        new List<int>(){1,1,1,1,0,1,1,1,1,0,1,1,1,1,0,1,1,1,0,1,},
        new List<int>(){1,1,1,1,0,1,1,1,1,0,1,1,1,1,0,1,1,1,0,1,},
        new List<int>(){1,1,1,1,0,1,1,1,1,0,1,1,1,1,0,1,1,1,0,1,},
        new List<int>(){1,1,1,1,0,1,1,1,1,0,1,1,1,1,0,1,1,1,0,1,},
        new List<int>(){1,1,1,1,0,1,1,1,1,0,1,1,1,1,0,1,1,1,0,1,},
        new List<int>(){1,1,1,1,0,1,1,1,1,0,1,1,1,1,0,1,1,1,0,1,},

    };
    private int _startX = -456; //�}�b�v�`�b�v�J�nX���W
    private int _startY = 456; //�}�b�v�`�b�v�J�nY���W
    private int _chipSize = 48; // �}�b�v�`�b�v�̑傫��

    // Start is called before the first frame update
    void Start()
    {
        MakeMap();
    }

    // Update is called once per frame
    void Update()
    {

    }
    /// <summary>
    /// 
    /// </summary>
    private void MakeMap()
    {
        for (int y = 0; y < 20; y++)
        {
            for (int x = 0; x < 20; x++)
            {
                GameObject gobj = Instantiate(_mapChip, _mapArea);

                Transform trans = gobj.transform;

                trans.localPosition = new Vector3(_startX + _chipSize * x,
                                                   _startY - _chipSize * y,
                                                   0);

                MapChipView mpView = gobj.GetComponent<MapChipView>();
                int mapIndex = _mapData[y][x];
                mpView.SetmapImage(_mapSprites[mapIndex]);
                _mapChipViews.Add(mpView);
            }


        }


    }
}
