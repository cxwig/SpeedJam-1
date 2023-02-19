using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AkshayDhotre.GraphicSettingsMenu
{
    public class MenuToggler : MonoBehaviour
    {
        public Canvas menuCanvasComponent;


        public void ButtonCheckSettings()
        {
            if (menuCanvasComponent.enabled)
            {
                SetMenuActive(false);
            }
            else
            {
                SetMenuActive(true);

            }
        }

        /// <param name="active"></param>
        public void SetMenuActive(bool active)
        {
            menuCanvasComponent.enabled = active;
        }
    }
}

