using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChipView : MonoBehaviour
{
    [SerializeField]
    private Image _image = null;
   /// <summary>
   /// �}�b�v�X�v���C�g��ݒu����
   /// </summary>
   /// <param name="sprite">�\������C���[�W</param>
    public void SetImage(Sprite sprite)
    {
        _image.sprite = sprite;
    }
}
