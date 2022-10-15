using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dungeonManager : MonoBehaviour
{
    //�}�b�v�`�b�v�̃v���n�u   
    [SerializeField]
    private GameObject _mapParts = null;
    
    //�e�I�u�W�F�N�g
    [SerializeField]
    private Transform _parent = null;
    
    //�}�b�v�`�b�v�X�v���C�g
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

    
    private void�@MapMake ()
    {
        foreach (int y in System.Linq.Enumerable.Range(0,20))
        {
            foreach (int x in System.Linq.Enumerable.Range(0, 20))
            {
                //�v���n�u�̎��Ԃ��q�G�����L�[�ɐ�������
                GameObject gobj= Instantiate(_mapParts, _parent);
                //�w�����W��ݒ肷��
                gobj.transform.localPosition = new Vector3(x*32-304, y*-32+304, 0);

                gobj.GetComponent<ChipView>().SetImage(_mapChipSprites[_mapData[0][y][x]]);
                //gobj.GetComponent<ChipView>().SetImage(_mapChipSprites[_mapDatalist[0,y,x]]);


            }
        }
    }
}
