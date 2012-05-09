///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace ConsumerPagesMain.RegStep2
{
    /// <summary>
    /// The class representing the OTLSubscriptionPlanRegPage2Repo element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "3.2.3"), RepositoryFolder("92731d2c-63e1-4c11-8eb8-783f70d52232")]
    public partial class OTLSubscriptionPlanRegPage2Repo : RepoGenBaseFolder
    {
        static OTLSubscriptionPlanRegPage2Repo instance = new OTLSubscriptionPlanRegPage2Repo();

        /// <summary>
        /// Gets the singleton class instance representing the OTLSubscriptionPlanRegPage2Repo element repository.
        /// </summary>
        [RepositoryFolder("92731d2c-63e1-4c11-8eb8-783f70d52232")]
        public static OTLSubscriptionPlanRegPage2Repo Instance
        {
            get { return instance; }
        }

        OTLSubscriptionPlanRegPage2RepoFolders.DOMAppFolder _dom;

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public OTLSubscriptionPlanRegPage2Repo() 
            : base("OTLSubscriptionPlanRegPage2Repo", "", null, 30000, false)
        {
            _dom = new OTLSubscriptionPlanRegPage2RepoFolders.DOMAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The DOM folder.
        /// </summary>
        [RepositoryFolder("bb48ffcf-865f-4327-93a5-0c9d1910efbf")]
        public virtual OTLSubscriptionPlanRegPage2RepoFolders.DOMAppFolder DOM
        {
            get { return _dom; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    public partial class OTLSubscriptionPlanRegPage2RepoFolders
    {
        /// <summary>
        /// The DOMAppFolder folder.
        /// </summary>
        [RepositoryFolder("bb48ffcf-865f-4327-93a5-0c9d1910efbf")]
        public partial class DOMAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _selfInfo;
            RepoItemInfo _plannameInfo;
            RepoItemInfo _planpriceInfo;

            /// <summary>
            /// Creates a new DOM  folder.
            /// </summary>
            public DOMAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DOM", "/dom", parentFolder, 30000, false, "bb48ffcf-865f-4327-93a5-0c9d1910efbf")
            {
                _selfInfo = new RepoItemInfo(this, "Self", "", 0, null, "bb48ffcf-865f-4327-93a5-0c9d1910efbf");
                _plannameInfo = new RepoItemInfo(this, "PlanName", "body/div[1]/div[2]/form/table/tbody/tr[2]/td[@class=null()]", 30000, null, "783b1314-ba93-4b47-863c-9d0df31a770b");
                _planpriceInfo = new RepoItemInfo(this, "PlanPrice", "body/div[1]/div[2]/form/table/tbody/tr[2]/td[@class='price']", 30000, null, "baaf37b3-a4ab-451f-8523-2bd1b5a741fc");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("bb48ffcf-865f-4327-93a5-0c9d1910efbf")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("bb48ffcf-865f-4327-93a5-0c9d1910efbf")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The PlanName item.
            /// </summary>
            [RepositoryItem("783b1314-ba93-4b47-863c-9d0df31a770b")]
            public virtual Ranorex.TdTag PlanName
            {
                get
                {
                    return _plannameInfo.CreateAdapter<Ranorex.TdTag>(true);
                }
            }

            /// <summary>
            /// The PlanName item info.
            /// </summary>
            [RepositoryItemInfo("783b1314-ba93-4b47-863c-9d0df31a770b")]
            public virtual RepoItemInfo PlanNameInfo
            {
                get
                {
                    return _plannameInfo;
                }
            }

            /// <summary>
            /// The PlanPrice item.
            /// </summary>
            [RepositoryItem("baaf37b3-a4ab-451f-8523-2bd1b5a741fc")]
            public virtual Ranorex.TdTag PlanPrice
            {
                get
                {
                    return _planpriceInfo.CreateAdapter<Ranorex.TdTag>(true);
                }
            }

            /// <summary>
            /// The PlanPrice item info.
            /// </summary>
            [RepositoryItemInfo("baaf37b3-a4ab-451f-8523-2bd1b5a741fc")]
            public virtual RepoItemInfo PlanPriceInfo
            {
                get
                {
                    return _planpriceInfo;
                }
            }
        }

    }
}