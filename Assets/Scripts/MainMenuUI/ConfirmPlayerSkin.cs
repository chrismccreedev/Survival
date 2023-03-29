using UnityEngine;
using UnityEngine.UI;
using VitaliyNULL.Core;

namespace VitaliyNULL.MainMenuUI
{
    public class ConfirmPlayerSkin : MonoBehaviour
    {
        private PlayerSkin _skin;
        private readonly string _mySkin = "MY_SKIN";


        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(ConfirmPlayer);
        }

        private void ConfirmPlayer()
        {
            UIMainMenuManager.Instance.OpenMainMenuUI();
            MainMenuCharacterAnim.Instance.PlayerSkinChange((PlayerSkin)PlayerPrefs.GetInt(_mySkin));
        }
    }
}