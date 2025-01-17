﻿using UnityEngine;

namespace Plugin.VRTRAKILL.UI
{
    internal class HideWhenMenuActive : MonoBehaviour
    {
        private bool ShouldHide => Vars.IsPlayerFrozen;

        public void Update()
        {
            if (ShouldHide) gameObject.GetComponent<Canvas>().enabled = false;
            else gameObject.GetComponent<Canvas>().enabled = true;
        }
    }
}
