﻿using Microsoft.Web.WebView2.Wpf;

using SampleMVVM;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleViewModels
{
    public class DomClickModel : BaseDomClickModel
    {
        // private DomClickModel _domClickModel;
        private List<DomInputModel> _domInputModels;

        /*
        public string ClickType => _domClickModel.type;
        public string ClickTargetId => _domClickModel.targetId;
        public string ClickTargetName => _domClickModel.targetName;
        */

        public void HandleButtonClick(DomClickModel clickModel)
        {
            //if (clickModel.targetType != "button") return;
            // TODO: need to ensure that there is a unique id for each button, even when users
            // are not using the id/name feature correctly. for now we loop over all the possible buttons
            var clickedButtons =
                _domInputModels.Where(b
                        => b.type == clickModel.targetType &&
                           b.id == clickModel.targetId ||
                           b.name == clickModel.targetName);

            //if (clickedButtons == null) return;
            foreach (DomInputModel domInput in clickedButtons)
            {
                domInput.value = "true";
            }
        }
    }
}
