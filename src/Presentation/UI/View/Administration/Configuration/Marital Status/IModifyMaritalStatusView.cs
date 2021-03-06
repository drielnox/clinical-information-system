﻿using CIS.Presentation.Model.Administration.MaritalStatus;
using CIS.Transversal.SharedKernel.Patterns.MVP;

namespace CIS.Presentation.UI.Contracts.Administration.Configuration.MaritalStatus
{
    public interface IModifyMaritalStatusView : IView
    {
        MaritalStatusViewModel GetCurrentMaritalStatus();

        void SetIdentifier(int p);

        void SetAbbreviation(string p);

        void SetDescription(string p);

        int GetIdentifier();

        string GetAbbreviation();

        string GetDescription();

        void EnableAcceptButton(bool enable);

        void SetTag(MaritalStatusViewModel model);
    }
}
