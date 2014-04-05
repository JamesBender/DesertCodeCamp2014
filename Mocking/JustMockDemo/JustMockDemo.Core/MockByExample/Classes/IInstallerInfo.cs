using System.Collections.Generic;

namespace JustMockDemo.Core.MockByExample.Classes
{
    public interface IInstallerInfo
    {
        DetectionInfoBase BlockingCondition { get; set; }
        string Name { get; set; }

        IList<IInstallPackage> InstallPackages { get; set; }
    }
}